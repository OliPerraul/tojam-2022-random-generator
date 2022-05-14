using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using Object = UnityEngine.Object;

namespace Cirrus.Unity.Editor
{
	public static class AssetUtils
	{
		public static Object[] GetSubAssets(string path)
		{
			return AssetDatabase.LoadAllAssetsAtPath(path);
		}
		/// <summary>
		/// Gets the target path for the asset to create.
		/// </summary>
		/// <returns>The asset path.</returns>
		public static string GetAssetPath(Object obj = null)
		{
			string path = AssetDatabase.GetAssetPath(obj == null ? Selection.activeObject : obj);
			if (path == "")
			{
				path = "Assets";
			}
			else if (Path.GetExtension(path) != "")
			{
				path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");
			}

			return path;
		}

	}
}
