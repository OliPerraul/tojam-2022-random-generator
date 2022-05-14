using System.Collections.ObjectModel;

namespace Cirrus.Collections
{
	public static class ReadOnlyCollectionUtils
	{
		private class _EmptyArrayProviderBase<T>
		{
			public static readonly ReadOnlyCollection<T> Empty = new ReadOnlyCollection<T>(new T[0]);
		}

		public static ReadOnlyCollection<T> Empty<T>() => _EmptyArrayProviderBase<T>.Empty;

	}
}
