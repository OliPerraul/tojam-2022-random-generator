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
////using Cirrus.Assets.Cirrus.Unity.Editor;

//namespace Cirrus.Unity.Objects
//{
//	public interface IIdentifiable
//	{ 
//		public IdAsset Id { get; set; }
//	}

//#if UNITY_EDITOR
//	public class IdentifiedAssetsPostprocessor : AssetPostprocessor
//	{
//		public static void OnPostprocessAllAssets(
//		string[] importedAssets
//		, string[] deletedAssets
//		, string[] movedAssets
//		, string[] movedFromAssetPaths
//		)
//		{
//			for (int i = 0; i < importedAssets.Length; i++)
//			{
//				AssetIdentificationUtils.AddIdentifications(importedAssets[i]);
//			}
//		}
//	}
//#endif
//}
