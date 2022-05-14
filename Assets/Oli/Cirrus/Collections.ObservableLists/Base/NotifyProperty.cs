using System;
using System.ComponentModel;
namespace Cirrus.Collections
{
	public abstract class NotifyProperty : INotifyPropertyChanged
	{
		protected const string CountString = "Count";
		protected const string IndexerName = "Item[]";
		public event PropertyChangedEventHandler PropertyChanged;
		internal virtual void OnPropertyChanged(PropertyChangedEventArgs e) => PropertyChanged?.Invoke(this, e);
		internal void OnPropertyChanged(string propertyName) => OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		internal void OnPropertyChangedCountAndIndex()
		{
			OnPropertyChanged(CountString);
			OnPropertyChanged(IndexerName);
		}
		internal void OnPropertyChangedIndex()
		{
			OnPropertyChanged(IndexerName);
		}
		#region Reentrancy
		private readonly SimpleMonitor _monitor = new SimpleMonitor();
		protected IDisposable BlockReentrancy()
		{
			return new Disposable();
		}
		internal void CheckReentrancy()
		{
		}
		private class Disposable : IDisposable
		{
			public void Dispose() { }
		}
		private class SimpleMonitor : IDisposable
		{
			int _busyCount;
			public void Enter() => ++_busyCount;
			public void Dispose() => --_busyCount;
			public bool Busy => _busyCount > 0;
		}
		#endregion
	}
}
