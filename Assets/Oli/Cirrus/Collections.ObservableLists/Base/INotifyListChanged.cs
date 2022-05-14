using System.Collections.Specialized;
namespace Cirrus.Collections
{
	public interface INotifyListChanged
	{
		event NotifyCollectionChangedEventHandler Added;
		event NotifyCollectionChangedEventHandler Removed;
		event NotifyCollectionChangedEventHandler Replaced;
		event NotifyCollectionChangedEventHandler Reset;
	}
}
