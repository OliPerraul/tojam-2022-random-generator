using System.IO;
using UnityEngine;
using UnityEditor;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    internal class EditorAssetsFolderLocator : ScriptableObject
    {
        /// <summary>
        /// Returns the project relative path to the "ScriptableObjectVariants/Editor" folder in the assets folder.
        /// </summary>
        public static string GetFolderPath()
        {
            var locator = CreateInstance<EditorAssetsFolderLocator>();
            var script = MonoScript.FromScriptableObject(locator);

            string path = Path.GetDirectoryName(AssetDatabase.GetAssetPath(script));
            if (Path.DirectorySeparatorChar != '/')
                path = path.Replace(Path.DirectorySeparatorChar, '/');

            DestroyImmediate(locator);
            return path;
        }
    }
}
