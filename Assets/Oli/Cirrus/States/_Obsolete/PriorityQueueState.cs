//using System.Collections.Generic;

//namespace Cirrus.States
//{
//	public partial class PriorityQueueState<StateMachineType, StateType>
//		: StateBase<StateMachineType>
//		where StateMachineType : IStateMachine
//		where StateType : IState
//	{
//		//public PriorityQueueState(StateMachineType machine) : base(machine)
//		//{
//		//}

//		//public PriorityQueueState(
//		//	StateMachineType machine,
//		//	IEnumerable<StateType> enumerable
//		//	) : base(machine)
//		//{
//		//	States = enumerable;
//		//}

//		public PriorityQueueState() : base()
//		{
//		}

//		public StateMachineStatus Enqueue(StateType state, float priority)
//		{
//			return StateMachineStatus.Failure;
//		}

//		public override StateMachineStatus Enter()
//		{
//			//if(States != null)
//			//{
//			//	_enumerator = States.GetEnumerator();
//			//	return NextState();
//			//}

//			return StateMachineStatus.Failure;
//		}

//		public override StateMachineStatus Exit()
//		{
//			base.Exit();
//			_enumerator = null;
//			return StateMachineStatus.Success;
//		}

//		//public override StateMachineStatus SetNextState(params object[] args)
//		//{
//		//	IState previous =
//		//		_hasEnumeratorStarted ?
//		//			_Current :
//		//			null;
//		//	if(_enumerator.MoveNext())
//		//	{
//		//		_hasEnumeratorStarted = true;
//		//		if(previous != null) previous.Exit();
//		//		Context.EnterState(_Current, args);
//		//		return StateMachineStatus.HasNext;
//		//	}

//		//	return StateMachineStatus.HasNextFailed;
//		//}

//		public override StateMachineStatus SetSubState(IState state)
//		{			
//			return _Current.SetSubState(state);
//		}

//		public override StateMachineStatus SetSubState(int state)
//		{
//			return _Current.SetSubState(state);
//		}

//		public override void FixedUpdate_()
//		{
//			_Current.FixedUpdate_();
//		}

//		public override StateMachineStatus Update_()
//		{
//			return _Current.Update_();
//		}


//		public override void CustomUpdate1(float deltaTime)
//		{
//			_Current.CustomUpdate1(deltaTime);
//		}

//		public override void CustomUpdate2(float deltaTime)
//		{
//			_Current.CustomUpdate2(deltaTime);
//		}

//		public override void CustomUpdate3(float deltaTime)
//		{
//			_Current.CustomUpdate3(deltaTime);
//		}

//		// TODO
//		//public override void Enter(params object[] args)
//		//{

//		//}

//		// TODO
//		public override void OnMachineDestroyed()
//		{
//			//foreach (var mach in States)
//			//{
//			//	if (mach == null) continue;
//			//	//mach.On();
//			//}
//		}

//		public override void OnDrawGizmos_()
//		{
//			_Current.OnDrawGizmos_();
//		}
//	}
//}
