//using Cirrus.DH.Objects.Collectibles;
//using Cirrus.Unity.Animations;

using Cirrus.Randomness;
//using Cirrus.Unity.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace Cirrus.Unity.Randomness
{
	public class CompositeRandomizationComponent<T>
		: RandomizationEntryComponentBase<T>
	{
		public virtual List<RandomizationEntryComponentBase<T>> Entries { get; } = new List<RandomizationEntryComponentBase<T>>();

		public override IEnumerable<T> Flattened => Entries.SelectMany(x => x.Flattened);

		public override List<T> Evaluate()
		{
			return this.EvaluateHelper();
		}
	}
}
