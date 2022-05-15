using Cirrus.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Objects
{
	public interface IBase
	{
//#if DEVELOPMENT_BUILD || UNITY_EDITOR
		public int DebugId { get; set; }
//#endif
	}

	public abstract class Base : IBase, ICopiableObject
	{
		public static implicit operator HashSet<object>(Base res)
		{
			return new HashSet<object> { res };
		}

//#if DEVELOPMENT_BUILD || UNITY_EDITOR
		private static IEnumerator<int> _autoIds = EnumerableUtils.IntegersFrom(0).GetEnumerator();
		public static int GetNextID() => _autoIds.Next();

		[field:SerializeField]
		public int DebugId { get; set; } = _autoIds.Next();
//#endif

		public object MemberwiseCopy()
		{
			return MemberwiseClone();
		}
	}
}
