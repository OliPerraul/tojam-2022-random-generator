//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UnityEditor;

//namespace Cirrus.Assetrus.Unity.Editor
//{
//	public static class FileSystemUtils
//	{   /// <summary>
//		/// Gets the target path for the asset to create.
//		/// </summary>
//		/// <returns>The asset path.</returns>
//		public static string GetAssetPath(Object obj = null)
//		{
//			string path = AssetDatabase.GetAssetPath(obj == null ? Selection.activeObject : obj);
//			if (path == "")
//			{
//				path = "Assets";
//			}
//			else if (Path.GetExtension(path) != "")
//			{
//				path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");
//			}

//			return path;
//		}
//	}
//}
