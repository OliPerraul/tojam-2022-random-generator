using System.IO;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
#endif
using UnityEngine;

namespace Cirrus.Unity.Editor
{	
#if UNITY_EDITOR

	public class MenuItemUtils
	{
		public const int MenuItemTopPriority = 0;
		public const int MenuItemBottomPriority = 100;

		[MenuItem("Cirrus.Unity/Reload Scene", false, priority = PackageUtils.MenuItemFrameworkPriority)]
		public static void ReloadScene()
		{
			EditorSceneManager.OpenScene(EditorSceneManager.GetActiveScene().path);
		}

		[MenuItem("Cirrus.Unity/Refresh Assets", false, priority = PackageUtils.MenuItemFrameworkPriority)]
		public static void RefreshAssets()
		{
			AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);
		}

		[MenuItem("Cirrus.Unity/Request Script Reload", false, priority = PackageUtils.MenuItemFrameworkPriority)]
		public static void RequestScriptReload()
		{
			EditorUtility.RequestScriptReload();
		}

		// TODO:
		// Wow well holding a reference to all our assets could be a big 
		// problem .. Let's see..
		[MenuItem("Cirrus.Unity/Unload Unused Assets", false, priority = PackageUtils.MenuItemFrameworkPriority)]
		public static void UnloadUnusedAssets()
		{
			EditorUtility.UnloadUnusedAssetsImmediate();
		}


		/// <summary>
		/// Symbols that will be added to the editor
		/// </summary>
		//public static readonly string[] Symbols = new string[] {
		//    "CIRRUS",
		//    "CIRRUS_MYPACKAGE"
		//};

		/// <summary>
		/// Add define symbols as soon as Unity gets done compiling.
		/// </summary>
		//[MenuItem("Cirrus" + "/Cmds/Unload Unused Assets", false)]
		//public static void AddDefineSymbols()
		//{
		//    //string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
		//    //List<string> allDefines = definesString.Split(';').ToList();
		//    //allDefines.AddRange(Symbols.Except(allDefines));
		//    //PlayerSettings.SetScriptingDefineSymbolsForGroup(
		//    //    EditorUserBuildSettings.selectedBuildTargetGroup,
		//    //    string.Join(";", allDefines.ToArray()));
		//}
	}

	public class EditorUtils
	{

		public static readonly string EditorOnlyTag = "EditorOnly";

		[MenuItem("Assets/Create/Cirrus.Unity/ .txt", false, priority = PackageUtils.MenuItemAssetFrameworkLowPriority)]
		static void CreateTxt()
		{
			string path = UnityEditor.AssetDatabase.GetAssetPath(Selection.activeObject);

			string unique = UnityEditor.AssetDatabase.GenerateUniqueAssetPath(path + "/Note.txt");

			// Debug.Log(unique);

			using(StreamWriter writer = new StreamWriter(unique, false))
			{
				writer.WriteLine("Hello world..");
				writer.Flush();
			}

			UnityEditor.AssetDatabase.Refresh();

		}

		[MenuItem("Assets/Create/Cirrus.Unity/ .json", false, priority = PackageUtils.MenuItemAssetFrameworkLowPriority)]
		static void CreateJson()
		{
			string path = UnityEditor.AssetDatabase.GetAssetPath(Selection.activeObject);

			string unique = UnityEditor.AssetDatabase.GenerateUniqueAssetPath(path + "/Document.json");

			// Debug.Log(unique);

			using(StreamWriter writer = new StreamWriter(unique, false))
			{
				writer.WriteLine("{}");
				writer.Flush();
			}

			UnityEditor.AssetDatabase.Refresh();

		}

		[MenuItem("Assets/Create/Cirrus.Unity/ .cs", false, priority = PackageUtils.MenuItemAssetFrameworkLowPriority)]
		static void CreateCs()
		{
			string path = UnityEditor.AssetDatabase.GetAssetPath(Selection.activeObject);

			string unique = UnityEditor.AssetDatabase.GenerateUniqueAssetPath(path + "/MyClass.cs");

			Debug.Log(unique);

			using(StreamWriter writer = new StreamWriter(unique, false))
			{
				writer.WriteLine("");
				//writer.WriteLine("aInt.ToString() to write");
				writer.Flush();
			}

			UnityEditor.AssetDatabase.Refresh();

		}
	}

#endif
}
