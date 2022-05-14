//using Cirrus.DH.Objects.Collectibles;
//using Cirrus.Unity.Animations;

using Cirrus.Collections;
using System;
//using Cirrus.Unity.Numerics;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Cirrus.Randomness
{
	public interface IRandomEntry
	{
		float Probability { get; }
	}

	public static class RandomUtils
	{
		private static System.Random random = new System.Random();//(GenerateSeed());

		public static IEnumerable<float> RandomStream()
		{
			while(true)
			{
				yield return UnityEngine.Random.value;
			}
		}

		public static IEnumerable<float> PerlinNoiseStream(Vector2 step)
		{
			Vector2 position = Vector2.zero;

			while(true)
			{
				yield return Mathf.PerlinNoise(position.x, position.y);
				position += step;
			}
		}

		public static IEnumerable<float> PerlinNoiseStream(float step = 1)
		{
			Vector2 step_ = new Vector2(step, step);
			Vector2 position = new Vector2();

			while(true)
			{
				yield return Mathf.PerlinNoise(position.x, position.y);
				position += step_;
			}
		}

		public static float PerlinNoise(Vector2 position)
		{
			return Mathf.PerlinNoise(position.x, position.y);
		}

		public static int NextInt(int max)
		{
			return random.Next(max);
		}

		public static float NextFloat()
		{
			return (float)NextDouble();
		}

		public static double NextDouble()
		{
			return random.NextDouble();
		}

		// Return an element chosen from the population with the given weights.
		public static T Choice<T>(
			this ICollection<T> population,
			IEnumerable<float> weights)
		{
			float[] weightsArray = weights.ToArray();
			T[] populationArray = Enumerable.ToArray(population);
			Tuple<T, float>[] weightedItems = new Tuple<T, float>[population.Count];
			for(int i = 0; i < population.Count; i++) weightedItems[i] = new Tuple<T, float>(populationArray[i], weightsArray[i]);

			weightedItems = Enumerable.ToArray(weightedItems.OrderBy(x => x.Item2));
			weightsArray = Enumerable.ToArray(weightsArray.OrderBy(x => x));

			//var random = this.random;
			int n = population.Count;
			float[] cummulativeWeights = Numerics.NumericUtils.Accumulate(weightsArray).ToArray();

			float total = cummulativeWeights.Last() + 0.0f;
			//if (total <= 0.0) DebugUtils.Assert(total <= 0.0, "Total of weights must be greater than zero");

			var hi = n - 1;
			int bisection = ArrayUtils.Bisect(
				cummulativeWeights,
				NextFloat() * total,
				0,
				hi);

			return weightedItems[bisection].Item1;
		}
	}
}
