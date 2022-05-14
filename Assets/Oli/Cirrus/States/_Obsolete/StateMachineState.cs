//using Cirrus.Collections;
//using Cirrus.Objects;
//using System;
//using System.Collections.Generic;
//using UnityEngine;

//namespace Cirrus.States
//{
//	public partial class StateMachineState
//		: IState
//		, IStateMachine
//		// TODO remove
//		, ICloneableState
//	{

//		public List<object> Decorators { get; set; }

//		object IPrototype.ShallowClone()
//		{
//			return MemberwiseClone();
//		}

//		public void OnCloned()
//		{
//		}


//		public object Clone()
//		{
//			return MemberwiseClone();
//		}

//		public IStateMachine StateMachine;

//		public Action<IState> OnStateChangedHandler { get; set; }

//		public Stack<IState> Stack { get; set; }

//		public SimpleBHeap2<IState> PriorityQueue { get; set; }

//		public bool Get(int id, out IState state)
//		{
//			return StateMachine.Get(id, out state);
//		}

//		public bool Get(Type type, out IState state)
//		{
//			return StateMachine.Get(type, out state);
//		}

//		public StateMachineState(IStateMachine machine)
//		{
//			StateMachine = machine;
//		}

//		public void CustomUpdate1(float deltaTime)
//		{
//			StateMachine.CustomUpdate1(deltaTime);
//		}

//		public void CustomUpdate2(float deltaTime)
//		{
//			StateMachine.CustomUpdate2(deltaTime);
//		}

//		public void CustomUpdate3(float deltaTime)
//		{
//			StateMachine.CustomUpdate3(deltaTime);
//		}

//		public void Disable()
//		{
//			StateMachine.Disable();
//		}

//		public void Enable()
//		{
//			StateMachine.Enable();
//		}

//		public StateMachineStatus Enter()
//		{
//			StateMachine.Start();
//			return StateMachineStatus.Success;

//		}

//		public StateMachineStatus Reenter()
//		{
//			return State.Reenter();
//		}

//		public StateMachineStatus Exit()
//		{
//			StateMachine.Stop();
//			return StateMachineStatus.Exited;
//		}

//		public void FixedUpdate_()
//		{
//			StateMachine.FixedUpdate_();
//		}

//		public void LateUpdate_()
//		{
//			StateMachine.LateUpdate_();
//		}


//		public void OnDrawGizmos_()
//		{
//			StateMachine.OnDrawGizmos_();
//		}

//		public void OnMachineDestroyed()
//		{
//			State.OnMachineDestroyed();
//		}

//		//public StateMachineStatus PopStaleStates(params object[] args)
//		//{
//		//	return StateMachine.PopStaleStates(args);
//		//}

//		//public StateMachineStatus RemoveSubState(IState state, params object[] args)
//		//{
//		//	return StateMachine.RemoveSubState(state, args);
//		//}

//		public StateMachineStatus RemoveSubState()
//		{
//			return StateMachineStatus.Failed;
//			//return State.RemoveSubState();
//		}

//		public StateMachineStatus AddState(IState state)
//		{
//			return StateMachine.AddState(state);
//		}

//		public StateMachineStatus SetSubState(IState state)
//		{
//			return StateMachine.SetSubState(state);
//		}

//		//public bool AddSubState(IState state, params object[] args)
//		//{
//		//	return StateMachine.AddSubState((IState)state, args);
//		//}

//		public StateMachineStatus SetState(int id)
//		{
//			return StateMachine.SetState(id);
//		}

//		public StateMachineStatus SetState(IState state)
//		{
//			return StateMachine.SetState(state);
//		}

//		public StateMachineStatus SetSubState(int stateID)
//		{
//			return StateMachine.SetSubState(stateID);
//		}

//		public void Start()
//		{
//			StateMachine.Start();
//		}

//		public void Stop()
//		{
//			StateMachine.Stop();
//		}

//		public StateMachineStatus Update_()
//		{
//			return StateMachine.Update_();
//		}

//		public void UpdateStateLabel(GameObject label)
//		{
//			StateMachine.UpdateStateLabel(label);
//		}
//	}
//}
