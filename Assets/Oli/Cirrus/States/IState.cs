using Cirrus.Objects;
using System;

namespace Cirrus.States
{
	// Encompasses : Behavioral design patterns

	public interface IState
	{

		string Name { get; set; }

		int ID { get; set; }

		StateMachineStatus Enter();

		StateMachineStatus Reenter();

		// TODO  catch if state can be indeed exited
		StateMachineStatus Exit();

		void Update_();

		void FixedUpdate_();

		void LateUpdate_();

		void CustomUpdate1(float deltaTime);

		void CustomUpdate2(float deltaTime);

		void CustomUpdate3(float deltaTime);

		void OnDrawGizmos_();

		void OnMachineDestroyed();

		StateMachineStatus __OBSOLETE_SetSubState(int state, Func<IState, bool> pred = null);

		StateMachineStatus __OBSOLETE_SetSubState(IState state, Func<IState, bool> pred = null);
	}

	public interface IState<TContext> : IState
	{
		TContext Context { get; set; }
	}

	public interface ICloneableState 
	: IState
	// , IRealizablePrototype
	{
	}

	public interface ICloneableState<StateMachineType> 
	: IState<StateMachineType>
	// , IRealizablePrototype
	where StateMachineType : IStateMachine
	{
	}

}
