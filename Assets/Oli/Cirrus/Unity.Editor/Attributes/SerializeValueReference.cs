using Cirrus.Unity.Numerics;
using System;
using UnityEditor;
using UnityEngine;

namespace Cirrus.Unity.Editor
{
#if UNITY_EDITOR

	//Original version of the ConditionalHideAttribute created by Brecht Lecluyse (www.brechtos.com)
	//Modified by: Sebastian Lague


	[CustomPropertyDrawer(typeof(Operation))]
	public class ValueAttributePropertyDrawer : PropertyDrawer
	{
		public void Default(Rect position, SerializedProperty property, GUIContent label)
		{
			RefEditorGUI.DefaultPropertyField(position, property, label);
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			SerializedPropertyType type = property.propertyType;
			SerializedProperty valueProperty = property.FindPropertyRelative("_expression");
			Default(position, valueProperty == null ? property : valueProperty, label);
		}
	}
#endif
}
