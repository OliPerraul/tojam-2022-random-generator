using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Cirrus.Unity.Editor
{
    //public class EditPrefabAssetScope : IDisposable
    //{

    //    public readonly string assetPath;
    //    public readonly GameObject prefabRoot;

    //    public EditPrefabAssetScope(string assetPath)
    //    {
    //        this.assetPath = assetPath;
    //        prefabRoot = PrefabUtility.LoadPrefabContents(assetPath);
    //    }

    //    public void Dispose()
    //    {
    //        PrefabUtility.SaveAsPrefabAsset(prefabRoot, assetPath);
    //        PrefabUtility.UnloadPrefabContents(prefabRoot);
    //    }
    //}
    public static class PrefabUtils
	{
		///// <summary>
		///// Create Project Create Context Menu item
		///// </summary>
		//[MenuItem("Assets/Cirrus.Unity.Objects/Prefab Variant", false, priority = PackageUtils.MenuItemAssetPackagePriority)]
		//public static void CreatePrefabVariant()
		//{
		//}

		///// <summary>
		///// Create Project Create Context Menu item
		///// </summary>
		//[MenuItem("Assets/Cirrus.Unity.Objects/Prefab", false, priority = PackageUtils.MenuItemAssetPackagePriority)]
		//public static void CreatePrefab()
		//{
		//}

        //[MenuItem("Assets/Create/Prefab", false, 202)]
        //static void CreatePrefab()
        //{
        //    StartNameEditingIfProjectWindowExists(
        //        0,
        //        ScriptableObject.CreateInstance<DoCreatePrefab>(),
        //        "New Prefab.prefab",
        //        EditorGUIUtility.FindTexture("Prefab Icon"),
        //        null);
        //}

        //[MenuItem("Assets/Create/Prefab Variant", true)]
        //static bool CreatePrefabVariantValidation()
        //{
        //    var gameObjects = Selection.gameObjects;
        //    if (gameObjects == null || gameObjects.Length == 0)
        //        return false;

        //    foreach (var go in gameObjects)
        //    {
        //        if (go == null || !EditorUtility.IsPersistent(go))
        //            return false;
        //    }
        //    return true;
        //}

        //[MenuItem("Assets/Create/Prefab Variant", false, 203)]
        //static void CreatePrefabVariant()
        //{
        //    var gameObjects = Selection.gameObjects;
        //    if (gameObjects == null || gameObjects.Length == 0)
        //        return;

        //    if (gameObjects.Length == 1)
        //    {
        //        var go = gameObjects[0];
        //        if (go == null || !EditorUtility.IsPersistent(go))
        //            return;

        //        string sourcePath = AssetDatabase.GetAssetPath(go);
        //        string sourceDir = Path.GetDirectoryName(sourcePath).ConvertSeparatorsToUnity();
        //        string variantPath = GetPrefabVariantPath(sourceDir, go.name);

        //        StartNameEditingIfProjectWindowExists(
        //            0,
        //            ScriptableObject.CreateInstance<DoCreatePrefabVariant>(),
        //            variantPath,
        //            EditorGUIUtility.FindTexture("PrefabVariant Icon"),
        //            sourcePath);
        //    }
        //    else if (gameObjects.Length > 1)
        //    {
        //        CreatePrefabVariants(gameObjects);
        //    }
        //}

    }
}
