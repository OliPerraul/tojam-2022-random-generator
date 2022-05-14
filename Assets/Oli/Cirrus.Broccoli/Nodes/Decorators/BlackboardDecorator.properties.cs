using Cirrus.Objects;
using Cirrus.Debugging;
using System;
using static Cirrus.Debugging.DebugUtils;
using UnityEngine;

namespace Cirrus.Broccoli
{
	public partial class BlackboardDecorator<TValue> 
	: BlackboardDecorator<Type, TValue>
	{
	}

	public partial class BlackboardDecorator<TKey, TValue> 
	: ObserverDecoratorBase
	{
		public Action<BlackboardDecorator<TKey, TValue>> OnSatisfiedHandler;

		public Func<TValue, TValue, bool> CompareCb;

		public TKey Key { get; set; }

		public TValue Value { get; set; }
	}
}