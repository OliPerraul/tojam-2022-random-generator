//using Cirrus.DH.Objects.Collectibles;
//using Cirrus.Unity.Animations;

using Cirrus.Randomness;
using Cirrus.Unity.Editor;
using Cirrus.Unity.Objects;
//using Cirrus.Unity.Numerics;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Unity.Randomness
{
	public abstract class RandomizationEntryAssetBase<T>
		: ScriptableObjectBase
	{
		public virtual float Weight { get; } = 1;

		public abstract IEnumerable<T> Flattened();

		public abstract List<T> Evaluate();
	}

	public class RandomizationEntryAsset<T>
		: RandomizationEntryAssetBase<T>
	{
		[field: SerializeField]
		public virtual T Entry { get; set; }

		public override IEnumerable<T> Flattened() => new T[] { Entry };
		
		[field: SerializeField]
		public virtual int Amount { get; set; } = 1;

		public override List<T> Evaluate()
		{
			return this.EvaluateHelper();
		}
	}
}
