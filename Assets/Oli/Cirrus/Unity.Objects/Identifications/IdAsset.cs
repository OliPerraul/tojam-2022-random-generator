using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;
using Cirrus.Collections;
using Cirrus.Healer.IDs;
using Cirrus.Unity.Editor;
using UnityEditor;
////using Cirrus.Events;
//using Event = Cirrus.Event;

namespace Cirrus.Unity.Objects
{
	public class IdAsset : ScriptableObjectBase, Healer.IDs.IIded
	{
		[field: SerializeField]
		[field: ReadOnly]
		public uint Id { get; set; }

#if UNITY_EDITOR
		[field: SerializeField]
		[field: ReadOnly]
		public Object Owner { get; set; } = null;
#endif

		public static implicit operator uint(IdAsset id)
		{
			return id.Id;
		}
	}

#if UNITY_EDITOR
	// IngredientDrawerUIE
	[CustomPropertyDrawer(typeof(IdAsset))]
	public class IdAssetPropertyDrawer : PropertyDrawer
	{
		public static GUIContent _label = new GUIContent("Id");
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			if (property.objectReferenceValue == null)
			{
				EditorGUI.PropertyField(position, property, label);
				return;
			}

			EditorGUI.BeginDisabledGroup(true);
			IdAsset asset = (IdAsset)property.objectReferenceValue;
			position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), _label);			
			EditorGUI.IntField(position, (int)asset.Id);
			EditorGUI.EndDisabledGroup();
		}
	}

#endif

}
