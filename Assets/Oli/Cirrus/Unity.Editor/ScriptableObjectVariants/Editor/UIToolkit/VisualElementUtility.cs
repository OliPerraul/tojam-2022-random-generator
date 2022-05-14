using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    // Mirrors the internal Unity enum of the same name. The enums MUST have the same names as the Unity implementation.
    internal enum VisualTreeUpdatePhase
    {
        ViewData,
        Bindings,
        Animation,
        Styles,
        Layout,
        TransformClip,
        Repaint,
        Count,
    }
    
    internal static class VisualElementUtility
    {
        private static Assembly _assembly;
        
        private static Type _uiElementsUtilityType;
        private static FieldInfo _panelsIterationListInfo;

        private static Type _visualTreeUpdatePhaseEnumType;

        private static Type _baseVisualElementPanelType;
        private static MethodInfo _getUpdaterInfo;
        
        private static Type _visualTreeBindingsUpdaterType;
        private static MethodInfo _pullElementsWithBindingsInfo;
        private static FieldInfo _lastUpdateTimeInfo;
        
        private static MethodInfo _setProperty;
        private static MethodInfo _getProperty;

        private static StyleSheet _variantStyleSheet;

        public static IEnumerable<IPanel> Panels
        {
            get
            {
                if (_panelsIterationListInfo == null)
                {
                    _panelsIterationListInfo = TypeTool.GetField(_uiElementsUtilityType, "s_PanelsIterationList");
                }
                
                // s_PanelsIterationList is a List of a internal type which implements IPanel, so we use that instead since it is public. 
                IList panels = (IList)_panelsIterationListInfo.GetValue(null);
                foreach (IPanel panel in panels)
                {
                    yield return panel;
                }
            }
        }

        public static StyleSheet VariantStyleSheet
        {
            get
            {
                if (_variantStyleSheet == null)
                {
                    string path =
                        $"{EditorAssetsFolderLocator.GetFolderPath()}/UI/VariantOverride{(EditorGUIUtility.isProSkin ? "Dark" : "Light")}.uss";
                    _variantStyleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>(path);
                }

                return _variantStyleSheet;
            }
        }

        static VisualElementUtility()
        {
            _assembly = typeof(VisualElement).Assembly;
            _uiElementsUtilityType = _assembly.GetType("UnityEngine.UIElements.UIElementsUtility");
            _visualTreeUpdatePhaseEnumType = _assembly.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase");
        }

        internal static long GetLastUpdateTime(object updater)
        {
            if (_lastUpdateTimeInfo == null)
            {
                _visualTreeBindingsUpdaterType = _assembly.GetType("UnityEngine.UIElements.VisualTreeBindingsUpdater");
                _lastUpdateTimeInfo = TypeTool.GetField(_visualTreeBindingsUpdaterType, "m_LastUpdateTime");
            }

            return (long) _lastUpdateTimeInfo.GetValue(updater);
        }

        internal static object GetUpdater(IPanel panel, VisualTreeUpdatePhase updatePhase)
        {
            if (_getUpdaterInfo == null)
            {
                _baseVisualElementPanelType = _assembly.GetType("UnityEngine.UIElements.BaseVisualElementPanel");
                _getUpdaterInfo = TypeTool.GetMethod(_baseVisualElementPanelType, "GetUpdater");
            }

            var unityUpdatePhase = Enum.Parse(_visualTreeUpdatePhaseEnumType, updatePhase.ToString());
            return _getUpdaterInfo.Invoke(panel, new object[] { unityUpdatePhase });
        }

        internal static void PullElementsWithBindings(object updater, Action<VisualElement, IBinding> action)
        {
            if (_pullElementsWithBindingsInfo == null)
            {
                _visualTreeBindingsUpdaterType = _assembly.GetType("UnityEngine.UIElements.VisualTreeBindingsUpdater");
                _pullElementsWithBindingsInfo = TypeTool.GetMethod(_visualTreeBindingsUpdaterType, "PollElementsWithBindings");
            }

            _pullElementsWithBindingsInfo.Invoke(updater, new object[] { action });
        }
        
        internal static void SetProperty(VisualElement element, PropertyName key, object value)
        {
            if (_setProperty == null)
                _setProperty = TypeTool.GetMethod<VisualElement>("SetProperty");
            _setProperty.Invoke(element, new object[] { key, value });
        }

        internal static object GetProperty(VisualElement element, PropertyName key)
        {
            if (_getProperty == null)
                _getProperty = TypeTool.GetMethod<VisualElement>("GetProperty");
            
            return _getProperty.Invoke(element, new object[] { key });
        }
    }
}
