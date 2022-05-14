using Cirrus.Content;
using Cirrus.Unity.Objects;
using System;
using System.Collections.Generic;

// TODO generate #define GEN_OPTION_LIBRARY at the top most of the file to enable default ids if 
// no class has been generated


namespace Cirrus.Unity.Objects.Libraries
{
	// TODO make the libraries and generator into menu item rather than asset
	// This way we can bulk generate etc..

	// TODO generate legacy attributes with some warnign
	// This is after we clear up the remainder of the warnigns
	public abstract partial class LibraryComponentBase : CustomMonoBehaviourBase, ILibrary
	{
		public override void Awake()
		{
			base.Awake();

			Load();
		}

		public virtual void Clear()
		{
#if UNITY_EDITOR
			__EditorObjects.Clear();
			__EditorObjects = new Dictionary<string, __LibraryLoadObject>();
#endif
			//if(_objects != null) _objects.Clear();
		}

		public virtual void Load()
		{
			_CustomLoad();
			_Load();
		}

		protected virtual void _CustomLoad() { }

		protected virtual void _Load() { }

		public ResourceType Get<ResourceType>(int key)
			where ResourceType : class
		{
			return this.Get(key, out ResourceType res) ? res : null;
		}

		public virtual bool _Get<ResourceType>(int key, out ResourceType res)
			where ResourceType : class
		{
			res = null;
			return false;
		}

		//public void LazilyLoad<ResourceType>(
		//	string identifier,
		//	Func<PlaceholderBase, ResourceType> load
		//	)
		//	where ResourceType : class
		//{
		//	this.Add(
		//		identifier,
		//		new Placeholder<ResourceType>(identifier, load));
		//}

		//public void LazilyLoad<ResourceType>(
		//	params object[] entries
		//	)
		//	where ResourceType : class
		//{
		//	for (int i = 0; i < entries.Length; i += 2)
		//	{
		//		this.Add(
		//			(string)entries[i],
		//			new Placeholder<ResourceType>(
		//				(string)entries[i],
		//				(Func<PlaceholderBase, ResourceType>)entries[i + 1]));
		//	}
		//}

		//public void LazilyLoadAssets<AssetType, ResourceType>(
		//	Func<AssetType, string> identifyFunc,
		//	Func<AssetType, ResourceType> loadFunc
		//	)
		//	where ResourceType : class, INameHash
		//	where AssetType : class, INamed
		//{
		//	foreach (var file in _resources)
		//	{
		//		if (file == null) continue;

		//		AssetType asset = null;

		//		if (file is AssetType)
		//		{
		//			asset = (AssetType)(object)file;
		//		}
		//		else if (
		//			typeof(AssetType).IsSubclassOf(typeof(Component)) &&
		//			file is GameObject)
		//		{
		//			asset = ((GameObject)file).GetComponent<AssetType>();
		//		}

		//		if (asset == null) continue;

		//		var lazy = new Placeholder<AssetType, ResourceType>(
		//			asset,
		//			loadFunc
		//			);

		//		this.Add(lazy.Name, lazy);
		//	}
		//}

		//public void LoadAssets<ResourceType>(Func<ResourceType, string> identifyFunc) where ResourceType : class
		//{
		//	foreach (var file in _resources)
		//	{
		//		if (file == null) continue;

		//		ResourceType asset = null;

		//		if (file is ResourceType)
		//		{
		//			asset = (ResourceType)(object)file;
		//		}
		//		else if (
		//			typeof(ResourceType).IsSubclassOf(typeof(Component)) &&
		//			file is GameObject)
		//		{
		//			asset = ((GameObject)file).GetComponent<ResourceType>();
		//		}

		//		if (asset == null) continue;

		//		//this.Add(identifyFunc(asset), asset);
		//	}

		// TODO: do not repeat yourself
		public void LoadAssets<ResourceType>(Func<ResourceType, string> identifyFunc) where ResourceType : class
		{
			LibraryUtils.__LoadAssets(this, identifyFunc);
		}

		public void LoadAssets<ResourceType>(Func<ResourceType, string> identifyFunc, CodeGenOptions options = CodeGenOptions.None) where ResourceType : class
		{
			LibraryUtils.__LoadAssets(this, identifyFunc, options);
		}

#if UNITY_EDITOR
		public virtual string GenerateCode()
		{
			return LibraryCodeGenerator.GenerateCode(this, GeneratorFlags.None);
		}
#endif
	}

	// public abstract class LibraryComponentBase<T> : LibraryComponentBase where T : LibraryComponentBase
	// {
	// 	private static T _instance;

	// 	public static T Instance =>
	// 		_instance == null ?
	// 		_instance = UnityEngine.Resources.FindObjectsOfTypeAll<T>().FirstOrDefault() :
	// 		_instance;
	// }

}