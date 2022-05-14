using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    [InitializeOnLoad]
    internal static class InheritanceManager
    {
        private static readonly Dictionary<GUID, List<string>> _syncChange = new Dictionary<GUID, List<string>>();
        private static readonly HashSet<Object> _playModeChangedData = new HashSet<Object>();

        private static readonly ScriptableObjectHandler _scriptableObjectHandler = new ScriptableObjectHandler();
#if ODIN_INSPECTOR
        private static readonly Odin.OdinScriptableObjectHandler _odinObjectHandler = new Odin.OdinScriptableObjectHandler();
#endif
        private static readonly IInheritanceHandler _activeInhiertanceHandler;

        private static List<(GUID, int)> _stagedChanges = new List<(GUID, int)>();

        static InheritanceManager()
        {
            ObjectChangeEvents.changesPublished += OnObjectChanged;
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private static void OnPlayModeStateChanged(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.EnteredEditMode)
            {
                foreach (var obj in _playModeChangedData)
                {
                    SyncVariantsPropertiesWithParent(obj, ScriptableVariantUtility.GetData(obj as ScriptableObject), new List<string>());
                }
            }
        }

        // Invoked when any object in memory is changed.
        private static void OnObjectChanged(ref ObjectChangeEventStream stream)
        {
            _stagedChanges.Clear();
            // Each event in the stream is an undo-able action that happened in a single update.
            for (int i = 0; i < stream.length; i++)
            {
                if (stream.GetEventType(i) == ObjectChangeKind.ChangeAssetObjectProperties)
                {
                    stream.GetChangeAssetObjectPropertiesEvent(i, out ChangeAssetObjectPropertiesEventArgs changeArgs);

                    // We get the asset instance instead of just getting the path from the GUID from the start
                    // because it is less expensive when the asset is *not* a ScriptableObject.
                    
                    // Get the instance of the object that changed.
                    // (The object is already in memory so we don't need to worry about unloading it).
                    Object obj = EditorUtility.InstanceIDToObject(changeArgs.instanceId);
                    
                    // We check the obj type instead of just trying to get inheritance data because it is cheaper
                    // to to do this for objects that are not ScriptableObjects, which will be most of them.
                    if (!(obj is ScriptableObject) || obj is ScriptableObjectDataObject)
                        continue;

                    _stagedChanges.Add((changeArgs.guid, changeArgs.instanceId));
                }
            }

            // SerializedProperties of UnityEngine.Object types do not have the references serialized immediately it seems
            // when the value is assigned, so we need to delay the call to update by a frame so that the references have time
            // to be resolved and serialized.
            EditorApplication.delayCall += () =>
            {
                for (int i = 0; i < _stagedChanges.Count; i++)
                {
                    UpdateInheritanceAsset(_stagedChanges[i].Item1, EditorUtility.InstanceIDToObject(_stagedChanges[i].Item2));
                }
            };
        }

        private static void UpdateInheritanceAsset(GUID guid, Object obj)
        {
            // We ignore the asset if it is not an inheritance asset since we do not need to update variants for it or sync properties.
            if (!ScriptableVariantUtility.TryGetDataFromGUID(guid, out ScriptableObjectData data))
                return;

            if (!WasVariantSyncChange(guid, out List<string> syncedPropertyPaths))
            {
                using var baseScope = new AssetUtility.LoadAssetScope(data.ParentGUID.ToString());
                
                if (baseScope.asset != null)
                {
                    if (obj is ScriptableObject scriptableObject)
                    {
#if ODIN_INSPECTOR
                        if (obj is Sirenix.OdinInspector.SerializedScriptableObject)
                        {
                            _odinObjectHandler.InitializeOwners(scriptableObject, baseScope.asset);
                            RegisterOverriddenProperties(data, _odinObjectHandler);
                            _odinObjectHandler.DisposeOwners();
                        }
                        else
                        {
                            _scriptableObjectHandler.InitializeOwners(scriptableObject, baseScope.asset);
                            RegisterOverriddenProperties(data, _scriptableObjectHandler);
                            _scriptableObjectHandler.DisposeOwners();
                        }
#else
                        _scriptableObjectHandler.InitializeOwners(scriptableObject, baseScope.asset);
                        RegisterOverriddenProperties(data, _scriptableObjectHandler);
                        _scriptableObjectHandler.DisposeOwners();                  
#endif
                    }
                }
                else
                {
                    data.DataObject.ParentGUID = string.Empty;
                }
            }

            if (data.HasVariants)
            {
                // We don't want variants to update during play mode because they wouldn't update in build.
                // We cache the changes so we can apply them in edit mode after exiting play mode.
                if (!EditorApplication.isPlaying)
                    SyncVariantsPropertiesWithParent(obj, data, syncedPropertyPaths);
                else
                    _playModeChangedData.Add(obj);
            }
        }

        private static void RegisterOverriddenProperties<TProperty, TOwner>(InheritanceData data, InheritanceHandlerBase<TProperty, TOwner> handler)
        {
            foreach (TProperty property in handler.EnumerateTarget())
            {
                if (!handler.ParentHasProperty(property))
                    continue;

                if (!handler.PropertyEqualsParent(property))
                    data.OverrideProperty(handler.GetPropertyPath(property));
            }

            handler.OnAfterRegisteredOverrides(data);
        }

        internal static void SyncVariantsPropertiesWithParent(Object parentAssetObject, ScriptableObjectData parentData, List<string> updatedProperties)
        {
            // We iterate in reverse because we remove variant GUIDs that no longer have an asset associated with them.
            foreach (var (variantGuid, variantPath) in parentData.GetVariantGUIDsAndPaths())
            {
                var variantData = ScriptableVariantUtility.GetDataImp(variantPath, variantGuid);

                SyncPropertiesWithParent(parentAssetObject, variantData, updatedProperties);
            }
        }

        /// <summary>
        /// Sync the properties of a variant to match the properties of its base.
        /// </summary>
        /// <remarks>Does not check to ensure inheritance, use with caution.</remarks>
        /// <param name="baseAssetObject"></param>
        /// <param name="variantData"></param>
        /// <param name="updatedProperties"></param>
        internal static void SyncPropertiesWithParent(Object baseAssetObject, InheritanceData variantData, List<string> updatedProperties)
        {
            using var variantAssetScope = new AssetUtility.LoadAssetScope(variantData.GUID);
            // TODO:
            if (variantAssetScope.asset == null) return;

            if (baseAssetObject is ScriptableObject)
            {
#if ODIN_INSPECTOR
                if (baseAssetObject is Sirenix.OdinInspector.SerializedScriptableObject)
                {
                    _odinObjectHandler.InitializeOwners(variantAssetScope.asset, baseAssetObject);
                    SyncPropertiesWithParent(variantData, updatedProperties, _odinObjectHandler);
                    _odinObjectHandler.DisposeOwners();
                }
                else
                {
                    _scriptableObjectHandler.InitializeOwners(variantAssetScope.asset, baseAssetObject);
                    SyncPropertiesWithParent(variantData, updatedProperties, _scriptableObjectHandler);
                    _scriptableObjectHandler.DisposeOwners();
                }
#else
                _scriptableObjectHandler.InitializeOwners(variantAssetScope.asset, baseAssetObject);
                SyncPropertiesWithParent(variantData, updatedProperties, _scriptableObjectHandler);
                _scriptableObjectHandler.DisposeOwners();
#endif
            }
        }

        private static void SyncPropertiesWithParent<TProperty, TOwner>(InheritanceData data, List<string> syncedPropertyPaths, InheritanceHandlerBase<TProperty, TOwner> handler)
        {
            bool isDirectVariant = syncedPropertyPaths.Count == 0;
            bool didSyncProperty = false;

            handler.OnBeforeSyncProperties();

            if (isDirectVariant)
            {
                // We iterate over all the properties of the variant object if it is the direct variant of the object that changed.
                foreach (TProperty propertyInParent in handler.EnumerateParent())
                {
                    UpdateVariantProperty(handler.GetPropertyPath(propertyInParent));
                }
            }
            else
            {
                // We iterate over the properties that the variant's parent changed.
                for (int i = syncedPropertyPaths.Count - 1; i >= 0; i--)
                {
                    UpdateVariantProperty(syncedPropertyPaths[i]);
                }
            }
            
            didSyncProperty |= handler.OnAfterSyncProperties(data);

            // We register that the at least one property of the variant was changed to sync with its base asset.
            // When a property changes it will trigger a change event, and we use the registered properties
            // so we don't need to iterate over every property for every variant.
            // This also results in an early out if no property was changed on a variant of a variant (etc.) as it will not trigger a change event.
            if (didSyncProperty)
                RegisterVariantSyncChange(data.GUID, syncedPropertyPaths);

            // <--Local functions-->
   
            void UpdateVariantProperty(string propertyPath)
            {
                if (data.IsPropertyOverridden(propertyPath))
                {
                    if (!isDirectVariant)
                        syncedPropertyPaths.Remove(propertyPath);
                }
                else if (handler.CopyFromParentIfDifferent(propertyPath))
                {
                    didSyncProperty = true;

                    if (isDirectVariant)
                        syncedPropertyPaths.Add(propertyPath);
                }
            }
        }

        /// <summary>
        /// Registers the properties that were changed in a variant sync.
        /// </summary>
        /// <param name="variantGuid">The <see cref="GUID"/> of the variant that was synced.</param>
        /// <param name="syncedPropertyPaths">The paths of the properties that were synced.</param>
        private static void RegisterVariantSyncChange(GUID variantGuid, List<string> syncedPropertyPaths)
        {
            _syncChange[variantGuid] = syncedPropertyPaths;
        }

        private static bool WasVariantSyncChange(GUID guid, out List<string> updatedProperties)
        {
            if (_syncChange.ContainsKey(guid))
            {
                updatedProperties = _syncChange[guid];
            }
            else
            {
                updatedProperties = new List<string>();
            }

            return _syncChange.Remove(guid);
        }

        [MenuItem("Assets/Create/ScriptableObject Variant", true, priority = 204)]
        private static bool CreateSOVariantValidation()
        {
            string path = AssetDatabase.GetAssetPath(Selection.activeObject);
            return Selection.activeObject is ScriptableObject && Path.GetExtension(path) == ".asset";
        }

        [MenuItem("Assets/Create/ScriptableObject Variant", priority = 204)]
        private static void CreateSOVariant()
        {
            var sourcePath = AssetDatabase.GetAssetPath(Selection.activeObject);
            var variantPath = sourcePath.Insert(sourcePath.LastIndexOf('.'), " Variant");
            var createVariantAction = ScriptableObject.CreateInstance<DoCreateScriptableObjectVariant>();
            var icon = (Texture2D)AssetDatabase.GetCachedIcon(sourcePath);

            ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0, createVariantAction, variantPath, icon, sourcePath);
        }


        internal class DoCreateScriptableObjectVariant : EndNameEditAction
        {
            public override void Action(int instanceId, string pathName, string resourceFile)
            {
                var original = (ScriptableObject)AssetDatabase.LoadMainAssetAtPath(resourceFile);

                var variantObject = ScriptableVariantUtility.CreateVariantAsset(original, AssetDatabase.GenerateUniqueAssetPath(pathName));
                ProjectWindowUtil.ShowCreatedAsset(variantObject);
            }
        }
    }
}
