using System;

using Cirrus.Objects;
using Cirrus.Unity.Objects;

using UnityEngine.Assertions;
using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Broccoli
{
	public enum ActionNodeResult
	{
		Success,
		Failed,
		Blocked,
		Running,
		None,
		Error
	}

	public abstract partial class ActionNodeBase
	: TaskNodeBase
	{
	}

	public partial class ActionNode<TContext, TData> : ActionNodeBase
		where TContext : ContextBase
	{
		public TData data;
		public override object Data { get => data; set => data = (TData)value; }

		public TContext context;

		public override ContextBase Context { get => context; set => context = (TContext)value; }


		public Action<TContext, ActionNode<TContext, TData>> initCb = null;
		public Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> enterCb = null;
		public Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> updateCb = null;
		public Func<TContext, ActionNode<TContext, TData>, ActionNodeResult> exitCb = null;

		public Action<TContext, ActionNode<TContext, TData>> fixedUpdateCb = null;
		public Action<TContext, ActionNode<TContext, TData>> lateUpdateCb = null;
		public Action<TContext, ActionNode<TContext, TData>> onDrawGizmosCb = null;		
		public Action<TContext, ActionNode<TContext, TData>, float> customCb1 = null;
		public Action<TContext, ActionNode<TContext, TData>, float> customCb2 = null;
		public Action<TContext, ActionNode<TContext, TData>, float> customCb3 = null;
	}

	public partial class ActionNode<TContext> : ActionNode<TContext, None>
	where TContext : ContextBase
	{ 
	
	}
}