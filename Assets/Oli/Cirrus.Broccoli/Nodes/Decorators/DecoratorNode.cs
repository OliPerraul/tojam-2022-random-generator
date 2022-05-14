using Cirrus.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Broccoli 
{
	public abstract partial class DecoratorNodeBase
	{
		public DecoratorNodeBase() : base()
		{
		}

		public DecoratorNodeBase(string name) : base(name)
		{
		}
		public DecoratorNodeBase(string name, object obj) : base(name, obj)
		{
		}

		public DecoratorNodeBase(object obj) : base(obj)
		{
		}

		//protected override void _AddChild(NodeInstanceBase<TContext> decoratee)
		//{
		//	base._AddChild(decoratee);

		//	if (
		//		decoratee != null &&
		//		Data != null
		//		)
		//	{
		//		if (typeof(IDataWrapper<TData>).IsAssignableFrom(decoratee.GetType()))
		//		{
		//			((IDataWrapper<TData>)decoratee).Data = Data;
		//		}
		//	}
		//}

		public override void OnParentCompositeStopped(CompositeNodeBase composite)
		{
			base.OnParentCompositeStopped(composite);
			Child.OnParentCompositeStopped(composite);
		}	


		protected override void _Init()
		{
			if (_child != null)
			{
				_child.Init();
			}
		}

		protected override void _ChildStopped(NodeBase child, bool succeeded)
		{
			_OnStopped(succeeded);
		}

		protected override void _Start()
		{
			if (!Context.IsValid) return;
			Child.Start();
		}

		protected override void _Stop()
		{
			Child.Stop();
		}

		protected virtual void _AddChild(NodeBase child)
		{
			if (child != null)
			{
				Assert(child.Parent == null, "Adding a child with existing parent", true);




				if (_child == null)
				{
					_child = child;
					_child.Parent = this;
				}
				else
				{
					if (_child is not SequenceNode)
					{
						_child.Parent = null;
						_child = new SequenceNode { _child };
						_child.Parent = this;
					}

					((SequenceNode)_child).Add(child);
				}

				child.Root = Root;
			}
		}

		public void Add(NodeBase decoratee)
		{
			_AddChild(decoratee);
		}

		public override IEnumerator<NodeBase> GetEnumerator()
		{
			return EnumerableUtils.ToEnumerable(Child).GetEnumerator();
		}

		//IEnumerator IEnumerable.GetEnumerator()
		//{
		//	return GetEnumerator();
		//}
	}
}
