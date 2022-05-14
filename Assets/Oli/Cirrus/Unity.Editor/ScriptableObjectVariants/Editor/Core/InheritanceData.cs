using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    /// <summary>
    /// Holds information about an asset object's inheritance and overridden properties.
    /// </summary>
    public abstract class InheritanceData
    {
        private InheritanceDataObject _dataObject;
        private GUID _guid;

        internal InheritanceDataObject DataObject
        {
            get { return _dataObject; }
            set { _dataObject = value; }
        }

        /// <summary>
        /// The GUID of the asset.
        /// </summary>
        public GUID GUID
        {
            get { return _guid; }
        }

        /// <summary>
        /// The asset GUID of the asset's base asset.
        /// </summary>
        public GUID ParentGUID
        {
            get { return _dataObject != null ? new GUID(_dataObject.ParentGUID) : default; }
        }

        /// <summary>
        /// The GUIDs of the assets that inherit from the asset.
        /// </summary>
        public IEnumerable<GUID> VariantGUIDs
        {
            get { return GetVariantGUIDs(); }
        }

        /// <summary>
        /// Whether the asset inherits from a base asset.
        /// </summary>
        public bool IsVariant
        {
            get { return _dataObject != null && !string.IsNullOrEmpty(_dataObject.ParentGUID); }
        }

        /// <summary>
        /// Whether the asset has assets that inherit from it.
        /// </summary>
        public bool HasVariants
        {
            get { return _dataObject != null && _dataObject.VariantGUIDs.Count > 0; }
        }

        public int OverrideCount
        {
            get { return _dataObject != null ? _dataObject.OverriddenProperties.Count : 0; }
        }
        
        /// <summary>
        /// Determines whether the data object is duplicated and is invalid.
        /// </summary>
        internal bool IsDuplicate
        {
            get { return _dataObject != null && new GUID(_dataObject.GUID) != _guid; }
        }

        internal InheritanceData(InheritanceDataObject dataObject, string assetGuid) : this(dataObject, new GUID(assetGuid)) { }

        internal InheritanceData(InheritanceDataObject dataObject, GUID assetGuid)
        {
            _dataObject = dataObject;
            _guid = assetGuid;
        }

        /// <summary>
        /// Determines whether the specified property is overridden by the asset.
        /// </summary>
        /// <param name="property">The name or path of the property to check.</param>
        /// <returns><c>true</c> if <paramref name="property"/> is overridden; otherwise, <c>false</c>.</returns>
        public bool IsPropertyOverridden(string property)
        {
            if (_dataObject == null)
                return false;

            return _dataObject.OverriddenProperties.Contains(property);
        }

        /// <summary>
        /// Overrides the value of the specified property so it will not change when the same property on the base asset changes.
        /// </summary>
        /// <param name="property">The name or path of the property to override.</param>
        /// <returns><c>true</c> if <paramref name="property"/> could be overridden; otherwise, <c>false</c>.</returns>
        public bool OverrideProperty(string property)
        {
            // We don't want to add the property to the overrides list multiple times. Also prevents needless undos.
            if (IsPropertyOverridden(property))
                return false;

            // We add a data object regardless of if the asset is a variant so you can save the current values before assigning a base object.
            if (_dataObject == null)
                _dataObject = ScriptableVariantUtility.AddDataObject(_guid);

            Undo.RegisterCompleteObjectUndo(_dataObject, "Override property");
            EditorUtility.SetDirty(_dataObject);
            _dataObject.OverriddenProperties.Add(property);

            return true;
        }

        /// <summary>
        /// Reverts the specified overridden property so that its value matches, and stays in sync with the asset's the parent asset.
        /// </summary>
        /// <param name="property">The name or path of the property to override.</param>
        public void RevertPropertyOverride(string property)
        {
            if (!IsPropertyOverridden(property))
                return;

            Undo.RegisterCompleteObjectUndo(DataObject, "Revert property");
            EditorUtility.SetDirty(_dataObject);
            DataObject.OverriddenProperties.Remove(property);

            if (IsVariant)
            {
                using var assetParentScope = new AssetUtility.LoadAssetScope(DataObject.ParentGUID);
                RevertPropertyValue(property, assetParentScope.asset);
            }
        }

        protected abstract void RevertPropertyValue(string property, Object parentObject);


        /// <summary>
        /// Returns the asset object of the inheritance data.
        /// </summary>
        /// <returns>The asset object the data is for.</returns>
        public Object GetAssetObject()
        {
            return AssetDatabase.LoadMainAssetAtPath(AssetDatabase.GUIDToAssetPath(_guid));
        }
        
        /// <summary>
        /// Returns the GUIDs of the assets that inherit from the asset.
        /// </summary>
        /// <returns>GUIDs of the variants of the asset.</returns>
        private IEnumerable<GUID> GetVariantGUIDs()
        {
            foreach (var guidAndPath in GetVariantGUIDsAndPaths())
            {
                yield return guidAndPath.Item1;
            }
        }

        // We have this return both the guid and path so that when used in the InheritanceManager, it does not need to
        // get the path again. The performance is important because it will be called multiple times any time a value changes.
        internal IEnumerable<(GUID, string)> GetVariantGUIDsAndPaths()
        {
            if (_dataObject == null)
                yield break;

            for (int i = _dataObject.VariantGUIDs.Count - 1; i >= 0; i--)
            {
                string variantGuid = _dataObject.VariantGUIDs[i];
                string variantPath = AssetDatabase.GUIDToAssetPath(variantGuid);

                // Remove the variant guid if there is no longer an asset associated with it.
                // This happens when the asset is deleted since the data sub-asset is
                // deleted at the same time so we can't get any data from it, like it's parent or variants.
                if (string.IsNullOrEmpty(variantPath))
                {
                    _dataObject.RemoveVariantGUID(variantGuid);
                    continue;
                }
#if UNITY_2020_3
                // In versions before 2021, GUID will still sometimes return a path after the asset has been deleted.
                // So we need to manually check if the file exists.
                if (!System.IO.File.Exists(ScriptableVariantUtility.ProjectPath + variantPath))
                {
                    _dataObject.RemoveVariantGUID(variantGuid);
                    continue;
                }
                else
                {
                    // We need to check the actual guid of the asset meta file because if a asset was deleted
                    // and then an asset with the same name & path was created before this check runs it will match even with a different guid.
                    using (var reader =
                        System.IO.File.OpenText(ScriptableVariantUtility.ProjectPath + variantPath + ".meta"))
                    {
                        reader.ReadLine();
                        var guidLine = reader.ReadLine();
                        if (guidLine.Substring(6) != variantGuid)
                        {
                            _dataObject.RemoveVariantGUID(variantGuid);
                            continue;
                        }
                    }
                }
#endif
                yield return (new GUID(variantGuid), variantPath);
            }
        }
    }
}
