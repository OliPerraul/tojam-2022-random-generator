using System;
using System.Collections.Generic;
using System.Linq;

namespace Cirrus.Collections
{
	public static class EnumeratorUtils
	{
		public static T Next<T>(this IEnumerator<T> enumerator)
		{
			enumerator.MoveNext();
			return enumerator.Current;
		}
	}


	public static class EnumerableUtils
	{
		public static IEnumerable<int> IntegersFrom(int start = 0)
		{
			while(true) checked { yield return start++; }
		}

		public static IEnumerable<T> IntegersFrom<T>(T start) where T : System.Enum
		{
			int start_ = (int)(object)start;
			while(true) checked { yield return (T)(object)start_++; }
		}

		public static IEnumerable<long> LongsFrom(long start = 0)
		{
			while(true) checked { yield return start++; }
		}

		public static IEnumerable<long> LongsFrom<T>(T start)
		{
			long start_ = (long)(object)start;
			while(true) checked { yield return start_++; }
		}

		public static IEnumerable<T> RepeatSequence<T>(this IEnumerable<T> source)
		{
			while(true)
			{
				foreach(var item in source)
				{
					yield return item;
				}
			}
		}


		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			foreach(T element in source)
			{
				action(element);
			}
		}


		public static IEnumerable<TSource> If<TSource>(
			this IEnumerable<TSource> source,
			bool condition,
			Func<IEnumerable<TSource>, IEnumerable<TSource>> then,
			Func<IEnumerable<TSource>, IEnumerable<TSource>> otherwise
			)
		{
			if(condition) return then(source);

			else if(otherwise != null) return otherwise(source);

			else return source;
		}

		public static IEnumerable<TSource> If<TSource>(
			this IEnumerable<TSource> source,
			Func<bool> condition,
			Func<IEnumerable<TSource>, IEnumerable<TSource>> then,
			Func<IEnumerable<TSource>, IEnumerable<TSource>> otherwise
			)
		{
			return source.If(condition(), then, otherwise);
		}

		public static bool IsNullOrEmpty<T>(this IEnumerable<T> items)
		{
			return items == null || !items.Any();
		}

		public static bool IsEmpty<T>(this IEnumerable<T> items)
		{
			return !items.Any();
		}

		//public static bool Intersects<T>(this IEnumerable<T> a, IEnumerable<T> b)
		//{
		//	return a != null && b != null && !a.Intersect(b).IsEmpty();
		//}


		/// <summary>
		/// Wraps this object instance into an IEnumerable&lt;T&gt;
		/// consisting of a single item.
		/// </summary>
		/// <typeparam name="T"> Type of the object. </typeparam>
		/// <param name="item"> The instance that will be wrapped. </param>
		/// <returns> An IEnumerable&lt;T&gt; consisting of a single item. </returns>
		public static IEnumerable<T> ToEnumerable<T>(this T item)
		{
			yield return item;
		}

		/// <summary>
		/// Wraps this object instance into an IEnumerable&lt;T&gt;
		/// consisting of a single item.
		/// </summary>
		/// <typeparam name="T"> Type of the object. </typeparam>
		/// <param name="item"> The instance that will be wrapped. </param>
		/// <returns> An IEnumerable&lt;T&gt; consisting of a single item. </returns>
		public static IEnumerable<T> ToEnumerable<T>(params IEnumerable<T>[] enumerables)
		{
			foreach(var enumerable in enumerables)
			{
				foreach(var item in enumerable)
				{
					yield return item;
				}
			}
		}
		public static int FastCount<T>(this IEnumerable<T> enumerable)
		{
			if(enumerable is T[]) return (enumerable as T[]).Length;

			if(enumerable is ICollection<T> collection) return collection.Count;
			if (typeof(ICollection<T>).IsAssignableFrom(enumerable.GetType()))
			{
				return ((ICollection<T>)enumerable).Count;
			}
			
			return Enumerable.Count(enumerable);
		}

	}


	public static class EnumerableRandomUtils
	{
		/// <summary>
		/// Returns a random element from a list, or null if the list is empty.
		/// </summary>
		/// <typeparam name="T">The type of object being enumerated</typeparam>
		/// <param name="rand">An instance of a random number generator</param>
		/// <returns>A random element from a list, or null if the list is empty</returns>
		/// 
		public static T Random<T>(this IEnumerable<T> list)
		{
			return Random(list, new System.Random());
		}

		public static T Random<T>(this IEnumerable<T> list, System.Random rand)
		{
			if(list != null && Enumerable.Count(list) > 0)
				return list.ElementAt(rand.Next(Enumerable.Count(list)));
			return default(T);
		}

		/// <summary>
		/// Returns a shuffled IEnumerable.
		/// </summary>
		/// <typeparam name="T">The type of object being enumerated</typeparam>
		/// <returns>A shuffled shallow copy of the source items</returns>
		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
		{
			return source.Shuffle(new System.Random());
		}

		/// <summary>
		/// Returns a shuffled IEnumerable.
		/// </summary>
		/// <typeparam name="T">The type of object being enumerated</typeparam>
		/// <param name="rand">An instance of a random number generator</param>
		/// <returns>A shuffled shallow copy of the source items</returns>
		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, System.Random rand)
		{
			var list = source.ToList();
			list.Shuffle(rand);
			return list;
		}

		/// <summary>
		/// Shuffles an IList in place.
		/// </summary>
		/// <typeparam name="T">The type of elements in the list</typeparam>
		public static void Shuffle<T>(this IList<T> list)
		{
			list.Shuffle(new System.Random());
		}

		/// <summary>
		/// Shuffles an IList in place.
		/// </summary>
		/// <typeparam name="T">The type of elements in the list</typeparam>
		/// <param name="rand">An instance of a random number generator</param>
		public static void Shuffle<T>(this IList<T> list, System.Random rand)
		{
			int count = list.Count;
			while(count > 1)
			{
				int i = rand.Next(count--);
				T temp = list[count];
				list[count] = list[i];
				list[i] = temp;
			}
		}

		public static void UniqueForEach<T>(this IEnumerable<T> source, Action<T> action)
			// Account for repeating sequence
			// NOTE cannot have repeated elements
			where T : class
		{
			T first = default(T);
			foreach(var state in source)
			{
				// NOTE: account for repeating sequence				
				if(state == first) break;
				if(first == null) first = state;
				action(state);
			}
		}
	}
}
