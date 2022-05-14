#if UNITY_EDITOR

using UnityEditor;

//using UnityEditor;

namespace Cirrus.Unity.UI.ProgressBars
{
	[CustomEditor(typeof(BarViewColor))]
	[CanEditMultipleObjects]
	public class BarViewColorDrawer : UnityEditor.Editor
	{
		SerializedProperty graphic;
		SerializedProperty canOverrideColor;
		SerializedProperty defaultColor;
		SerializedProperty useGradient;
		SerializedProperty barGradient;

		SerializedProperty flashOnGain;
		SerializedProperty gainColor;
		SerializedProperty flashOnLoss;
		SerializedProperty lossColor;
		SerializedProperty flashTime;

		void OnEnable()
		{
			graphic = serializedObject.FindProperty("_graphic");
			canOverrideColor = serializedObject.FindProperty("_canOverrideColor");
			defaultColor = serializedObject.FindProperty("_defaultColor");
			useGradient = serializedObject.FindProperty("_useGradient");
			barGradient = serializedObject.FindProperty("_barGradient");

			flashOnGain = serializedObject.FindProperty("_flashOnGain");
			gainColor = serializedObject.FindProperty("_gainColor");
			flashOnLoss = serializedObject.FindProperty("_flashOnLoss");
			lossColor = serializedObject.FindProperty("_lossColor");
			flashTime = serializedObject.FindProperty("_flashTime");
		}

		public override void OnInspectorGUI()
		{
			serializedObject.Update();
			EditorGUILayout.PropertyField(graphic);

			EditorGUILayout.PropertyField(canOverrideColor);
			EditorGUILayout.PropertyField(defaultColor);
			EditorGUILayout.PropertyField(useGradient);

			if(useGradient.boolValue)
				EditorGUILayout.PropertyField(barGradient);

			EditorGUILayout.PropertyField(flashOnGain);

			if(flashOnGain.boolValue)
				EditorGUILayout.PropertyField(gainColor);

			EditorGUILayout.PropertyField(flashOnLoss);

			if(flashOnLoss.boolValue)
				EditorGUILayout.PropertyField(lossColor);

			if(flashOnGain.boolValue || flashOnLoss.boolValue)
				EditorGUILayout.PropertyField(flashTime);

			serializedObject.ApplyModifiedProperties();
		}
	}
}

#endif