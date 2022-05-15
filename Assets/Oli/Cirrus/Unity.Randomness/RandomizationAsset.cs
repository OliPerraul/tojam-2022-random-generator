////using Cirrus.DH.Objects.Collectibles;
////using Cirrus.Unity.Animations;

//using Cirrus.Randomness;
//using Cirrus.Unity.Editor;
////using Cirrus.Unity.Numerics;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;

//namespace Cirrus.Unity.Randomness
//{
//	public class RandomizationAsset<T>
//		: RandomizationEntryAssetBase<T>
//	{
//		[field: SerializeField]
//		public virtual int NumRandomIterations { get; set; } = 1;

//		// Declining curve to determined chance of dropping successive items
//		[field: SerializeField]
//		public virtual AnimationCurve RandomSuccessRegression { get; set; }


//		[field: SerializeEmbedded]
//		[field: SerializeField]
//		public virtual List<RandomizationEntryAssetBase<T>> Entries { get; set; }


//		public override IEnumerable<T> Flattened() => Entries.SelectMany(x => x.Flattened());

//		public override List<T> Evaluate()
//		{
//			return this.EvaluateHelper();
//		}
//	}
//}
