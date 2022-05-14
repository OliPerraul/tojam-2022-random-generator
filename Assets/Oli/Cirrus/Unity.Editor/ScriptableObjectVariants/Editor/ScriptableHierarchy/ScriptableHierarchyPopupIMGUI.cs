using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    internal class ScriptableHierarchyPopupIMGUI : EditorWindow
    {
        private static readonly float _minWindowWidth = 300f;
        private static readonly float _maxWindowWidth = 500f;
        private static readonly float _windowPadding = 6f;
        private static readonly float _halfPadding = 3f;
        private static readonly float _headerHeight = 49f;
        private static readonly float _lineHeight = 20f;
        private static readonly float _relationWidth = 56f;
        private static float _overridesWidth;
        private static float _locksWidth;
        private static ObjectListAreaState _listAreaState = new ObjectListAreaState() { GridSize = 56 };

        private ScriptableObject _target;
        private ObjectListArea _listArea;
        private float _nameWidth;
        private float _windowWidth;
        private int _ancestorCount;

        public static void Show(Rect buttonRect, ScriptableObject target)
        {
            var window = CreateInstance<ScriptableHierarchyPopupIMGUI>();
            window._target = target;
            window.Init();
            
            window.ShowAsDropDown(GUIUtility.GUIToScreenRect(buttonRect), new Vector2(window._windowWidth, 200));
            //window.Show();
            window.position = new Rect(window.position) { width = window._windowWidth };
        }

        private void Init()
        {
            _overridesWidth = 1f + EditorStyles.miniLabel.CalcSize(new GUIContent("Overrides")).x + 6f;
            
            float minNameWidth = _minWindowWidth - (_relationWidth + 1 + 16 + _overridesWidth);
            float maxNameWidth = _maxWindowWidth - (_relationWidth + 1 + 16 + _overridesWidth);

            _ancestorCount = 0;
            _nameWidth = minNameWidth;
            var content = new GUIContent();
            ScriptableObject parent = _target;
            while (parent != null)
            {
                content.text = parent.name;
                _nameWidth = Mathf.Max(EditorStyles.label.CalcSize(content).x + 23f, _nameWidth);
                parent = ScriptableVariantUtility.GetParent(parent);
                _ancestorCount++;
            }

            _nameWidth = Mathf.Min(_nameWidth, maxNameWidth);

            _windowWidth = _relationWidth + 16 + _nameWidth + 1 + _overridesWidth;
        }

        private void InitListArea()
        {
            _listArea = new ObjectListArea(_listAreaState, this, false)
            {
                AllowDeselection = true,
                AllowMultiSelect = false,
                AllowRenaming = false,
                AllowBuiltinResources = true
            };
            _listArea.ObjectSelectedCallback += doubleClicked =>
            {
                if (_listArea.GetSelection().Length == 0)
                    return;
                
                int num = _listArea.GetSelection()[0];
                GUIUtility.keyboardControl = GUIUtility.GetControlID(FocusType.Keyboard);
                if (doubleClicked)
                {
                    Selection.SetActiveObjectWithContext(EditorUtility.InstanceIDToObject(num), null);
                    Close();
                    GUIUtility.ExitGUI();
                }
                else
                {
                    EditorGUIUtility.PingObject(num);
                }
                
                Event.current.Use();
            };
        }
        
        private void OnGUI()
        {
            DrawHeader();
            DrawAncestors();
        }

        private void DrawHeader()
        {
            Rect rect = new Rect(0, 0, _windowWidth, _headerHeight);
            EditorGUI.DrawRect(rect, Styles.HeaderColor);

            rect.xMin += _windowPadding;
            rect.xMax += _windowPadding;
            rect.yMin += _halfPadding;

            rect.height = EditorGUIUtility.singleLineHeight;
            rect.width = EditorStyles.boldLabel.CalcSize(Styles.HierarchyOfContent).x;

            Rect objectLabelRect = new Rect(rect);
            objectLabelRect.width = _windowWidth;
            objectLabelRect.xMin = rect.xMax;
            
            GUI.Label(rect, Styles.HierarchyOfContent, EditorStyles.boldLabel);
            if (EditorGUIUtilities.ObjectLabel(objectLabelRect, _target, EditorStyles.boldLabel))
            {
                Close();
                GUIUtility.ExitGUI();
            }
        }

        private void DrawAncestors()
        {
            Rect rect = new Rect(0, _headerHeight, _windowWidth, _lineHeight);
            EditorGUI.DrawRect(rect, Styles.GetRowColor(0));

            rect.x += _relationWidth + _windowPadding;
            rect.width = _nameWidth;
            GUI.Label(rect, Styles.AncestorsContent, EditorStyles.miniLabel);

            rect.x += rect.width;
            rect.width = _overridesWidth;
            GUI.Label(rect, Styles.OverridesContent, Styles.CenteredMiniLabel);

            rect.x = 0;
            rect.width = _windowWidth;
            int i = _ancestorCount;
            ScriptableObject parent = _target;
            while (parent != null)
            {
                rect.y = _headerHeight + (i * _lineHeight);
                EditorGUI.DrawRect(rect, Styles.GetRowColor(i--));
                DrawAncestor(rect, parent, i);
                parent = ScriptableVariantUtility.GetParent(parent);
            }

            var dividerRect = new Rect();
            dividerRect.x = _windowPadding + _relationWidth + _nameWidth;
            dividerRect.y = _headerHeight;
            dividerRect.width = 1;
            dividerRect.height = (_ancestorCount + 1) * _lineHeight;
            EditorGUI.DrawRect(dividerRect, Styles.HeaderColor);
            dividerRect.x += _overridesWidth;
            EditorGUI.DrawRect(dividerRect, Styles.HeaderColor);
        }

        private void DrawAncestor(Rect rect, ScriptableObject obj, int number)
        {
            rect.x = _windowPadding;
            rect.width = _relationWidth;
            GUIContent content = EditorGUIUtilities.TempContent("");
            if (number == _ancestorCount - 1)
                content.text = "Current";
            else if (number == _ancestorCount - 2)
                content.text = "Parent";
            else if (number == 0)
                content.text = "Root";

            GUI.Label(rect, content);

            rect.x = rect.xMax;
            rect.width = _nameWidth;
            if (EditorGUIUtilities.ObjectLabel(rect, obj, EditorStyles.label))
            {
                Close();
                GUIUtility.ExitGUI();
            }

            rect.x = rect.xMax;
            rect.width = _overridesWidth;
            int count = ScriptableVariantUtility.GetData(obj).OverrideCount;
            GUI.Label(rect, count == 0 ? "-" : count.ToString(), Styles.CenteredLabel);
        }

        private void DrawChildren()
        {
            
        }

        private static class Styles
        {
            private static Color _headerColorDark = new Color32(74, 74, 74, Byte.MaxValue);
            private static Color _headerColorLight = new Color32(223, 223, 223, byte.MaxValue);
            private static Color[] _rowBackgroundColorsDark = new Color[]
            {
                new Color32(56, 56, 56, byte.MaxValue),
                new Color32(62, 62, 62, byte.MaxValue)
            };
            private static Color[] _rowBackgroundColorsLight = new Color[]
            {
                new Color32(200, 200, 200, byte.MaxValue),
                new Color32(206, 206, 206, byte.MaxValue)
            };
            
            public static readonly GUIStyle CenteredLabel = new GUIStyle(EditorStyles.label)
            {
                alignment = TextAnchor.MiddleCenter
            };
            public static readonly GUIStyle CenteredMiniLabel = new GUIStyle(EditorStyles.miniLabel)
            {
                alignment = TextAnchor.MiddleCenter
            };
            public static readonly GUIStyle SearchAreaBackground = new GUIStyle("ProjectBrowserIconAreaBg");
            

            public static readonly GUIContent HierarchyOfContent = new GUIContent("Hierarchy of");
            public static readonly GUIContent AncestorsContent = new GUIContent("Ancestors");
            public static readonly GUIContent OverridesContent = new GUIContent("Overrides");
            public static readonly GUIContent LocksContent = new GUIContent("Locks");
            
            public static Color HeaderColor
            {
                get { return EditorGUIUtility.isProSkin ? _headerColorDark : _headerColorLight; }
            }

            public static Color GetRowColor(int num)
            {
                return EditorGUIUtility.isProSkin ? _rowBackgroundColorsDark[num % 2] : _rowBackgroundColorsLight[num % 2];
            }
        }
    }
}
