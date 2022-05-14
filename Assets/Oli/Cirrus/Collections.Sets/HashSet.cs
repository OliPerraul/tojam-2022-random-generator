using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Collections
{
	public class HashSet_<T> : HashSet<T>
	{
		public HashSet_() : base() { }
		public HashSet_(IEnumerable<T> collection) : base(collection) { }
		public HashSet_(IEqualityComparer<T> comparer) : base(comparer) { }
		public HashSet_(int capacity) : base(capacity) { }
		public HashSet_(IEnumerable<T> collection, IEqualityComparer<T> comparer) : base(collection, comparer) { }
		public HashSet_(int capacity, IEqualityComparer<T> comparer) : base(capacity, comparer) { }
		protected HashSet_(SerializationInfo info, StreamingContext context) : base(info, context) { }

		public static HashSet_<T> operator +(HashSet_<T> left, HashSet_<T> right)
		{
			return new HashSet_<T> { left, right };
		}

		public static implicit operator HashSet_<T>(T item)
		{
			return new HashSet_<T> { item };

		}

		//public bool Intersects<T>(HashSet_<T> other)
		//{
		//	if (this == null) return false;
		//	if (other == null) return false;
		//	return this.Overlaps((HashSet<T>)other);
		//}

		//public bool Intersects<T>(T other)
		//{
		//	if (this == null) return false;
		//	if (other == null) return false;
		//	return this.Contains(other);
		//}

		//public static implicit operator HashSet_<T>(HashSet<T> item)
		//{
		//	return new HashSet_<T> { item };
		//}
	}
}
