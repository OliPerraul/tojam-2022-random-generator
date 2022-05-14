using System.Collections.Generic;

namespace Cirrus.Collections
{
	public interface IObservableList<TItem> :
		IObservableCollection<TItem>,
		IList<TItem>
	{
	}
}
