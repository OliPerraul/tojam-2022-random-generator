using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus
{
	public delegate void ArgsDelegate<T>(T value, params object[] args);

	//public delegate void Action();

	//public delegate void Action<T>(T value);

	//public delegate void Covariant<out T>(T value);

	//public delegate void Covariant<out T>(T value);

	//public delegate void Action<A, B>(A value1, B value2);

	//public delegate void Action<A, B, C>(A value1, B value2, C value3);

	//public delegate void Action<A, B, C, D>(A value1, B value2, C value3, D value4);

	[System.Serializable]
	public class Observable<T>
	{
		public Observable()
		{
			_value = default(T);
		}

		public Observable(T value)
		{
			_value = value;
		}

		public Action<T> OnValueChangedHandler;

		[SerializeField]
		private T _value;

		public T Value
		{
			get => _value;

			set
			{
				if(!EqualityComparer<T>.Default.Equals(_value, value))
				{
					Set(value);
					OnValueChangedHandler?.Invoke(_value);
				}
			}
		}


		public virtual void Set(T value, bool forceNotification = true)
		{
			_value = value;

			if(forceNotification) OnValueChangedHandler?.Invoke(value);
		}

	}

	[System.Serializable]
	public class ObservableInt : Observable<int> { }

	[System.Serializable]
	public class ObservableBool : Observable<bool> { }

	[System.Serializable]
	public class ObservableString : Observable<string> { }

	public static class EventUtils
	{
		public static bool MouseUp(int n)
		{
			return Event.current.type == EventType.MouseUp && Event.current.button == n;
		}

		public static bool MouseDown(int n)
		{
			return Event.current.type == EventType.MouseDown && Event.current.button == n;
		}

		public static bool MouseWheelUp()
		{
			return Event.current.type == EventType.ScrollWheel && Event.current.delta.y < 0;
		}

		public static bool MouseWheelDown()
		{
			return Event.current.type == EventType.ScrollWheel && Event.current.delta.y > 0;
		}
	}
}