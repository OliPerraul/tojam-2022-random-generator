//using Cirrus.Collections;
//using System;
//using System.Collections.Generic;

//namespace Cirrus.States
//{
//	public partial class PriorityQueueState<StateMachineType, StateType>
//	{
//		//public virtual IEnumerable<StateType> States { get; set; } = null;

//		SimpleBHeap2<StateType> _heap = new SimpleBHeap2<StateType>(SortDirection.Descending);		

//		private IEnumerator<StateType> _enumerator;

//		private bool _hasEnumeratorStarted = false;

//		protected IState _Current => _enumerator.Current;

//		public override string Name =>
//			_enumerator == null ?
//			StateMachineUtils.InvalidStateName :
//			_Current.Name;
//	}
//}
