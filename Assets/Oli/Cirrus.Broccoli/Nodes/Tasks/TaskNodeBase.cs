using Cirrus.Objects;
using static Cirrus.Debugging.DebugUtils;


namespace Cirrus.Broccoli
{
	public abstract partial class TaskNodeBase
	: NodeBase
	, ITaskNode
	{
		public TaskNodeBase(string name) : base(name)
		{
		}

		public TaskNodeBase(string name, object obj) : base(name, obj)
		{
		}

		public TaskNodeBase(object obj) : base(obj)
		{
		}

		public TaskNodeBase() : base()
		{
		}

		public virtual void Update()
		{
		}

		protected virtual ActionNodeResult _Enter()
		{
			return ActionNodeResult.Running;
		}

		protected virtual ActionNodeResult _Update()
		{
			return ActionNodeResult.Running;
		}

		protected virtual ActionNodeResult _Exit()
		{
			return ActionNodeResult.Success;
		}

		/// <summary>
		/// TODO investigate this
		/// </summary>
		protected override void _Stop()
		{
			ActionNodeResult result = _Exit();
			Assert(result != ActionNodeResult.Running, "The Task has to return Result.SUCCESS, Result.FAILED/BLOCKED after beeing cancelled!");
			_OnStopped(result == ActionNodeResult.Success);
		}

		public virtual void FixedUpdate()
		{
		}

		public virtual void LateUpdate()
		{
		}

		public virtual void OnDrawGizmos()
		{
		}

		public virtual void CustomUpdate1(float dt)
		{
		}

		public virtual void CustomUpdate2(float dt)
		{
		}

		public virtual void CustomUpdate3(float dt)
		{
		}
	}

	public abstract partial class TaskNodeBase<TContext, TData>
	{
		public TaskNodeBase() : base()
		{
		}

		public TaskNodeBase(string name) : base(name)
		{
		}

		public TaskNodeBase(string name, object obj) : base(name, obj)
		{
		}

		public TaskNodeBase(object obj) : base(obj)
		{
		}

	}

	public abstract partial class TaskNodeBase<TContext>
	{
		public TaskNodeBase() : base()
		{
		}

		public TaskNodeBase(string name) : base(name)
		{
		}

		public TaskNodeBase(string name, object obj) : base(name, obj)
		{
		}

		public TaskNodeBase(object obj) : base(obj)
		{
		}

	}
}