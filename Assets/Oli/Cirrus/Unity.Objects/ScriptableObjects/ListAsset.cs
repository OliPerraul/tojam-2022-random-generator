using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cirrus.Unity.Editor;
using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
//using GenericUnityObjects;

namespace Cirrus.Unity.Objects
{
	public class ListAsset<T> : ScriptableObjectBase, IList<T>, IEnumerable<T>
	{
		[SerializeField]
		protected List<T> _entries;

		public T this[int index] { get => ((IList<T>)_entries)[index]; set => ((IList<T>)_entries)[index] = value; }

		public int Count => ((ICollection<T>)_entries).Count;

		public bool IsReadOnly => ((ICollection<T>)_entries).IsReadOnly;

		public void Add(T item)
		{
			((ICollection<T>)_entries).Add(item);
		}

		public void Clear()
		{
			((ICollection<T>)_entries).Clear();
		}

		public bool Contains(T item)
		{
			return ((ICollection<T>)_entries).Contains(item);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			((ICollection<T>)_entries).CopyTo(array, arrayIndex);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return ((IEnumerable<T>)_entries).GetEnumerator();
		}

		public int IndexOf(T item)
		{
			return ((IList<T>)_entries).IndexOf(item);
		}

		public void Insert(int index, T item)
		{
			((IList<T>)_entries).Insert(index, item);
		}

		public bool Remove(T item)
		{
			return ((ICollection<T>)_entries).Remove(item);
		}

		public void RemoveAt(int index)
		{
			((IList<T>)_entries).RemoveAt(index);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)_entries).GetEnumerator();
		}
	}
}
