using Cirrus.Collections;
using Cirrus.States;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
//using Priority_Queue;

namespace Cirrus.Unity.States
{
	public enum StartMode
	{
		Manual,
		Awake,
		Start,
		LateStart,
		LateLateStart
	}


	/// <summary>
	/// TODO Handle events do not force everything to appear in the loop
	/// Make it so that some states respond to events
	/// </summary>   
	public partial class StateMachineComponent
	{
		public virtual StateMachineBase StateMachine { get; set; } = null;

		public Stack<IState> Stack { get => StateMachine.Stack; set => StateMachine.Stack = value; }

		public SimpleBHeap2<IState> PriorityQueue { get => StateMachine.PriorityQueue; set => StateMachine.PriorityQueue = value; }


		[SerializeField]
		private bool _enableStateLabel = true;

		public IState State => StateMachine.State;

		public Action<IState> OnStateChangedHandler { get; set; }

		[SerializeField]
		private StartMode _startMode;

		protected virtual StartMode _StartMode => _startMode;

#if UNITY_EDITOR
		[SerializeField]
		[FormerlySerializedAs("_stateLabelGameObject")]
		private GameObject _stateLabel;
#endif
	}
}
