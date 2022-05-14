using System;
using System.Collections;
using System.Collections.Generic;
using Cirrus.Objects;
using UnityEngine;
using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Collections
{
	// aka list
	public class ListBase<TItem> 
		: IList<TItem>
		, IReadOnlyList<TItem>
		, IEnumerable<TItem>
		, IReadOnlyCandidate
		, IIndexedCollection<TItem>
	{
		[SerializeField]
		protected System.Collections.Generic.List<TItem> _list = ObjectUtils.Empty<System.Collections.Generic.List<TItem>>();

		public static readonly string _AssertMessage = "This container is readonly. Cannot modify its content.";

		public bool IsReadOnlyObject { get; set; }
				
		public static ListBase<TItem> Empty => ObjectUtils.Empty<ListBase<TItem>>();

		public static implicit operator ListBase<TItem>(TItem node)
		{
			return new ListBase<TItem>() { node };
		}

		public static implicit operator ListBase<TItem>(TItem[] nodes)
		{
			return new ListBase<TItem>(nodes);
		}

		public static implicit operator ListBase<TItem>(System.Collections.Generic.List<TItem> nodes)
		{
			return new ListBase<TItem>(nodes);
		}

		public ListBase()
		{
			_list = new System.Collections.Generic.List<TItem>();
		}

		public ListBase(int cap)
		{
			_list = new System.Collections.Generic.List<TItem>(cap);
		}

		public ListBase(TItem[] col)
		{
			_list = new System.Collections.Generic.List<TItem>(col.Length);
			for(int i = 0; i < col.Length; i++) _list.Add(col[i]);
		}

		public ListBase(System.Collections.Generic.List<TItem> col)
		{
			_list = new System.Collections.Generic.List<TItem>(col.Count);
			for(int i = 0; i < col.Count; i++) _list.Add(col[i]);
		}

		public ListBase(IEnumerable<TItem> col)
		{
			foreach(var item in col) _list.Add(item);
		}

		public int Length => _list.Count;

		public int Count => _list.Count;

		public bool IsReadOnly => ((ICollection<TItem>)_list).IsReadOnly;

		public TItem this[int index] 
		{ 
			get => _list[index];

			set
			{
				if (AssertDidNotFail(!IsReadOnlyObject, _AssertMessage, true))
				{
					_list[index] = value;
				}
			}
		
		}

		public virtual int IndexOf(TItem item)
		{
			return _list.IndexOf(item);
		}

		public virtual void Insert(int index, TItem item)
		{
			if (AssertDidNotFail(!IsReadOnlyObject, _AssertMessage, true))
			{
				_list.Insert(index, item);
			}
		}

		public virtual void RemoveAt(int index)
		{
			if (AssertDidNotFail(!IsReadOnlyObject, _AssertMessage, true))
			{
				_list.RemoveAt(index);
			}
		}

		public virtual void Add(TItem item)
		{
			if (AssertDidNotFail(!IsReadOnlyObject, _AssertMessage, true))
			{
				_list.Add(item);
			}
		}

		public virtual void Clear()
		{
			if (AssertDidNotFail(!IsReadOnlyObject, _AssertMessage, true))
			{
				_list.Clear();
			}
		}

		public virtual bool Contains(TItem item)
		{
			return _list.Contains(item);
		}

		public virtual void CopyTo(TItem[] array, int arrayIndex)
		{
			_list.CopyTo(array, arrayIndex);
		}

		public virtual bool Remove(TItem item)
		{
			if (AssertDidNotFail(!IsReadOnlyObject, _AssertMessage, true))
			{
				return _list.Remove(item);
			}
			
			return false;
		}

		public virtual IEnumerator<TItem> GetEnumerator()
		{
			return _list.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _list.GetEnumerator();
		}
	}
}