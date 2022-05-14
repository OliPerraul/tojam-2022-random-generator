using System;
using UnityEngine;

namespace Cirrus.Unity.Numerics
{
	[Serializable]
	public class Total
	{
		[SerializeField]
		private float _current;
		public float Current
		{
			get => _current;
			set
			{
				_current = value;
				if(_current < 0) _current = 0;
				else if(_current > Amount) _current = Amount;
			}
		}


		[SerializeReference]
		public float Amount;

		//  For example 3/4 and 6/8 might be considered different fractions which represent the same ratio.
		//  You might also run across phrases like "when dividing two complex numbers,
		//  first write the ratio as a fraction with a real denominator."
		public float Ratio => Current / Amount;

		public static implicit operator int(Total i) => i.Current.Round();

		public static implicit operator float(Total f) => f.Current;

		public static implicit operator double(Total d) => d.Current;

		public static implicit operator Total(double d) => new Total(Convert.ToSingle(d));

		public static implicit operator Total(float f) => new Total(f);

		public static implicit operator Total(int i) => new Total(i);

		public static implicit operator Total(Range_ range) => new Total(range);

		public Total(float amount)
		{
			Current = amount;
			Amount = amount;
		}

		public Total(float current, float amount)
		{
			Current = current;
			Amount = amount;
		}
	}
}
