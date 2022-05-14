//using Cirrus.CodeGen;
//using Cirrus.Objects;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;

//namespace Cirrus.Unity.Libraries
//{
//	public abstract class LibraryBase : ILibrary
//	{
//		public IDictionary<int, object> Objects { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
//		public IDictionary<int, string> Identifiers { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

//		public virtual void Clear()
//		{

//		}

//		public virtual void Load()
//		{
//		}

//		public void WriteCustomClassCode(Writer writer, IEnumerable<EntryInfo> entries)
//		{
//			throw new System.NotImplementedException();
//		}

//		public void WriteCustomCode(Writer writer, IEnumerable<EntryInfo> entries)
//		{
//			throw new System.NotImplementedException();
//		}

//		public void WriteCustomLoadCode(Writer writer, IEnumerable<EntryInfo> entries)
//		{
//			throw new System.NotImplementedException();
//		}
//	}

//	public abstract class LibraryAssetBase : AssetBase, ILibrary
//	{
//		public IDictionary<int, object> Objects { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
//		public IDictionary<int, string> Identifiers { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

//		public virtual void Clear()
//		{

//		}

//		public virtual void Load()
//		{
//		}
//	}

//	public abstract class LibraryAssetBase<T> : LibraryAssetBase where T : LibraryAssetBase
//	{
//		private static T _instance;

//		public static T Instance
//		{
//			get
//			{
//				if (_instance == null)
//				{
//					_instance = Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();
//				}

//				return _instance;
//			}
//		}
//	}

//}