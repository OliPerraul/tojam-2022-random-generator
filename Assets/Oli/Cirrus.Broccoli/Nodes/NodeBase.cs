using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Broccoli
{
	public abstract partial class NodeBase
	{
		public NodeBase(string name)
		{
			Name = name;
		}

		public NodeBase(string name, object data)
		{
			Name = name;
			Data = data;
		}

		public NodeBase(object data)
		{
			Data = data;
		}

		public NodeBase()
		{
			Name = GetType().Name;
		}

		public T Ancestor<T>(int position = 0) where T : NodeBase
		{
			NodeBase parent = _parent;
			for (int i = 0; i < position; i++)
			{
				if (i == position) return (T)parent;
				parent = Parent.Parent;
			}

			return null;
		}

		public NodeBase Ancestor(int position = 0)
		{
			NodeBase parent = _parent;
			for (int i = 0; i < position; i++)
			{
				if (i == position) return parent;
				parent = Parent.Parent;
			}

			return null;
		}


		public void OnChildStopped(NodeBase child, bool succeeded)
		{
			// Assert.AreNotEqual(this.currentState, State.INACTIVE, "The Child " + child.Name + "
			// of Container " + this.Name + " was stopped while the container was inactive. PATH: "
			// + GetPath());
			Assert(State != NodeState.Inactive, "A Child of a Container was stopped while the container was inactive.", true);
			_ChildStopped(child, succeeded);
		}

		protected virtual void _ChildStopped(NodeBase child, bool succeeded) { }

		protected abstract void _Init();

		public void Init()
		{
			if (_state == NodeState.Uninit && Root != null)
			{
				if (Parent != null && Parent.Data != null && Data == null) Data = Parent.Data;
				_Init();
				_state = NodeState.Inactive;
			}
		}

		public void Start()
		{
			Init();
			// Assert.AreEqual(currentState, State.INACTIVE, "can only start inactive nodes, tried
			// to start: " + Name + "! PATH: " + GetPath());
			Assert(State == NodeState.Inactive, "can only start inactive nodes", true);
			State = NodeState.Active;
			_Start();
		}

		/// <summary>
		/// TODO: Rename to "Cancel" in next API-Incompatible version
		/// </summary>
		public void Stop()
		{
			// Assert.AreEqual(currentState, State.ACTIVE, "can only stop active nodes, tried to
			// stop " + Name + "! PATH: " + GetPath());
			Assert(State == NodeState.Active, "can only stop active nodes, tried to stop", true);
			State = NodeState.Stopping;
			_Stop();
		}

		protected virtual void _Start()
		{
		}

		protected virtual void _Stop()
		{
		}

		protected virtual void _OnStarted()
		{
		}

		public virtual void Schedule(TaskNodeBase node)
		{
			Assert(Parent != null, true);
			Parent.Schedule(node);
		}

		public virtual void Unschedule(TaskNodeBase node)
		{
			Assert(Parent != null, true);
			Parent.Unschedule(node);
		}


		/// THIS ABSOLUTLY HAS TO BE THE LAST CALL IN YOUR FUNCTION, NEVER MODIFY ANY STATE AFTER
		/// CALLING Stopped !!!!
		protected virtual void _OnStopped(bool success)
		{
			// Assert.AreNotEqual(currentState, State.INACTIVE, "The Node " + this + " called
			// 'Stopped' while in state INACTIVE, something is wrong! PATH: " + GetPath());
			Assert(State != NodeState.Inactive, "Called 'Stopped' while in state INACTIVE, something is wrong!", true);
			State = NodeState.Inactive;
			if (Parent != null)
			{
				Parent.OnChildStopped(this, success);
			}
		}

		public virtual void OnParentCompositeStopped(CompositeNodeBase composite)
		{
			_ParentCompositeStopped(composite);
		}

		/// THIS IS CALLED WHILE YOU ARE INACTIVE, IT's MEANT FOR DECORATORS TO REMOVE ANY PENDING OBSERVERS
		protected virtual void _ParentCompositeStopped(CompositeNodeBase composite)
		{
			/// be careful with this!
		}

		// public Composite ParentComposite { get { if (ParentNode != null && !(ParentNode is
		// Composite)) { return ParentNode.ParentComposite; } else { return ParentNode as Composite;
		// } } }

		override public string ToString()
		{
			return Name.IsNullOrEmpty() ? GetType().Name : Name;
		}

		protected string GetPath()
		{
			return Parent != null ? Parent.GetPath() + "/" + Name : Name;
		}
	}
}