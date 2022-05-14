#if UNITY_EDITOR

/*
 * Scriptable Object Context Editor 		
 * --------------------------------------------------------------------
 * Allows you to easily add ways to create scriptable objects to the Create pulldown in the project pane.
 *
 * Author
 * Martin Nerurkar of Sharkbomb Studios (http://www.sharkbombs.com)
 * Based on the CreateScriptableObjectAsset work by Brandon Edmark and Lea Hayes
 * 
 * License
 * This script is made available under a CC0 1.0 Universal license.
 * You can copy, modify, distribute and perform the work, even for commercial purposes, all without asking permission. 
 * Find out more here: https://creativecommons.org/publicdomain/zero/1.0/
 */

//using GenericUnityObjects;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Cirrus.Unity.Editor
{


	public class EditorScriptableObjectUtils
	{

		/// <summary>
		/// Creating specific class menu items.
		/// </summary>
		/// <returns>The created ScriptableObject.</returns>
		/// <typeparam name="T">Type of ScriptableObject to create.</typeparam>
		public static T CreateAsset<T>() where T : ScriptableObject
		{			
			T asset = ScriptableObject.CreateInstance<T>();

			string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath($"{AssetDatabaseUtils.GetAssetPath()}/New {typeof(T).Name}.asset");
			AssetDatabase.CreateAsset(asset, assetPathAndName);
			Selection.activeObject = asset;
			return asset;
		}


		/// <summary>
		/// Builds the asset and does neccessary AssetDatabase things.
		/// </summary>
		/// <param name="assetType">Asset type.</param>
		/// <param name="path">Path.</param>
		public static void BuildAsset(ScriptableObject asset, string assetPathAndName)
		{
			AssetDatabase.CreateAsset(asset, assetPathAndName);
			//AssetDatabase.SaveAssets();
			//AssetDatabase.Refresh();
			//EditorUtility.FocusProjectWindow();
			Selection.activeObject = asset;
		}

		/// <summary>
		/// Create Project Create Context Menu item
		/// </summary>
		[MenuItem("Assets/Cirrus.Unity/Objects/Create ScriptableObject", false, priority = PackageUtils.MenuItemAssetFrameworkPriority)]
		static void DoCreateScriptableObject()
		{
			string targetScriptPath;
			List<MonoScript> scripts = new List<MonoScript>();
			foreach(UnityEngine.Object o in Selection.objects)
			{
				if(o.GetType() == typeof(MonoScript))
				{
					var scr = ((MonoScript)o);

					// Check if we are a ScriptableObject
					if(typeof(ScriptableObject).IsAssignableFrom(scr.GetClass()))
					{
						var scriptableObject = ScriptableObject.CreateInstance(scr.GetClass());
						string assetPathAndName = AssetDatabase.GenerateUniqueAssetPath($"{AssetDatabaseUtils.GetAssetPath()}/New {scriptableObject.GetType().Name}.asset");						
						AssetDatabase.CreateAsset(scriptableObject, assetPathAndName);
						Selection.activeObject = scriptableObject;
					}
					else
					{
						Debug.LogWarning("Create ScriptableObject Asset failed: Selected Class does not inherit from ScriptableObject");
					}
				}
			}
		}
	}
}

#endif