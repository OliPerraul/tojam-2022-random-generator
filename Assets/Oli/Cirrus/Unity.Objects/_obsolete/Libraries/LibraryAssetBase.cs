using Cirrus.Content;
using Cirrus.Unity.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// TODO generate #define GEN_OPTION_LIBRARY at the top most of the file to enable default ids if 
// no class has been generated


namespace Cirrus.Unity.Objects.Libraries
{
	// TODO make the libraries and generator into menu item rather than asset
	// This way we can bulk generate etc..

	// TODO generate legacy attributes with some warnign
	// This is after we clear up the remainder of the warnigns
	public abstract partial class LibraryAssetBase : ScriptableObjectBase, ILibrary
	{
		// TODO: Rename
		public virtual void Clear()
		{
#if UNITY_EDITOR
			if(__EditorObjects != null) __EditorObjects.Clear();
			__EditorObjects = new Dictionary<string, __LibraryLoadObject>();
#endif
			//if(_objects != null) _objects.Clear();
		}

		// TODO: Rename
		public virtual void Load()
		{
			_CustomLoad();
			LoadInEditor();
		}

		protected virtual void _CustomLoad() { }

		protected virtual void LoadInEditor() { }

		public ResourceType Get<ResourceType>(int key)
			where ResourceType : class
		=> this.Get(key, out ResourceType res) ? res : null;


		public ResourceType Get<ResourceType>(object key)
			where ResourceType : class
		=> this.Get((int)key, out ResourceType res) ? res : null;

		public virtual bool _Get<ResourceType>(int key, out ResourceType res)
			where ResourceType : class
		{
			res = null;
			return false;
		}

		public void LoadAssets<ResourceType>(Func<ResourceType, string> identifyFunc, CodeGenOptions options=CodeGenOptions.None) where ResourceType : class
		{
			LibraryUtils.__LoadAssets(this, identifyFunc, options);
		}

#if UNITY_EDITOR
		public virtual string GenerateCode()
		{
			return LibraryCodeGenerator.GenerateCode(this, GeneratorFlags.WriteAsStaticProps);
		}
#endif
	}

	public abstract class LibraryAssetBase<T> : LibraryAssetBase where T : LibraryAssetBase
	{
		[NonSerialized]
		private static T _instance;		

		public static T Instance
		{
			get
			{
				if(_instance == null) _instance = UnityEngine.Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();
				return _instance;
			}
		}
	}

}