using System;
using System.Collections.Generic;

namespace Cirrus.Collections
{
	public class CollectionGenericUtils<T>
	{
		//public static implicit operator T[](T t)
		//{
		//	return new T[] { t };
		//}
	}

	public class TupleList<T1, T2> : System.Collections.Generic.List<Tuple<T1, T2>>
	{
		public void Add(T1 item, T2 item2)
		{
			Add(new Tuple<T1, T2>(item, item2));
		}
	}

	public static class CollectionUtils
	{
		public static void For_<T>(this IIndexedCollection<T> container, Action<T> action)
		{
			for (int i = 0; i < container.Count; i++)
			{
				action(container[i]);
			}
		}

		public static bool Any_<T>(this IIndexedCollection<T> list, Func<T, bool> func)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (func(list[i])) return true;
			}

			return false;
		}

		public static bool All_<T>(this IIndexedCollection<T> list, Func<T, bool> func)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (!func(list[i])) return false;
			}

			return true;
		}


		public static void Add<T>(this ICollection<T> collection, IEnumerable<T> itemsToAdd)
		{
			foreach(var item in itemsToAdd)
			{
				collection.Add(item);
			}
		}

		public class FunctionalComparer<T> : Comparer<T>
		{
			private Func<T, T, int> _comparer;
			public FunctionalComparer(Func<T, T, int> comparer)
			{
				this._comparer = comparer;
			}
			public static IComparer<T> Create(Func<T, T, int> comparer)
			{
				return new FunctionalComparer<T>(comparer);
			}
			public override int Compare(T x, T y)
			{
				return _comparer(x, y);
			}

			public static implicit operator FunctionalComparer<T>(Func<T, T, int> compare)
			{
				return new FunctionalComparer<T>(compare);
			}

		}


		public static Tuple<A, B> MakePair<A, B>(A a, B b)
		{
			return new Tuple<A, B>(a, b);
		}

		public static ICollection<T> AsCollection<T>(this IEnumerable<T> t, Action<ICollection<T>> update = null)
		{
			var c = t as ICollection<T>;
			if(update != null)
			{
				update(c);
			}
			return c;
		}


		public static bool IsEmpty<T>(this ICollection<T> collection)
		{
			return collection.Count == 0;
		}
	}

	public interface IIndexedCollection<T>
	{
		T this[int index] { get; set; }
		int Count { get; }
	}
}
