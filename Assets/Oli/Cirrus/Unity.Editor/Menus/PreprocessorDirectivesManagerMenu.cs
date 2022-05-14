#if UNITY_EDITOR

using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Cirrus.Unity.Editor
{
	public class PreprocessorDirectivesManagerMenu : EditorWindow
	{
		private class _PreprocessorDirectivesManagerObject : ScriptableObject
		{
			[SerializeField]
			public List<string> _symbols;

		}

		private static Vector2 _windowsMinSize = Vector2.one * 500f;

		private static float _btnHeight = 64f;


		private SerializedProperty _symbolProperty;

		List<string> _symbols = new List<string>();

		_PreprocessorDirectivesManagerObject _internalObject;

		private Vector2 scrollPosition;


		[MenuItem("Cirrus.Unity/Preprocessor Directives", priority=PackageUtils.MenuItemFrameworkPriority)]
		public static void OpenSimulatorWindow()
		{
			GetWindow<PreprocessorDirectivesManagerMenu>(true, "Preprocessor Directives");
		}

		private void OnEnable()
		{
			string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone);
			_internalObject = CreateInstance<_PreprocessorDirectivesManagerObject>();
			_internalObject._symbols = definesString.Split(';').ToList();
			_internalObject._symbols.Sort((x, y) => x.CompareTo(y));
			SerializedObject serializedObject = new SerializedObject(_internalObject);
			_symbolProperty = serializedObject.FindProperty("_symbols");
		}

		private void OnInspectorUpdate()
		{
			Repaint();
		}

		private void OnGUI()
		{
			scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);

			EditorGUILayout.PropertyField(_symbolProperty);
			if(GUILayout.Button("Save"))
			{
				PlayerSettings.SetScriptingDefineSymbolsForGroup(
					BuildTargetGroup.Standalone,
					string.Join(";", _internalObject._symbols.ToArray()));
			}

			EditorGUILayout.EndScrollView();
		}
	}
}

#endif