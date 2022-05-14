//using UnityEngine;
//using System.Collections;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Cirrus.Collections
{
	public static class ArrayUtils
	{
		//public static T[] Clone<T>(this T[] ar) where T : IPrototype
		//{
		//	var inst = new T[ar.Length];
		//	for(int i = 0; i < ar.Length; i++)
		//	{
		//		inst[i] = ar[i].DeepCopy<T>();
		//	}
		//	return inst;
		//}


		public static T[] WithoutDuplicates<T>(this T[] s)
		{
			HashSet<T> set = new HashSet<T>(s);
			T[] result = new T[set.Count];
			set.CopyTo(result);
			return result;
		}

		public static void For<T>(this T[] list, Action<T> action)
		{
			for (int i = 0; i < list.Length; i++)
			{
				action(list[i]);
			}
		}

		public static bool Any<T>(this T[] ar, Func<T, bool> func)
		{
			if (ar == null) return false;

			for (int i = 0; i < ar.Length; i++)
			{
				if (func(ar[i])) return true;
			}

			return false;
		}

		public static bool All<T>(this T[] ar, Func<T, bool> func)
		{
			if (ar == null) return true;

			for (int i = 0; i < ar.Length; i++)
			{
				if (!func(ar[i])) return false;
			}

			return true;
		}

		public static System.Collections.Generic.List<T>[] ArrayOfList<T>(int size)
		{
			return new System.Collections.Generic.List<T>[size];
		}

		public static System.Collections.Generic.List<T>[] ArrayOfArray<T>(int size)
		{
			return new System.Collections.Generic.List<T>[size];
		}


		public static T[] Concat<T>(this T[] x, T[] y)
		{
			if(x == null) throw new ArgumentNullException("x");
			if(y == null) throw new ArgumentNullException("y");
			int oldLen = x.Length;
			Array.Resize<T>(ref x, x.Length + y.Length);
			Array.Copy(y, 0, x, oldLen, y.Length);
			return x;
		}

		public static T[] Append<T>(this T[] array, T item)
		{
			if(array == null)
			{
				return new T[] { item };
			}
			T[] result = new T[array.Length + 1];
			array.CopyTo(result, 0);
			result[array.Length] = item;
			return result;
		}

		public static T[] Empty<T>() => Array.Empty<T>();

		//public static T[] Make<T>(params T[] args) => args;		

		//public static T[] ToArray<T>(this T t) => new T[] { t };		

		/// <summary>
		///	 Convert to binary string
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		public static string ToBinaryString(byte[] target)
		{
			if(null == target)
			{
				throw new ArgumentNullException(nameof(target));
			}

			return String.Join(" ", target.Select(a => Convert.ToString(a, 2).PadLeft(8, '0')));
		}

		public static T[] SubArray<T>(this T[] data, int index, int length=-1)
		{
			if(length == -1) length = data.Length - index;
			T[] result = new T[length];
			Array.Copy(data, index, result, 0, length);
			//bool isEqual = Enumerable.SequenceEqual(data, result);
			return result;
		}

		public static string ToBitString(this byte[] target)
		{
			if(null == target)
			{
				throw new ArgumentNullException(nameof(target));
			}

			return String.Join(" ", target.Select(a => Convert.ToString(a, 2).PadLeft(8, '0')));
		}

		public static void Clear(this byte[] data)
		{
			Array.Clear(data, 0, data.Length);
		}

		public static int BisectRight(float[] A, float x)
		{
			return BisectRight(A, x, 0, A.Length);
		}

		public static int BisectRight(float[] A, float x, int lo, int hi)
		{
			float N = A.Length;
			if(N == 0)
			{
				return 0;
			}
			if(x < A[lo])
			{
				return lo;
			}
			if(x > A[hi - 1])
			{
				return hi;
			}
			for(; ; )
			{
				if(lo + 1 == hi)
				{
					return lo + 1;
				}
				int mi = (hi + lo) / 2;
				if(x < A[mi])
				{
					hi = mi;
				}
				else
				{
					lo = mi;
				}
			}
		}

		public static int BisectLeft(float[] A, float x)
		{
			return BisectLeft(A, x, 0, A.Length);
		}

		public static int BisectLeft(float[] A, float x, int lo, int hi)
		{
			int N = A.Length;
			if(N == 0)
			{
				return 0;
			}
			if(x < A[lo])
			{
				return lo;
			}
			if(x > A[hi - 1])
			{
				return hi;
			}
			for(; ; )
			{
				if(lo + 1 == hi)
				{
					return x == A[lo] ? lo : (lo + 1);
				}
				int mi = (hi + lo) / 2;
				if(x <= A[mi])
				{
					hi = mi;
				}
				else
				{
					lo = mi;
				}
			}
		}

		// The returned insertion point i partitions the array a into two halves so that all(val <= x for val in a[lo:i]) 
		// for the left side and all(val > x for val in a[i:hi]) for the right side
		//
		// Locate the insertion point for x in a to maintain sorted order. The parameters lo and hi may be used to specify a 
		// subset of the list which should be considered; by default the entire list is used. If x is already present in a, the insertion point will be before (to the left of) any existing entries. 
		/// The return value is suitable for use as the first parameter to list.insert() assuming that a is already sorted.		
		public static int Bisect(float[] A, float x, int lo, int hi)
		{
			return BisectRight(A, x, lo, hi);
		}
	}

}

