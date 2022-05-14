using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEditor.UIElements;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    internal static class VisualElementStyler
    {
        internal static readonly string prefabOverrideBarContainerName = "unity-prefab-override-bars-container";
        
        internal static readonly string variantOverrideBarName = "bewildered-binding-variant-override-bar";
        internal static readonly string variantOverrideBarUssClassName = "bewildered-binding__variant-override-bar";
        internal static readonly string variantOverrideUssClassName = "bewildered-binding--variant-override";

        

        public static void UpdateVariantStateStyle(VisualElement element, SerializedProperty prop)
        {
            ScriptableObjectData data = ScriptableVariantUtility.GetData(prop.serializedObject.targetObject as ScriptableObject);
            if (prop.serializedObject.targetObjects.Length == 1 && data != null && data.IsVariant && data.IsPropertyOverridden(prop.propertyPath))
            {
                if (element.ClassListContains(variantOverrideUssClassName))
                    return;
                
                InspectorElement inspectorElement = element.GetFirstAncestorOfType<InspectorElement>();
                VisualElement overrideBarContainer = inspectorElement?.Q(prefabOverrideBarContainerName);

                element.AddToClassList(variantOverrideUssClassName);
                if (inspectorElement != null && overrideBarContainer != null)
                {
                    VisualElement overrideBar = new VisualElement();
                    overrideBar.name = variantOverrideBarName;
                    overrideBar.userData = element;
                    overrideBar.AddToClassList(variantOverrideBarUssClassName);
                    overrideBarContainer.Add(overrideBar);

                    VisualElementUtility.SetProperty(element, variantOverrideBarName, overrideBar);
                    UpdateVariantOverrideBarStyle(overrideBar);
                    inspectorElement.RegisterCallback<GeometryChangedEvent>(UpdatePrefabOverrideBarStyleEvent, TrickleDown.NoTrickleDown);
                    
                    // Some times the update will happen before the field element has initialized so doesn't have rect set,
                    // so we register an even to update the bar once the field has initialized.
                    if (float.IsNaN(element.worldBound.y))
                        element.RegisterCallback<GeometryChangedEvent>(DelayedUpdateVariantOverrideStyleEvent);
                }
            }
            else
            {
                if (element.ClassListContains(variantOverrideUssClassName))
                {
                    element.RemoveFromClassList(variantOverrideUssClassName);

                    InspectorElement inspectorElement = element.GetFirstAncestorOfType<InspectorElement>();
                    VisualElement overrideBarContainer = inspectorElement?.Q(prefabOverrideBarContainerName);

                    if (inspectorElement != null && overrideBarContainer != null)
                    {
                        if (VisualElementUtility.GetProperty(element, variantOverrideBarName) is VisualElement overrideBar)
                        {
                            overrideBar.RemoveFromHierarchy();
                        }
                    }
                }
            }
        }

        private static void UpdateVariantOverrideBarStyle(VisualElement overrideBar)
        {
            VisualElement element = overrideBar.userData as VisualElement;
            InspectorElement inspectorElement = element.GetFirstAncestorOfType<InspectorElement>();
            
            if (inspectorElement != null)
            {
                float topOffset = element.worldBound.y - inspectorElement.worldBound.y;
                
                if (!float.IsNaN(topOffset))
                {
                    float height = element.resolvedStyle.height;
                    float marginBottom = element.resolvedStyle.marginBottom;
                    overrideBar.style.top = topOffset;
                    overrideBar.style.height = height + marginBottom;
                    overrideBar.style.left = 0f;
                }
            }
        }

        private static void UpdatePrefabOverrideBarStyleEvent(GeometryChangedEvent evt)
        {
            if (evt.target is InspectorElement inspectorElement)
            {
                VisualElement overrideBarContainer = inspectorElement.Q(prefabOverrideBarContainerName);
                
                if (overrideBarContainer != null)
                {
                    foreach (VisualElement overrideBar in overrideBarContainer.Children())
                    {
                        UpdateVariantOverrideBarStyle(overrideBar);
                    }
                }
            }
        }

        private static void DelayedUpdateVariantOverrideStyleEvent(GeometryChangedEvent evt)
        {
            var element = (VisualElement)evt.target;
            InspectorElement inspectorElement = element.GetFirstAncestorOfType<InspectorElement>();
            VisualElement overrideBarContainer = inspectorElement?.Q(prefabOverrideBarContainerName);
            
            if (overrideBarContainer != null)
            {
                foreach (VisualElement overrideBar in overrideBarContainer.Children())
                {
                    UpdateVariantOverrideBarStyle(overrideBar);
                }
            }
            
            element.UnregisterCallback<GeometryChangedEvent>(DelayedUpdateVariantOverrideStyleEvent);
        }
    }
}
