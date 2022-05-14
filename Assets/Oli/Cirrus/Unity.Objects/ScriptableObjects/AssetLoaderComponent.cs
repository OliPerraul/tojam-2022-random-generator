using Cirrus.Collections;
using Cirrus.Unity.Objects;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Cirrus.Unity.Objects.Libraries
{
	public class AssetLoaderComponent : SingletonComponentBase<AssetLoaderComponent>
	{
		[SerializeField]
		public string _suffixes;

		[SerializeField]
		public string _prefixes = "Library_";

		private Mutex _mutex = new Mutex();

		[SerializeField]
		public System.Collections.Generic.List<Object> _assets;

		public void Add(Object obj)
		{
			_mutex.WaitOne();
			_assets.Add(obj);
			_mutex.ReleaseMutex();
		}

		public override void Awake()
		{
			base.Awake();

			//#if UNITY_EDITOR
			//			foreach(var asset in _assets)
			//			{
			//				// https://www.reddit.com/r/Unity3D/comments/2d03al/variable_does_not_reset_when_i_exit_my_game_and/
			//				EditorUtility.SetDirty(asset);
			//			}
			//#endif
		}
	}

#if UNITY_EDITOR

	[CustomEditor(typeof(AssetLoaderComponent), true)]
	public class AssetLoaderComponentEditor : UnityEditor.Editor
	{
		private AssetLoaderComponent _lib;

		public static string LoadContentStr = "Load Content";

		public void OnEnable()
		{
			_lib = (AssetLoaderComponent)target;
		}

		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			if(GUILayout.Button(LoadContentStr))
			{
				if(_lib == null)
					_lib = (AssetLoaderComponent)target;

				string[] exts = _lib._suffixes
					.Split(';')
					.Where(s => s.FastCount() > 0).ToArray();
				string[] pfxs = _lib._prefixes
					.Split(';')
					.Where(s => s.FastCount() > 0).ToArray();

				_lib._assets.Clear();
				var libraryPath = Application.dataPath;
				System.Collections.Generic.List<string> dirs = new System.Collections.Generic.List<string>();
				dirs.Add(libraryPath);
				dirs.AddRange(Directory.GetDirectories(libraryPath, "*.*", SearchOption.AllDirectories));
				System.Collections.Generic.List<string> toLoad = new System.Collections.Generic.List<string>();

				foreach(var dir in dirs)
				{
					if(dir == null || dir == "") continue;
					IEnumerable<string> contentFiles = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
					//.Where(s => s.EndsWith(".json"));
					Parallel.ForEach(contentFiles, fullname =>
					//foreach(var fullname in contentFiles)
					{
						string filename = Path.GetFileName(fullname);

						if(
							exts.Any(ext => filename.EndsWith(ext)) ||
							pfxs.Any(pfx => filename.StartsWith(pfx))
							)
						{
							toLoad.Add(fullname);
						}
					});

					foreach(var file in toLoad)
					{
						Object asset = null;
						if((asset = AssetDatabase.LoadAssetAtPath<Object>(FileUtil.GetProjectRelativePath(file))) != null)
						{
							if(!_lib._assets.Contains(asset))
								_lib.Add(asset);
						}
					}
				}

				_lib._assets.Sort((x, y) => x.name.CompareTo(y.name));

				EditorUtility.SetDirty(_lib);
			}
		}
	}

#endif
}