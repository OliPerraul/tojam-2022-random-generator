using Cirrus.Objects; //using Cirrus.UnityUnity.EditorExt;
using System;
//using Priority_Queue;

namespace Cirrus.States
{

	// TODO nest another state inside



	public abstract partial class ConcurrentStateBase<StateMachineType, StateType>
		: StateBase<StateMachineType>
		where StateMachineType : class, IStateMachine
		where StateType 
		: class
		, IState
		// , IRealizablePrototype
	{

		public ConcurrentStateBase(StateMachineType machine) : base(machine)
		{
		}

		public ConcurrentStateBase() : base(null)
		{

		}

		public override StateMachineStatus __OBSOLETE_SetSubState(IState state, Func<IState, bool> pred = null)
		{
			StateMachineStatus ret = StateMachineStatus.Failure;
			foreach(var s in GetStates())
			{
				var machine = s as IStateMachine;
				if(machine != null)
				{
					if(pred != null && !pred(s)) continue;
					ret = machine.SetState(state);
				}
			}

			return ret;
		}

		public override StateMachineStatus __OBSOLETE_SetSubState(int state, Func<IState, bool> pred = null)
		{
			StateMachineStatus ret = StateMachineStatus.Failure;
			foreach(var s in GetStates())
			{
				if(s == null) continue;
				var machine = s as IStateMachine;
				if(machine != null)
				{
					if(pred != null && !pred(s)) continue;
					ret = machine.SetState(state);
				}
			}

			return ret;
		}

		public override void FixedUpdate_()
		{
			foreach(var s in GetStates())
			{
				if(s == null) continue;
				s.FixedUpdate_();
			}
		}

		public override void Update_()
		{
			foreach(var s in GetStates())
			{
				if(s == null) continue;
				s.Update_();
			}
		}

		public override void CustomUpdate1(float deltaTime)
		{
			foreach(var s in GetStates())
			{
				if(s == null) continue;
				s.CustomUpdate1(deltaTime);
			}
		}

		public override void CustomUpdate2(float deltaTime)
		{
			foreach(var s in GetStates())
			{
				if(s == null) continue;
				s.CustomUpdate2(deltaTime);
			}
		}

		public override void CustomUpdate3(float deltaTime)
		{
			foreach(var s in GetStates())
			{
				if(s == null) continue;
				s.CustomUpdate3(deltaTime);
			}
		}

		// TODO
		public override StateMachineStatus Enter()
		{
			// TODO catch warnings here
			foreach(var s in GetStates())
			{
				if(s == null) continue;

				// TODO: is assignable from
				else if(s is IStateMachine)
				{
					((IStateMachine)s).Start();
				}

				else return s.Enter();
			}

			return StateMachineStatus.Success;
		}

		// TODO
		public override void OnMachineDestroyed()
		{
			foreach(var mach in GetStates())
			{
				if(mach == null) continue;
				//mach.On();
			}
		}

		public override void OnDrawGizmos_()
		{
			foreach(var mach in GetStates())
			{
				if(mach == null) continue;
				mach.OnDrawGizmos_();
			}
		}
	}
}