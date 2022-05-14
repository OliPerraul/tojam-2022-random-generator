using System;

namespace Cirrus
{
	public static class FuncUtils
	{
		public static T As<T>(
			this object obj,
			Action<T> updateFunc = null)
		{
			if(typeof(T).IsAssignableFrom(obj.GetType()))
			{
				updateFunc?.Invoke((T)obj);
				return (T)obj;
			}
			return default(T);
		}

		public static bool IsAssignableFrom<T>(
			this object obj,
			out T objectOfType
			)
		{
			objectOfType = default;
			if (typeof(T).IsAssignableFrom(obj.GetType()))
			{
				objectOfType = (T)obj;
				return true;
			}

			return false;			
		}

		public static bool IsAssignableFrom<T>(this object obj)
		{			
			if (typeof(T).IsAssignableFrom(obj.GetType()))
			{				
				return true;
			}

			return false;
		}

		// Similar to GML "with" keyword
		public static T Return<T>(
			this object obj,
			Func<T, T> updateFunc = null)
		{
			if(obj is T)
			{
				return updateFunc.Invoke((T)obj);
			}

			return default(T);
		}

		public static ReturnType Return<T, ReturnType>(
			this object obj,
			Func<T, ReturnType> updateFunc)
		{
			if(obj is T)
			{
				return updateFunc.Invoke((T)obj);
			}

			return default(ReturnType);
		}

		public static T Out<T>(
			this T ret,
			out T value)
		{
			value = ret;
			return ret;
		}

		public static T Do<T>(
			this Func<T> invoke)
			where T : class
		{
			return invoke?.Invoke();
		}

		public static T Do<T>(
			this T instance,
			Action<T> updateFunc = null)
		{
			updateFunc?.Invoke(instance);
			return instance;
		}

		public static T Do<T>(
			this T instance,
			Func<T, T> updateFunc = null)
		{
			return updateFunc.Invoke(instance);
		}

		public static T New<T>(Action<T> invoke)
			where T : new()
		{
			var inst = new T();
			invoke(inst);
			return inst;
		}
	}
}