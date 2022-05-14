using Cirrus.States;
using Cirrus.Unity.Objects;
using System;

namespace Cirrus.Unity.States
{
	public partial class StateComponentBase : CustomMonoBehaviourBase, IState
	{
		public virtual void CustomUpdate1(float deltaTime)
		{
		}

		public virtual void CustomUpdate2(float deltaTime)
		{
		}

		public virtual void CustomUpdate3(float deltaTime)
		{
		}

		public virtual StateMachineStatus Enter()
		{
			return StateMachineStatus.Success;
		}

		public virtual StateMachineStatus Reenter()
		{
			return StateMachineStatus.Success;
		}

		public virtual StateMachineStatus Exit()
		{
			return StateMachineStatus.Success;
		}

		public virtual StateMachineStatus SetNextState()
		{
			return StateMachineStatus.Failure;
		}

		public virtual void FixedUpdate_()
		{
		}

		public virtual void OnDrawGizmos_()
		{
		}

		public virtual void OnMachineDestroyed()
		{
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

		public virtual void Update_()
		{
		}

		public virtual void LateUpdate_()
		{
		}
	}
}