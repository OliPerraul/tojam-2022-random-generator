using Cirrus.Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Broccoli 
{

	public partial class RootNode
		: NodeBase
		, IEnumerable<NodeBase>
	{
		//private Node inProgressNode;

		protected ContextBase _context;
		public override ContextBase Context => _context;

		public override object Data { get => null; set { } }

		protected NodeBase _child;

		public NodeBase Child
		{
			get => _child;
			set => _AddChild(value);
		}

		public override RootNode Root
		{
			get => this;
			set { }
		}	
	}
}