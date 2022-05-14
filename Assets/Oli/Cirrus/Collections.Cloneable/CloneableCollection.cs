using Cirrus.Objects;
using System.Collections;
using System.Collections.Generic;

namespace Cirrus.Collections
{
	// NOTE: otherwise we  might lose info such as repeated etc. when cloning.
	public interface ICloneableStream<T>
	: IEnumerable<T>
	// , IRealizablePrototype
	{
	}


	public abstract class CloneableStreamBase<T>
		: Base
		, ICloneableStream<T>
		// where T 
		// : IRealizablePrototype
		, ICopiableObject
	{
		public object[] RealizeStepCbs { get; set; }

		public object ProtoData { get; set; }

		public object ProxyCb { get; set; }

		public bool IsRealizable { get; set; } = false;

		object ICopiableObject.MemberwiseCopy()
		{
			return MemberwiseClone();
		}


		public object Clone()
		{
			return _Clone();
		}

		protected abstract CloneableStreamBase<T> _Clone();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public abstract IEnumerator<T> GetEnumerator();
	}

	public abstract class CloneableCollectionBase<T>
		: CloneableStreamBase<T>
		, ICollection<T>
		where T : ICopiableObject
	{
		public abstract int Count { get; }
		public abstract bool IsReadOnly { get; }

		public abstract void Add(T item);
		public abstract void Clear();
		public abstract bool Contains(T item);
		public abstract void CopyTo(T[] array, int arrayIndex);
		//public abstract IEnumerator<T> GetEnumerator();
		public abstract bool Remove(T item);
	}
}
