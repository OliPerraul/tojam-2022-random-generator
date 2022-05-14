using Cirrus.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.States
{
	public interface IStateMachine
	{
		IState State { get; }

		Stack<IState> Stack { get; set; }

		SimpleBHeap2<IState> PriorityQueue { get; set; }

		//void AddState(
		//	IState state,
		//	bool isStart = false);

		bool Get(int id, out IState state);

		bool Get(Type type, out IState state);


		void Start();

		void Stop();

		//StateMachineStatus Next(params object[] args);

		void Disable();

		void Enable();

		void Update_();

		void __UpdateStateLabel(GameObject label);

		void FixedUpdate_();


		void LateUpdate_();

		void CustomUpdate1(float deltaTime);

		void CustomUpdate2(float deltaTime);

		void CustomUpdate3(float deltaTime);

		//:::::::::::::::::::::::::::::::::::::::::::::

		//StateMachineStatus __OBSOLETE_SetSubState(IState state, Func<IState, bool> pred=null);

		//StateMachineStatus __OBSOLETE_SetSubState(int state, Func<IState, bool> pred=null);


		// TODO remove args 
		StateMachineStatus AddState(IState state);

		StateMachineStatus SetState(int id);

		StateMachineStatus SetState(IState state);
		Action<IState> OnStateChangedHandler { get; set; }

		//:::::::::::::::::::::::::::::::::::::::::::::

		//StateMachineStatus RemoveSubState(
		//	IState state,
		//	params object[] args);

		//StateMachineStatus PopStaleStates(
		//	params object[] args);

		//:::::::::::::::::::::::::::::::::::::::::::::


		void OnDrawGizmos_();
	}
}
