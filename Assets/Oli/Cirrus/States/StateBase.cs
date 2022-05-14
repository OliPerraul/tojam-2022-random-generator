using Cirrus.Objects;
using System; //using Advanced.Algorithms;

namespace Cirrus.States
{
	[Serializable]
	public abstract partial class StateBase<TContext>
		: Base
		, IState<TContext>
	{

		//bool IState.IsStale { get; set; } = false;

		public StateBase()
		{

		}

		public StateBase(TContext context)
		{
			Context = context;
		}

		public virtual StateMachineStatus AddSubState(int stateID)
		{
			return StateMachineStatus.Failure;
		}

		public virtual StateMachineStatus RemoveSubState()
		{
			return StateMachineStatus.Failure;
		}

		public virtual StateMachineStatus __OBSOLETE_SetSubState(IState state, Func<IState, bool> pred = null)
		{
			return StateMachineStatus.Failure;
		}

		public virtual StateMachineStatus __OBSOLETE_SetSubState(int state, Func<IState, bool> pred = null)
		{
			return StateMachineStatus.Failure;
		}

		public virtual StateMachineStatus Enter() { return StateMachineStatus.Success; }

		public virtual StateMachineStatus Reenter() { return StateMachineStatus.Success; }

		public virtual StateMachineStatus Exit() { return StateMachineStatus.Success; }

		public virtual void Update_() { }

		public virtual void FixedUpdate_() { }

		public virtual void LateUpdate_() { }

		public virtual void CustomUpdate1(float deltaTime = 0) { }

		public virtual void CustomUpdate2(float deltaTime = 0) { }

		public virtual void CustomUpdate3(float deltaTime = 0) { }

		public virtual void OnDrawGizmos_() { }

		public virtual void OnMachineDestroyed() { }
	}
}
