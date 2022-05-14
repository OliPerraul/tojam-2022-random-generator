using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEditor.UIElements;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    [InitializeOnLoad]
    internal static class VisualTreeUpdater
    {
        private static Type _serializedObjectBindingBaseType;
        private static FieldInfo _boundPropertyInfo;
        
        /// <summary>
        /// The time in milliseconds between updates.
        /// </summary>
        private const long UpdateFrequencyMs = 100;
        private static long _timeOfLastUpdate = 0;
        

        static VisualTreeUpdater()
        {
            _serializedObjectBindingBaseType =
                typeof(PropertyField).Assembly.GetType("UnityEditor.UIElements.Bindings.SerializedObjectBindingBase");
            _boundPropertyInfo = TypeTool.GetField(_serializedObjectBindingBaseType, "boundProperty");

            EditorApplication.update += UpdateAllBoundElements;
        }

        private static void UpdateAllBoundElements()
        {
            // We only update the styles every x milliseconds since it has to iterate over all of the bound properties
            // of all of the panels, and a small delay is not really noticeable, but makes a big impact on performance.
            long currentTimeMs = (long)(EditorApplication.timeSinceStartup * 1000.0);
            long deltaTime = currentTimeMs - _timeOfLastUpdate;
            if (deltaTime < UpdateFrequencyMs)
                return;
            
            _timeOfLastUpdate = currentTimeMs;
            
            foreach (IPanel panel in VisualElementUtility.Panels)
            {
                var bindingsUpdater = VisualElementUtility.GetUpdater(panel, VisualTreeUpdatePhase.Bindings);
                if (bindingsUpdater != null)
                {
                    if (!panel.visualTree.styleSheets.Contains(VisualElementUtility.VariantStyleSheet))
                        panel.visualTree.styleSheets.Add(VisualElementUtility.VariantStyleSheet);
                    VisualElementUtility.PullElementsWithBindings(bindingsUpdater, UpdateBoundElementStyle);
                }
            }
        }
        
        private static void UpdateBoundElementStyle(VisualElement element, IBinding binding)
        {
            if (binding.GetType().IsSubclassOf(_serializedObjectBindingBaseType))
            {
                if (_boundPropertyInfo.GetValue(binding) is SerializedProperty property)
                    UpdatePropertyElementStyle(element, property);
            }
        }

        private static void UpdatePropertyElementStyle(VisualElement element, SerializedProperty property)
        {
            VisualElementStyler.UpdateVariantStateStyle(element, property);
        }
    }
}
