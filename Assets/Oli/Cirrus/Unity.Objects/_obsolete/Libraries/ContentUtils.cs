using Cirrus.Objects;
using UnityEngine;

namespace Cirrus.Content
{
	public static class ContentUtils
	{
		public static bool __Add(this ILibrary lib, string key, __LibraryLoadObject obj)
		{
#if UNITY_EDITOR
			if(lib.__EditorObjects.ContainsKey(key))
			{
				Debug.Log($"Duplicated: Key: {key} ID:{lib.__EditorObjects.Count} ");
				return false;
			}
			lib.__EditorObjects.Add(key, obj);
#endif
			return true;
		}

		public static bool Get<ResourceType>(this ILibrary lib, int key, out ResourceType res)
				where ResourceType : class
		{
			//if(!lib.IsLoaded) lib.Load();

			if(
				!lib._Get(key, out res) &&
				lib.Objects[key] != null)
			{
				var obj = lib.Objects[key];
				if(obj is ResourceType)
				{
					res = obj as ResourceType;
				}
				// TODO: We should load the component not the gameobject from the start
				// save this overhead
				else if(
					typeof(ResourceType).IsSubclassOf(typeof(Component)) &&
					obj is GameObject)
				{
					res = ((GameObject)obj).GetComponent<ResourceType>();
				}
				//else if(typeof(ResourceType).IsSubclassOf(typeof(GameObject)))
				//{
				//	res = ;
				//}
			}

			if(res != null)
			{
				//if(typeof(IResourceProvider).IsAssignableFrom(typeof(ResourceType)))
				//{
				//	var prov = ((IResourceProvider)res);
				//	if(typeof(IIDed).IsAssignableFrom(prov.Object.GetType()))
				//	{
				//		((IIDed)prov.Object).ContentID = key;
				//	}
				//}
				//else if(typeof(IIDed).IsAssignableFrom(typeof(ResourceType)))
				//{
				//	((IIDed)res).ContentID = key;
				//}

				return true;
			}

			return false;
		}
	}

	//public class Content<T> : Content<T>
	//{
	//	public Content() : base()
	//	{
	//	}

	//	public Content(
	//		bool isThreadSafe)
	//		: base(isThreadSafe)
	//	{
	//	}

	//	public Content(
	//		Func<T> valueFactory)
	//		: base(valueFactory)
	//	{
	//	}

	//	public Content(
	//		LazyThreadSafetyMode mode)
	//		: base(mode)
	//	{
	//	}

	//	public Content(
	//		Func<T> valueFactory,
	//		bool isThreadSafe)
	//		: base(
	//			  valueFactory,
	//			  isThreadSafe)
	//	{
	//	}

	//	public Content(
	//		Func<T> valueFactory,
	//		LazyThreadSafetyMode mode)
	//		: base(
	//			  valueFactory,
	//			  mode)
	//	{
	//	}

	//	public Content(
	//		Func<T> factory,
	//		Action<T> action = null)
	//		: base(() =>
	//		{
	//			var value = factory();
	//			action?.Invoke(value);
	//			return value;
	//		})
	//	{
	//	}

	//	// Ctors removed for brevity

	//	/// <summary>
	//	/// Cast the <see cref="LazyBase{T}"/> to it's contained <typeparamref name="T"/>
	//	/// </summary>
	//	/// <param name="lazy">The lazy to cast.</param>
	//	/// <returns>The instance of <see cref="LazyBase{T}.Value"/></returns>
	//	public static implicit operator T(Lazily<T> lazy)
	//	{
	//		return lazy.Resource;
	//	}

	//	public static implicit operator Content<T>(Func<T> lazy)
	//	{
	//		return new Content<T>(lazy);
	//	}
	//}
}
