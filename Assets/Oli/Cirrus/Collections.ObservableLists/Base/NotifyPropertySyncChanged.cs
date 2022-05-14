using System.ComponentModel;
namespace Cirrus.Collections
{
	public abstract class NotifyPropertySyncChanged : INotifyPropertySyncChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged(object sender, PropertyChangedEventArgs args) => PropertyChanged?.Invoke(this, args);
		public void OnPropertyChanged(string name="") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
