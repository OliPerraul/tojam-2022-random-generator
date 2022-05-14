#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;
namespace Cirrus.Unity.UI.ProgressBars
{

	[CustomEditor(typeof(ProgressBar))]
	[CanEditMultipleObjects]
	public class ProgressBarProDrawer : UnityEditor.Editor
	{
		SerializedProperty value;
		SerializedProperty views;
		SerializedProperty animateBar;
		SerializedProperty animationType;
		SerializedProperty animTime;
		SerializedProperty minAnimDelta;

		void OnEnable()
		{
			value = serializedObject.FindProperty("_valuePercentage");
			views = serializedObject.FindProperty("_views");
			animateBar = serializedObject.FindProperty("_animateBar");
			animationType = serializedObject.FindProperty("_animationType");
			animTime = serializedObject.FindProperty("_animTime");
			minAnimDelta = serializedObject.FindProperty("_minAnimDelta");
		}

		public override void OnInspectorGUI()
		{
			serializedObject.Update();

			EditorGUILayout.Space();
			EditorGUILayout.PropertyField(value);
			EditorGUILayout.Space();

			// Only show the damage progress bar if all the objects have the same damage value:
			if(value.hasMultipleDifferentValues)
				DrawProgressBar(0f, "Multiple Values");
			else
				DrawProgressBar(value.floatValue, "Value");

			EditorGUILayout.PropertyField(animateBar);

			if(animateBar.boolValue)
			{
				EditorGUILayout.PropertyField(animationType);
				EditorGUILayout.PropertyField(
					animTime, new GUIContent(
						animationType.enumValueIndex == (int)ProgressBar.AnimationType.FixedTimeForChange ?
					"Animation Duration" :
					"Animation Speed"));


				EditorGUILayout.PropertyField(minAnimDelta);
			}

			EditorGUILayout.PropertyField(views, true);

			EditorGUILayout.BeginHorizontal();
			{
				EditorGUILayout.PrefixLabel(new GUIContent(" "));

				if(GUILayout.Button("Detect View Components in Children"))
					TriggerDetection();
			}
			EditorGUILayout.EndHorizontal();

			serializedObject.ApplyModifiedProperties();
		}

		void DrawProgressBar(float value, string label)
		{
			Rect rect = GUILayoutUtility.GetRect(18, 18, "TextField");
			EditorGUI.ProgressBar(rect, value, label);
		}

		void TriggerDetection()
		{
			if(targets != null && targets.Length > 0)
			{
				for(int i = 0; i < targets.Length; i++)
					TriggerDetection(targets[i] as ProgressBar);
			}
			else
			{
				TriggerDetection(target as ProgressBar);
			}
		}

		void TriggerDetection(ProgressBar progressBarPro)
		{
			if(progressBarPro == null)
				return;

			Undo.RecordObject(progressBarPro, "Detected View Components in Children");
			progressBarPro.DetectViewObjects();
			EditorUtility.SetDirty(progressBarPro);
		}


	}
}

#endif