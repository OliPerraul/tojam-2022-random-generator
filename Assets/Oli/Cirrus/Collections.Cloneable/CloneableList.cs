//using Cirrus.Objects;
//using System.Collections.Generic;

//namespace Cirrus.Collections
//{

//	public static class CloneableListUtils
//	{
//		//private class _CloneableList<T> : CloneableList<T>
//		//	where T : IPrototype
//		//{
//		//	public static readonly _CloneableList<T> Empty = new _CloneableList<T>();
//		//}

//		//public static CloneableList<T> Empty<T>() where T : IPrototype => _CloneableList<T>.Empty;
//	}

//	public abstract class CloneableListBase<T> 
//		: CloneableCollectionBase<T>
//		where T : ICopiableObject
//	{
//		protected System.Collections.Generic.List<T> _list;

//		public CloneableListBase()
//		{
//			_list = new System.Collections.Generic.List<T>();
//		}

//		//protected override CloneableStreamBase<T> _Clone()
//		//{
//		//	var list = (CloneableListBase<T>)MemberwiseClone();
//		//	list._list = new List<T>();
//		//	foreach(var item in _list)
//		//	{
//		//		list._list.Add(item.DeepCopy<T>());
//		//	}
//		//	return list;
//		//}

//		public override int Count => _list.Count;

//		public override bool IsReadOnly => false;

//		public override void Add(T item)
//		{
//			_list.Add(item);
//		}

//		public override void Clear()
//		{
//			_list.Clear();
//		}

//		public override bool Contains(T item)
//		{
//			return _list.Contains(item);
//		}

//		public override void CopyTo(T[] array, int arrayIndex)
//		{
//			_list.CopyTo(array, arrayIndex);
//		}

//		public override IEnumerator<T> GetEnumerator()
//		{
//			return _list.GetEnumerator();
//		}

//		public override bool Remove(T item)
//		{
//			return _list.Remove(item);
//		}
//	}

//	//public class CloneableList<T> : CloneableListBase<T>
//	//	where T : IPrototype
//	//{

//	//}
//}
