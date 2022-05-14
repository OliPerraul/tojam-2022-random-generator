using Cirrus.Collections;
using System;
using System.Collections.Generic;

namespace Cirrus.Objects
{
	public struct None { }

	public struct __ { }

	public interface IReadOnlyCandidate
	{
		public bool IsReadOnlyObject { get; set; }
	}

	public interface ICopiableObject
	{
		public object MemberwiseCopy();
	}

	public interface ICopiablePrototype : ICopiableObject, IBase
	{ 
	}

	public static class ObjectUtils
	{
		private static class _Empty<T> where T : new()
		{
			public static T _instance = new T();
		}

		public static T Empty<T>() where T : new()
		{
			if (typeof(IReadOnlyCandidate).IsAssignableFrom(_Empty<T>._instance.GetType()))
			{
				((IReadOnlyCandidate)_Empty<T>._instance).IsReadOnlyObject = true;
			}
			return _Empty<T>._instance;
		}

		public static T ConvertObject<T>(this object input)
		{
			return (T)Convert.ChangeType(input, typeof(T));
		}

		//public static int ComputeHash(this INameHash instance, bool force = false)
		//{
		//	return force || instance.Hash == -1 ?
		//		instance.Hash = CryptoUtils.HashCode(instance.Name + instance.Salt) :
		//		instance.Hash;
		//}

		public static T Copy<T>(this ICopiableObject copiable)
			where T : IBase
		{
			var copy = (T)(object)copiable.MemberwiseCopy();
			copy.DebugId = Base.GetNextID();
			return copy;
		}

		public static ICopiablePrototype Copy(this ICopiablePrototype copiable)
		{
			var copy = (ICopiablePrototype)copiable.MemberwiseCopy();
			copy.DebugId = Base.GetNextID();
			return copy;
		}
	}
}
