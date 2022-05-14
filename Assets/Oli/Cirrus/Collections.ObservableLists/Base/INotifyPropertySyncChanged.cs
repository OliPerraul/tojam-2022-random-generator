using System.ComponentModel;
namespace Cirrus.Collections
{
	public interface INotifyPropertySyncChanged : INotifyPropertyChanged
	{
		void OnPropertyChanged(object sender, PropertyChangedEventArgs args);
	}
}
