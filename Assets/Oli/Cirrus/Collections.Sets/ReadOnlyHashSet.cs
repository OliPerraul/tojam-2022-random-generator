using System.Collections;
using System.Collections.Generic;
using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Collections
{
	public class ReadOnlyHashSet<T> : ISet<T>
	{
		private ISet<T> _hashSet = new HashSet<T>();

		public int Count => ((ICollection<T>)_hashSet).Count;

		public bool IsReadOnly => true;

		public void _LogError() => Error($"{nameof(ReadOnlyHashSet<T>)} is read only.");

		public bool Add(T item)
		{
			_LogError();
			return false;
		}

		public void Clear()
		{
			_LogError();
		}

		public bool Contains(T item)
		{
			return ((ICollection<T>)_hashSet).Contains(item);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			((ICollection<T>)_hashSet).CopyTo(array, arrayIndex);
		}

		public void ExceptWith(IEnumerable<T> other)
		{
			((ISet<T>)_hashSet).ExceptWith(other);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return ((IEnumerable<T>)_hashSet).GetEnumerator();
		}

		public void IntersectWith(IEnumerable<T> other)
		{
			_LogError();
		}

		public bool IsProperSubsetOf(IEnumerable<T> other)
		{
			return ((ISet<T>)_hashSet).IsProperSubsetOf(other);
		}

		public bool IsProperSupersetOf(IEnumerable<T> other)
		{
			return ((ISet<T>)_hashSet).IsProperSupersetOf(other);
		}

		public bool IsSubsetOf(IEnumerable<T> other)
		{
			return ((ISet<T>)_hashSet).IsSubsetOf(other);
		}

		public bool IsSupersetOf(IEnumerable<T> other)
		{
			return ((ISet<T>)_hashSet).IsSupersetOf(other);
		}

		public bool Overlaps(IEnumerable<T> other)
		{
			return ((ISet<T>)_hashSet).Overlaps(other);
		}

		public bool Remove(T item)
		{
			_LogError();
			return false;
		}

		public bool SetEquals(IEnumerable<T> other)
		{
			return ((ISet<T>)_hashSet).SetEquals(other);
		}

		public void SymmetricExceptWith(IEnumerable<T> other)
		{
			((ISet<T>)_hashSet).SymmetricExceptWith(other);
		}

		public void UnionWith(IEnumerable<T> other)
		{
			((ISet<T>)_hashSet).UnionWith(other);
		}

		void ICollection<T>.Add(T item)
		{
			_LogError();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)_hashSet).GetEnumerator();
		}
	}
}
