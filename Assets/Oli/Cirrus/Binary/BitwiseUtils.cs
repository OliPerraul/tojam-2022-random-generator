using System;
using System.Collections.Generic;
using System.Linq;
///====================================================================================================
///
///	 BitwiseUtil by
///	 - CantyCanadian
///
///====================================================================================================
namespace Cirrus
{
	public static class BitwiseUtils
	{
		// TODO why not uints?
		public const int MaxValue = int.MaxValue;

		public static T All<T>() where T : Enum
		{
			return (T)(object)0x7FFFFFFF;
		}

		public static T None<T>() where T : Enum
		{
			return (T)(object)0;
		}



		public static int ToBitmask(IEnumerable<int> positions)
		{
			int mask = 0;
			foreach(var position in positions)
			{
				mask |= 1 << (int)(object)position;
			}
			return mask;
		}

		public static int ToBitmask<T>(params T[] positions) where T : Enum
		{
			return ToBitmask(positions.Select(x => (int)(object)x));
		}

		public static int ToBitmask(params int[] positions)
		{
			return ToBitmask((IEnumerable<int>)positions);
		}

		public static int ToBitmask(this List<int> positions)
		{
			return ToBitmask((IEnumerable<int>)positions);
		}

		public static int ToBitmask<T>(this List<T> positions) where T : Enum
		{
			return ToBitmask(positions.Select(x => (int)(object)x));
		}

		public static int ToBitmask<T>(this T position, params T[] positions) where T : Enum
		{
			return ToBitmask(positions) | 1 << (int)(object)position;
		}

		public static long ToBitmask64<T>(params T[] positions)
		{
			long mask = 0;
			foreach(var position in positions)
			{
				mask |= (long)(1 << (int)(object)position);
			}
			return mask;
		}


	#region AND

		public static uint AND(this uint mask1, uint mask2)
		{
			return mask1 & mask2;
		}

		public static int AND(this int mask1, int mask2)
		{
			return mask1 & mask2;
		}
		public static T AND<T>(this T mask1, int mask2) where T : Enum
		{
			return (T)(object)(((int)(object)mask1) & mask2);
		}

		public static T AND<T>(this T mask1, uint mask2) where T : Enum
		{
			return (T)(object)(((uint)(object)mask1) & mask2);
		}

		public static int AND<T>(this int mask1, T mask2) where T : Enum
		{
			return mask1 & ((int)(object)mask2);
		}

		public static uint AND<T>(this uint mask1, T mask2) where T : Enum
		{
			return mask1 & ((uint)(object)mask2);
		}

		public static T AND<T>(this T mask1, T mask2) where T : Enum
		{
			return (T)(object)(((int)(object)mask1) & ((int)(object)mask2));
		}


		#endregion


		#region AND_NOT


		public static T AND_NOT<T>(this T flags, T mask2) where T : Enum
		{
			return (T)(object)((int)(object)flags & ~(int)(object)mask2);
		}

		public static uint AND_NOT(this uint mask1, uint mask2)
		{
			return mask1 & ~mask2;
		}

		public static int AND_NOT(this int mask1, int mask2)
		{
			return mask1 & ~mask2;
		}
		public static T AND_NOT<T>(this T mask1, int mask2) where T : Enum
		{
			return (T)(object)(((int)(object)mask1) & ~mask2);
		}

		public static T AND_NOT<T>(this T mask1, uint mask2) where T : Enum
		{
			return (T)(object)(((uint)(object)mask1) & ~mask2);
		}

		public static int AND_NOT<T>(this int mask1, T mask2) where T : Enum
		{
			return mask1 & ~((int)(object)mask2);
		}

		public static uint AND_NOT<T>(this uint mask1, T mask2) where T : Enum
		{
			return mask1 & ~((uint)(object)mask2);
		}



		#endregion

		#region OR


		public static uint OR(this uint mask1, uint mask2)
		{
			return mask1 | mask2;
		}

		public static int OR(this int mask1, int mask2)
		{
			return mask1 | mask2;
		}
		public static T OR<T>(this T mask1, int mask2) where T : Enum
		{
			return (T)(object)(((int)(object)mask1) | mask2);
		}

		public static T OR<T>(this T mask1, uint mask2) where T : Enum
		{
			return (T)(object)(((uint)(object)mask1) | mask2);
		}

		public static int OR<T>(this int mask1, T mask2) where T : Enum
		{
			return mask1 | ((int)(object)mask2);
		}

		public static uint OR<T>(this uint mask1, T mask2) where T : Enum
		{
			return mask1 | ((uint)(object)mask2);
		}

		public static T OR<T>(this T mask1, T mask2) where T : Enum
		{
			return (T)(object)(((int)(object)mask1) | ((int)(object)mask2));
		}


		#endregion

		#region Intersects

		public static bool Overlaps(this int mask1, int mask2)
		{
			return (mask1 & mask2) != 0;
		}

		public static bool Intersects(this uint mask1, uint mask2)
		{
			return (mask1 & mask2) != 0;
		}

		public static bool Intersects(this int mask1, int mask2)
		{
			return (mask1 & mask2) != 0;
		}
		public static bool Intersects<T>(this T mask1, int mask2) where T : Enum
		{
			return ((int)(object)mask1 & mask2) != 0;
		}

		public static bool Intersects<T>(this T mask1, uint mask2) where T : Enum
		{
			return ((int)(object)mask1 & mask2) != 0;
		}

		public static bool Intersects<T>(this int mask1, T mask2) where T : Enum
		{
			return (mask1 & (int)(object)mask2) != 0;
		}

		public static bool Intersects<T>(this uint mask1, T mask2) where T : Enum
		{
			return (mask1 & (int)(object)mask2) != 0;
		}

		public static bool Intersects<T>(this T mask1, T mask2) where T : Enum
		{
			return ((int)(object)mask1 & (int)(object)mask2) != 0;
		}

#endregion

		/// <summary>
		/// Counts how many bits within an integer is set to 1.
		/// </summary>
		/// <param name="value">Integer to work with.</param>
		/// <returns>Number of set bits.</returns>
		public static int Count<T>(T t)
		{
			int value = (int)(object)t;

			int count = 0;
			while(value > 0)
			{
				count += value & 1;
				value >>= 1;
			}

			return count;
		}

		static bool IsPowerOfTwo(int n)
		{
			return (n > 0 && ((n & (n - 1)) == 0)) ? true : false;
		}

		// Returns position of the only set bit in 'n' 
		public static int Position(int n)
		{
			if(!IsPowerOfTwo(n))
				return -1;

			int i = 1, pos = 1;

			// Iterate through bits of n till we find a set bit 
			// i&n will be non-zero only when 'i' and 'n' have a set bit 
			// at same position 
			while((i & n) == 0)
			{
				// Unset current bit and set the next bit in 'i' 
				i = i << 1;

				// increment position 
				++pos;
			}

			return pos;
		}



		//public static int Position<T>(T t)
		//{
		//	int value = (int)(object)t;
		//	int count = 0;
		//	while (value != 0)
		//	{
		//		count++;
		//		value >>=  1;
		//	}
		//	return count;
		//}


		public static bool TestOne<A, B>(this A t, B position)
		{
			int value = (int)(object)t;

			return ((value >> (int)(object)position) & 1) == 1;
		}

		public static T SetOne<T>(this T t, int position)
		{
			int value = (int)(object)t;
			value |= 1 << position;
			return (T)(object)value;
		}

		public static T ClearOne<T>(this T t, int position)
		{
			int value = (int)(object)t;
			value &= ~(1 << position);
			return (T)(object)value;
		}

		public static T ToggleOne<T>(this T t, int position)
		{
			int value = (int)(object)t;
			value ^= 1 << position;
			return (T)(object)value;
		}
	}

	public interface IFlagged<T> where T : Enum
	{ 
		T Flags { get; set; }
	}

	public static class FlaggedUtils
	{
		public static bool TestFlags<T>(this IFlagged<T> flagged, T flags) where T : Enum
		{
			return flagged.Flags.Intersects(flags);
		}

		public static void ClearFlags<T>(this IFlagged<T> flagged, T flags) where T : Enum
		{
			flagged.Flags = flagged.Flags.AND_NOT(flags);
		}

		public static void SetFlags<T>(this IFlagged<T> flagged, T flags) where T : Enum
		{
			flagged.Flags = flagged.Flags.OR(flags);
		}
	}
}