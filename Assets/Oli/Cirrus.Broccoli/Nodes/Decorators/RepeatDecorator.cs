using Cirrus.Objects;
using Cirrus.Broccoli;
using System;

namespace Cirrus.Broccoli
{
	public class RepeatDecorator : DecoratorNodeBase
	{
		public int LoopCount = -1;
		private int _currentLoop;

		public bool RepeatFailures = true;

		public RepeatDecorator() : base()
		{
		}


		//public RepeatDecoratorInstance(string name) : base(name)
		//{
		//}
		public RepeatDecorator(string name, object obj) : base(name, obj)
		{
		}

		public RepeatDecorator(object obj) : base(obj)
		{
		}

		//public Action<TContext, RepeatDecorator<TContext, TData>> InitCb;

		public RepeatDecorator(string name, int loopCount=-1, bool repeatFailures=true) : base(name)
		{
			LoopCount = loopCount;
			RepeatFailures = repeatFailures;
		}
		public RepeatDecorator(int loopCount = -1, bool repeatFailures = true) : base()
		{
			LoopCount = loopCount;
			RepeatFailures = repeatFailures;
		}

		protected override void _Init()
		{
			//InitCb?.Invoke(Context, this);
		}

		protected override void _Start()
		{
			if (!Context.IsValid) return;
			if (LoopCount != 0)
			{
				_currentLoop = 0;
				Child.Start();
			}
			else
			{
				_OnStopped(true);
			}
		}

		protected override void _Stop()
		{
			Clock.RemoveTimer(_RestartDecoratee);

			if(Child.State == NodeState.Active)
			{
				Child.Stop();
			}
			else
			{
				_OnStopped(false);
			}
		}

		protected override void _ChildStopped(NodeBase child, bool result)
		{
			if(RepeatFailures ? !result : result) 
			{
				if(
					State == NodeState.Stopping 
					|| (LoopCount > 0 && ++_currentLoop >= LoopCount)
					)
				{
					_OnStopped(true);
				}
				else
				{
					Clock.AddTimer(0, 0, _RestartDecoratee);
				}
			}
			else
			{
				_OnStopped(false);
			}
		}

		protected void _RestartDecoratee()
		{
			Child.Start();
		}
	}
}