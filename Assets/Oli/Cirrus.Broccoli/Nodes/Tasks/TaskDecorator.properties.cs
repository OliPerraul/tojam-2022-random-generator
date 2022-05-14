using System;
using System.Collections.Generic;
using Cirrus.Objects;
using Cirrus.Unity.Objects;

using UnityEngine.Assertions;


namespace Cirrus.Broccoli
{
	public abstract partial class TaskDecoratorBase
	: TaskNodeBase		
	//where TContext : IBtContext
	{
		public object _data;
		public override object Data { get => _data; set => _data = value; }

		public bool _blocked = false;

		//Maybe scheduled items should be a member of the node itself, so that it can be scheduled and unscheduled easily.
		private List<ITaskNode> _scheduled = new List<ITaskNode>();


		protected NodeBase _child;

		public NodeBase Child
		{
			get => _child;
			set => _AddChild(value);
		}

		private RootNode _root;

		public override RootNode Root
		{
			get => _root;
			set
			{
				_root = value;
				if (Child != null)
				{
					Child.Root = value;					
				}
			}
		}
	}

	public partial class TaskDecorator : TaskDecoratorBase
	{
		public Func< TaskDecorator, bool> InitCb;

		public Func< TaskDecorator, ActionNodeResult> EnterCb = null;
		public Func< TaskDecorator, ActionNodeResult> UpdateCb = null;
		public Func< TaskDecorator, ActionNodeResult> ExitCb = null;
	}
}