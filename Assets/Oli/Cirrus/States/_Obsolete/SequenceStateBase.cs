using Cirrus.Objects;
using System;

namespace Cirrus.States
{
	public partial class StateSequenceBase<StateMachineType, StateType>
		: StateBase<StateMachineType>
		where StateType 
		: class
		, IState<StateMachineType>
		// , IRealizablePrototype
		where StateMachineType : IStateMachine

	{
		public StateSequenceBase(StateMachineType machine) : base(machine)
		{
		}

		public StateSequenceBase() : base()
		{
		}

		public override StateMachineStatus Enter()
		{
			_enumerator = GetStates().GetEnumerator();
			return StateMachineStatus.Failure;
		}

		public override StateMachineStatus Exit()
		{
			base.Exit();
			_enumerator = null;
			return StateMachineStatus.Success;
		}

		//public override StateMachineStatus SetNextState()
		//{
		//	IState previous =
		//		_hasEnumeratorStarted ?
		//			_Current :
		//			null;
		//	if(_enumerator.MoveNext())
		//	{
		//		_hasEnumeratorStarted = true;
		//		if(previous != null) previous.Exit();
		//		Context.EnterState(_Current, args);
		//		return StateMachineStatus.HasNext;
		//	}

		//	return StateMachineStatus.HasNextFailed;
		//}

		public override StateMachineStatus __OBSOLETE_SetSubState(IState state, Func<IState, bool> pred = null)
		{
			return _Current.__OBSOLETE_SetSubState(state, pred);
		}

		public override StateMachineStatus __OBSOLETE_SetSubState(int state, Func<IState, bool> pred = null)
		{
			return _Current.__OBSOLETE_SetSubState(state, pred);
		}

		public override void FixedUpdate_()
		{
			_Current.FixedUpdate_();
		}

		public override void Update_()
		{
			_Current.Update_();
		}

		public override void CustomUpdate1(float deltaTime)
		{
			_Current.CustomUpdate1(deltaTime);
		}

		public override void CustomUpdate2(float deltaTime)
		{
			_Current.CustomUpdate2(deltaTime);
		}
		public override void CustomUpdate3(float deltaTime)
		{
			_Current.CustomUpdate3(deltaTime);
		}


		// TODO
		//public override void Enter(params object[] args)
		//{

		//}

		// TODO
		public override void OnMachineDestroyed()
		{
			//foreach (var mach in States)
			//{
			//	if (mach == null) continue;
			//	//mach.On();
			//}
		}

		public override void OnDrawGizmos_()
		{
			_Current.OnDrawGizmos_();
		}
	}
}
