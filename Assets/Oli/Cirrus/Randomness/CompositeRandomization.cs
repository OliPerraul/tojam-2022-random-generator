//using Cirrus.DH.Objects.Collectibles;
//using Cirrus.Unity.Animations;

using System.Collections;
//using Cirrus.Unity.Numerics;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Cirrus.Randomness
{
	public abstract class RandomizationEntryBase<T>
		: IRandomizationEntryBase<T>
	{
		public float Weight { get; set; } = 1;

		public abstract List<T> Evaluate();

		public virtual IEnumerable<T> Flattened { get; set; }
	}

	public class RandomizationEntry<T>
		: RandomizationEntryBase<T>
		, IRandomizationEntry<T>
	{
		private T _entry = default(T);
		public T Entry
		{
			get => _entry; set
			{
				_entry = value;
				Flattened = new List<T> { value };
			}
		}

		public static implicit operator RandomizationEntry<T>(T entry)
		{
			return new RandomizationEntry<T>
			{
				Entry = entry
			};
		}

		public int Amount { get; set; } = 1;

		public override List<T> Evaluate()
		{
			return this.EvaluateHelper();
		}
	}

	public class CompositeRandomization<T>
		: RandomizationEntryBase<T>
		, ICompositeRandomization<T>
		, ICollection<T>
	{
		public List<IRandomizationEntryBase<T>> Entries { get; set; } = new List<IRandomizationEntryBase<T>>();

		public override IEnumerable<T> Flattened => Entries.SelectMany(x => x.Flattened);

		public int Count => Entries.Count;

		public bool IsReadOnly => true;

		public void Add(float weight, T item)
		{
			Entries.Add(new RandomizationEntry<T>
			{
				Entry = item,
				Weight = weight
			});
		}

		public void Add(T item)
		{
			Entries.Add(new RandomizationEntry<T>
			{
				Entry = item,
				Weight = 1f
			});
		}

		public void Add(RandomizationEntry<T> item)
		{
			Entries.Add(item);
		}

		public void Add(Randomization<T> item)
		{
			Entries.Add(item);
		}


		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public override List<T> Evaluate()
		{
			return this.EvaluateHelper();
		}

		public IEnumerator<T> GetEnumerator()
		{
			return Flattened.GetEnumerator();
		}

		public bool Remove(T item)
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return Flattened.GetEnumerator();
		}
	}

	public class Randomization<T>
		: RandomizationEntryBase<T>
		, IRandomization<T>
		, ICollection<T>
	{
		[SerializeField]
		public int NumRandomIterations { get; set; } = 1;

		// Declining curve to determined chance of dropping successive items
		public AnimationCurve RandomSuccessRegression { get; set; }

		[SerializeField]
		public List<IRandomizationEntryBase<T>> Entries { get; set; } = new List<IRandomizationEntryBase<T>>();

		public override IEnumerable<T> Flattened => Entries.SelectMany(x => x.Flattened);


		public override List<T> Evaluate()
		{
			return this.EvaluateHelper();
		}

		public int Count => Entries.Count;

		public bool IsReadOnly => true;

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return Flattened.GetEnumerator();
		}

		public bool Remove(T item)
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return Flattened.GetEnumerator();
		}
	}
}
