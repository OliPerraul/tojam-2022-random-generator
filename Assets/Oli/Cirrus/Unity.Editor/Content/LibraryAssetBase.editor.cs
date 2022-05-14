#if UNITY_EDITOR

using Cirrus.Collections;
using Cirrus.Source;
using Cirrus.Unity.Editor;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Cirrus.Unity.Objects.Libraries
{
	[CustomEditor(typeof(LibraryAssetBase), true)]
	public class AssetLibraryEditor : UnityEditor.Editor
	{
		LibraryAssetBase _lib;

		public static string LoadContentStr = "Load Content";

		private Mutex _mutex;

		public void OnEnable()
		{
			_lib = (LibraryAssetBase)target;
			_mutex = new Mutex();
		}

		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			if(GUILayout.Button(LoadContentStr))
			{
				_lib.Clear();				
				_lib._assets.Clear();

				string[] exts = _lib._suffixes
					.Split(';')
					.Where(s => s.FastCount() > 0).ToArray();
				string[] pfxs = _lib._prefixes
					.Split(';')
					.Where(s => s.FastCount() > 0).ToArray();
				
				var libraryPath = Path.GetDirectoryName(AssetDatabase.GetAssetPath(_lib));
				System.Collections.Generic.List<string> dirs = new System.Collections.Generic.List<string>();
				dirs.Add(libraryPath);
				dirs.AddRange(Directory.GetDirectories(libraryPath, "*.*", SearchOption.AllDirectories));

				foreach(var dir in dirs)
				{
					if(dir == null || dir == "") continue;
					IEnumerable<string> contentFiles = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
					//.Where(s => s.EndsWith(".json"));
					foreach(var file in contentFiles)
					{
						Object asset = null;
						if((asset = AssetDatabase.LoadAssetAtPath<Object>(file)) != null)
						{
							//if (exts.Any(ext => file.EndsWith(ext)))
							//{
							//	if (!_lib._assets.Contains(asset))
							//		_lib._assets.Add(asset);
							//}

							string filename = Path.GetFileName(file);

							if(
								(exts.Length == 0 || exts.Any(ext => filename.EndsWith(ext))) &&
								(pfxs.Length == 0 || pfxs.Any(pfx => filename.StartsWith(pfx)))
								)
							{
								if(!_lib._assets.Contains(asset))
									_lib._assets.Add(asset);
							}
						}
					}
				}



#if UNITY_EDITOR
				// Apply filters
				// TODO clean this up
				_lib.Clear();
				_lib.Load();
				_lib._assets.Clear();
				_lib._assets.AddRange(_lib.__EditorObjects.Values.Select(x => (Object)x.Object));
#endif

				_lib._assets.Sort((x, y) => x.name.CompareTo(y.name));
				EditorUtility.SetDirty(_lib);
			}

			if(GUILayout.Button("Generate Code"))
			{
				_mutex.WaitOne();
				
				_lib.Clear();
				_lib.Load();

				// Write.
				File.WriteAllText(
					Path.GetDirectoryName(AssetDatabase.GetAssetPath(_lib)) + $"/{_lib.GetType().Name.FormatGeneratedFileName()}",
					_lib.GenerateCode());
				ProjectUtils.AddDefineSymbols($"{CodeGenUtils.DefinePrefix}{_lib.DefinePrefix}{_lib.GetType().Name.FormatDefine()}");

				EditorUtility.SetDirty(_lib);

				_mutex.ReleaseMutex();
			}
		}
	}
}


#endif