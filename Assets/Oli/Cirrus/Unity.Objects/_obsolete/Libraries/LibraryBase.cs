using System.Collections.Generic;
using Object = UnityEngine.Object;

namespace Cirrus.Content
{
	public enum CodeGenOptions
	{
		None = 0,
		PrivateProperty = 1 << 0,
	}

	public struct __LibraryLoadObject
	{
		public CodeGenOptions CodeGenOptions;
		public object Object;
	}

	public interface ILibrary
	{
		void Clear();

#if UNITY_EDITOR
		void Load();
#endif

		bool __IsLoaded { get; }

		//Type StaticClassType { get; }

		bool _Get<ResourceType>(int key, out ResourceType res) where ResourceType : class;

		List<Object> Objects { get; }

#if UNITY_EDITOR

		Dictionary<string, __LibraryLoadObject> __EditorObjects { get; set; }
#endif
	}

}
