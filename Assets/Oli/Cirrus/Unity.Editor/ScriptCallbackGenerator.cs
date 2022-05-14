#if UNITY_EDITOR

using Cirrus.Unity.Numerics;
using Cirrus.Unity.Objects;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Reflection;
using System.IO;
using System;
using Object = UnityEngine.Object;
using Cirrus.Source;
using Unity.EditorCoroutines.Editor;
using EditorCoroutines = Unity.EditorCoroutines;
using Cirrus.Files;
using Cirrus.Healer.IDs;

using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Unity.Editor
{
	[InitializeOnLoad]
	public static class ScriptCallbackGenerator
	{
		private sealed class Destructor
		{
			~Destructor()
			{
				EditorApplication.contextualPropertyMenu -= OnPropertyContextMenu;
			}
		}

		private static readonly Destructor _dtor = new Destructor();

		private static readonly string _key = $"{nameof(ScriptCallbackGenerator)}";

		[Serializable]
		private class _DelegateScriptInfo
		{
			public string filePath;
			public string name;
			public string baseName;
			public string ret;
			public string parameters;
			public string ns;
			public string genericParams;
			public string genericArg;
			public string propertyName;
			public string propertyPath;
			//public string _
			//public Type propertyType;
			//public FieldInfo fieldInfo;
			//public SerializedProperty property;
			public string assetPath;
			public string assetNs;
			public string assetName;
			public string assetAsmdef;
		}

		static ScriptCallbackGenerator()
		{
			EditorApplication.contextualPropertyMenu += OnPropertyContextMenu;
			AssemblyReloadEvents.afterAssemblyReload += _OnAssemblyReload;
		}

		public static void OnPropertyContextMenu(GenericMenu menu, SerializedProperty property)
		{
			if (property == null) return;
			if (property.serializedObject == null) return;
			Object asset = property.serializedObject.targetObject;
			if (asset == null) return;
						
			FieldInfo fi = InspectorUtils.GetFieldViaPath(asset.GetType(), property.propertyPath);
			if (fi == null) return;

			//and only when called on a Transform component
			//object obj = EditorHelper.GetTargetObjectOfProperty(property);
			if (!typeof(DelegateAssetBase).IsAssignableFrom(fi.FieldType))
				return;

			var scriptInfo = new _DelegateScriptInfo();
			scriptInfo.propertyPath = property.propertyPath;
			scriptInfo.assetNs = asset.GetType().Namespace;
			scriptInfo.assetName = asset.GetType().Name;
			scriptInfo.assetAsmdef = asset.GetType().Assembly.GetName().Name;

			var propertyCopy = property.Copy();
			menu.AddItem(new GUIContent("Add Callback"), false, 
			() => _CreateDelegateAsset(menu, scriptInfo, fi, asset));

			menu.AddItem(new GUIContent("Edit Callback"), false,
			() => _EditDelegateScript(menu, scriptInfo, fi, asset));
		}


		//public static void BuildAsset(ScriptableObject asset, string assetPathAndName)
		//{
		//	AssetDatabase.CreateAsset(asset, assetPathAndName);
		//	AssetDatabase.SaveAssets();
		//	AssetDatabase.Refresh();
		//	//EditorUtility.FocusProjectWindow();
		//	//Selection.activeObject = asset;
		//}

		//EditorCoroutines.Editor.
		//private static EditorWaitForSeconds _waitForSeconds = new EditorWaitForSeconds(0.001f);

		//private static _DelegateScriptInfo _scriptInfo = null;

		private static void _EditDelegateScript(
			GenericMenu menu
			, _DelegateScriptInfo scriptInfo
			, FieldInfo fi
			, Object asset)
		{
		}

		private static void _CreateDelegateAsset(
			GenericMenu menu
			, _DelegateScriptInfo scriptInfo
			, FieldInfo fi
			, Object asset)
		{

			Type propertyType = fi.FieldType;
			//Object asset;			

			if (!AssertSucceeded(AssetDatabaseUtils.GetNearestAssetName(asset, "asmdef", out string asmdef))) return;
			scriptInfo.ns = asmdef.StripExtension();
			scriptInfo.filePath = $"{Path.GetDirectoryName(AssetDatabase.GetAssetPath(asset))}/{PackageUtils.GenDirName}";
			Directory.CreateDirectory(scriptInfo.filePath);
			//scriptInfo.name = "_Callback"+ GuidUtils.GuidString().FormatIdentifierName();
			//scriptInfo.name = $"{asset.name.StripPrefix()}_{fi.Name.FromCamelToPascalCase()}";
			scriptInfo.baseName = "";
			scriptInfo.ret = "";
			scriptInfo.parameters = "";
			scriptInfo.propertyName = fi.Name;

			scriptInfo.genericParams = "";
			scriptInfo.genericArg = "";

			propertyType = fi.FieldType;
			//scriptInfo.property = serializedProperty;
			//asset = asset;

			if (typeof(ActionAssetBase).IsAssignableFrom(propertyType))
			{
				//scriptInfo.propertyType.BaseType
				//count = ReflectionUtils.CountOfType(scriptInfo.propertyType.BaseType);
				//Assembly.				
				uint actionNum = EditorLibrary.Instance.NextAvailableAction;
				scriptInfo.name = $"Action{actionNum}";
				scriptInfo.filePath += $"/{scriptInfo.name}.cs";
				scriptInfo.baseName = "ActionAsset";
				scriptInfo.ret = "void";
				scriptInfo.assetPath = AssetDatabase.GetAssetPath(asset);
				//scriptInfo.ns = AssetDatabase.Fold
				//_scriptInfo.

				string genericArg = "";
				if (propertyType.IsGenericType)
				{
					var args = propertyType.GetGenericArguments();
					for (int i = 0; i < args.Length; i++)
					{
						if(!CodeGenUtils.GetAliasName(args[i], out genericArg)) genericArg = args[i].Name;
						scriptInfo.genericParams += genericArg;
						scriptInfo.parameters += genericArg;
						scriptInfo.parameters += " ";
						scriptInfo.parameters += $"arg{i}";
						if (i != args.Length - 1)
						{
							scriptInfo.parameters += ",";
							scriptInfo.genericParams += ",";
						}
					}
					//Type itemType = type.GetGenericArguments()[0]; // use this...
				}
			}
			else if (typeof(FuncAssetBase).IsAssignableFrom(propertyType))
			{
				scriptInfo.name = "MyFunc";
				scriptInfo.filePath += $"/{scriptInfo.name}.cs";
				//code = InspectorUtils.DelegateTemplate_GeneratedClass();
			}

			string code = $@"
using Cirrus.Objects;
using Cirrus.Unity.Objects;
using UnityEngine;
using static Cirrus.Debugging.DebugUtils;
using Cirrus.Content;

namespace {scriptInfo.ns}
{{	
	public class {scriptInfo.name} : {scriptInfo.baseName}<{scriptInfo.genericParams}>
	{{
		public override {scriptInfo.ret} Invoke({scriptInfo.parameters})
		{{
			// Write code here			
		}}
	}}
}}
";
			// Write.
			File.WriteAllText(scriptInfo.filePath, code);
			string json = JsonUtility.ToJson(scriptInfo);
			EditorPrefs.SetString(_key, json);
			AssetDatabase.Refresh();
			//AssemblyRel			
			//AssemblyReloadEvents.afterAssemblyReload += _OnAssemblyReload;
			//EditorCoroutineUtility.StartCoroutineOwnerless(_CompileCoroutine(_scriptInfo));
			//EditorCoroutineUtility.
			//asset.Start
		}

		//[Editor.Call]

		static IEnumerator _RefreshDatabaseCoroutine(_DelegateScriptInfo scriptInfo, Object newAsset)
		{
			yield return null;
			while (
				EditorApplication.isUpdating
				//|| EditorApplication.isCompiling
				//|| EditorApplication.
				)
			{
				yield return null;
			}

			Object asset = AssetDatabase.LoadAssetAtPath<Object>(scriptInfo.assetPath);
			if (asset is GameObject gobj)
			{
				Type assetType = Type.GetType($"{scriptInfo.assetNs}.{scriptInfo.assetName}, {scriptInfo.assetAsmdef}");
				asset = gobj.GetComponent(assetType);
			}
			//scriptInfo.prop
			//asset
			// TODO: handle props
			Type type = asset.GetType();
			//FieldInfo fi = type.GetFieldViaPath(scriptInfo.propertyName);
			FieldInfo fi = InspectorUtils.GetFieldViaPath(asset.GetType(), scriptInfo.propertyPath);
			fi.SetValue(asset, newAsset);
			EditorUtility.SetDirty(asset);
			EditorGUIUtility.PingObject(asset);

			((DelegateAssetBase)newAsset).Owner = asset;
			EditorUtility.SetDirty(newAsset);
			AssetDatabase.SaveAssetIfDirty(newAsset);
			EditorLibrary.Instance.Save((DelegateAssetBase)newAsset);
			//MonoScript script = AssetDatabase.LoadAssetAtPath<MonoScript>(info.filePath);

		}
		private static void _OnAssemblyReload()
		{
			if (EditorPrefs.HasKey(_key))
			{
				string json = EditorPrefs.GetString(_key);
				EditorPrefs.DeleteKey(_key);
				_DelegateScriptInfo scriptInfo = JsonUtility.FromJson<_DelegateScriptInfo>(json);

				//AssemblyReloadEvents.afterAssemblyReload -= _OnAssemblyReload;
				Type newType = Type.GetType($"{scriptInfo.ns}.{scriptInfo.name}, {scriptInfo.ns}" );
				ScriptableObject newAsset = ScriptableObject.CreateInstance(newType);				
				string newAssetPathAndName = AssetDatabase.GenerateUniqueAssetPath(scriptInfo.filePath.StripExtension() + ".asset");
				//BuildAsset(callbackAsset, assetPathAndName);
				AssetDatabase.CreateAsset(newAsset, newAssetPathAndName);
				AssetDatabase.SaveAssets();
				AssetDatabase.Refresh();

				EditorCoroutineUtility.StartCoroutineOwnerless(_RefreshDatabaseCoroutine(scriptInfo, newAsset));
			}
		}
	}
}

#endif