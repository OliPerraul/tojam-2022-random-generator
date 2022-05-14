using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Numerics
{

	public static class NumericUtils
	{
		//public const float Half = 180f;		

		public static float EaseSinInOut(this float lerp, float start, float change)
		{
			return -change / 2 * (Mathf.Cos(Mathf.PI * lerp) - 1) + start;
		}

		public static bool Almost(this float val, float other = 0, float tolerance = 0.1f)
		{			
			return (val - other) < 0 ? -(val - other) < tolerance : (val - other) < tolerance;
		}

		public static float Normalize(this float value, float min, float max, float zero)
		{
			if(zero < min)
				zero = min;
			// Prevent NaN/Inf from dividing 0 by something.
			if(Mathf.Approximately(value, min))
			{
				if(min < zero)
					return -1f;
				return 0f;
			}
			var percentage = (value - min) / (max - min);
			if(min < zero)
				return 2 * percentage - 1;
			return percentage;
		}

		public static float DeadZone(this float value, float min, float max)
		{
			var absValue = Mathf.Abs(value);
			if(absValue < min)
				return 0;
			if(absValue > max)
				return Mathf.Sign(value);

			return Mathf.Sign(value) * ((absValue - min) / (max - min));
		}

		public static int Log2(this int value)
		{
			int i;
			for(i = -1; value != 0; i++)
				value >>= 1;

			return (i == -1) ? 0 : i;
		}

		// https://www.geeksforgeeks.org/highest-power-2-less-equal-given-number/
		public static int HighestPowerOf2(this int n)
		{
			return Log2(n & (~(n - 1)));
		}

		public static bool IsPowerOfTwo(this int x)
		{
			// x will check if x == 0 and !(x & (x - 1)) will check if x is a power of 2 or not
			return (
				x != 0 &&
				(x & (x - 1)) == 0); // renmoves the lat bit set and checks
		}

		public static int Mod(this int x, int m)
		{
			return (x % m + m) % m;
		}

		public static int Wrap(this int x, int xMin, int xMax)
		{
			if(xMin == xMax)
				return xMin;

			else if(xMax == xMin + 1)
				return xMin;

			else if(x < xMin)
				return xMax - (xMin - x) % (xMax - xMin);

			else return xMin + (x - xMin) % (xMax - xMin);

		}

		public static float Wrap(this float x, float xMin, float xMax)
		{
			if (xMin == xMax)
				return xMin;

			else if (xMax == xMin + 1)
				return xMin;

			else if (x < xMin)
				return xMax - (xMin - x) % (xMax - xMin);

			else return xMin + (x - xMin) % (xMax - xMin);

		}

		public static int Sign(this float x)
		{
			if(x < 0) return -1;
			else if(x > 0) return 1;
			else return 0;
		}

		public static int Sign(this int x)
		{
			if(x < 0) return -1;
			else if(x > 0) return 1;
			else return 0;
		}

		public static int Clamp(this int x, int x_min, int x_max)
		{
			if(x < x_min) return x_min;
			else if(x >= x_max) return x_max;
			else return x;
		}
		public static float Clamp(this float x, float x_min, float x_max)
		{
			if(x < x_min) return x_min;
			else if(x >= x_max) return x_max;
			else return x;
		}


		// TODO more operator
		public static IEnumerable<float> Accumulate(this IEnumerable<float> list)
		{
			//'Return running totals'
			//# accumulate([1,2,3,4,5]) --> 1 3 6 10 15
			//# accumulate([1,2,3,4,5], initial=100) --> 100 101 103 106 110 115
			//# accumulate([1,2,3,4,5], operator.mul) --> 1 2 6 24 120

			float sum = 0;
			List<float> nlist = new List<float>();
			foreach(var x in list)
			{
				sum += x;
				nlist.Add(sum);
			}

			return nlist;
		}

	}


	[Serializable]
	public class Transformation
	{
		[SerializeField]
		public Vector3 Position { get; set; }

		[SerializeField]
		public Quaternion Rotation { get; set; }

		[SerializeField]
		public Vector3 Scale { get; set; }

	}
}