using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
namespace Cirrus.Collections
{
	public abstract class ObservableListSynchronizer<TSource, TDestination>
	{
		protected IObservableList<TSource> _sourceObservableList;
		protected IObservableList<TDestination> _destinationObservableList;
		public abstract TDestination ConvertSourceToDestination(TSource item);
		public abstract TSource ConvertDestinationToSource(TDestination item);
		#region Properties
		public IObservableList<TSource> SourceObservableList
		{
			get => _sourceObservableList;
			set => ReplaceSource_SyncToDestination(value);
		}
		public IObservableList<TDestination> DestinationObservableList
		{
			get => _destinationObservableList;
			set => ReplaceDestination_SyncFromSource(value);
		}
		public bool IsSyncSourceToDestCollection { get; set; } = true;
		public bool IsSyncDestToSourceCollection { get; set; } = true;
		public bool IsPropertyNotifySourceToDest { get; private set; }
		public bool IsPropertyNotifyDestToSource { get; private set; }
		public bool IsPropertyNotify => IsPropertyNotifySourceToDest || IsPropertyNotifyDestToSource;
		#endregion
		#region Constructors
		protected ObservableListSynchronizer(bool propertyNotifySourceToDest = true, bool propertyNotifyDestToSource = true)
		{
			IsPropertyNotifySourceToDest = propertyNotifySourceToDest;
			IsPropertyNotifySourceToDest = propertyNotifyDestToSource;
		}
		protected ObservableListSynchronizer(ObservableList<TSource> sourceCollection, ObservableList<TDestination> destCollection, bool propertyNotifySourceToDest = true, bool propertyNotifyDestToSource = false)
		{
			IsPropertyNotifySourceToDest = propertyNotifySourceToDest;
			IsPropertyNotifySourceToDest = propertyNotifyDestToSource;
			_destinationObservableList = destCollection;
			_destinationObservableList.CollectionChanged += DestinationCollectionChanged;
			ReplaceSource_SyncToDestination(sourceCollection);
		}
		#endregion
		#region Replace Source or destination
		public void ReplaceSource_SyncToDestination(IObservableList<TSource> sourceObvList)
		{
			if(_sourceObservableList != null) _sourceObservableList.CollectionChanged -= SourceCollectionChanged;
			_sourceObservableList = sourceObvList;
			if(_sourceObservableList == null) { ((IList<TDestination>)_destinationObservableList).Clear(); return; }
			if(_destinationObservableList == null) { _sourceObservableList.CollectionChanged += SourceCollectionChanged; return; }
			_destinationObservableList.CollectionChanged -= DestinationCollectionChanged;
			((IList<TDestination>)_destinationObservableList).Clear();
			foreach(var sourceItem in _sourceObservableList)
			{
				var destItem = ConvertSourceToDestination(sourceItem);
				_destinationObservableList.Add(destItem);
				if(IsPropertyNotify) CreatePropertySync(sourceItem, destItem);
			}
			_sourceObservableList.CollectionChanged += SourceCollectionChanged;
			_destinationObservableList.CollectionChanged += DestinationCollectionChanged;
		}
		public void ReplaceSource_SyncFromDestination(ObservableList<TSource> sourceObvList)
		{
			if(_sourceObservableList != null) _sourceObservableList.CollectionChanged -= SourceCollectionChanged;
			_sourceObservableList = sourceObvList;
			if(_sourceObservableList == null) return;
			((IList<TSource>)_sourceObservableList).Clear();
			if(_destinationObservableList == null)
			{
				_sourceObservableList.CollectionChanged += SourceCollectionChanged;
				return;
			}
			foreach(var destItem in _destinationObservableList)
			{
				var sourceItem = ConvertDestinationToSource(destItem);
				_sourceObservableList.Add(sourceItem);
				if(IsPropertyNotify) CreatePropertySync(sourceItem, destItem);
			}
			_sourceObservableList.CollectionChanged += SourceCollectionChanged;
		}
		public void ReplaceDestination_SyncToSource(ObservableList<TDestination> destObvList)
		{
			if(_destinationObservableList != null) _destinationObservableList.CollectionChanged -= DestinationCollectionChanged;
			_destinationObservableList = destObvList;
			if(_destinationObservableList == null) { ((IList<TSource>)_sourceObservableList)?.Clear(); return; }
			if(_sourceObservableList == null) { _destinationObservableList.CollectionChanged += DestinationCollectionChanged; return; }
			_sourceObservableList.CollectionChanged -= SourceCollectionChanged;
			((IList<TSource>)_sourceObservableList)?.Clear();
			foreach(var destItem in _destinationObservableList)
			{
				var sourceItem = ConvertDestinationToSource(destItem);
				_sourceObservableList.Add(sourceItem);
				if(IsPropertyNotify) CreatePropertySync(sourceItem, destItem);
			}
			_destinationObservableList.CollectionChanged += DestinationCollectionChanged;
			_sourceObservableList.CollectionChanged += SourceCollectionChanged;
		}
		public void ReplaceDestination_SyncFromSource(IObservableList<TDestination> destObvList)
		{
			if(_destinationObservableList != null) _destinationObservableList.CollectionChanged -= DestinationCollectionChanged;
			_destinationObservableList = destObvList;
			if(_destinationObservableList == null) return;
			((IList<TDestination>)_destinationObservableList)?.Clear();
			if(_sourceObservableList == null)
			{
				_destinationObservableList.CollectionChanged += DestinationCollectionChanged;
				return;
			}
			foreach(var sourceItem in _sourceObservableList)
			{
				var destItem = ConvertSourceToDestination(sourceItem);
				_destinationObservableList.Add(destItem);
				if(IsPropertyNotify) CreatePropertySync(sourceItem, destItem);
			}
			_destinationObservableList.CollectionChanged += DestinationCollectionChanged;
		}
		#endregion
		private void CreatePropertySync(TSource sourceItem, TDestination destItem)
		{
			if(!(sourceItem is INotifyPropertyChanged && destItem is INotifyPropertyChanged)) return;
			if(!(sourceItem is INotifyPropertySyncChanged || destItem is INotifyPropertySyncChanged)) return;
			var propertySyncNotifer = new PropertySyncNotifier(
				sourceItem as INotifyPropertyChanged,
				destItem as INotifyPropertyChanged,
				IsPropertyNotifySourceToDest,
				IsPropertyNotifyDestToSource);
		}
		private void SourceCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
		{
			if(!IsSyncSourceToDestCollection) return;
			if(_destinationObservableList == null) return;
			_destinationObservableList.CollectionChanged -= DestinationCollectionChanged;
			switch(args.Action)
			{
				case NotifyCollectionChangedAction.Add:
					for(var index = 0; index < args.NewItems.Count; index++)
					{
						var sourceItem = (TSource)args.NewItems[index];
						var destItem = ConvertSourceToDestination(sourceItem);
						_destinationObservableList.Insert(args.NewStartingIndex + index, destItem);
						if(IsPropertyNotify) CreatePropertySync(sourceItem, destItem);
					}
					break;
				case NotifyCollectionChangedAction.Remove:
					for(var index = 0; index < args.OldItems.Count; index++)
						((IList<TDestination>)_destinationObservableList).RemoveAt(args.OldStartingIndex + index);
					break;
				case NotifyCollectionChangedAction.Replace:
					for(var index = 0; index < args.NewItems.Count; index++)
					{
						var sourceItem = (TSource)args.NewItems[index];
						var destItem = ConvertSourceToDestination(sourceItem);
						((IList<TDestination>)_destinationObservableList)[args.OldStartingIndex + index] = destItem;
						if(IsPropertyNotify) CreatePropertySync(sourceItem, destItem);
					}
					break;
				case NotifyCollectionChangedAction.Reset:
					((IList<TDestination>)_destinationObservableList).Clear();
					foreach(var sourceItem in _sourceObservableList)
					{
						var destItem = ConvertSourceToDestination(sourceItem);
						_destinationObservableList.Add(destItem);
						if(IsPropertyNotify) CreatePropertySync(sourceItem, destItem);
					}
					break;
				default:
					_destinationObservableList.CollectionChanged += DestinationCollectionChanged;
					throw new ArgumentOutOfRangeException();
			}
			_destinationObservableList.CollectionChanged += DestinationCollectionChanged;
		}
		private void DestinationCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
		{
			if(!IsSyncDestToSourceCollection) return;
			if(_sourceObservableList == null) return;
			_sourceObservableList.CollectionChanged -= SourceCollectionChanged;
			switch(args.Action)
			{
				case NotifyCollectionChangedAction.Add:
					for(var index = 0; index < args.NewItems.Count; index++)
					{
						var destItem = (TDestination)args.NewItems[index];
						var sourceItem = ConvertDestinationToSource(destItem);
						_sourceObservableList.Insert(args.NewStartingIndex + index, sourceItem);
						if(IsPropertyNotify) CreatePropertySync(sourceItem, destItem);
					}
					break;
				case NotifyCollectionChangedAction.Remove:
					for(var index = 0; index < args.OldItems.Count; index++)
						((IList<TSource>)_sourceObservableList).RemoveAt(args.OldStartingIndex + index);
					break;
				case NotifyCollectionChangedAction.Replace:
					for(var index = 0; index < args.NewItems.Count; index++)
					{
						var destItem = (TDestination)args.NewItems[index];
						var sourceItem = ConvertDestinationToSource(destItem);
						((IList<TSource>)_sourceObservableList)[args.OldStartingIndex + index] = sourceItem;
						if(IsPropertyNotify) CreatePropertySync(sourceItem, destItem);
					}
					break;
				case NotifyCollectionChangedAction.Reset:
					((IList<TSource>)_sourceObservableList).Clear();
					foreach(var destItem in _destinationObservableList)
					{
						var sourceItem = ConvertDestinationToSource(destItem);
						_sourceObservableList?.Add(sourceItem);
						if(IsPropertyNotify) CreatePropertySync(sourceItem, destItem);
					}
					break;
				default:
					_sourceObservableList.CollectionChanged += SourceCollectionChanged;
					throw new ArgumentOutOfRangeException();
			}
			_sourceObservableList.CollectionChanged += SourceCollectionChanged;
		}
	}
}
