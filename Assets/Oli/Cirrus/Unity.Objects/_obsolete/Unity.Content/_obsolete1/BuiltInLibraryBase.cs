//using Cirrus.Collections;
//using Cirrus.Resources;
//using System;
//using System.Collections.Generic;
//using UnityEngine;
//using static Cirrus.Debugging.DebugUtils;

//namespace Cirrus.Content
//{
//	public abstract partial class BuiltInLibraryBase<T>
//		: SingletonBase<T>
//		, ILibrary
//		where T : SingletonBase, new()
//	{		
//		public class EntryList<ResourceType> : TupleList<string, Func<PlaceholderBase, ResourceType>>
//		{ }

//		public class EntryList<AssetType, ResourceType> 
//			: TupleList<AssetType, Func<AssetType, ResourceType>>
//			where AssetType : class, INamed
//			where ResourceType : class
//		{ }

//		public BuiltInLibraryBase()
//		{
//		}

//		public virtual bool _Get<ResourceType>(int key, out ResourceType res)
//			where ResourceType : class
//		{
//			res = null;
//			return false;
//		}

//		public override void OnAcquired()
//		{
//			base.OnAcquired();		

//			if(!IsLoaded)
//			{
//				_objects = new Dictionary<int, object>();
//#if UNITY_EDITOR
//				_identifiers = new Dictionary<string, int>();
//#endif
//				Load();
//			}
//		}

//		protected Func<PlaceholderBase, T> _Process<T>(
//			Func<T> create,
//			Action<PlaceholderBase, T> preprocess,
//			Action<PlaceholderBase, T> postprocess,
//			Action< T> process
//			) where T : class
//		{
//			return (placeholder) =>
//			{
//				T resource = create();
//				if(preprocess != null) preprocess(placeholder, resource);
//				if(process != null) process(resource);
//				if(postprocess != null) postprocess(placeholder, resource);
//				return resource;
//			};
//		}

//		protected Func<A, T> _Process<A, T>(
//			Func<T> create,
//			Action<A, T> preprocess,
//			Action<A, T> postprocess,
//			Action<T> process
//			) 
//			where T : class
//			where A : INamed
//		{
//			return (placeholder) =>
//			{
//				T resource = create();
//				if(preprocess != null) preprocess(placeholder, resource);
//				if(process != null) process(resource);
//				if(postprocess != null) postprocess(placeholder, resource);
//				return resource;
//			};
//		}

//		protected Func<PlaceholderBase, T> _Process<T>(
//			Action<PlaceholderBase, T> preprocess,
//			Action<PlaceholderBase, T> postprocess,
//			Action<T> process
//			) where T : class, new()
//		{
//			return (placeholder) =>
//			{
//				T resource = new T();
//				if(preprocess != null) preprocess(placeholder, resource);
//				if(process != null) process(resource);
//				if(postprocess != null) postprocess(placeholder, resource);
//				return resource;
//			};
//		}

//		protected Func<A, T> _Process<A, T>(
//			Action<A, T> preprocess,
//			Action<A, T> postprocess,
//			Action<T> process
//			)
//			where T : class, new()			
//			where A : INamed
//		{
//			return (placeholder) =>
//			{
//				T resource = new T();
//				if(preprocess != null) preprocess(placeholder, resource);
//				if(process != null) process(resource);
//				if(postprocess != null) postprocess(placeholder, resource);
//				return resource;
//			};
//		}


//		protected Func<PlaceholderBase, T> _Process<T>(
//			Action<T> process)
//			where T : class, new()
//		{
//			return _Process(
//				null,
//				null,
//				null,
//				process
//				);
//		}

//		protected Func<A, T> _Process<A, T>(
//			Action<T> process)
//			where T : class, new()
//			where A : INamed
//		{
//			return _Process<A, T>(
//				null,
//				null,
//				null,
//				process
//				);
//		}

//		protected Func<PlaceholderBase, T> _Process<T>(
//			Func<T> create,
//			Action<T> process=null)
//			where T : class, new()
//		{
//			return _Process(
//				create,
//				null,
//				null,
//				process
//				);
//		}

//		protected Func<A, T> _Process<A, T>(
//			Func<T> create,
//			Action<T> process = null)
//			where T : class, new()
//			where A : INamed
//		{
//			return _Process<A, T>(
//				create,
//				null,
//				null,
//				process
//				);
//		}

//		public virtual void Load()
//		{
//			_CustomLoad();
//			_Load();
//		}
//		public virtual void Clear()
//		{
//			if(_objects != null) _objects.Clear();
//			_objects = null;
//#if UNITY_EDITOR
//			if(_identifiers != null ) _identifiers.Clear();			
//			_identifiers = null;
//#endif
//		}

//		protected virtual void _CustomLoad() { }

//		protected virtual void _Load() { }


////		public void Add(string key, object obj)
////		{

////#if UNITY_EDITOR
////			if(_identifiers == null) _identifiers = new Dictionary<string, int>();
////#endif
////			if(_objects == null) _objects = new Dictionary<int, object>();

////#if UNITY_EDITOR
////			int hashCode = key.HashCode();
////			if(_identifiers.ContainsKey(hashCode)) return;			
////			_identifiers.Add(hashCode, key);
////#endif
////			_objects.Add(key.HashCode(), obj);
////		}


//		//public ResourceType Get<ResourceType, T>(T key)
//		//	where ResourceType : class
//		//	where T : Enum
//		//	=> Get((int)(object)key, out ResourceType res) ? res : null;

//		public ResourceType Get<ResourceType>(int key)
//			where ResourceType : class
//			=> Get(key, out ResourceType res) ? res : null;

//		public bool Get<ResourceType>(int key, out ResourceType res)
//			where ResourceType : class
//		{
//			//if (!IsLoaded) Load();

//			res = null;
//			if (_objects.TryGetValue(key, out object obj))
//			{
//				if (obj is PlaceholderBase)
//				{
//					res = (ResourceType)((PlaceholderBase)obj).LoadObject();
//					_objects[key] = res;
//					return true;
//				}
//				else if (obj is ResourceType)
//				{
//					res = obj as ResourceType;
//					return true;
//				}
//			}

//			return false;
//		}

//		public void LazilyLoad<ResourceType>(
//			string identifier,
//			Func<PlaceholderBase, ResourceType> load
//			)
//			where ResourceType : class
//		{
//			this.Add(
//				identifier,
//				new Placeholder<ResourceType>(identifier, load));
//		}

//		// TODO replace with Func<> which takes string and
//		[Obsolete]
//		public void LazilyLoad<ResourceType>(
//			params object[] entries
//			)
//			where ResourceType : class
//		{
//			for (int i = 0; i < entries.Length; i += 2)
//			{
//				this.Add(
//					(string)entries[i],
//					new Placeholder<ResourceType>(
//						(string)entries[i],
//						(Func<PlaceholderBase, ResourceType>)entries[i + 1]));
//			}
//		}

//		public void LazilyLoad<ResourceType>(
//			EntryList<ResourceType> entries
//			)
//			where ResourceType : class
//		{
//			foreach(var entry in entries)
//			{
//				this.Add(
//					entry.Item1,
//					new Placeholder<ResourceType>(
//						entry.Item1,
//						entry.Item2));
//			}
//		}

//		public void LazilyLoad<AssetType, ResourceType>(
//			EntryList<AssetType, ResourceType> entries
//			)
//			where ResourceType : class
//			where AssetType : class, INamed
//		{
//			foreach(var entry in entries)
//			{
//				this.Add(
//					entry.Item1.Name,
//					new Placeholder<AssetType, ResourceType>(entry.Item1, entry.Item2));
//			}
//		}
//	}
//}
