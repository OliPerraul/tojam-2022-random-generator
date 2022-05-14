using System.Collections;
using System.Collections.Generic;

namespace Cirrus.Collections
{
	public class ObservableList<TItem> : BaseObservableList<TItem>, ICollection<TItem>
	{
		public class SyncInfo<TItem>
		{
			public IObservableList<TItem> List;
			public bool PropertyNotifySourceToDest = true;
			public bool PropertyNotifyDestToSource = false;
		}
		private System.Collections.Generic.List<TItem> _list = new System.Collections.Generic.List<TItem>();
		private System.Collections.Generic.List<ObservableListSynchronizer<TItem, TItem>> _synchronizers =
			new System.Collections.Generic.List<ObservableListSynchronizer<TItem, TItem>>();

		protected override IList<TItem> InternalList => _list;
		public ObservableList() { _list = new System.Collections.Generic.List<TItem>(); }
		public ObservableList(System.Collections.Generic.List<TItem> list) { List = list; }
		public ObservableList(
			IObservableList<TItem> list,
			bool propertyNotifySourceToDest = true,
			bool propertyNotifyDestToSource = false
			)
		{
			_synchronizers.Add(new TrivialObservableListSynchronizer<TItem>(
				list,
				this,
				propertyNotifySourceToDest,
				propertyNotifyDestToSource));
		}
		public ObservableList(
				params SyncInfo<TItem>[] syncInfos
			)
		{
			foreach(var sync in syncInfos)
			{
				_synchronizers.Add(new TrivialObservableListSynchronizer<TItem>(
					sync.List,
					this,
					sync.PropertyNotifySourceToDest,
					sync.PropertyNotifyDestToSource));
			}
		}

		#region Properties
		public System.Collections.Generic.List<TItem> List
		{
			get => _list;
			set
			{
				_list = value;
				OnPropertyChangedCountAndIndex();
				OnCollectionChangedReset();
			}
		}
		public void AddRange(IList<TItem> items)
		{
			var count = _list.Count;
			_list.AddRange(items);
			OnPropertyChangedCountAndIndex();
			OnCollectionChangedAddMany((IList)items, count);
		}
		#endregion
		#region overrides
		public override TItem this[int index]
		{
			get => _list[index];
			set
			{
				var oldItem = _list[index];
				_list[index] = value;
				OnPropertyChangedIndex();
				OnCollectionChangedReplace(oldItem, value, index);
			}
		}
		public override void Add(TItem item)
		{
			_list.Add(item);
			OnPropertyChangedCountAndIndex();
			OnCollectionChangedAdd(item, _list.IndexOf(item));
		}
		public override void Clear()
		{
			_list.Clear();
			OnPropertyChangedCountAndIndex();
			OnCollectionChangedReset();
		}
		public override void Insert(int index, TItem item)
		{
			_list.Insert(index, item);
			OnPropertyChangedCountAndIndex();
			OnCollectionChangedAdd(item, index);
		}
		public override void Move(int oldIndex, int newIndex)
		{
			var removedItem = this[oldIndex];
			_list.RemoveAt(oldIndex);
			_list.Insert(newIndex, removedItem);
			OnPropertyChangedIndex();
			OnCollectionChangedMove(removedItem, oldIndex, newIndex);
		}
		public override bool Remove(TItem item)
		{
			var index = _list.IndexOf(item);
			if(index == -1) return false;
			_list.RemoveAt(index);
			OnPropertyChangedCountAndIndex();
			OnCollectionChangedRemove(item, index);
			return true;
		}

		public override bool RemoveRange(IEnumerable<TItem> items)
		{
			foreach(var item in items)
			{
				var index = _list.IndexOf(item);
				if(index == -1) return false;
				_list.RemoveAt(index);
			}
			OnPropertyChangedCountAndIndex();
			OnCollectionChangedRemoveMany(items, -1);
			return true;
		}

		public override void RemoveAt(int index)
		{
			var item = _list[index];
			_list.RemoveAt(index);
			OnPropertyChangedCountAndIndex();
			OnCollectionChangedRemove(item, index);
		}
		#endregion
	}
}
