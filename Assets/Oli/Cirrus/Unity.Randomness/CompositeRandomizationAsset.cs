//using Cirrus.DH.Objects.Collectibles;
//using Cirrus.Unity.Animations;

using Cirrus.Randomness;
using Cirrus.Unity.Editor;
//using Cirrus.Unity.Numerics;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Cirrus.Unity.Randomness
{
	public class CompositeRandomizationAsset<T>
		: RandomizationEntryAssetBase<T>
	{		
		[field: SerializeField]
		[field: SerializeEmbedded]
		public virtual List<RandomizationEntryAssetBase<T>> Entries { get; set; }

		public override IEnumerable<T> Flattened() => Entries.SelectMany(x => x.Flattened());

		public override List<T> Evaluate()
		{
			return this.EvaluateHelper();
		}
	}
}
