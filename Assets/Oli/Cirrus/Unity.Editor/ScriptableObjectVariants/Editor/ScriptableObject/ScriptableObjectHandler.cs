using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    internal class ScriptableObjectHandler : InheritanceHandlerBase<SerializedProperty, SerializedObject>
    {
        private SerializedProperty _baseProperty;

        public override void InitializeOwners(Object target, Object parent)
        {
            TargetOwner = new SerializedObject(target);
            ParentOwner = new SerializedObject(parent);
        }

        public override void DisposeOwners()
        {
            TargetOwner.Dispose();
            ParentOwner.Dispose();
        }
        
        public override bool ParentHasProperty(SerializedProperty property)
        {
            _baseProperty = ParentOwner.FindProperty(property.propertyPath);
            return _baseProperty != null;
        }

        public override bool PropertyEqualsParent(SerializedProperty property)
        {
            return SerializedProperty.DataEquals(property, _baseProperty);
        }

        public override string GetPropertyPath(SerializedProperty property)
        {
            return property.propertyPath;
        }

        protected override IEnumerable<SerializedProperty> EnumerateOwner(SerializedObject owner)
        {
            return owner.Iterate();
        }

        public override bool CopyFromParentIfDifferent(string propertyPath)
        {
            var ownerBaseProperty = ParentOwner.FindProperty(propertyPath);
            
            // Need to check if both the owner and owner base have the property, otherwise CopyFrom will log an error.
            if (ownerBaseProperty != null && TargetOwner.FindProperty(propertyPath) != null)
                return TargetOwner.CopyFromSerializedPropertyIfDifferent(ownerBaseProperty);
            else
                return false;
        }

        public override bool OnAfterSyncProperties(InheritanceData data)
        {
            return TargetOwner.ApplyModifiedProperties();
        }
    }
}
