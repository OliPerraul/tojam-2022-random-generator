﻿using System.Collections.Concurrent;

namespace Cirrus.Collections
{
	public interface IPoolable { }

	public interface IPoolableSource<B> where B : IPoolable
	{
		B Create();

		void Recycle(B b);
	}

	public class Pool<PoolableSourceType, PoolableType>
		where PoolableSourceType : IPoolableSource<PoolableType>
		where PoolableType : IPoolable
	{
		private readonly ConcurrentBag<PoolableType> _items = new ConcurrentBag<PoolableType>();
		private int _counter = 0;
		private int _max = 10;

		private PoolableSourceType _source;

		public Pool(
			PoolableSourceType source,
			int max = 10)
		{
			_source = source;
			_max = max;
		}

		public void Release(PoolableType item)
		{
			if(_counter < _max)
			{
				_items.Add(item);
				_counter++;
			}
		}

		public PoolableType Get()
		{
			PoolableType item;
			if(_items.TryTake(out item))
			{
				_counter--;
				return item;
			}
			else
			{
				PoolableType obj = _source.Create();
				_items.Add(obj);
				_counter++;
				return obj;

			}
		}
	}



	public class Pool<PoolableType> where PoolableType : IPoolable
	{
		private readonly ConcurrentBag<PoolableType> _items = new ConcurrentBag<PoolableType>();
		private int _counter = 0;
		private int _max = 10;

		public Pool(
			int max = 10)
		{
			_max = max;
		}

		public void Release(PoolableType item)
		{
			if(_counter < _max)
			{
				_items.Add(item);
				_counter++;
			}
		}

		public PoolableType Get<PoolableSourceType>(PoolableSourceType source) where PoolableSourceType : IPoolableSource<PoolableType>
		{
			PoolableType item;
			if(_items.TryTake(out item))
			{
				source.Recycle(item);
				_counter--;
				return item;
			}
			else
			{
				PoolableType obj = source.Create();
				_items.Add(obj);
				_counter++;
				return obj;

			}
		}
	}



	public class BasicPool<A> where A : new()
	{
		private readonly ConcurrentBag<A> _items = new ConcurrentBag<A>();
		private int _counter = 0;
		private int _max = 10;

		public BasicPool(
			int max = 10)
		{
			_max = max;
		}

		public void Release(A item)
		{
			if(_counter < _max)
			{
				_items.Add(item);
				_counter++;
			}
		}

		public A Get()
		{
			A item;
			if(_items.TryTake(out item))
			{
				_counter--;
				return item;
			}
			else
			{
				A obj = new A();
				_items.Add(obj);
				_counter++;
				return obj;
			}
		}
	}
}