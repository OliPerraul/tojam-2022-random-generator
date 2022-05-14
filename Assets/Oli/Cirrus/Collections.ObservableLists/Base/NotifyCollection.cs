using System.Collections;
using System.Collections.Specialized;
namespace Cirrus.Collections
{
	public abstract class NotifyCollection :
		NotifyProperty,
		INotifyCollectionChanged
	{
		#region Events
		public event NotifyCollectionChangedEventHandler CollectionChanged;
		public event NotifyCollectionChangedEventHandler Added;
		public event NotifyCollectionChangedEventHandler Removed;
		public event NotifyCollectionChangedEventHandler Moved;
		public event NotifyCollectionChangedEventHandler Replaced;
		public event NotifyCollectionChangedEventHandler Reset;
		#endregion
		#region Methods
		internal void OnCollectionChangedReset()
		{
			var eventArgs = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
			using(BlockReentrancy())
			{
				CollectionChanged?.Invoke(this, eventArgs);
				Reset?.Invoke(this, eventArgs);
			}
		}
		internal void OnCollectionChangedAdd(object value, int index)
		{
			var eventArgs = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, value, index);
			using(BlockReentrancy())
			{
				CollectionChanged?.Invoke(this, eventArgs);
				Added?.Invoke(this, eventArgs);
			}
		}
		internal void OnCollectionChangedAddMany(IList valueList, int index)
		{
			var eventArgs = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, valueList, index);
			using(BlockReentrancy())
			{
				CollectionChanged?.Invoke(this, eventArgs);
				Added?.Invoke(this, eventArgs);
			}
		}
		internal void OnCollectionChangedRemove(object value, int index)
		{
			var eventArgs = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, value, index);
			using(BlockReentrancy())
			{
				CollectionChanged?.Invoke(this, eventArgs);
				Removed?.Invoke(this, eventArgs);
			}
		}

		internal void OnCollectionChangedRemoveMany(IEnumerable valueList, int index)
		{
			var eventArgs = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, valueList, index);
			using(BlockReentrancy())
			{
				CollectionChanged?.Invoke(this, eventArgs);
				Removed?.Invoke(this, eventArgs);
			}
		}
		internal void OnCollectionChangedMove(object value, int index, int oldIndex)
		{
			var eventArgs = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Move, value, index, oldIndex);
			using(BlockReentrancy())
			{
				CollectionChanged?.Invoke(this, eventArgs);
				Moved?.Invoke(this, eventArgs);
			}
		}
		internal void OnCollectionChangedReplace(object oldValue, object newValue, int index)
		{
			var eventArgs = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newValue, oldValue, index);
			using(BlockReentrancy())
			{
				CollectionChanged?.Invoke(this, eventArgs);
				Replaced?.Invoke(this, eventArgs);
			}
		}
		#endregion
	}
}
