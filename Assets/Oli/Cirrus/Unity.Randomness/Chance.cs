//using Cirrus.Unity.EditorExt;
using System;
using UnityEngine;

namespace Cirrus.Unity.Randomness
{
	public struct Chance
	{
		[SerializeField]
		[Range(0f, 1f)]
		public float Probability;

		public Chance(float probability = 0.5f)
		{
			Probability = probability;
		}
		public Chance(double probability)
		{
			Probability = Convert.ToSingle(probability);
		}

		public static implicit operator Chance(float prob)
		{
			return new Chance(prob);
		}

		public static implicit operator bool(Chance chance)
		{
			return chance.Result;
		}


		public bool Result => UnityEngine.Random.Range(0f, 1f) <= Probability;
	}
}
