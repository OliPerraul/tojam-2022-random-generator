//using Cirrus.DH.Objects.Collectibles;
//using Cirrus.Unity.Animations;

using Cirrus.Randomness;
using Cirrus.Unity.Objects;
//using Cirrus.Unity.Numerics;
using System.Collections.Generic;

namespace Cirrus.Unity.Randomness
{
	public abstract class RandomizationEntryComponentBase<T>
		: MonoBehaviourBase
	{
		public virtual float Weight { get; } = 1;

		public virtual IEnumerable<T> Flattened { get; set; }

		public abstract List<T> Evaluate();
	}

	public class RandomizationEntryComponent<T>
		: RandomizationEntryComponentBase<T>
	{
		public virtual T Entry { get; }

		public override IEnumerable<T> Flattened => new T[] { Entry };

		public virtual int Amount { get; } = 1;

		public override List<T> Evaluate()
		{
			return this.EvaluateHelper();
		}
	}
}
