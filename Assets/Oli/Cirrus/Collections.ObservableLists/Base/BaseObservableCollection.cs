using System;
using System.Collections;
using System.Collections.Generic;
namespace Cirrus.Collections
{
	public abstract class BaseObservableCollection<TItem> :
		NotifyCollection,
		IObservableCollection<TItem>
	{
		protected abstract ICollection<TItem> InternalCollection { get; }
		public abstract void Add(TItem item);
		public abstract void Clear();
		public abstract bool Remove(TItem item);
		public abstract bool RemoveRange(IEnumerable<TItem> item);
		public int Count => InternalCollection.Count;
		public bool IsReadOnly => ((IList)InternalCollection).IsReadOnly;
		public bool Contains(TItem item) => InternalCollection.Contains(item);
		public void CopyTo(TItem[] array, int arrayIndex) => InternalCollection.CopyTo(array, arrayIndex);
		public IEnumerator<TItem> GetEnumerator() => InternalCollection.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator() => InternalCollection.GetEnumerator();
		int ICollection.Count => InternalCollection.Count;
		void ICollection.CopyTo(Array array, int arrayIndex) => ((ICollection)InternalCollection).CopyTo(array, arrayIndex);
		bool ICollection.IsSynchronized => ((ICollection)InternalCollection).IsSynchronized;
		object ICollection.SyncRoot => ((ICollection)InternalCollection).SyncRoot;
	}
}
