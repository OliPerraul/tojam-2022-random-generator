#if UNITY_EDITOR

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Animations;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.Timeline;
using Object = UnityEngine.Object;

namespace Cirrus.Unity.Editor
{
	public static class AssetDatabaseUtils
	{
		/// <summary>
		/// Convert global path to relative
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static string GlobalPathToRelative(this string path)
		{
			if (path.StartsWith(Application.dataPath))
				return "Assets" + path.Substring(Application.dataPath.Length);
			else
				throw new ArgumentException("Incorrect path. PAth doed not contain Application.datapath");
		}

		/// <summary>
		/// Convert relative path to global
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static string RelativePathToGlobal(this string path)
		{
			path = path.Replace("Assets/", "");
			return Path.Combine(Application.dataPath, path);
		}

		/// <summary>
		/// Convert path from unix style to windows
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static string UnixToWindowsPath(string path)
		{
			return path.Replace("/", "\\");
		}

		/// <summary>
		/// Convert path from windows style to unix
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static string WindowsToUnixPath(string path)
		{
			return path.Replace("\\", "/");
		}

		/// <summary>
		/// Gets the target path for the asset to create.
		/// </summary>
		/// <returns>The asset path.</returns>
		public static string GetAssetPath(Object obj = null)
		{
			obj = obj == null ? Selection.activeObject : obj;
			string path = AssetDatabase.GetAssetPath(obj);

			if (
				obj != null &&
				typeof(DefaultAsset).IsAssignableFrom(obj.GetType())
				)
			{
				return path;
			}
			
			if (path == "")
			{
				path = "Assets";
			}
			else if (Path.GetExtension(path) != "")
			{
				path = path.Replace(Path.GetFileName(path), "");
			}

			return path;
		}

		[MenuEntry("Cirrus.Unity.Timeline/Revert anim track name")]
		class SimpleMenuAction : TimelineAction
		{
			public override ActionValidity Validate(ActionContext actionContext)
			{
				return ActionValidity.Valid;
			}

			public override bool Execute(ActionContext actionContext)
			{
				var obj = Selection.activeObject;
				if(obj is AnimationTrack)
				{
					var track = obj as AnimationTrack;
					var binding = actionContext.director.GetGenericBinding(track);
					if(binding != null)
					{
						track.name = PackageUtils.AnimTrackSuffix + binding.name;
					}

					var path = AssetDatabase.GetAssetPath(Selection.activeObject);
					AssetDatabase.ImportAsset(path);
					AssetDatabase.SaveAssets();
					AssetDatabase.Refresh();

					return true;
				}

				return false;
			}
		}

		[MenuEntry("Cirrus.Unity.Timeline/Revert anim clip name")]
		class SimpleMenuAction2 : TimelineAction
		{
			public override ActionValidity Validate(ActionContext actionContext)
			{
				return ActionValidity.Valid;
			}

			public override bool Execute(ActionContext actionContext)
			{
				var obj = Selection.activeObject;
				if(obj is AnimationTrack)
				{
					var track = obj as AnimationTrack;
					var binding = actionContext.director.GetGenericBinding(track);
					if(binding != null)
					{
						//track.name = PackageUtils.AnimTrackSuffix + binding.name;
						track.GetClips().First();
						foreach(var clip in track.GetClips())
						{
							clip.animationClip.name = track.name;
							clip.animationClip.name = clip.animationClip.name.StartsWith(PackageUtils.AnimTrackSuffix) ?
								clip.animationClip.name.Substring(PackageUtils.AnimTrackSuffix.Length) :
								clip.animationClip.name;
							clip.animationClip.name = clip.animationClip.name.StartsWith(PackageUtils.AnimSuffix) ?
								clip.animationClip.name :
								PackageUtils.AnimSuffix + clip.animationClip.name;
							clip.displayName = clip.animationClip.name;
							break;
						}
					}
					var path = AssetDatabase.GetAssetPath(Selection.activeObject);
					AssetDatabase.ImportAsset(path);
					AssetDatabase.SaveAssets();
					AssetDatabase.Refresh();

					return true;
				}

				return false;
			}
		}

		[MenuItem("Assets/Cirrus.Unity/Timeline/Revert anim clip names", priority = PackageUtils.MenuItemAssetFrameworkPriority)]
		public static void Timeline_RevertAnimClipNames()
		{
			//Popup menu with AnimatorController selected
			var path = AssetDatabase.GetAssetPath(Selection.activeObject);
			//Get everything in SubAsset
			foreach(var item in AssetDatabase.LoadAllAssetsAtPath(path))
			{
				if(item is AnimationTrack)
				{
					AnimationTrack track = (AnimationTrack)item;
					track.GetClips().First();
					foreach(var clip in track.GetClips())
					{
						clip.animationClip.name = track.name;
						clip.animationClip.name = clip.animationClip.name.Substring(PackageUtils.AnimTrackSuffix.Length);
						clip.animationClip.name = PackageUtils.AnimSuffix + clip.animationClip.name;
						clip.displayName = clip.animationClip.name;
						break;
					}
				}
			}

			AssetDatabase.ImportAsset(path);
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
		}


		[MenuItem("Assets/Cirrus.Unity/Animations/Revert anim state names", priority = PackageUtils.MenuItemAssetFrameworkPriority)]
		public static void Anims_RevertAnimStateNames()
		{
			//Popup menu with AnimatorController selected
			var path = AssetDatabase.GetAssetPath(Selection.activeObject);

			//Get everything in SubAsset
			foreach(var item in AssetDatabase.LoadAllAssetsAtPath(path))
			{
				if(item is AnimatorController)
				{
					var animator = item as AnimatorController;
					foreach(var layer in animator.layers)
					{
						foreach(var state in layer.stateMachine.states)
						{
							var motion = state.state.motion;
							if(motion == null) continue;
							state.state.name = motion.name;
							if(state.state.name.StartsWith(PackageUtils.AnimSuffix))
							{
								state.state.name = state.state.name.Substring(PackageUtils.AnimSuffix.Length);
							}
						}
					}

					break;
				}
			}

			AssetDatabase.ImportAsset(path);
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
		}





		[MenuItem("Assets/Cirrus.Unity/Objects/Refresh asset", priority = PackageUtils.MenuItemAssetFrameworkPriority)]
		public static void Refresh()
		{
			//Object.DestroyImmediate(Selection.activeObject, true);
			var path = AssetDatabase.GetAssetPath(Selection.activeObject);
			AssetDatabase.ImportAsset(path);
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
		}



		[MenuItem("Assets/Cirrus.Unity/Objects/Destroy asset", priority = PackageUtils.MenuItemAssetFrameworkPriority)]
		public static void Remove()
		{
			Object.DestroyImmediate(Selection.activeObject, true);
			var path = AssetDatabase.GetAssetPath(Selection.activeObject);
			AssetDatabase.ImportAsset(path);
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
		}


		[MenuItem("Assets/Cirrus.Unity/Objects/Unhide sub asset", priority = PackageUtils.MenuItemAssetFrameworkPriority)]
		public static void SetHideFlags()
		{
			//Popup menu with AnimatorController selected
			var path = AssetDatabase.GetAssetPath(Selection.activeObject);
			//Get everything in SubAsset
			foreach(var item in AssetDatabase.LoadAllAssetsAtPath(path))
			{//Set all the flags to None to release the hidden state
				item.hideFlags = HideFlags.None;
			}
			//Refresh with Import
			AssetDatabase.ImportAsset(path);
		}

		public static T FindObjectOfType<T>() where T : ScriptableObject
		{
			string[] guids = AssetDatabase.FindAssets("t:" + typeof(T).Name);  //FindAssets uses tags check documentation for more info
			string path = AssetDatabase.GUIDToAssetPath(guids[0]);
			return AssetDatabase.LoadAssetAtPath<T>(path);
		}

		public static Object FindObjectOfType(System.Type type)
		{
			string[] guids = AssetDatabase.FindAssets("t:" + type);  //FindAssets uses tags check documentation for more info
			string path = AssetDatabase.GUIDToAssetPath(guids[0]);

			return AssetDatabase.LoadAssetAtPath(path, type);
		}

		public static T[] FindObjectsOfType<T>() where T : Object
		{
			List<string> guids = AssetDatabase.FindAssets("t:" + typeof(T)).ToList();
			var prefabs = AssetDatabase.FindAssets("t:Prefab");
			foreach(var prefab in prefabs)
			{
				if(!guids.Contains(prefab)) guids.AddRange(prefabs);
			}

			List<T> assets = new List<T>();
			foreach(var guid in guids)
			{
				string path = AssetDatabase.GUIDToAssetPath(guid);
				assets.Add(AssetDatabase.LoadAssetAtPath<T>(path));
			}

			return assets.ToArray();
		}

		public static bool GetNearestAssetName(Object asset, string ext, out string result)
		{
			//Get
			result = null;
			string assetPath = AssetDatabase.GetAssetPath(asset).RelativePathToGlobal();
			for (int k = 0; k < 1000; k++)
			{				
				assetPath = assetPath.Replace("/" + Path.GetFileName(assetPath), "");

				string[] assetNames = Directory.GetFiles(assetPath);

				for (int i = 0; i < assetNames.Length; i++)
				{
					if (assetNames[i].EndsWith(ext))
					{
						result = Path.GetFileName(assetNames[i]);
						return true;
					}
				}
			}

			return false;


			//AssetDatabase.Get
		}
	}
}

#endif