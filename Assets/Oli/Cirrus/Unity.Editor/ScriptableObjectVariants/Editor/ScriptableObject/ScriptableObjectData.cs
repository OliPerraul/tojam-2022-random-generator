using UnityEngine;
using UnityEditor;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    /// <summary>
    /// Holds information about a <see cref="ScriptableObject"/>'s inheritance and overridden properties.
    /// </summary>
    public class ScriptableObjectData : InheritanceData
    {
        internal ScriptableObjectData(InheritanceDataObject dataObject, string assetGuid) : base(dataObject, assetGuid) { }

        internal ScriptableObjectData(InheritanceDataObject dataObject, GUID assetGuid) : base(dataObject, assetGuid) { }

        protected override void RevertPropertyValue(string property, Object parentObject)
        {
            using var targetSerializedObject = new SerializedObject(GetAssetObject());
            using var parentSerializedObject = new SerializedObject(parentObject);
            
            targetSerializedObject.CopyFromSerializedPropertyIfDifferent(parentSerializedObject.FindProperty(property));
            targetSerializedObject.ApplyModifiedProperties();
        }

        public void Apply(string propertyPath, ScriptableObject ancestorObject)
        {
            if (!ScriptableVariantUtility.IsAncestorOf((ScriptableObject)GetAssetObject(), ancestorObject))
                return;
            
            using var ancestorSerializedObject = new SerializedObject(ancestorObject);
            using var targetSerializedObject = new SerializedObject(GetAssetObject());

            int groupId = Undo.GetCurrentGroup();
            
            ancestorSerializedObject.CopyFromSerializedProperty(targetSerializedObject.FindProperty(propertyPath));
            ancestorSerializedObject.ApplyModifiedProperties();

            Undo.RegisterCompleteObjectUndo(DataObject, "Remove overridden property");
            EditorUtility.SetDirty(DataObject);
            DataObject.OverriddenProperties.Remove(propertyPath);

            Undo.CollapseUndoOperations(groupId);
        }
    }
}
