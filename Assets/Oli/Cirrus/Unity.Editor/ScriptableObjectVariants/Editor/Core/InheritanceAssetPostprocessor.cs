using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    internal class InheritanceAssetPostprocessor : AssetPostprocessor
    {
        private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            foreach (string importedPath in importedAssets)
            {
                // Check if the asset being imported is an Inheritance.
                if (ScriptableVariantUtility.TryGetDataAtPath(importedPath, out ScriptableObjectData data))
                {
                    // Handle the case where a asset is duplicated.
                    DuplicatedInheritance(data);
                }
            }
        }

        private static void DuplicatedInheritance(ScriptableObjectData data)
        {
            // We check if the guid of the asset that the inheritance data thinks it is for, is actually the asset that it is for.
            // This happens when the main asset was duplicated, the "AssetGuid" will have the guid of the original main asset,
            // not the duplicated one that it is the sub-asset of.
            if (data.IsDuplicate)
            {
                // If it is a variant, we keep it, and update all the information for it so it is a valid variant.
                if (data.IsVariant)
                {
                    data.DataObject.GUID = data.GUID.ToString();
                    // Remove all variants it thinks it has because they are actually variants of the original asset.
                    data.DataObject.ClearVariantGUIDs();
                    // Add it to the base as a variant.
                    var baseData = ScriptableVariantUtility.GetDataFromGUID(data.ParentGUID);
                    
                    baseData.DataObject.AddVariantGUID(data.DataObject.GUID);
                    EditorUtility.SetDirty(baseData.DataObject);
                }
                // If it is not a variant the then there is no reason to keep inheritance data,
                // so we get rid of it because all of the variants are of the original not this duplicated one.
                else
                {
                    AssetDatabase.RemoveObjectFromAsset(data.DataObject);
                    Object.DestroyImmediate(data.DataObject, true);
                    AssetDatabase.SaveAssets();
                }
            }
        }
    }
}
