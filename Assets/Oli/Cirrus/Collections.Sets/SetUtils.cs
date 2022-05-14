using Cirrus.Objects;
using System.Collections.Generic;

namespace Cirrus.Collections
{
	//public static class SetUtils
	//{
	//	private class _EmptyListProviderBase<T>
	//	{
	//		public static readonly ISet<T> Empty = new ReadOnlyHashSet<T>();
	//	}

	//	public static ISet<T> Empty<T>()
	//	{
	//		return _EmptyListProviderBase<T>.Empty;
	//	}

	//	public static bool Intersects<T>(this HashSet<T> hashSet, HashSet<T> other)
	//	{
	//		if (hashSet == null) return false;
	//		if (other == null) return false;
	//		return hashSet.Overlaps(other);
	//	}

	//	//public static ISet<T> Clone<T>(this ISet<T> ar) where T : IPrototype
	//	//{
	//	//	var inst = new HashSet<T>();
	//	//	foreach(var item in ar)
	//	//	{
	//	//		inst.Add(item.DeepCopy<T>());
	//	//	}
	//	//	return inst;
	//	//}

	//}

	public static class HashSetUtils
	{
		private class _EmptyListProviderBase<T>
		{
			public static readonly HashSet<T> Empty_ = ObjectUtils.Empty<HashSet<T>>();

			public static readonly HashSet<T> Empty = ObjectUtils.Empty<HashSet<T>>();
		}

		public static HashSet<T> Empty_<T>()
		{
			return _EmptyListProviderBase<T>.Empty_;
		}

		public static HashSet<T> Empty<T>()
		{
			return _EmptyListProviderBase<T>.Empty_;
		}

		public static bool Intersects<T>(this HashSet<T> hashSet, HashSet<T> other)
		{
			if (hashSet == null) return false;
			if (other == null) return false;
			return hashSet.Overlaps(other);
		}

		public static bool Intersects<T>(this HashSet<T> hashSet, T other)
		{
			if (hashSet == null) return false;
			if (other == null) return false;
			return hashSet.Contains(other);
		}

	}


	/// <summary>
	/// A self expanding array implementation.
	/// </summary>
	/// <typeparam name="T">The datatype of this ArrayList.</typeparam>
	public static class SetUtils
	{
		private class _EmptyListProviderBase<T>
		{
			public static readonly ISet<T> Empty = new ReadOnlyHashSet<T>();
		}

		public static ISet<T> Empty<T>()
		{
			return _EmptyListProviderBase<T>.Empty;
		}

		//public static bool Intersects<T>(this HashSet<T> hashSet, HashSet<T> other)
		//{
		//	if(hashSet == null) return false;
		//	if(other == null) return false;
		//	return hashSet.Overlaps(other);
		//}

		//public static ISet<T> Clone<T>(this ISet<T> ar) where T : IPrototype
		//{
		//	var inst = new HashSet<T>();
		//	foreach(var item in ar)
		//	{
		//		inst.Add(item.DeepCopy<T>());
		//	}
		//	return inst;
		//}

	}
}
