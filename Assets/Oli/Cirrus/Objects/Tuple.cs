using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

using Cirrus.Collections;
using Cirrus.Objects;
using Cirrus.Debugging;
using Cirrus.Unity;

using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using static UnityEngine.ParticleSystem;
using Cirrus.Unity.Objects;
using Cirrus.Unity.Numerics;
using static Cirrus.Debugging.DebugUtils;
using UnityEngine.UIElements;
using System;
using Random = UnityEngine.Random;

namespace Cirrus.Objects
{
	[Serializable]
	public class SerializableTuple<T1>
	{
		public T1 Field1;

		public static implicit operator SerializableTuple<T1>(Tuple<T1> tuple)
		{
			return new SerializableTuple<T1>
			{
				Field1 = tuple.Item1,
				//Item2 = tuple.Item2,
				//Item3 = tuple.Item3,
				//Item4 = tuple.Item4,
			};
		}

	}

	[Serializable]
	public class SerializableTuple<T1, T2>
	{
		public T1 Field1;

		public T2 Field2;

		public static implicit operator SerializableTuple<T1, T2>(Tuple<T1, T2> tuple)
		{
			return new SerializableTuple<T1, T2>
			{
				Field1 = tuple.Item1,
				Field2 = tuple.Item2,
				//Item3 = tuple.Item3,
				//Item4 = tuple.Item4,
			};
		}
	}

	[Serializable]
	public class SerializableTuple<T1, T2, T3>
	{
		public T1 Field1;

		public T2 Field2;

		public T3 Field3;

		public static implicit operator SerializableTuple<T1, T2, T3>(Tuple<T1, T2, T3> tuple)
		{
			return new SerializableTuple<T1, T2, T3>
			{
				Field1 = tuple.Item1,
				Field2 = tuple.Item2,
				Field3 = tuple.Item3,
			};
		}
	}	

	[Serializable]
	public class SerializableTuple<T1, T2, T3, T4>
	{
		public T1 Field1;

		public T2 Field2;

		public T3 Field3;

		public T4 Field4;

		public static implicit operator SerializableTuple<T1, T2, T3, T4>(Tuple<T1, T2, T3, T4> tuple)
		{
			return new SerializableTuple<T1, T2, T3, T4>
			{
				Field1 = tuple.Item1,
				Field2 = tuple.Item2,
				Field3 = tuple.Item3,
				Field4 = tuple.Item4,
			};
		}
	}
}
