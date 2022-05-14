using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

using Object = UnityEngine.Object;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    public enum InheritanceType { None, Regular, Variant }

    public static class ScriptableVariantUtility
    {
        internal static string ProjectPath { get; } = Application.dataPath.Remove(Application.dataPath.Length - 6);

        /// <summary>
        /// Gets <see cref="InheritanceData"/> for the specified asset only if it is already an inheritance asset (is a variant, or has variants).
        /// </summary>
        /// <param name="guid">The <see cref="GUID"/> of the asset to get the inheritance data for.</param>
        /// <param name="data">The data of the asset, <c>null</c> if the asset is not a variant and is not a base of a variant.</param>
        /// <returns><c>true</c> if the asset is a variant or a base of a variant; otherwise, <c>false</c>.</returns>
        internal static bool TryGetDataFromGUID(GUID guid, out ScriptableObjectData data)
        {
            data = null;
            if (guid == default)
                return false;
            
            return TryGetDataImp(AssetDatabase.GUIDToAssetPath(guid), guid, out data);
        }

        internal static bool TryGetDataAtPath(string path, out ScriptableObjectData data)
        {
            return TryGetDataImp(path, default, out data);
        }

        public static bool TryGetData(ScriptableObject assetObject, out ScriptableObjectData data)
        {
            data = null;
            if (assetObject == null)
                return false;
            
            return TryGetDataImp(AssetDatabase.GetAssetPath(assetObject), default, out data);
        }

        internal static bool TryGetDataImp(string path, GUID guid, out ScriptableObjectData data)
        {
            data = null;
            var dataObject = LoadDataObject(path);

            if (dataObject == null || (dataObject.ParentGUID == default && dataObject.VariantGUIDs.Count <= 0))
                return false;
            
            data = new ScriptableObjectData(dataObject, guid != default ? guid : AssetDatabase.GUIDFromAssetPath(path));
            return true;

        }

        public static ScriptableObjectData GetData(ScriptableObject assetObject)
        {
            if (assetObject == null)
                return null;
            
            return GetDataImp(AssetDatabase.GetAssetPath(assetObject));
        }
        
        public static ScriptableObjectData GetDataFromGUID(GUID guid)
        {
            if (guid == default)
                return null;
            
            return GetDataImp(AssetDatabase.GUIDToAssetPath(guid), guid);
        }

        internal static ScriptableObjectData GetDataImp(string path, GUID guid = default)
        {
            // If the path does not have the .asset extension then it is not supported.
            // A ScriptableObject may be the main asset at a path, but the file extension may be different.
            // This happens when an asset is imported, and a SO is created as a Unity representation of the data in the file.
            // The file's data controls the data of the SO, so we do not support creating variants of it.
            if (Path.GetExtension(path) != ".asset")
                return null;
            
            var dataObject = LoadDataObject(path);
            return new ScriptableObjectData(dataObject, guid != default ? guid : AssetDatabase.GUIDFromAssetPath(path));
        }

        /// <summary>
        /// Determines whether the specified asset is an inhiertance asset (either has variants and/or inherits from another asset).
        /// </summary>
        /// <param name="assetObject"></param>
        /// <returns></returns>
        public static bool IsInhiertanceAsset(Object assetObject)
        {
            string path = AssetDatabase.GetAssetPath(assetObject);
            InheritanceDataObject dataObject = LoadDataObject(path);

            if (dataObject == null)
                return false;

            return dataObject.VariantGUIDs.Count > 0 || !string.IsNullOrEmpty(dataObject.ParentGUID);
        }

       
        private static ScriptableObjectDataObject LoadDataObject(string path)
        {
            // If the path does not have the .asset extension then it is not supported.
            // A ScriptableObject may be the main asset at a path, but the file extension may be different.
            // This happens when an asset is imported, and a SO is created as a Unity representation of the data in the file.
            // The file's data controls the data of the SO, so we do not support creating variants of it.
            if (Path.GetExtension(path) != ".asset")
                return null;

            // Load the main asset and all sub-assets at the path of the guid.
            // Need to use LoadAllAssetsAtPath because there is no other way to load sub-assets that have the HideInHierarchy HideFlag.
            Object[] assets = AssetDatabase.LoadAllAssetsAtPath(path);
            // Iterate over the assets to find if one is inheritance data.
            foreach (Object asset in assets)
            {
                if (asset is ScriptableObjectDataObject dataObject)
                    return dataObject;
            }

            return null;
        }
        
        /// <summary>
        /// Determines whether the asset associated with the specified guid is an archetype.
        /// </summary>
        /// <param name="guid">GUID of an asset.</param>
        /// <returns><c>true</c> if the asset associated with <paramref name="guid"/> is an archetype; otherwise, <c>false</c>.</returns>
        public static bool IsGUIDInheritance(GUID guid)
        {
            return IsInheritanceFromPath(AssetDatabase.GUIDToAssetPath(guid));
        }

        /// <summary>
        /// Determines whether the specified <see cref="Object"/> is either a variant of another asset or has variants of it.
        /// </summary>
        /// <param name="assetObject">The <see cref="Object"/> to check.</param>
        /// <returns><c>true</c> if <paramref name="assetObject"/> is a variant or has variants; otherwise, <c>false</c>.</returns>
        public static bool IsInheritanceAsset(Object assetObject)
        {
            return IsInheritanceFromPath(AssetDatabase.GetAssetPath(assetObject));
        }

        public static bool IsInheritanceFromPath(string path)
        {
            if (string.IsNullOrEmpty(path))
                return false;

            InheritanceDataObject dataObject = LoadDataObject(path);

            if (dataObject == null)
                return false;

            // Empty Inheritance data object is only deleted on session start (to support undo/redo of setting base),
            // so an asset can have inheritance data without 'being an inheritance asset'.
            // So we check if it either has variants or is a variant.
            return dataObject.ParentGUID != default || dataObject.VariantGUIDs.Count > 0;
        }

        /// <summary>
        /// Returns whether the specified asset is a variant.
        /// </summary>
        /// <param name="assetObject">The asset to check</param>
        /// <returns><c>true</c> if <paramref name="assetObject"/> is a variant; otherwise, <c>false</c>.</returns>
        public static bool IsVariant(ScriptableObject assetObject)
        {
            if (TryGetData(assetObject, out var data))
                return data.IsVariant;
            return false;
        }

        /// <summary>
        /// Returns the base asset of the specified asset if it is an variant.
        /// </summary>
        /// <param name="assetObject">The asset to get the base of.</param>
        /// <returns>The base <see cref="Object"/> of <paramref name="assetObject"/> if it is a variant; otherwise, <c>null</c>.</returns>
        public static T GetParent<T>(ScriptableObject assetObject) where T : ScriptableObject
        {
            return GetParent(assetObject) as T;
        }
        
        /// <summary>
        /// Returns the base asset of the specified asset if it is an variant.
        /// </summary>
        /// <param name="assetObject">The asset to get the base of.</param>
        /// <returns>The base <see cref="Object"/> of <paramref name="assetObject"/> if it is a variant; otherwise, <c>null</c>.</returns>
        public static ScriptableObject GetParent(ScriptableObject assetObject)
        {
            if (TryGetData(assetObject, out ScriptableObjectData data))
            {
                if (data.IsVariant)
                    return AssetDatabase.LoadMainAssetAtPath(AssetDatabase.GUIDToAssetPath(data.ParentGUID)) as ScriptableObject;
            }

            return null;
        }

        /// <summary>
        /// Sets the base <see cref="Object"/> from which the specified target <see cref="Object"/> directly inherits.
        /// </summary>
        /// <param name="targetObject">The object to set the parent of.</param>
        /// <param name="newParentObject">The object to set as the parent of <paramref name="targetObject"/>.</param>
        public static void SetParent(ScriptableObject targetObject, ScriptableObject newParentObject)
        {

            if (!EditorUtility.IsPersistent(targetObject))
                throw new AggregateException("Cannot set the parent of an object that is not an asset.");
            
            if (!AssetDatabase.IsMainAsset(targetObject))
                throw new ArgumentException("Cannot set the parent of a sub-asset.");

            // The newParentObject may be null if we are trying to clear the parent.
            if (newParentObject != null)
            {
                if (!EditorUtility.IsPersistent(newParentObject))
                    throw new AggregateException("Cannot set parent as an object that is not an asset.");
            
                if (!AssetDatabase.IsMainAsset(newParentObject))
                    throw new ArgumentException("Cannot set parent as an object that is a sub-asset.");
            }

            GUID targetGuid = AssetDatabase.GUIDFromAssetPath(AssetDatabase.GetAssetPath(targetObject));
            GUID newParentGuid = AssetDatabase.GUIDFromAssetPath(AssetDatabase.GetAssetPath(newParentObject));
            SetInheritanceParent(targetGuid, newParentGuid, true);
        }

        private static void SetInheritanceParent(GUID targetGuid, GUID newParentGuid, bool registerUndo)
        {
            if (targetGuid == default)
                throw new ArgumentNullException(nameof(targetGuid));

            string targetPath = AssetDatabase.GUIDToAssetPath(targetGuid);
            string newParentPath = AssetDatabase.GUIDToAssetPath(newParentGuid);
            bool willClearParent = newParentGuid == default;

            if (string.IsNullOrEmpty(targetPath))
                return; //throw new ArgumentException("The target GUID does not have an associated asset.");

            if (string.IsNullOrEmpty(newParentPath) && !willClearParent)
                return; //throw new ArgumentException("Parent GUID does not have an associated asset.");

            if (!IsValidGUIDParent(targetGuid, newParentGuid))
                return; //throw new InvalidOperationException("The provided asset cannot be set as the parent because it is a descendent of the target asset.");

            // Load the inheritance data for the asset.
            var targetData = GetDataFromGUID(targetGuid);

            // We don't need to set the parent if it is already the parent of target.
            if (targetData.ParentGUID == newParentGuid)
                return;

            int undoGroup = Undo.GetCurrentGroup();

            if (targetData.DataObject == null)
                targetData.DataObject = AddDataObject(targetGuid);

            // Register the undo before anything is changed on the target.
            if (registerUndo)
            {
                Undo.RegisterCompleteObjectUndo(targetData.DataObject, "Modified asset inheritance");
            }

            // Clear the target's current parent if it is already a variant, so we can set it to the new one cleanly.
            if (targetData.IsVariant)
            {
                ClearParent(targetData, registerUndo);
            }

            if (!willClearParent)
            {
                // Set the guid base of the target.
                targetData.DataObject.ParentGUID = newParentGuid.ToString();

                ScriptableObjectData newParentData = GetDataFromGUID(newParentGuid);

                if (newParentData.DataObject == null)
                    newParentData.DataObject = AddDataObject(newParentGuid);

                if (registerUndo)
                {
                    Undo.RegisterCompleteObjectUndo(newParentData.DataObject, "Modified asset inheritance");
                }

                newParentData.DataObject.AddVariantGUID(targetGuid.ToString());

                var parentAsset = AssetDatabase.LoadMainAssetAtPath(newParentPath);

                InheritanceManager.SyncPropertiesWithParent(parentAsset, targetData, new List<string>());
            }

            if (registerUndo)
                Undo.CollapseUndoOperations(undoGroup);
        }

        /// <summary>
        /// Determines whether the specified object can be set as the direct parent of the other specified object.
        /// </summary>
        /// <param name="targetObject">The <see cref="ScriptableObject"/> who's parent would be set.</param>
        /// <param name="parentObject">The <see cref="ScriptableObject"/> to check if it can be the parent of the target <see cref="Object"/></param>
        /// <returns
        /// ><c>true</c> if <paramref name="parentObject"/> can be set as the parent of <paramref name="targetObject"/>, 
        /// or <paramref name="parentObject"/> is <c>null</c>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidParent(ScriptableObject targetObject, ScriptableObject parentObject)
        {
            if (targetObject == null)
                return false;

            // No further checks are needed if trying to set the base to null since all further checks are related to the base object.
            if (parentObject == null || !AssetDatabase.IsMainAsset(parentObject))
                return true;

            return IsValidParentImp(AssetDatabase.GetAssetPath(targetObject), AssetDatabase.GetAssetPath(parentObject));
        }

        public static bool IsValidGUIDParent(GUID targetGuid, GUID baseGuid)
        {
            // Return if target is empty to avoid having to try getting the asset path,
            // for a slight performance improvement.
            if (targetGuid == default || targetGuid == baseGuid)
                return false;

            return IsValidParentImp(AssetDatabase.GUIDToAssetPath(targetGuid), AssetDatabase.GUIDToAssetPath(baseGuid));
        }

        private static bool IsValidParentImp(string assetPath, string newParentAssetPath)
        {
            // Cannot set an asset's parent as itself.
            if (assetPath == newParentAssetPath)
                return false;

            if (string.IsNullOrEmpty(assetPath))
                return false;
            
            if (string.IsNullOrEmpty(newParentAssetPath))
                return true;
            else if (Path.GetExtension(newParentAssetPath) != ".asset")
                return false;

            bool wasParentLoaded = AssetDatabase.IsMainAssetAtPathLoaded(newParentAssetPath);

            var dataObject = LoadDataObject(assetPath);
            var newParentDataObject = LoadDataObject(newParentAssetPath);
            
            
            while (newParentDataObject != null)
            {
                // If the target and parent data is the same, we return false because
                // it would be cyclical inheritance.
                if (newParentDataObject == dataObject)
                    return false;

                newParentAssetPath = AssetDatabase.GUIDToAssetPath(newParentDataObject.ParentGUID);

                // We unload the base asset before cycling to its base if we loaded it.
                if (!wasParentLoaded)
                {
                    Resources.UnloadAsset(newParentDataObject);
                }

                // Cache whether the base asset is already loaded so we can unload it next iteration if it wasn't loaded.
                wasParentLoaded = AssetDatabase.IsMainAssetAtPathLoaded(newParentAssetPath);

                newParentDataObject = LoadDataObject(newParentAssetPath);
            }

            return true;
        }
        
        internal static bool IsAncestorOf(ScriptableObject targetObject, ScriptableObject ancestorObject)
        {
            if (targetObject == null || ancestorObject == null)
                return false;
            
            var targetPath = AssetDatabase.GetAssetPath(targetObject);
            var ancestorPath = AssetDatabase.GetAssetPath(ancestorObject);
            
            bool wasLoaded = AssetDatabase.IsMainAssetAtPathLoaded(targetPath);
            
            var dataObject = LoadDataObject(targetPath);
            var ancestorDataObject = LoadDataObject(ancestorPath);
            
            
            while (dataObject != null)
            {
                if (dataObject == ancestorDataObject)
                    return true;

                string parentPath = AssetDatabase.GUIDToAssetPath(dataObject.ParentGUID);
                
                if (!wasLoaded)
                {
                    Resources.UnloadAsset(dataObject);
                }
                
                wasLoaded = AssetDatabase.IsMainAssetAtPathLoaded(parentPath);
                dataObject = LoadDataObject(parentPath);
            }

            return false;
        }

        /// <summary>
        /// Create a variant of the specified <see cref="ScriptableObject"/> asset and save it at the specified path.
        /// </summary>
        /// <param name="parentAssetObject">The <see cref="ScriptableObject"/> asset to create a variant of.</param>
        /// <param name="variantPath">The path at which to save the variant.</param>
        /// <returns>The variant <see cref="Object"/> that was created of <paramref name="parentAssetObject"/>.</returns>
        public static ScriptableObject CreateVariantAsset(ScriptableObject parentAssetObject, string variantPath)
        {
            if (parentAssetObject == null)
                throw new ArgumentNullException(nameof(parentAssetObject));

            if (!EditorUtility.IsPersistent(parentAssetObject))
                throw new ArgumentException("Cannot create a variant of a non-persistent Object.");

            if (!AssetDatabase.IsMainAsset(parentAssetObject))
                throw new ArgumentException("Cannot create a variant of a sub-asset.");

            if (parentAssetObject is InheritanceDataObject)
                throw new ArgumentException($"Cannot create a variant of type '{nameof(InheritanceDataObject)}'.", nameof(parentAssetObject));

            if (string.IsNullOrEmpty(variantPath))
                throw new ArgumentNullException(nameof(variantPath), "The provided path is null or empty.");

            variantPath = AssetDatabase.GenerateUniqueAssetPath(variantPath);
            
            string basePath = AssetDatabase.GetAssetPath(parentAssetObject);
            // Create a copy of the asset, CopyAsset doesn't throw errors, instead uses Debug.LogError so we return null if there was a problem with the copy.
            if (!AssetDatabase.CopyAsset(basePath, variantPath))
                return null;

            // We need to import the newly created variant asset.
            AssetDatabase.ImportAsset(variantPath);

            // Get the newly created variant asset.
            Object variantObject = AssetDatabase.LoadMainAssetAtPath(variantPath);

            GUID baseGuid = AssetDatabase.GUIDFromAssetPath(basePath);
            GUID variantGuid = AssetDatabase.GUIDFromAssetPath(variantPath);

            // Set the variant's parent.
            SetInheritanceParent(variantGuid, baseGuid, false);

            return (ScriptableObject)variantObject;
        }

        /// <summary>
        /// Adds a <see cref="InheritanceDataObject"/> to the asset of the specified GUID.
        /// </summary>
        /// <param name="guid">The GUID of the asset to add inheritance data to.</param>
        /// <returns>The newly created <see cref="InheritanceDataObject"/>.</returns>
        internal static InheritanceDataObject AddDataObject(GUID guid)
        {
            if (IsGUIDInheritance(guid))
                throw new ArgumentException("Inheritance data already present for asset associated with guid.");

            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            Type mainType = AssetDatabase.GetMainAssetTypeAtPath(assetPath);

            // Get the type of data object to create for the asset.
            Type dataObjectType;
            if (mainType.IsSubclassOf(typeof(ScriptableObject)))
                dataObjectType = typeof(ScriptableObjectDataObject);
            else
                throw new NotSupportedException("Asset associated with guid is not of a supported inheritance asset type.");

            var dataObject = (InheritanceDataObject)ScriptableObject.CreateInstance(dataObjectType);
            dataObject.name = "Inheritance Data";
            dataObject.GUID = guid.ToString();
            dataObject.hideFlags = HideFlags.DontSaveInBuild | HideFlags.HideInHierarchy; // Uncomment before release.

            AssetDatabase.AddObjectToAsset(dataObject, assetPath);
            AssetDatabase.SaveAssets();

            return dataObject;
        }

        internal static void ClearParent(InheritanceData data, bool registerUndo)
        {
            if (data == null)
                throw new ArgumentNullException($"{nameof(InheritanceDataObject)} is null.");

            if (!data.IsVariant)
                return;

            var baseData = GetDataFromGUID(data.ParentGUID);

            if (registerUndo)
            {
                Undo.RegisterCompleteObjectUndo(data.DataObject, "Modified asset inheritance");
                Undo.RegisterCompleteObjectUndo(baseData.DataObject, "Modified asset inheritance");
            }

            baseData.DataObject.RemoveVariantGUID(data.DataObject.GUID);

            data.DataObject.ParentGUID = "";
        }
    }
}
