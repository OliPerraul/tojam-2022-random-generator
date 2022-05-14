using Cirrus.Collections;
using Cirrus.Objects;
using Cirrus.Unity.Objects;
using System;
//// using Cirrus.Unity.AI.BehaviourTrees;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Broccoli
{
	public enum NodeState
	{
		Uninit,
		Inactive,
		Active,
		/// <summary>
		/// Stop requested: the node is currently stopping, but has not yet called Stopped() to notify the parent.
		/// </summary>
		Stopping
	}

	public interface INodeInstance
	{
		NodeState State { get; }
	}

	public abstract partial class NodeBase
	: Base
	, IEnumerable<NodeBase>
	{
		// This could be abstract so that not all children must be a generic...
		// This would improve CompositeNodes, waitNode etc. Not all leaves
		// This would probably require casting
		// Casting would occur once..
		public virtual ContextBase Context { get => Root.Context; set { } }

		// variable to arbitrary data
		public abstract object Data { get; set; }

		// Equivalent to ConditionDecorator, added here for conciseness
		//public Func<NodeBase, bool> CondCb;

		private NodeState _state = NodeState.Uninit;

		public NodeState State
		{
			get => _state;
			protected set
			{
				_state = value;
			}
		}

		public abstract RootNode Root { get; set; }

		//public NodeInstanceBase GrandParent => Parent.Parent;

		private NodeBase _parent;

		public NodeBase Parent
		{
			get => _parent;
			set => _parent = value;
		}		

		public virtual string Name { get; set; } = "";

		public Blackboard Blackboard => Context.Blackboard;
		public Clock Clock => Context.Clock;

		public virtual IEnumerator<NodeBase> GetEnumerator()
		{
			return EnumerableUtils.ToEnumerable(this).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		//public bool IsStopRequested => State == NodeInstanceState.Stopping;

		//public bool IsActive => State == NodeInstanceState.Active;
	}
}