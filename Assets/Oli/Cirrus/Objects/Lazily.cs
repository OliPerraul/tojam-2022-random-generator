// Allow text management via json

using System;
using System.Threading;

using Cirrus.Content;

namespace Cirrus.Objects
{
	//public class Lazily_<T>
	//	: IResourceProvider<T>
	//	, IIDed
	//	where T : IIDed
	//{
	//	private Lazy<T> _lazy;

	//	public T Resource => _lazy.Value;

	//	public object Object => Resource;

	//	public int ID { get; set; }

	//	public Lazily_(Func<T> valueFactory)
	//	{
	//		_lazy = new Lazy<T>(() =>
	//		{
	//			T value = valueFactory();
	//			value.ID = ID;
	//			return value;
	//		});				
	//	}		

	//	// Ctors removed for brevity

	//	/// <summary>
	//	/// Cast the <see cref="LazyBase{T}"/> to it's contained <typeparamref name="T"/>
	//	/// </summary>
	//	/// <param name="lazy">The lazy to cast.</param>
	//	/// <returns>The instance of <see cref="LazyBase{T}.Value"/></returns>
	//	public static implicit operator T(Lazily_<T> lazy)
	//	{			
	//		return lazy.Resource;
	//	}

	//	public static implicit operator Lazily_<T>(Func<T> lazy)
	//	{
	//		return new Lazily_<T>(lazy);
	//	}
	//}

	public class Lazily<T>
	: Lazy<T>
	//, IProvider<T>
	where T : new()
	{
		public T Object => Value;

		public object RawObject => Object;

		public Lazily() : base()
		{
		}

		public Lazily(
			bool isThreadSafe)
			: base(isThreadSafe)
		{
		}

		public Lazily(
			Func<T> valueFactory)
			: base(valueFactory)
		{
		}

		public Lazily(
			LazyThreadSafetyMode mode)
			: base(mode)
		{
		}

		public Lazily(
			Func<T> valueFactory,
			bool isThreadSafe)
			: base(
				  valueFactory,
				  isThreadSafe)
		{
		}

		public Lazily(
			Func<T> valueFactory,
			LazyThreadSafetyMode mode)
			: base(
				  valueFactory,
				  mode)
		{
		}

		// Ctors removed for brevity

		/// <summary>
		/// Cast the <see cref="LazyBase{T}"/> to it's contained <typeparamref name="T"/>
		/// </summary>
		/// <param name="lazy">The lazy to cast.</param>
		/// <returns>The instance of <see cref="LazyBase{T}.Value"/></returns>
		public static implicit operator T(Lazily<T> lazy)
		{
			return lazy.Object;
		}

		public static implicit operator Lazily<T>(Func<T> lazy)
		{
			return new Lazily<T>(lazy);
		}

		public static implicit operator Lazily<T>(Action<T> action)
		{
			return new Lazily<T>(() =>
			{
				var result = new T();
				action(result);
				return result;
			});
		}

	}

	//public class Lazily<A>
	//	: IResourceProvider<A>
	//{
	//	public A Input { get; set; }

	//	private Lazily<A> _lazy = null;

	//	public object Object => _lazy.Object;

	//	public A Resource => _lazy.Resource;

	//	public virtual Func<A> ValueCb
	//	{
	//		set => _lazy = new Lazily<A>(value);
	//	}


	//	public Lazily() : base()
	//	{
	//	}

	//	public Lazily(Func<A> valueFactory)
	//	{
	//		_lazy = new Lazily<A>(valueFactory);
	//	}

	//}

	//public class Lazily<A, B>
	//	: IResourceProvider<B>
	//{
	//	public A Input { get; set; }

	//	private Lazily<B> _lazy = null;

	//	public object Object => _lazy.Object;

	//	public B Resource => _lazy.Resource;

	//	public Lazily() : base()
	//	{
	//	}

	//	public Lazily(Func<A, B> valueFactory)
	//	{
	//		_lazy = new Lazily<B>(() => valueFactory(Input));
	//	}

	//	public Lazily(A input, Func<A, B> valueFactory)
	//	{
	//		Input = input;
	//		_lazy = new Lazily<B>(() => valueFactory(Input));
	//	}

	//	public static implicit operator B(Lazily<A, B> lazy)
	//	{
	//		return lazy.Resource;
	//	}

	//	public static implicit operator Lazily<A, B>(Func<A,B> lazy)
	//	{
	//		return new Lazily<A, B>(lazy);
	//	}
	//}

	public static class LazyUtils
	{
		// Becase casting lambdas does not work for some reaosn
		//public static Lazily<T> Lazily<T>(Action<T> invoke) where T : new()
		//{
		//	return new Lazily<T>(
		//		() => new T(),
		//		invoke);
		//}

		//public static Lazily<T> Lazily<T>(
		//	Func<T> factory,
		//	Action<T> invoke = null)
		//{
		//	return new Lazily<T>(factory, invoke);
		//}


	}
}
