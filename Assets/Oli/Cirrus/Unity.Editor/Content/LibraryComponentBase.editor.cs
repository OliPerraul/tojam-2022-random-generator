#if UNITY_EDITOR

using Cirrus.Source;
using Cirrus.Unity.Editor;
using System.IO;
using System.Threading;
using UnityEditor;
using UnityEngine;

// TODO generate #define GEN_OPTION_LIBRARY at the top most of the file to enable default ids if 
// no class has been generated


namespace Cirrus.Unity.Objects.Libraries
{
	// TODO make the libraries and generator into menu item rather than asset
	// This way we can bulk generate etc..

	// TODO generate legacy attributes with some warnign
	// This is after we clear up the remainder of the warnigns
	[CustomEditor(typeof(LibraryComponentBase), true)]
	public class LibraryComponentBaseEditor : UnityEditor.Editor
	{
		LibraryComponentBase _lib;
		private Mutex _mutex;

		//public static string LoadContentStr = "Load Content";

		public void OnEnable()
		{
			_lib = (LibraryComponentBase)target;
			_mutex = new Mutex();
		}

		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();


			if(GUILayout.Button("Generate Code"))
			{
				_mutex.WaitOne();

				_lib.Clear();
				_lib.Load();

				// Write.
				Debug.Log(_lib.GeneratedFile);
				File.WriteAllText(_lib.GeneratedFile, _lib.GenerateCode());
				ProjectUtils.AddDefineSymbols($"{CodeGenUtils.DefinePrefix}{_lib.DefinePrefix}{_lib.GetType().Name.FormatDefine()}");

				EditorUtility.SetDirty(_lib);

				_mutex.ReleaseMutex();
			}
		}
	}
}

#endif