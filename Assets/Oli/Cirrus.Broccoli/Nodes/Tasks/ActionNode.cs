using System;

using Cirrus.Objects;
using Cirrus.Unity.Objects;

using UnityEngine.Assertions;
using static Cirrus.Debugging.DebugUtils;

// SUBTREE DECORATOR

// Make any node appear as a task to be scheduled

namespace Cirrus.Broccoli
{
	public abstract partial class ActionNodeBase
	{
		public ActionNodeBase() : base()
		{
		}

		public ActionNodeBase(string name) : base(name)
		{
		}
		public ActionNodeBase(string name, object obj) : base(name, obj)
		{
		}

		public ActionNodeBase(object obj) : base(obj)
		{
		}

		protected override void _Init()
		{
		}

		protected override void _OnStopped(bool success)
		{			
			base._OnStopped(success);
			Parent.Unschedule(this);
		}

		protected override void _Start()
		{
			ActionNodeResult result = _Enter();
			if (
				result == ActionNodeResult.Failed
				|| result == ActionNodeResult.Success
				)
			{
				_OnStopped(result == ActionNodeResult.Success);
			}
			else if (
				result == ActionNodeResult.Running
				)
			{
				result = _Update();
				if (result != ActionNodeResult.None)
				{
					if (
						result == ActionNodeResult.Running
						|| result == ActionNodeResult.Blocked
						)
					{
						Parent.Schedule(this);
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
			ActionNodeResult result = _Update();
			if (State != NodeState.Active) return;
			State = NodeState.Active;
			if (
				result != ActionNodeResult.Running &&
				result != ActionNodeResult.Blocked
				)
			{
				_OnStopped(result == ActionNodeResult.Success);
			}
		}

		protected override void _Stop()
		{
			ActionNodeResult result = _Exit();
			Assert(result != ActionNodeResult.Running, "The Task has to return Result.SUCCESS, Result.FAILED/BLOCKED after beeing cancelled!");
			_OnStopped(result == ActionNodeResult.Success);
		}
	}

	public partial class ActionNode<TContext, TData>
	{
		public ActionNode() : base()
		{
		}

		public ActionNode(string name) : base(name)
		{
		}

		public ActionNode(
		Action<TContext, ActionNode<TContext, TData>> initCb
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> exitCb = null
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> updateCb = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) :	base()
		{
			this.initCb = initCb;
			this.enterCb = enterCb;
			this.updateCb = updateCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}


		public ActionNode(
		Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> exitCb = null
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> updateCb = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) :	base()
		{
			this.enterCb = enterCb;
			this.updateCb = updateCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) :	base()
		{
			this.enterCb = enterCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		Action<TContext, ActionNode<TContext, TData>> initCb
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) : base()
		{
			this.initCb = initCb;
			this.enterCb = enterCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		Action<TContext, ActionNode<TContext, TData>> initCb
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> exitCb
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) :	base()
		{
			this.initCb = initCb;
			this.enterCb = enterCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}


		public ActionNode(
		Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> exitCb
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) :	base()
		{
			this.enterCb = enterCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}


		public ActionNode(
		string name,
		Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> exitCb = null
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> updateCb = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) :	base(name)
		{
			this.enterCb = enterCb;
			this.updateCb = updateCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		string name,
		Action<TContext, ActionNode<TContext, TData>> initCb,
		Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) : base(name)
		{
			this.initCb = initCb;
			this.enterCb = enterCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		string name,
		Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) :	base(name)
		{
			this.enterCb = enterCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}


		public ActionNode(
		string name,
		Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> exitCb
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) :	base(name)
		{
			this.enterCb = enterCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		string name,
		Action<TContext, ActionNode<TContext, TData>> initCb,
		Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> exitCb
		, Action<TContext, ActionNode<TContext, TData>, float> customCb1
		, Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null
		) :	base(name)
		{
			this.enterCb = enterCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		protected override void _Init()
		{
			base._Init();
			initCb?.Invoke(context, this);
		}

		protected override ActionNodeResult _Exit()
		{
			return exitCb == null ? base._Exit() : exitCb.Invoke(context, this);
		}

		protected override ActionNodeResult _Enter()
		{
			//if (!Context.IsValid) return ActionNodeResult.Error;
			return enterCb == null ? base._Enter() : enterCb.Invoke(context, this);
		}

		protected override ActionNodeResult _Update()
		{
			return updateCb == null ? base._Update() : updateCb.Invoke(context, this);
		}

		public override void LateUpdate()
		{
			lateUpdateCb?.Invoke(context, this);
		}

		public override void CustomUpdate1(float dt)
		{
			customCb1?.Invoke(context, this, dt);
		}

		public override void CustomUpdate2(float dt)
		{
			customCb2?.Invoke(context, this, dt);
		}

		public override void CustomUpdate3(float dt)
		{
			customCb3?.Invoke(context, this, dt);
		}

		public override void OnDrawGizmos()
		{
			onDrawGizmosCb?.Invoke(context, this);
		}
	}

	public partial class ActionNode<TContext> : ActionNode<TContext, None>		
	{
		public ActionNode() : base()
		{
		}

		public ActionNode(string name) : base(name)
		{
		}

		public ActionNode(
		Action<TContext, ActionNode<TContext, None>> initCb
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> exitCb = null
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> updateCb = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb1 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base()
		{
			this.initCb = initCb;
			this.enterCb = enterCb;
			this.updateCb = updateCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}


		public ActionNode(
		Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> exitCb = null
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> updateCb = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb1 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base()
		{
			this.enterCb = enterCb;
			this.updateCb = updateCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Action<TContext, ActionNode<TContext, None>, float> customCb1
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base()
		{
			base.enterCb = enterCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		Action<TContext, ActionNode<TContext, None>> initCb
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Action<TContext, ActionNode<TContext, None>, float> customCb1
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base()
		{
			this.initCb = initCb;
			this.enterCb = enterCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		Action<TContext, ActionNode<TContext, None>> initCb
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> exitCb
		, Action<TContext, ActionNode<TContext, None>, float> customCb1
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base()
		{
			this.initCb = initCb;
			this.enterCb = enterCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}


		public ActionNode(
		Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> exitCb
		, Action<TContext, ActionNode<TContext, None>, float> customCb1
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base()
		{
			this.enterCb = enterCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}


		public ActionNode(
		string name,
		Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> exitCb = null
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> updateCb = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb1 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base(name)
		{
			this.enterCb = enterCb;
			this.updateCb = updateCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		string name,
		Action<TContext, ActionNode<TContext, None>> initCb,
		Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Action<TContext, ActionNode<TContext, None>, float> customCb1
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base(name)
		{
			this.initCb = initCb;
			this.enterCb = enterCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		string name,
		Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Action<TContext, ActionNode<TContext, None>, float> customCb1
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base(name)
		{
			this.enterCb = enterCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}


		public ActionNode(
		string name,
		Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> exitCb
		, Action<TContext, ActionNode<TContext, None>, float> customCb1
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base(name)
		{
			this.enterCb = enterCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}

		public ActionNode(
		string name,
		Action<TContext, ActionNode<TContext, None>> initCb,
		Func<TContext, ActionNode<TContext, None>, ActionNodeResult> enterCb
		, Func<TContext, ActionNode<TContext, None>, ActionNodeResult> exitCb
		, Action<TContext, ActionNode<TContext, None>, float> customCb1
		, Action<TContext, ActionNode<TContext, None>, float> customCb2 = null
		, Action<TContext, ActionNode<TContext, None>, float> customCb3 = null
		) : base(name)
		{
			this.enterCb = enterCb;
			this.exitCb = exitCb;
			this.customCb1 = customCb1;
			this.customCb2 = customCb2;
			this.customCb3 = customCb3;
		}
	}
}