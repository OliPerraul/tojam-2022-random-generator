using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirrus.Unity.Editor
{
	using Cirrus.Unity.Objects;
	using UnityEditor;
    using UnityEditor.UIElements;
	using UnityEngine;
	using UnityEngine.UIElements;

	public static class PropertyUtils
	{
		public static SerializedProperty GetParentProperty(this SerializedProperty property)
		{
			var path = property.propertyPath;
			var lastDot = path.LastIndexOf('.');
			if (lastDot == -1)
				return null;
			var parentPath = path.Substring(0, lastDot);
			return property.serializedObject.FindProperty(parentPath);
		}
	}

    // IngredientDrawerUIE
    [CustomPropertyDrawer(typeof(ActionAssetBase), true)]
    public class CallbackAssetPropertyDrawer : PropertyDrawer
    {
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			//base.OnGUI(position, property, label);			
			var objectReferenceValue = property.objectReferenceValue;
			if (objectReferenceValue == null)
			{
				RefEditorGUI.DefaultPropertyField(position, property, label);
			}
			else
			{
				MonoScript scr = MonoScript.FromScriptableObject((ScriptableObject)objectReferenceValue);
				if (scr == null)
				{
					RefEditorGUI.DefaultPropertyField(position, property, label);
				}
				else
				{
					EditorGUI.BeginProperty(position, label, property);
					Rect labelPos = EditorGUI.PrefixLabel(position, label);					
					Object o = EditorGUI.ObjectField(labelPos, scr, typeof(MonoScript), false);
					EditorGUI.EndProperty();
				}
			}
			//EditorGUI.
			//EditorGUI.BeginProperty(position, new GUIContent(((CollectionRenameAttribute)attribute).NewName), property.GetParent());
			//EditorGUI.PropertyField(position, property.GetParent(), new GUIContent("Hello"), true);
			//EditorGUI.PropertyField(position, property.GetParent(), new GUIContent(((CollectionRenameAttribute)attribute).NewName));
			//EditorGUI.PropertyField(position, property, new GUIContent(label.text));
		}
		//public override VisualElement CreatePropertyGUI(SerializedProperty property)
		//{


		//    //return container;
		//}
	}
}
