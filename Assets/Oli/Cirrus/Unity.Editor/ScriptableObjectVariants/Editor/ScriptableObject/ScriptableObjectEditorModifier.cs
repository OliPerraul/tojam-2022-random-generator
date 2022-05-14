using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using UnityEngine;
using UnityEditor;

using UEditor = UnityEditor.Editor;
using UnityObject = UnityEngine.Object;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    [InitializeOnLoad]
    internal static class ScriptableObjectEditorModifier
    {
        internal static readonly Color OverrideMarginColor = new Color(196f / 255f, 196f / 255f, 196f / 255f, 0.75f);//new Color(1f / 255f, 153f / 255f, 235f / 255f, 0.75f);

        static ScriptableObjectEditorModifier()
        {
            UEditor.finishedDefaultHeaderGUI += OnHeaderGUI;
            EditorGUIUtilities.BeginProperty += OnBeginProperty;
            EditorApplication.contextualPropertyMenu += PopulatePropertyContextMenu;
        }

        private static void OnBeginProperty(Rect rect, SerializedProperty property)
        {
            if (property.serializedObject.targetObject is ScriptableObject target)
            {
                if (ScriptableVariantUtility.TryGetData(target, out ScriptableObjectData data))
                {
                    // TODO: Remove as this is only temp for testing!!
                    // This shows how to disable a property for things like locking.
                    // if (property.propertyPath == "_fooString")
                    // {
                    //     GUI.enabled = false;
                    // }

                    if (!data.IsPropertyOverridden(property.propertyPath))
                        return;

                    Rect indentRect = rect;
                    indentRect.xMin += 5;
                    
                    EditorGUIUtilities.DrawMarginLineForRect(indentRect, OverrideMarginColor);
                    EditorGUIUtilities.SetBoldDefaultFont(true);
                }
            }
        }

        internal static void PopulatePropertyContextMenu(GenericMenu menu, SerializedProperty property)
        {
            UnityObject target = property.serializedObject.targetObject;
            if (ScriptableVariantUtility.TryGetData(target as ScriptableObject, out ScriptableObjectData data))
            {
                if (data.IsPropertyOverridden(property.propertyPath))
                {
                    var parentObject = ScriptableVariantUtility.GetParent((ScriptableObject)target);
                    var targetParentObject = parentObject;
                    
                    while (parentObject != null)
                    {
                        string text = "";
                        if (parentObject == targetParentObject)
                            text = $"Apply to ScriptableObject '{parentObject.name}'";
                        else
                            text = $"Apply as Override in Variant '{parentObject.name}'";
                        menu.AddItem(new GUIContent(text), false, ApplyProperty, 
                            (parentObject, data, property.propertyPath));

                        parentObject = ScriptableVariantUtility.GetParent(parentObject);
                    }
                    
                    menu.AddItem(new GUIContent("Revert"), false, userData => RevertProperty(userData, data), (target, property.propertyPath));
                }
            }
        }

        private static void RevertProperty(object userData, InheritanceData data)
        {
            var (target, propertyPath) = ((UnityObject, string))userData;
            var group = Undo.GetCurrentGroup();

            data.RevertPropertyOverride(propertyPath);

            Undo.CollapseUndoOperations(group);
        }

        private static void ApplyProperty(object userData)
        {
            var (target, data, propertyPath) = ((ScriptableObject, ScriptableObjectData, string)) userData;
            data.Apply(propertyPath, target);
        }

        
        private static void OnHeaderGUI(UEditor editor)
        {
            const float openButtonWidth = 47;
            const float horizontalSpacing = 5;
            const float hierarchyButtonWidth = 44;
            
            if (editor.target is ScriptableObject target)
            {
                // We don't show the field if the scriptableObject is invalid (not an asset and not main asset).
                if (!AssetDatabase.IsMainAsset(target))
                    return;

                float fieldWidth = EditorGUIUtility.currentViewWidth - openButtonWidth - horizontalSpacing - hierarchyButtonWidth - 3 - 43;
                Rect rect = new Rect(43, 28, fieldWidth, EditorGUIUtility.singleLineHeight);
                
                // If the object has a custom editor that overrides the header, we show the field on its own line
                // inside of inline with the "Open" button since we have no way of knowing what the header contains.
                if (EditorTypeTool.DoesCustomEditorOverrideHeader(target))
                {
                    rect = GUILayoutUtility.GetRect(120, EditorGUIUtility.singleLineHeight);
                    rect.xMin += 5;
                }

                Rect hierarchyButtonRect = rect;
                hierarchyButtonRect.x = rect.xMax + 3;
                hierarchyButtonRect.width = hierarchyButtonWidth;
                
                if (EditorGUI.DropdownButton(hierarchyButtonRect, GUIContent.none, FocusType.Passive))
                {
                    //ScriptableHierarchyPopup popup = EditorWindow.CreateInstance<ScriptableHierarchyPopup>();
                    //popup.Target = target;
                    //popup.ShowAsDropDown(hierarchyButtonRect, new Vector2(400, 200));
                    ScriptableHierarchyPopupIMGUI.Show(hierarchyButtonRect, target);
                    GUIUtility.ExitGUI();
                }

                EditorGUI.BeginChangeCheck();
                EditorGUI.showMixedValue = HasMixedValues(editor.targets);
                var obj = ParentField(rect, editor.targets);
                EditorGUI.showMixedValue = false;
                if (EditorGUI.EndChangeCheck())
                {
                    int groupIndex = Undo.GetCurrentGroup();
                    foreach (ScriptableObject targetScriptableObject in editor.targets)
                    {
                        ScriptableVariantUtility.SetParent(targetScriptableObject, obj);
                    }
                    Undo.CollapseUndoOperations(groupIndex);
                }
            }
        }

        private static bool HasMissingParent(ScriptableObject target)
        {
            bool isVariant = ScriptableVariantUtility.IsVariant(target);
            var parent = ScriptableVariantUtility.GetParent(target);
            return isVariant && parent == null;
        }
        

        private static ScriptableObject ParentField(Rect rect, UnityObject[] targets)
        {
            EditorGUIUtility.labelWidth = 51;
            rect = EditorGUI.PrefixLabel(rect, Styles.ParentContent);
            
            int controlId = GUIUtility.GetControlID(FocusType.Keyboard);
            Event evt = Event.current;


            var obj = GetObjectFromTargetsAndDnD(rect, evt, controlId, targets);

            if (evt.type == EventType.Repaint && HasMissingParent(targets[0] as ScriptableObject))
            {
                Rect fieldButtonRect = Styles.ObjectFieldButton.margin.Remove(new Rect(rect.xMax - 19f, rect.y, 19f, rect.height));
                EditorGUIUtilities.BeginHandleMixedValueContentColor();
                EditorStyles.objectField.Draw(rect, Styles.MissingParentContent, controlId, DragAndDrop.activeControlID == controlId, rect.Contains(evt.mousePosition));
                Styles.ObjectFieldButton.Draw(fieldButtonRect, GUIContent.none, controlId, DragAndDrop.activeControlID == controlId, fieldButtonRect.Contains(evt.mousePosition));
                EditorGUIUtilities.EndHandleMixedValueContentColor();
            }
            else
            {
                obj = DoObjectField(rect, rect, controlId, obj, null, typeof(ScriptableObject), false, null);   
            }

            return obj as ScriptableObject;
        }

        private static UnityObject GetObjectFromTargetsAndDnD(Rect rect, Event evt, int controlId, UnityObject[] targets)
        {
            var target = targets[0] as ScriptableObject;
            
            ScriptableObject resultParent = ScriptableVariantUtility.GetParent(target);

            if (evt.type != EventType.DragUpdated && evt.type != EventType.DragPerform)
                return resultParent;
            
            if (rect.Contains(evt.mousePosition) && GUI.enabled)
            {
                ScriptableObject draggedParentObject = null;

                if (DragAndDrop.objectReferences.Length > 0)
                    draggedParentObject = DragAndDrop.objectReferences[0] as ScriptableObject;
                    
                if (draggedParentObject != null && !ScriptableVariantUtility.IsAncestorOf(draggedParentObject, target))
                {
                    DragAndDrop.visualMode = DragAndDropVisualMode.Generic;
                    if (evt.type == EventType.DragPerform)
                    {
                        GUI.changed = true;
                        DragAndDrop.AcceptDrag();
                        DragAndDrop.activeControlID = 0;
                        resultParent = draggedParentObject;
                    }
                    else
                    {
                        DragAndDrop.activeControlID = controlId;
                    }
                        
                }
                    
                evt.Use();
            }

            return resultParent;
        }

        private static bool HasMixedValues(UnityObject[] targets)
        {
            var targetParent = ScriptableVariantUtility.GetParent((ScriptableObject)targets[0]);
            for (int i = 1; i < targets.Length; i++)
            {
                var parent =  ScriptableVariantUtility.GetParent((ScriptableObject)targets[i]);
                if (targetParent != parent)
                    return true;
            }

            return false;
        }
        
        private static MethodInfo _doObjectFieldInfo;

        private static UnityObject DoObjectField(Rect position, Rect dropRect, int id, UnityObject obj, UnityObject objBeingEdited,
            Type objType, bool allowSceneObjects, GUIStyle style = null)
        {
            if (_doObjectFieldInfo == null)
            {
                _doObjectFieldInfo = TypeTool.GetMethod<EditorGUI>("DoObjectField", 
                    typeof(Rect), typeof(Rect), typeof(int),
                    typeof(UnityObject), typeof(UnityObject), typeof(Type),
                    typeof(EditorGUI).GetNestedType("ObjectFieldValidator", BindingFlags.NonPublic), typeof(bool),
                    typeof(GUIStyle));
            }

            return (UnityObject)_doObjectFieldInfo.Invoke(null,
                new object[] { position, dropRect, id, obj, objBeingEdited, objType, null, allowSceneObjects, style });
        }
        
        private static class Styles
        {
            public static readonly GUIContent ParentContent = new GUIContent("Parent", "The parent of the ScriptableObject");
            public static readonly GUIContent MissingParentContent = new GUIContent("Missing (Scriptable Object)");

            public static GUIStyle ObjectFieldButton { get; }
            
            static Styles()
            {
                ObjectFieldButton = new GUIStyle("ObjectFieldButton");
            }
        }
    }
}
