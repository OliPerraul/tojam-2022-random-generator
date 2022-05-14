////using Priority_Queue;
////using Cirrus.UnityDH.Attributes;
//using Cirrus.Collections;
//using System;
//using System.Collections.Generic;
//using System.Threading;
//using UnityEngine;

//namespace Cirrus.States
//{
//	using Queue = BHeap<IState>;

//	public partial class MultiplePriorityQueueStateMachine
//	{
//		public object[] Context { get; set; }

//		private Mutex _mutex = new Mutex();

//		private Queue _defaultQueue = MakeQueue();
//		private Queue _currentQueue;
//		private Dictionary<int, Queue> _dictionary = new Dictionary<int, Queue>();

//		public string _stateName = "";

//		[SerializeField]
//		public override IState State => _currentQueue.Peek();
//	}
//}