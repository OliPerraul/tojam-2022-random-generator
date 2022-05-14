//using System;
//namespace Cirrus.Content
//{
//	public class Provider<T>
//	{
//		private Func<T> _providerFunc;

//		public T _object;

//		public T Object
//		{
//			get
//			{
//				if(_object == null) _object = _providerFunc();
//				return _object;
//			}
//		}

//		public static implicit operator T(Provider<T> d) => d.Object;

//		public Provider(Func<T> func)
//		{
//			_providerFunc = func;
//		}
//	}

//	public interface IProvider
//	{
//		object RawObject { get; }
//	}

//	public interface IProvider<T> : IProvider
//	{
//		T Object { get; }
//	}
//}
