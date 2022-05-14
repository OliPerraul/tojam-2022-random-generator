using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Experimental;
using UnityEditor;
using UnityEditor.VersionControl;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    public class AssetProcessor : UnityEditor.AssetModificationProcessor
    {
        private static AssetDeleteResult OnWillDeleteAsset(string assetPath, RemoveAssetOptions options)
        {
            if (ScriptableVariantUtility.IsInheritanceFromPath(assetPath))
            {
                int result = EditorUtility.DisplayDialogComplex("Reparent children assets",
                    $"{assetPath} \nOne ore more files are ScriptableObjects. Would you like to reparent all their children in the project to the closest ancestor?", 
                    "Reparent children ",
                    "Continue", string.Empty);
                Debug.Log($"result: {result}");   
            }
            return AssetDeleteResult.DidNotDelete;
        }
    }
}
