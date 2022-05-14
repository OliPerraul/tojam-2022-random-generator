using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;

namespace Cirrus.Unity.ScriptableObjectVariants.Odin
{
    internal class OdinEditorModifier : OdinDrawer, IDefinesGenericMenuItems
    {
        protected override void DrawPropertyLayout(GUIContent label)
        {
            if (Property.Tree.WeakTargets.FirstOrDefault() is ScriptableObject target)
            {
                if (ScriptableVariantUtility.TryGetData(target, out ScriptableObjectData data))
                {
                    if (!data.IsPropertyOverridden(Property.UnityPropertyPath))
                    {
                        CallNextDrawer(label);
                        return;
                    }
                
                    GUIHelper.PushIsBoldLabel(true);
                    CallNextDrawer(label);
                    var rect = GUILayoutUtility.GetLastRect();
                    rect.x -= EditorStyles.inspectorFullWidthMargins.padding.left;
                    rect.x -= 15;
                    rect.width = 4;
                    EditorGUI.DrawRect(rect, ScriptableObjectEditorModifier.OverrideMarginColor);
                    GUIHelper.PopIsBoldLabel();
                    return;
                }
            }
        
            CallNextDrawer(label);
        }

        public void PopulateGenericMenu(InspectorProperty property, GenericMenu genericMenu)
        {
            ScriptableObjectEditorModifier.PopulatePropertyContextMenu(genericMenu, property.Tree.GetUnityPropertyForPath(property.UnityPropertyPath));
        }
    }
}
#endif
