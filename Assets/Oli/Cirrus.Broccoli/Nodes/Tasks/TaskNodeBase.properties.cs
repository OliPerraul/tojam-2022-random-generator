using Cirrus.Objects;
using static Cirrus.Debugging.DebugUtils;


namespace Cirrus.Broccoli
{
	public interface ITaskNode : INodeInstance
	{
		void Update();

		void FixedUpdate();

		void LateUpdate();

		void OnDrawGizmos();
		void CustomUpdate1(float dt);

		void CustomUpdate2(float dt);

		void CustomUpdate3(float dt);

		string Name { get; }
	}


	public abstract partial class TaskNodeBase
	: NodeBase
	, ITaskNode
	{
		private RootNode _root = null;

		public override RootNode Root 
		{
			get => _root;
			set => _root = value;
		}
	}

	public abstract partial class TaskNodeBase<TContext, TData> 
	: TaskNodeBase
	where TContext : ContextBase
	{
		
		public TData data;
		public override object Data { get => data; set => data = (TData)value; }

		// Covariant return type
		public TContext context;

		public override ContextBase Context { get => context; set => context = (TContext) value; }
	}


	public abstract partial class TaskNodeBase<TContext> : TaskNodeBase<TContext, None>
	where TContext : ContextBase
	{
	}
}