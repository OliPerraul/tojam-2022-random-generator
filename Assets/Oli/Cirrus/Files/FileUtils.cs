using System;
using System.IO;
using UnityEngine;

namespace Cirrus.Files
{
	public static class FileUtils
	{
		public static string GetAssetPath(this string fullPath)
		{
			if(fullPath.StartsWith("Assets")) return fullPath;

			FileInfo fileInfo = new FileInfo(fullPath);
			//FileInfo[] fileInf = dirInfo.GetFiles("*.prefab");
			string replacedPath = fileInfo.FullName.Replace(@"\", "/");
			string assetPath = "Assets" + replacedPath.Replace(Application.dataPath, "");
			return assetPath;
		}

		public static string GetRelativePath(this string relativeTo, string path)
		{
			// Require trailing backslash for path
			if(!relativeTo.EndsWith("\\"))
				relativeTo += "\\";

			Uri baseUri = new Uri(relativeTo);
			Uri fullUri = new Uri(path, UriKind.Absolute);

			Uri relativeUri = baseUri.MakeRelativeUri(fullUri);
			var relativeUriStr = relativeUri.ToString().Replace("/", "\\");

			//if (preserveRoot)
			//{
			//	var root = Path.GetPathRoot(relativeTo);
			//	relativeUriStr = Path.Combine(root, relativeUriStr);
			//}

			// Uri's use forward slashes so convert back to backward slashes
			return relativeUriStr;
		}

		public static string StripExtension(this string path)
		{
			int index = path.LastIndexOf('.');
			return index == -1 ? path : path.Substring(0, index);
		}

		public static string GetDirectoryName(this string path)
		{
			return Path.GetDirectoryName(path);
		}

		public static string GetFileName(this string path)
		{
			return Path.GetFileName(path);
		}
	}
}