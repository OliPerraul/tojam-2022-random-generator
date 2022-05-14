//using Cirrus.UnityUnity.EditorExt;
//using Priority_Queue;
using Cirrus.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
namespace Cirrus.States
{
	public partial class StateMachineBase
	{
		public abstract IState State { get; }

		public Stack<IState> Stack { get; set; }

		public SimpleBHeap2<IState> PriorityQueue { get; set; }


		protected bool _enabled = false;

		public void __UpdateStateLabel(GameObject label)
		{
			label.name = State == null ? "?" : State.Name;
		}

		//public abstract StateMachineStatus PopStaleStates(
		//	params object[] args);		

		public Action<IState> OnStateChangedHandler { get; set; }

	}
}
