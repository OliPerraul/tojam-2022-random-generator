using System;
using System.Collections;
using System.Collections.Generic;
using Cirrus.Collections;
using Cirrus.Objects;
using Cirrus.Unity.Objects;

using UnityEngine.Assertions;
using static Cirrus.Debugging.DebugUtils;


namespace Cirrus.Broccoli
{
	/// <summary>
	/// TODO: subclass this if extra update method needed (see control node)
	/// </summary>
	/// <typeparam name="TContext"></typeparam>
	/// <typeparam name="TData"></typeparam>
	public abstract partial class TaskDecoratorBase 
		: TaskNodeBase
		, IEnumerable<NodeBase>
	{
		public TaskDecoratorBase(string name) : base(name)
		{
		}
		public TaskDecoratorBase(string name, object obj) : base(name, obj)
		{
		}

		public TaskDecoratorBase(object obj) : base(obj)
		{
		}

		public TaskDecoratorBase() : base()
		{
		}

		protected virtual void _AddChild(NodeBase child)
		{
			if (child != null)
			{
				Assert(child.Parent == null, "Adding a child with existing parent", true);
				_child = child;
				_child.Parent = this;
				_child.Root = Root;

			}
		}

		protected override void _Init()
		{
			_child.Init();
		}

		public void Add(NodeBase decoratee)
		{
			_AddChild(decoratee);
		}

		public override IEnumerator<NodeBase> GetEnumerator()
		{
			return EnumerableUtils.ToEnumerable(Child).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		protected override void _OnStopped(bool success)
		{
			base._OnStopped(success);
			Parent.Unschedule(this);
		}

		public override void Schedule(TaskNodeBase node)
		{
			_scheduled.Add(node);
		}

		public override void Unschedule(TaskNodeBase node)
		{
			_scheduled.Remove(node);
		}

		protected override void _Start()
		{
			ActionNodeResult result = _Enter();
			if (			
				result == ActionNodeResult.Failed ||
				result == ActionNodeResult.Success
				)
			{
				_OnStopped(result == ActionNodeResult.Success);
			}
			else if(result == ActionNodeResult.Running)
			{
				result = _Update();
				if (result != ActionNodeResult.None)
				{
					if (
						result == ActionNodeResult.Running ||
						result == ActionNodeResult.Blocked
						)
					{
						Parent.Schedule(this);
						if (result == ActionNodeResult.Blocked)	_blocked = true;
						Child.Start();

					}
					else
					{
						_OnStopped(result == ActionNodeResult.Success);
					}
				}
			}
		}

		public override void Update()
		{
			_blocked = false;
			ActionNodeResult result = _Update();
			if (
				result != ActionNodeResult.Running &&
				result != ActionNodeResult.Blocked)
			{
				_OnStopped(result == ActionNodeResult.Success);
			}
			else if (result != ActionNodeResult.Blocked)
			{
				_scheduled.For(node => node.Update());
			}
			else _blocked = true;
		}

		protected override void _Stop()
		{
			ActionNodeResult result = _Exit();
			Assert(result == ActionNodeResult.Running, "The Task has to return Result.SUCCESS, Result.FAILED/BLOCKED after beeing cancelled!");
			_OnStopped(result == ActionNodeResult.Success);
			Child.Stop();
		}

		public override void FixedUpdate()
		{
			if (!_blocked)
			{
				_scheduled.For(node => node.FixedUpdate());
			}
		}

		public override void LateUpdate()
		{
			if (!_blocked)
			{
				_scheduled.For(node => node.LateUpdate());
			}
		}

		public override void OnDrawGizmos()
		{
			if (!_blocked)
			{
				_scheduled.For(node => node.LateUpdate());
			}
		}

		public override void CustomUpdate1(float dt)
		{
			if (!_blocked)
			{
				_scheduled.For(node => node.CustomUpdate1(dt));
			}
		}

		public override void CustomUpdate2(float dt)
		{
			if (!_blocked)
			{
				_scheduled.For(node => node.CustomUpdate2(dt));
			}
		}

		public override void CustomUpdate3(float dt)
		{
			if (!_blocked)
			{
				_scheduled.For(node => node.CustomUpdate3(dt));
			}
		}
	}	

	public partial class TaskDecorator	
	{
		protected override void _Init()
		{
			//InitCb?.Invoke(Context, this);
		}

		protected override ActionNodeResult _Exit()
		{
			//return ExitCb == null ? base._Exit() : ExitCb.Invoke(Context, this);
			return ActionNodeResult.Success;
		}

		protected override ActionNodeResult _Enter()
		{
			//if (!Context.IsValid) return ActionNodeResult.Error;
			return EnterCb == null ? base._Enter() : EnterCb.Invoke(this);
			//return ActionNodeResult.Success;
		}

		protected override ActionNodeResult _Update()
		{
			return UpdateCb == null ? base._Update() : UpdateCb.Invoke(this);
		}
	}
}