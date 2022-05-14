using UnityEngine;

namespace Cirrus.Collections
{

	[System.Serializable]
	public class SerializablePair<A, B>
	{
		[SerializeField]
		private A _first;

		public A First => _first;

		[SerializeField]
		private B _second;

		public B Second => _second;
	}
}