using System;
using System.Reflection;
using UnityEngine;
using UnityEditor;
using Object = UnityEngine.Object;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    public static class EditorGUIUtilities
    {
        private static readonly Type _hostViewType = EditorTypeTool.GetEditorType("HostView");

        private static readonly EventInfo _beginPropertyInfo = TypeTool.GetEvent<EditorGUIUtility>("beginProperty");
        private static readonly EventInfo _actualViewChangedInfo = TypeTool.GetEvent(_hostViewType, "actualViewChanged");

        private static readonly PropertyInfo _actualViewInfo = TypeTool.GetProperty(_hostViewType, "actualView");
        
        private static readonly Action<Rect, Color> _drawMarginLineForRect = TypeTool.GetMethod<EditorGUI>("DrawMarginLineForRect").CreateStaticDelegate<Action<Rect, Color>>();
        private static readonly Action<bool> _setBoldDefaultFont = TypeTool.GetMethod<EditorGUIUtility>("SetBoldDefaultFont").CreateStaticDelegate<Action<bool>>();

        private static Action _beginHandleMixedValueContentColor;
        private static Action _endHandleMixedValueContentColor;

        private static GUIContent _tempContent;

        /// <summary>
        /// Called before a PropertyField is drawn.
        /// </summary>
        public static event Action<Rect, SerializedProperty> BeginProperty
        {
            add { _beginPropertyInfo.AddMethod.Invoke(null, new object[] { value }); }
            remove { _beginPropertyInfo.RemoveMethod.Invoke(null, new object[] { value }); }
        }

        /// <summary>
        /// Called when a window's visibility is changed
        /// </summary>
        /// <remarks>Visibility changes when a window is either opened, closed, or tabbed to. <c>null</c> if window is closed.</remarks>
        public static event Action<EditorWindow> OnWindowVisibilityChanged;

        static EditorGUIUtilities()
        {
            Action<object> onActualViewChanged = HandleActualViewChanged;
            _actualViewChangedInfo.AddMethod.Invoke(null, new object[] { onActualViewChanged });
        }
        
        private static void HandleActualViewChanged(object hostView)
        {
            EditorWindow window = _actualViewInfo.GetValue(hostView) as EditorWindow;
            OnWindowVisibilityChanged?.Invoke(window);
        }

        public static void DrawMarginLineForRect(Rect position, Color color)
        {
            _drawMarginLineForRect(position, color);
        }

        public static void SetBoldDefaultFont(bool isBold)
        {
            _setBoldDefaultFont(isBold);
        }

        public static void BeginHandleMixedValueContentColor()
        {
            if (_beginHandleMixedValueContentColor == null)
            {
                _beginHandleMixedValueContentColor = TypeTool.GetMethod<EditorGUI>("BeginHandleMixedValueContentColor").CreateDelegate<Action>(null);
            }

            _beginHandleMixedValueContentColor();
        }
        
        public static void EndHandleMixedValueContentColor()
        {
            if (_endHandleMixedValueContentColor == null)
            {
                _endHandleMixedValueContentColor = TypeTool.GetMethod<EditorGUI>("EndHandleMixedValueContentColor").CreateDelegate<Action>(null);
            }

            _endHandleMixedValueContentColor();
        }

        public static bool ObjectLabel(Rect rect, Object obj, GUIStyle style)
        {
            bool doubleClicked = false;
            GUI.Label(rect, TempContent(obj.name, AssetPreview.GetMiniThumbnail(obj)), style);
            Event evt = Event.current;
            if (evt.type == EventType.MouseDown && evt.button == 0 && rect.Contains(evt.mousePosition))
            {
                if (evt.clickCount == 1)
                {
                    GUIUtility.keyboardControl = GUIUtility.GetControlID(FocusType.Keyboard);
                    EditorGUIUtility.PingObject(obj);
                }
                else
                {
                    Selection.activeObject = obj;
                    doubleClicked = true;
                }
                
                Event.current.Use();
            }

            return doubleClicked;
        }

        public static GUIContent TempContent(string text) => TempContent(text, "", null);
        
        public static GUIContent TempContent(string text, Texture2D image) => TempContent(text, "", image);
        
        public static GUIContent TempContent(string text, string tooltip, Texture2D image)
        {
            if (_tempContent == null)
                _tempContent = new GUIContent();
            _tempContent.text = text;
            _tempContent.tooltip = tooltip;
            _tempContent.image = image;
            return _tempContent;
        }
    }
}
