using Cirrus.Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Broccoli 
{
	// Existential, Universal
	public enum NodeResultQuantifier
	{
		One,
		All,
	}


	public abstract partial class CompositeNodeBase
	: NodeBase
	, IEnumerable<NodeBase>
	{
		protected object _data;

		public override object Data { get => _data; set => _data = value; }
		

		private RootNode _root = null;

		public override RootNode Root
		{
			get => _root;
			set
			{
				if (value != null)
				{
					_root = value;
					for (int i = 0; i < Children.Count; i++)
					{
						var node = Children[i];
						if (!AssertSucceeded(node != null)) continue;
						node.Root = value;						
					}
				}
			}
		}

		protected List<NodeBase> _children = new List<NodeBase>();

		public IReadOnlyList<NodeBase> Children
		{
			get => _children;
			set
			{
				if (value != null)
				{
					_children = new List<NodeBase>(value.Count);
					for (int i = 0; i < value.Count; i++) _AddChild(value[i]);
				}
			}
		}

		public override IEnumerator<NodeBase> GetEnumerator()
		{
			return ((IEnumerable<NodeBase>)Children).GetEnumerator();
		}
	}
	
}