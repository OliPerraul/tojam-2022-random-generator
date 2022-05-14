using Cirrus.Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Broccoli 
{
	public abstract partial class CompositeNodeBase
	{
		public CompositeNodeBase() : base()
		{
		}

		public CompositeNodeBase(string name) : base(name)
		{
		}
		public CompositeNodeBase(object obj) : base(obj)
		{
		}

		public CompositeNodeBase(string name, object obj) : base(name, obj)
		{
		}

		public abstract void StopLowerPriorityChildrenForChild(NodeBase child, bool immediateRestart);

		protected override void _OnStopped(bool success)
		{
			for (int i = 0; i < Children.Count; i++)
			{
				Children[i].OnParentCompositeStopped(this);
			}
			base._OnStopped(success);
		}

		protected virtual void _AddChild(NodeBase child)
		{
			if (child == null) return;
			Assert(child.Parent == null, "Adding a child with existing parent", true);
			_children.Add(child);
			child.Parent = this;
			//Assert(Root != null, "Assigning null root to child.", true);
			child.Root = Root;
		}

		protected override void _Init()
		{
			for (int i = 0; i < Children.Count; i++)
			{
				Children[i].Init();
			}
		}

		public void Add(NodeBase child)
		{
			_AddChild(child);
		}

	}
}