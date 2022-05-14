using System;
namespace Cirrus.Collections
{
	public class ObservableListSynchronizerFunc<TSource, TDestination> : ObservableListSynchronizer<TSource, TDestination>
	{
		private readonly Func<TSource, TDestination> _convertSourceToDest;
		private readonly Func<TDestination, TSource> _convertDestToSource;
		public override TDestination ConvertSourceToDestination(TSource item) => _convertSourceToDest(item);
		public override TSource ConvertDestinationToSource(TDestination item) => _convertDestToSource(item);
		public ObservableListSynchronizerFunc(
				Func<TSource, TDestination> convertSourceToDest,
				Func<TDestination, TSource> convertDestToSource,
				bool propertyNotifySourceToDest = true,
				bool propertyNotifyDestToSource = true) : base(propertyNotifySourceToDest, propertyNotifyDestToSource)
		{
			_convertSourceToDest = convertSourceToDest;
			_convertDestToSource = convertDestToSource;
		}
		public ObservableListSynchronizerFunc(
				Func<TSource, TDestination> convertSourceToDest,
				Func<TDestination, TSource> convertDestToSource,
				IObservableList<TSource> sourceObvList,
				IObservableList<TDestination> destObvList,
				bool propertyNotifySourceToDest = true,
				bool propertyNotifyDestToSource = true) : base(propertyNotifySourceToDest, propertyNotifyDestToSource)
		{
			_convertSourceToDest = convertSourceToDest;
			_convertDestToSource = convertDestToSource;
			SourceObservableList = sourceObvList;
			DestinationObservableList = destObvList;
		}
	}
	public class TrivialObservableListSynchronizer<TItem> : ObservableListSynchronizerFunc<TItem, TItem>
	{
		public TrivialObservableListSynchronizer(
			IObservableList<TItem> sourceObvList,
			IObservableList<TItem> destObvList,
			bool propertyNotifySourceToDest = true,
			bool propertyNotifyDestToSource = true
			)
		: base(
			(x) => x,
			(x) => x,
			sourceObvList,
			destObvList,
			propertyNotifySourceToDest,
			propertyNotifyDestToSource)
		{
		}
	}
}
