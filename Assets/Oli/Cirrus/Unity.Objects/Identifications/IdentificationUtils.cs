//using Cirrus.Healer.IDs;
//using Cirrus.Objects;
//using Cirrus.Unity.Editor;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using UnityEditor;
//using UnityEngine;
//using UnityEngine.UIElements;
//using Object = UnityEngine.Object;
//using UnityEditor;
//using UnityEditor.SceneManagement;
//using EditorCoroutines = Unity.EditorCoroutines.Editor;
//using System.Collections;
//using System.IO;
//using Cirrus.Collections;
////using Cirrus.Unity.ScriptableObjectVariants;
////using Cirrus.Assets.Cirrus.Unity.Editor;

//namespace Cirrus.Unity.Objects
//{
//	public static class AssetIdentificationUtils
//	{
//		/// <summary>
//		/// Create Project Create Context Menu item
//		/// </summary>
//		[MenuItem("Assets/Cirrus.Unity/Objects/Identify Asset", false, priority = PackageUtils.MenuItemAssetFrameworkPriority)]
//		static void DoIdentifyAsset()
//		{
//			foreach (Object o in Selection.objects)
//			{
//				AddIdentifications(AssetDatabase.GetAssetPath(o));
//			}
//		}

//		public static void AddIdentifications(string path)
//		{
//			GameObject gobj = null;
//			IIdentifiable[] ideds = ArrayUtils.Empty<IIdentifiable>();
//			string dir = "";
//			Type type = AssetDatabase.GetMainAssetTypeAtPath(path);
//			Object asset = null;
//			ScriptableObjectData inheritance = null;

//			if (typeof(IIdentifiable).IsAssignableFrom(type))
//			{
//				asset = AssetDatabase.LoadMainAssetAtPath(path);
//				ideds = new IIdentifiable[] { (IIdentifiable)asset };
//				inheritance = ScriptableVariantUtility.GetData((ScriptableObject)asset);
//			}
//			else if (typeof(GameObject).IsAssignableFrom(type))
//			{
//				asset = AssetDatabase.LoadMainAssetAtPath(path);
//				gobj = (GameObject)asset;
//				ideds = gobj.GetComponentsInChildren<IIdentifiable>();
//			}

//			if (ideds.Length != 0)
//			{
//				dir = $"{Path.GetDirectoryName(path)}/{PackageUtils.GenDirName}";
//			}

//			bool changed = false;
//			for (int i = 0; i < ideds.Length; i++)
//			{
//				var ided = ideds[i];
//				if (ided != null && !ided.IsValid())
//				{
//					ided.Id = ScriptableObject.CreateInstance<IdAsset>();
//					ided.Id.Id = EditorLibrary.Instance.NextAvailableId;
//					ided.Id.name = "Id";
//					ided.Id.Owner = (Object)ided;
					
//					Directory.CreateDirectory(dir);
//					string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath($"{dir}/Id_{ided.Id.Id}.asset");
//					AssetDatabase.CreateAsset(ided.Id, assetPathAndName);

//					EditorUtility.SetDirty(asset);
//					EditorLibrary.Instance.Save(ided.Id);

//					if (inheritance != null)
//					{
//						PropertyInfo property = typeof(IIdentifiable).GetProperty(nameof(IIdentifiable.Id));
//						var bindingFlag = BindingFlags.Instance | BindingFlags.NonPublic ;
//						FieldInfo field = property.GetBackingField(ided.GetType(), bindingFlag);
//						inheritance.OverrideProperty(field.Name);
//					}					
					
//					changed = true;
//				}
//			}

//			if (
//				changed &&
//				gobj != null
//				)
//			{
//				EditorUtility.SetDirty(gobj);
//				AssetDatabase.SaveAssetIfDirty(gobj);
//			}
//		}	

//		public static bool IsValid<T>(this T asset) where T : IIdentifiable
//		{
//			if (asset.Id != null && asset.Id.Owner == (Object)(object)asset) return true;
//			return false;
//		}
//	}
//}

