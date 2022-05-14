using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEditor.UIElements;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    internal class ScriptableHierarchyPopup : EditorWindow
    {
        private static readonly float _minWindowWidth = 300 - 56;
        private static readonly float _maxWindowWidth = 500 - 56;
        //private static readonly float _windowPadding = 3;
        private static readonly float _relationWidth = 56f;
        
        private static readonly string _ancestorRelationUssClassName = "bewildered-variant-ancestor__relation";
        private static readonly string _ancestorAltRowUssClassName = "bewildered-variant-ancestor--alternate";

        private float _nameWidth;
        private float _windowWidth;
        private int _ancestorCount;
        
        public ScriptableObject Target { get; set; }

        public static void Show(Rect position, ScriptableObject target)
        {
            var window = CreateInstance<ScriptableHierarchyPopup>();
            window.Target = target;
            window.Init();
            
            //window.ShowAsDropDown(GUIUtility.GUIToScreenRect(position), new Vector2(window._windowWidth, 200));
            window.Show();
            window.position = new Rect(window.position) { width = window._windowWidth };
        }

        private void Init()
        {
            CalculateNameWidth();
        }

        private void CalculateNameWidth()
        {
            float overridesWidth = 1f + EditorStyles.miniLabel.CalcSize(new GUIContent("Overrides")).x + 6f;
            float minNameWidth = _minWindowWidth - (_relationWidth + 1 + 16 + overridesWidth);
            float maxNameWidth = _maxWindowWidth - (_relationWidth + 1 + 16 + overridesWidth);

            _ancestorCount = 0;
            _nameWidth = minNameWidth;
            var content = new GUIContent();
            ScriptableObject parent = Target;
            while (parent != null)
            {
                content.text = parent.name;
                _nameWidth = Mathf.Max(EditorStyles.label.CalcSize(content).x + 23f, _nameWidth);
                parent = ScriptableVariantUtility.GetParent(parent);
                _ancestorCount++;
            }

            _nameWidth = Mathf.Min(_nameWidth, maxNameWidth);

            _windowWidth = _relationWidth + 16 + _nameWidth + 1 + overridesWidth;
        }

        private void CreateGUI()
        {
            EditorUtilities.LoadVisualTree("ScriptableHierarchy").CloneTree(rootVisualElement);
            rootVisualElement.styleSheets.Add(EditorUtilities.LoadStyleSheet("ScriptableHierarchy"));

            rootVisualElement.Q<Image>("title-icon").image = AssetPreview.GetMiniThumbnail(Target);
            rootVisualElement.Q<Label>("title-name").text = Target.name;
            rootVisualElement.Q("ancestors-label").style.width = _relationWidth + 1 + _nameWidth + 16;

            var container = rootVisualElement.Q(className: "bewildered-variant-ancestors-container");

            int number = _ancestorCount;
            ScriptableObject parent = Target;
            while (parent != null)
            {
                container.Insert(0, CreateAncestorItem(parent, number--));
                parent = ScriptableVariantUtility.GetParent(parent);
            }
        }

        private VisualElement CreateAncestorItem(ScriptableObject obj, int num)
        {
            var element = new VisualElement();
            element.AddToClassList("bewildered-variant-ancestor-entry");
            
            if (num % 2 == 1)
                element.AddToClassList(_ancestorAltRowUssClassName);

            string relationName = "";
            if (obj == Target)
                relationName = "Current";
            else if (ScriptableVariantUtility.GetParent(Target) == obj)
                relationName = "Parent";
            else if (ScriptableVariantUtility.GetParent(obj) == null)
                relationName = "Root";
            
            var relation = new Label();
            relation.text = relationName;
            relation.AddToClassList(_ancestorRelationUssClassName);
            element.Add(relation);

            var icon = new Image();
            icon.image = AssetPreview.GetMiniThumbnail(obj);
            icon.AddToClassList("bewildered-icon");
            element.Add(icon);

            var objName = new Label();
            objName.text = obj.name;
            objName.AddToClassList("bewildered-variant-ancestor__name");
            objName.style.width = _nameWidth;
            element.Add(objName);

            int count = ScriptableVariantUtility.GetData(obj).OverrideCount;
            var overrideCount = new Label();
            overrideCount.text = count > 0 ? count.ToString() : "-";
            overrideCount.AddToClassList("bewildered-variant-ancestor__override-count");
            element.Add(overrideCount);
            
            return element;
        }
    }
}
