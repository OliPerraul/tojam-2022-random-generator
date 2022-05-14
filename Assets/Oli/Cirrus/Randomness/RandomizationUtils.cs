//using Cirrus.DH.Objects.Collectibles;
//using Cirrus.Unity.Animations;

//using Cirrus.Unity.Numerics;
using Cirrus.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cirrus.Randomness
{
	public static class RandomizationUtils
	{
		public static System.Collections.Generic.List<T> EvaluateHelper<T>(
			this IRandomizationEntry<T> distrib)
		{
			int n = distrib.Amount;
			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>().Resize(n, default(T));
			for(int i = 0; i < n; i++) evaluated[i] = distrib.Entry;
			return evaluated;
		}

		public static System.Collections.Generic.List<T> EvaluateHelper<T>(
			this ICompositeRandomization<T> distrib)
		{
			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>();
			for(int i = 0; i < distrib.Entries.Count; i++)
			{
				evaluated.AddRange(distrib.Entries[i].Evaluate());
			}

			return evaluated;
		}

		public static System.Collections.Generic.List<T> EvaluateHelper<T>(
			this IRandomization<T> distrib)
		{
			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>();

			if(distrib.Entries.Count == 0) return evaluated;

			int numRandomIterations = distrib.NumRandomIterations;
			for(int i = 0; i < numRandomIterations; i++)
			{
				float progress = (float)i / (float)numRandomIterations;
				float point = distrib.RandomSuccessRegression.Evaluate(progress);
				if(RandomUtils.NextFloat() < point)
				{
					IRandomizationEntryBase<T> choice = distrib.Entries.Choice(distrib.Entries.Select(x => x.Weight));
					evaluated.AddRange(choice.Evaluate());
				}
				else break;
			}

			return evaluated;
		}


		public static System.Collections.Generic.List<T> FlattenHelper<T>(
			this IRandomizationEntry<T> distrib)
		{
			int n = distrib.Amount;
			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>().Resize(n, default(T));
			for(int i = 0; i < n; i++) evaluated[i] = distrib.Entry;
			return evaluated;
		}

		public static System.Collections.Generic.List<T> FlattenHelper<T>(
			this ICompositeRandomization<T> distrib)
		{
			System.Collections.Generic.List<T> flatten = new System.Collections.Generic.List<T>();
			for (int i = 0; i < distrib.Entries.Count; i++)
			{
				flatten.AddRange(distrib.Entries[i].Flattened);
			}

			return flatten;
		}
	}
}
