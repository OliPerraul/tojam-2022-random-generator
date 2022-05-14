using Cirrus.States;
using Cirrus.Unity.Objects;
using System;
using UnityEngine;
//using Priority_Queue;

namespace Cirrus.Unity.States
{
	/// <summary>
	/// TODO Handle events do not force everything to appear in the loop
	/// Make it so that some states respond to events
	/// </summary>   
	public partial class StateMachineComponent
		: CustomMonoBehaviourBase
		, IStateMachine
	{
		public override void Awake()
		{
			base.Awake();
		}

		public override void Start()
		{
			base.Start();

			if(StateMachine == null) StateMachine = new StateMachine();
			foreach(var state in GetComponents<StateComponentBase>())
			{
				StateMachine.AddState(state);
			}

			if(_StartMode == StartMode.Start)
			{
				Debug.Assert(StateMachine != null, "Make sure to populate the state machine!");
				StateMachine.Start();
			}
		}

		public override void LateStart()
		{
			base.LateStart();

			if(_StartMode == StartMode.LateStart)
			{
				Debug.Assert(StateMachine != null, "Make sure to populate the state machine!");
				StateMachine.Start();
			}
		}

		public void Stop()
		{
			StateMachine.Stop();
		}

		public override void LateLateStart()
		{
			base.LateLateStart();

			if(_StartMode == StartMode.LateLateStart)
			{
				Debug.Assert(StateMachine != null, "Make sure to populate the state machine!");
				StateMachine.Start();
			}
		}

		public void __UpdateStateLabel(GameObject label)
		{
			if(label != null)
			{
				StateMachine.__UpdateStateLabel(label);
			}
		}

		public override void OnValidate()
		{
			base.OnValidate();

			if(_stateLabel != null) _stateLabel.SetActive(_enableStateLabel);
		}

		public void Update()
		{
			if(_IsApplicationQuit) return;

			StateMachine.Update_();
#if UNITY_EDITOR
			__UpdateStateLabel(_stateLabel);
#endif
		}

		public void FixedUpdate()
		{
			if(_IsApplicationQuit) return;

			StateMachine.FixedUpdate_();
		}

		public void LateUpdate()
		{
			if(_IsApplicationQuit) return;

			StateMachine.LateUpdate_();
		}

		public void LateUpdate_()
		{
			LateUpdate();
		}


		public void OnDrawGizmos()
		{
			if(StateMachine != null)
			{
				StateMachine.OnDrawGizmos_();
			}
		}

		public StateMachineStatus AddState(IState state)
		{
			return StateMachine.AddState(state);
		}

		public void Disable()
		{
			StateMachine.Disable();
		}

		public void Enable()
		{
			StateMachine.Enable();
		}

		//public bool PopState(int from, params object[] args)
		//{
		//	return StateMachine.PopState(from, args);
		//}

		// TODO : replace with if IsStale : then just Next()

		//public StateMachineStatus PopStaleStates(params object[] args)
		//{
		//	return StateMachine.PopStaleStates(args);
		//}

		//public StateMachineStatus AddOneState(IState state, params object[] args)
		//{
		//	return StateMachine.SetState(state.ID, args);
		//}


		public StateMachineStatus SetState(int state)
		{
			return StateMachine.SetState(state);
		}

		public StateMachineStatus SetState<T>(T state)
			where T : System.Enum
		{
			return SetState((int)(object)state);
		}

		public StateMachineStatus SetState(IState state)
		{
			return StateMachine.SetState(state);
		}

		public StateMachineStatus __OBSOLETE_SetSubState(IState state, Func<IState, bool> pred = null)
		{
			return StateMachine.__OBSOLETE_SetSubState(state, pred);
		}

		public StateMachineStatus RemoveSubState(IState state)
		{
			return StateMachine.RemoveSubState(state);
		}

		public StateMachineStatus __OBSOLETE_SetSubState(int state, Func<IState, bool> pred = null)
		{
			return StateMachine.__OBSOLETE_SetSubState(state, pred);
		}

		public StateMachineStatus SetSubState<T>(T state, Func<IState, bool> pred = null) where T : System.Enum
		{
			return __OBSOLETE_SetSubState((int)(object)state, pred);
		}

		public void CustomUpdate1()
		{
			StateMachine.CustomUpdate1();
		}

		public void CustomUpdate2()
		{
			StateMachine.CustomUpdate2();
		}

		public void CustomUpdate1(float deltaTime)
		{
			StateMachine.CustomUpdate1(deltaTime);
		}

		public void CustomUpdate2(float deltaTime)
		{
			StateMachine.CustomUpdate2(deltaTime);
		}

		public void CustomUpdate3(float deltaTime)
		{
			StateMachine.CustomUpdate3(deltaTime);
		}


		public void Update_()
		{
			StateMachine.Update_();
		}

		public void FixedUpdate_()
		{
			FixedUpdate();
		}

		public void OnDrawGizmos_()
		{
			OnDrawGizmos();
		}

		public bool Get(int id, out IState state)
		{
			return StateMachine.Get(id, out state);
		}
		public bool Get(Type type, out IState state)
		{
			state = null;
			if(StateMachine == null) return false;
			return StateMachine.Get(type, out state);
		}

	}
}
