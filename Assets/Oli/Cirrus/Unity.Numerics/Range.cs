using System;
using UnityEngine;

namespace Cirrus.Unity.Numerics
{
	public static class RangeUtils
	{
		public static float Lerp(this Range_ range, float t)
		{
			return  (1 - t) * range.Min + t * range.Max;
		}

		public static float InvLerp(this Range_ range, float t)
		{
			return (1 - t) * range.Max + t * range.Min;
		}

		public static float Clamp(this Range_ range, float value)
		{
			return Mathf.Clamp(value, range.Min, range.Max);
		}

		public static bool Contains(this Range_ range, float value)
		{
			return value >= range.Min && value < range.Max;
		}

		public static bool Contains(this Range_ range, int value)
		{
			return value >= range.Min && value < range.Max;
		}
		public static bool Contains(this RangeInt_ range, int value)
		{
			return value >= range.Min && value < range.Max;
		}

		public static float Average(this Range_ range)
		{
			return (range.Max + range.Min) / 2f;
		}

		public static float Random(this Range_ range)
		{
			return UnityEngine.Random.Range(range.Min, range.Max);
		}
		public static int Random(this RangeInt_ range)
		{
			return UnityEngine.Random.Range(range.Min, range.Max);
		}
	}

	// Replace with c# range..

	[Serializable]
	public struct Range_
	{
		[SerializeField]
		private float _min;

		[SerializeField]
		private float _max;

		public float Max => _max;

		public float Min => _min;

		public static implicit operator Range_(float b) => new Range_(b);

		public static implicit operator Range_(double d) => new Range_(Convert.ToSingle(d));

		public static implicit operator Range_(int b) => new Range_(b);


		public static implicit operator int(Range_ i) => Convert.ToInt32(i.Min);

		public static implicit operator float(Range_ f) => f.Min;

		public static implicit operator double(Range_ d) => d.Min;

		public static implicit operator Range_(Range d) => new Range_(d.Start.Value, d.End.Value);
		
		public Range_(
			float min,
			float max)
		{			
			_min = min;
			_max = max;
		}

		public Range_(
			double min,
			double max)
		{			
			_min = Convert.ToSingle(min);
			_max = Convert.ToSingle(max);
		}

		public Range_(float minMax)
		{
			_min = minMax;
			_max = minMax;
		}

		public Range_(int minMax)
		{
			_min = minMax;
			_max = minMax;
		}

		public Range_(Range_ range)
		{
			_min = range.Min;
			_max = range.Max;
		}
	}

	[Serializable]
	public struct RangeInt_
	{
		[SerializeField]
		private int _min;

		[SerializeField]
		private int _max;

		public int Max => _max;

		public int Min => _min;

		public static implicit operator RangeInt_(float b) => new RangeInt_(Convert.ToInt32(b));

		public static implicit operator RangeInt_(double d) => new RangeInt_(Convert.ToInt32(d));

		public static implicit operator RangeInt_(int b) => new RangeInt_(b);


		public static implicit operator int(RangeInt_ i) => Convert.ToInt32(i.Min);

		public static implicit operator float(RangeInt_ f) => f.Min;

		public static implicit operator double(RangeInt_ d) => d.Min;

		public RangeInt_(
			int min,
			int max
			)
		{
			_max = min;
			_min = max;
		}

		public RangeInt_(int minMax)
		{
			_max = minMax;
			_min = minMax;
		}
	}
}