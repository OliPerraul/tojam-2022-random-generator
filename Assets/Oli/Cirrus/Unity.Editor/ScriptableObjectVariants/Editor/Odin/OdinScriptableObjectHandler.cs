using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if ODIN_INSPECTOR

using Sirenix.OdinInspector.Editor;

namespace Cirrus.Unity.ScriptableObjectVariants.Odin
{
    internal class OdinScriptableObjectHandler : InheritanceHandlerBase<InspectorProperty, PropertyTree>
    {
        private InspectorProperty _parentProperty;
        
        public override void InitializeOwners(Object target, Object parent)
        {
            TargetOwner = PropertyTree.Create(target);
            ParentOwner = PropertyTree.Create(parent);
        }

        public override void DisposeOwners()
        {
            TargetOwner.Dispose();
            ParentOwner.Dispose();
        }

        public override bool ParentHasProperty(InspectorProperty property)
        {
            _parentProperty = ParentOwner.GetPropertyAtPath(property.Path);
            return _parentProperty != null;
        }
        
        public override bool PropertyEqualsParent(InspectorProperty property)
        {
            return Equals(_parentProperty.ValueEntry.WeakSmartValue, property.ValueEntry.WeakSmartValue);
        }

        protected override IEnumerable<InspectorProperty> EnumerateOwner(PropertyTree owner)
        {
            foreach (var child in owner.EnumerateTree())
            {
                if (child.Path == "InternalOnInspectorGUI" || child.Path.EndsWith("#entry"))
                    continue;
                
                yield return child;
            }
        }

        public override string GetPropertyPath(InspectorProperty property)
        {
            return property.Path;
        }

        public override bool CopyFromParentIfDifferent(string propertyPath)
        {
            var targetValueEntry = TargetOwner.GetPropertyAtPath(propertyPath).ValueEntry;
            var parentValueEntry = ParentOwner.GetPropertyAtPath(propertyPath).ValueEntry;
            if (Equals(targetValueEntry.WeakSmartValue, parentValueEntry.WeakSmartValue))
            {
                targetValueEntry.WeakSmartValue = parentValueEntry.WeakSmartValue;
                targetValueEntry.ApplyChanges();
                return true;
            }

            return false;
        }
    }
}
#endif
