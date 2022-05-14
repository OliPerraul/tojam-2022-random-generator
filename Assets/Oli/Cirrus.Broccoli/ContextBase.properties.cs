using Cirrus.Unity.Objects;

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Broccoli
{
	public interface IContext
	{
		Blackboard Blackboard { get; }
		Clock Clock { get; }

		void Schedule(TaskNodeBase node);

		void Unschedule(TaskNodeBase node);

		bool IsValid { get; }
	}

	public partial class ContextBase
		: CustomMonoBehaviourBase
		, IContext
	{

		public NodeState State => _Root.State;

		protected RootNode _root;
		protected RootNode _Root => _root;

		protected bool _running = true;
		public bool IsRunning => _running;

		[NonSerialized]
		protected Blackboard _blackboard = null;
		public Blackboard Blackboard => _blackboard;

		[NonSerialized]
		protected Clock _clock;
		public Clock Clock => _clock;

		[SerializeField]
		protected GameObject _label = null;

		//Maybe scheduled items should be a member of the node itself, so that it can be scheduled and unscheduled easily.
		private List<ITaskNode> _scheduled = new List<ITaskNode>();

		public bool IsValid => gameObject != null;
	}
}