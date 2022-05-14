using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Broccoli
{
	public abstract partial class DecoratorNodeBase : NodeBase
	{
		public object _data;
		public override object Data { get => _data; set => _data = value; }

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
}
