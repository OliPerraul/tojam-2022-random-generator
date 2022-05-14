using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    internal static class EditorUtilities
    {
        private static string _editorPath;
        
        public static string EditorPath
        {
            get
            {
                if (string.IsNullOrEmpty(_editorPath))
                    _editorPath = EditorAssetsFolderLocator.GetFolderPath();
                return _editorPath;
            }
        }
        
        private static string ThemeName
        {
            get { return EditorGUIUtility.isProSkin ? "Dark" : "Light"; }
        }
        
        public static StyleSheet LoadStyleSheet(string name)
        {
            return (StyleSheet)AssetDatabase.LoadMainAssetAtPath($"{EditorPath}/UI/{name}{ThemeName}.uss");
        }
        
        public static VisualTreeAsset LoadVisualTree(string name)
        {
            return (VisualTreeAsset)AssetDatabase.LoadMainAssetAtPath($"{EditorPath}/UI/{name}.uxml");
        }
    }
}
