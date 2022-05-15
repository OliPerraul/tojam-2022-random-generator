
//using Cirrus.Collections;
//using Cirrus.Randomness;
//using Cirrus.Unity.Objects;
////using Cirrus.Unity.Numerics;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;

//namespace Cirrus.Unity.Randomness
//{
//	public static class RandomizationUtils
//	{
//		public static System.Collections.Generic.List<T> EvaluateHelper<T>(
//			this RandomizationEntryComponent<T> distrib)
//		{
//			int n = distrib.Amount;
//			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>().Resize(n, default(T));
//			for (int i = 0; i < n; i++) evaluated[i] = distrib.Entry;
//			return evaluated;
//		}

//		public static System.Collections.Generic.List<T> EvaluateHelper<T>(
//		this RandomizationEntryAsset<T> distrib)
//		{
//			int n = distrib.Amount;
//			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>().Resize(n, default(T));
//			for (int i = 0; i < n; i++) evaluated[i] = distrib.Entry;
//			return evaluated;
//		}



//		public static System.Collections.Generic.List<T> EvaluateHelper<T>(
//			this CompositeRandomizationComponent<T> distrib)
//		{
//			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>();
//			for (int i = 0; i < distrib.Entries.Count; i++)
//			{
//				evaluated.AddRange(distrib.Entries[i].Evaluate());
//			}

//			return evaluated;
//		}

//		public static System.Collections.Generic.List<T> EvaluateHelper<T>(
//		this CompositeRandomizationAsset<T> distrib)
//		{
//			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>();
//			for (int i = 0; i < distrib.Entries.Count; i++)
//			{
//				evaluated.AddRange(distrib.Entries[i].Evaluate());
//			}

//			return evaluated;
//		}

//		public static System.Collections.Generic.List<T> EvaluateHelper<T>(
//			this RandomizationComponent<T> distrib)
//		{
//			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>();

//			if (distrib.Entries.Count == 0) return evaluated;

//			int numRandomIterations = distrib.NumRandomIterations;
//			for (int i = 0; i < numRandomIterations; i++)
//			{
//				float progress = (float)i / (float)numRandomIterations;
//				float point = distrib.RandomSuccessRegression.Evaluate(progress);
//				if (Cirrus.Randomness.RandomUtils.NextFloat() < point)
//				{
//					RandomizationEntryComponentBase<T> choice = distrib.Entries.Choice(distrib.Entries.Select(x => x.Weight));
//					evaluated.AddRange(choice.Evaluate());
//				}
//				else break;
//			}

//			return evaluated;
//		}

//		public static System.Collections.Generic.List<T> EvaluateHelper<T>(
//			this RandomizationAsset<T> distrib)
//		{
//			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>();

//			if (distrib.Entries.Count == 0) return evaluated;

//			int numRandomIterations = distrib.NumRandomIterations;
//			for (int i = 0; i < numRandomIterations; i++)
//			{
//				float progress = (float)i / (float)numRandomIterations;
//				float point = distrib.RandomSuccessRegression.Evaluate(progress);
//				if (Cirrus.Randomness.RandomUtils.NextFloat() < point)
//				{
//					RandomizationEntryAssetBase<T> choice = distrib.Entries.Choice(distrib.Entries.Select(x => x.Weight));
//					evaluated.AddRange(choice.Evaluate());
//				}
//				else break;
//			}

//			return evaluated;
//		}

//		public static System.Collections.Generic.List<T> FlattenHelper<T>(
//			this RandomizationEntryComponent<T> distrib)
//		{
//			int n = distrib.Amount;
//			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>().Resize(n, default(T));
//			for (int i = 0; i < n; i++) evaluated[i] = distrib.Entry;
//			return evaluated;
//		}


//		public static System.Collections.Generic.List<T> FlattenHelper<T>(
//			this RandomizationEntryAsset<T> distrib)
//		{
//			int n = distrib.Amount;
//			System.Collections.Generic.List<T> evaluated = new System.Collections.Generic.List<T>().Resize(n, default(T));
//			for (int i = 0; i < n; i++) evaluated[i] = distrib.Entry;
//			return evaluated;
//		}

//		public static System.Collections.Generic.List<T> FlattenHelper<T>(
//		this CompositeRandomizationComponent<T> distrib)
//		{
//			System.Collections.Generic.List<T> flatten = new System.Collections.Generic.List<T>();
//			for (int i = 0; i < distrib.Entries.Count; i++)
//			{
//				flatten.AddRange(distrib.Entries[i].Flattened);
//			}

//			return flatten;
//		}
//		public static System.Collections.Generic.List<T> FlattenHelper<T>(
//			this CompositeRandomizationAsset<T> distrib)
//		{
//			System.Collections.Generic.List<T> flatten = new System.Collections.Generic.List<T>();
//			for (int i = 0; i < distrib.Entries.Count; i++)
//			{
//				flatten.AddRange(distrib.Entries[i].Flattened());
//			}

//			return flatten;
//		}
//	}
//}


