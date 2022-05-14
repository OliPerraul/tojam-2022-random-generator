//using Cirrus.UnityUnity.EditorExt;
//using Priority_Queue;
using System;
namespace Cirrus.States
{

	public abstract partial class StateMachineBase : IStateMachine
	{
		public abstract bool Get(int id, out IState state);

		public abstract bool Get(Type type, out IState state);

		public abstract StateMachineStatus AddState(IState state);

		public abstract StateMachineStatus SetState(IState state);

		public abstract StateMachineStatus SetState(int id);

		public StateMachineStatus SetState<T>(T state)
			where T : Enum
		{
			return SetState((int)(object)state);
		}

		//public virtual void AddState(
		//	IState state,
		//	bool start,
		//	bool isStart = false)
		//{
		//	if (AddOneState(state).Succeeded())
		//	{
		//		if (isStart) SetState(state.ID);
		//	}
		//}

		public virtual void Disable()
		{
			if(State == null) return;
			_enabled = false;
		}

		public virtual void Enable()
		{
			if(State == null) return;
			_enabled = true;
		}

		public virtual void Start()
		{
			if(State == null) return;
			_enabled = true;
			this.EnterState(State);
		}

		public virtual void Stop()
		{
			_enabled = false;
			State?.Exit();
		}

		public virtual void OnDrawGizmos_()
		{
			if(!_enabled) return;

			State?.OnDrawGizmos_();
		}


		public StateMachineBase(params IState[] states)
		{
			foreach(var state in states) AddState(state);
			if(states.Length != 0) SetState(states[0]);
		}

		public virtual void Update_()
		{
			if(!_enabled) return;

			State.Update_();
		}

		public virtual void FixedUpdate_()
		{
			if(!_enabled) return;

			State?.FixedUpdate_();
		}

		public virtual void LateUpdate_()
		{
			if(!_enabled) return;

			State?.LateUpdate_();
		}

		public virtual void CustomUpdate1(float deltaTime = 0)
		{
			if(!_enabled) return;

			State?.CustomUpdate1(deltaTime);
		}

		public virtual void CustomUpdate2(float deltaTime = 0)
		{
			if(!_enabled) return;

			State?.CustomUpdate2(deltaTime);
		}

		public virtual void CustomUpdate3(float deltaTime = 0)
		{
			if(!_enabled) return;

			State?.CustomUpdate3(deltaTime);
		}


		public virtual StateMachineStatus __OBSOLETE_SetSubState(IState state, Func<IState, bool> pred = null)
		{
			if(State == null) return StateMachineStatus.Failure;

			return State.__OBSOLETE_SetSubState(state, pred);
		}

		public virtual StateMachineStatus __OBSOLETE_SetSubState(int state, Func<IState, bool> pred = null)
		{
			if(State == null) return StateMachineStatus.Failure;

			return State.__OBSOLETE_SetSubState(state, pred);
		}

		public virtual StateMachineStatus RemoveSubState(IState state)
		{
			return StateMachineStatus.Failure;
		}
	}
}