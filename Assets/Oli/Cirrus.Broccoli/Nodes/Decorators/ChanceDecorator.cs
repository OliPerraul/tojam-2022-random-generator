using Cirrus.Objects;
using Cirrus.Unity.Randomness;
using System;
using UnityEngine;
using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Broccoli
{
	public class ChanceDecorator : DecoratorNodeBase
	{
		public Chance Chance = 0.5f;

		//public Action<TContext, ChanceDecorator<TContext, TData>> InitCb;

		public ChanceDecorator(Chance chance) : base()
		{
			Chance = chance;
		}

		public ChanceDecorator(string name) : base(name)
		{
		}
		public ChanceDecorator(string name, object obj) : base(name, obj)
		{
		}

		public ChanceDecorator(object obj) : base(obj)
		{
		}


		protected override void _Init()
		{
		}

		protected override void _Start()
		{
			if (!Context.IsValid) return;
			if (Chance) Child.Start(); else _OnStopped(false);
		}

		protected override void _Stop()
		{
			Child.Stop();
		}

		protected override void _ChildStopped(NodeBase child, bool result)
		{
			_OnStopped(result);
		}
	}
}