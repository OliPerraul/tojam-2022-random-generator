////using Cirrus.DH.Objects.Collectibles;
////using Cirrus.Unity.Animations;

////using Cirrus.Unity.Numerics;
//using System.Collections.Generic;
//using UnityEngine;

//namespace Cirrus.Randomness
//{
//	public interface IRandomizationEntryBase<T>
//	{
//		float Weight { get; }

//		List<T> Evaluate();

//		IEnumerable<T> Flattened { get; }
//	}

//	public interface IRandomizationEntry<T> : IRandomizationEntryBase<T>
//	{
//		T Entry { get; }

//		int Amount { get; }
//	}

//	public interface ICompositeRandomization<T> : IRandomizationEntryBase<T>
//	{
//		List<IRandomizationEntryBase<T>> Entries { get; }
//	}

//	public interface IRandomization<T> : IRandomizationEntryBase<T>
//	{
//		int NumRandomIterations { get; }

//		// Declining curve to determined chance of dropping successive items
//		AnimationCurve RandomSuccessRegression { get; }

//		List<IRandomizationEntryBase<T>> Entries { get; }
//	}
//}
