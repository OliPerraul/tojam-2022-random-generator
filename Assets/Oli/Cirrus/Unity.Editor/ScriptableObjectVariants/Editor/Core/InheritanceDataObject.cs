using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Serialization;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    /// <summary>
    /// Stores inheritance data for an asset on disk.
    /// </summary>
    internal class InheritanceDataObject : ScriptableObject
    {
        [SerializeField] private string _guid;
        [SerializeField] private string parentGuid;
        [SerializeField] private List<string> _variantGuids = new List<string>();
        [SerializeField] private List<PropertyOverrideData> _overriddenProperties = new List<PropertyOverrideData>();

        /// <summary>
        /// The GUID of the asset.
        /// </summary>
        public string GUID
        {
            get { return _guid; }
            internal set 
            {
                _guid = value;
                EditorUtility.SetDirty(this);
            }
        }

        /// <summary>
        /// The GUID of the asset that the asset is a variant of.
        /// </summary>
        public string ParentGUID
        {
            get { return parentGuid; }
            set 
            {
                parentGuid = value;
                EditorUtility.SetDirty(this);
            }
        }

        /// <summary>
        /// The GUIDs of the assets that inherit from the asset.
        /// </summary>
        public IReadOnlyList<string> VariantGUIDs
        {
            get { return _variantGuids; }
        }

        /// <summary>
        /// The names/paths of the properties that the asset overrides.
        /// </summary>
        public List<PropertyOverrideData> OverriddenProperties
        {
            get { return _overriddenProperties; }
        }

        /// <summary>
        /// Adds the specified GUID to the variant GUIDs list and sets the <see cref="InheritanceDataObject"/> dirty.
        /// </summary>
        /// <remarks>Does not register undo.</remarks>
        /// <param name="guid">The GUID of the asset to add to the variants list.</param>
        public void AddVariantGUID(string guid)
        {
            EditorUtility.SetDirty(this);
            _variantGuids.Add(guid);
        }

        /// <summary>
        /// Removes the specified GUID from the variant GUIDs list and sets the <see cref="InheritanceDataObject"/> dirty.
        /// </summary>
        /// <remarks>Does not register undo.</remarks>
        /// <param name="guid">The GUID of the asset to remove from the variants list.</param>
        /// <returns><c>true</c> if <paramref name="guid"/> was removed; otherwise, <c>false</c>.</returns>
        public bool RemoveVariantGUID(string guid)
        {
            EditorUtility.SetDirty(this);
            return _variantGuids.Remove(guid);
        }

        /// <summary>
        /// Removes all GUIDs from the variant GUIDs list and sets the <see cref="InheritanceDataObject"/> dirty.
        /// </summary>
        /// <remarks>Does not register undo.</remarks>
        public void ClearVariantGUIDs()
        {
            EditorUtility.SetDirty(this);
            _variantGuids.Clear();
        }

        public void ClearOverriddenProperties()
        {
            EditorUtility.SetDirty(this);
            _overriddenProperties.Clear();
        }
    }
}
