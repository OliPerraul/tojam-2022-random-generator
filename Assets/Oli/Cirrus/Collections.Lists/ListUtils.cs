//using UnityEngine;
//using System.Collections;

using Cirrus.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cirrus.Collections
{
	public static class SortExtensions
	{
		//  Sorts an IList<T> in place.
		public static void Sort<T>(this IList<T> list, Comparison<T> comparison)
		{
			ArrayList.Adapter((IList)list).Sort(new ComparisonComparer<T>(comparison));
		}

		// Sorts in IList<T> in place, when T is IComparable<T>
		public static void Sort<T>(this IList<T> list) where T : IComparable<T>
		{
			Comparison<T> comparison = (l, r) => l.CompareTo(r);
			Sort(list, comparison);

		}

		// Convenience method on IEnumerable<T> to allow passing of a
		// Comparison<T> delegate to the OrderBy method.
		public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> list, Comparison<T> comparison)
		{
			return list.OrderBy(t => t, new ComparisonComparer<T>(comparison));
		}
	}

	// Wraps a generic Comparison<T> delegate in an IComparer to make it easy
	// to use a lambda expression for methods that take an IComparer or IComparer<T>
	public class ComparisonComparer<T> : IComparer<T>, IComparer
	{
		private readonly Comparison<T> _comparison;

		public ComparisonComparer(Comparison<T> comparison)
		{
			_comparison = comparison;
		}

		public int Compare(T x, T y)
		{
			return _comparison(x, y);
		}

		public int Compare(object o1, object o2)
		{
			return _comparison((T)o1, (T)o2);
		}
	}

	public static class ListUtils
	{
		public static System.Collections.Generic.List<T> WithoutDuplicates<T>(this System.Collections.Generic.List<T> s)
		{
			return new HashSet<T>(s).ToList();
		}

		public static void For<T>(this IList<T> list, Action<T> action)
		{
			for (int i = 0; i < list.Count; i++)
			{
				action(list[i]);
			}
		}

		public static bool Any<T>(this IList<T> list, Func<T, bool> func)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (func(list[i])) return true;
			}

			return false;
		}

		public static bool All<T>(this IList<T> list, Func<T, bool> func)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (!func(list[i])) return false;
			}

			return true;
		}

		public static void Add<T>(this System.Collections.Generic.List<T> collection, IEnumerable<T> itemsToAdd)
		{
			collection.AddRange(itemsToAdd);
		}

		public static void Add<T>(this System.Collections.Generic.List<T> collection, T[] itemsToAdd)
		{
			collection.AddRange(itemsToAdd);
		}

		public static System.Collections.Generic.List<T> Empty<T>()
		{
			return ObjectUtils.Empty<System.Collections.Generic.List<T>>();
		}

		public static T Find<T>(this IList<T> ilist, Predicate<T> match)
		{
			if(ilist is System.Collections.Generic.List<T> list)
			{
				return list.Find(match);
			}
			else if(ilist is T[] array)
			{
				return Array.Find(array, match);
			}
			else
			{
				return ilist.FirstOrDefault(i => match(i));
			}
		}

		public static T Find<T>(this IList<T> ilist, T element)
			where T : class
		{
			if(ilist is System.Collections.Generic.List<T> list)
			{
				return list.Find(element);
			}
			else if(ilist is T[] array)
			{
				return Array.Find(array, x => x == element);
			}
			else
			{
				return ilist.FirstOrDefault(x => x == element);
			}
		}

		public static System.Collections.Generic.List<T> Resize<T>(this System.Collections.Generic.List<T> list, int sz, T c)
		{
			int cur = list.Count;
			list.Reserve(sz);
			if(sz < cur)
				list.RemoveRange(sz, cur - sz);
			else if(sz > cur)
			{
				if(sz > list.Capacity)//this bit is purely an optimisation, to avoid multiple automatic capacity changes.
					list.Capacity = sz;
				list.AddRange(Enumerable.Repeat(c, sz - cur));
			}

			return list;
		}

		public static System.Collections.Generic.List<T> Resize<T>(this System.Collections.Generic.List<T> list, int sz)
		{
			return Resize(list, sz, default);
		}

		public static System.Collections.Generic.List<T> Reserve<T>(this System.Collections.Generic.List<T> list, int sz)
		{
			list.Capacity = sz;
			return list;
		}

		public static T RemoveRandom<T>(this System.Collections.Generic.List<T> list)
		{
			int index = UnityEngine.Random.Range(0, list.Count);
			var val = list[index];
			list.RemoveAt(index);
			return val;
		}

		public static bool IsEmpty<T>(this System.Collections.Generic.List<T> collection)
		{
			return collection.Count == 0;
		}



		//public static bool Intersects<T>(this List<T> list, List<T> other)
		//{
		//	if (list == null) return false;
		//	if (other == null) return false;
		//	return list.Overlaps(other);
		//}

		//public static bool Intersects<T>(this List<T> list, T other)
		//{
		//	if (list == null) return false;
		//	if (other == null) return false;
		//	return list.Contains(other);
		//}


		// Update is called once per frame
		//void Update()
		//{

		//}
	}
}