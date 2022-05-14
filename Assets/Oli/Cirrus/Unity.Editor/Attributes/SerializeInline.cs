using Cirrus.Unity.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Cirrus.Unity.Editor
{
	/// <summary>\author http://wiki.unity3d.com/index.php/EnumFlagPropertyDrawer</summary>
	public class SerializeInline : PropertyAttribute
	{
	}

	/// <summary>
	/// Extends how ScriptableObject object references are displayed in the inspector
	/// Shows you all values under the object reference
	/// Also provides a button to create a new ScriptableObject if property is null.
	/// </summary>
	[CustomPropertyDrawer(typeof(SerializeInline), true)]
	public class SerializeInlineDrawer : PropertyDrawer
	{
		public void Default(Rect position, SerializedProperty property, GUIContent label)
		{
			RefEditorGUI.DefaultPropertyField(position, property, label);
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			var temp = property.Copy();		
			temp.NextVisible(true);
			
			Default(position, temp, label);
		}
	}
}
