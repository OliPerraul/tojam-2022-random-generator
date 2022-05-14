using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    internal static class SerializedPropertyExtensions
    {
        //public static bool IsInheritanceOverridden(this SerializedProperty property)
        //{
        //    if (ScriptableVariantUtility.tryget(property.serializedObject.targetObject, out InheritanceDataBase data))
        //    {
        //        return data.HasOverriddenProperty(property.propertyPath);
        //    }

        //    return false;
        //}

        internal static IEnumerable<SerializedProperty> Iterate(this SerializedObject serializedObject)
        {
            SerializedProperty property = serializedObject.GetIterator();
            // Required to start. Skip all of the hidden internal fields like "m_PrefabAsset".
            property.NextVisible(true);

            // We first skip the object fields like "m_script" to go to the fields defined on the class.
            if (property.NextVisible(true))
            {
                do
                {
                    // We skip some properties as they are not needed since the 'main' property can handle applying/reverting them.
                    string propertyPath = property.propertyPath;
                    if (!propertyPath.EndsWith("Array") && !propertyPath.EndsWith("Array.size") && !propertyPath.EndsWith("m_FileID"))
                    {
                        yield return property;   
                    }
                    
                } while (property.Next(true));
            }
        }
    }
}
