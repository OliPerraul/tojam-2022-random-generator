using Cirrus.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cirrus.States
{
	public static class StateMachineUtils
	{
		public static bool Succeeded(this StateMachineStatus ret)
		{
			return ((int)ret) > -1;
		}

		public static bool Succeeded(this StateMachineStatus ret, out StateMachineStatus status)
		{
			status = ret;
			return ((int)ret) > -1;
		}

		public static bool Failed(this StateMachineStatus ret)
		{
			return ((int)ret) < 0;
		}

		public static bool Failed(this StateMachineStatus ret, out StateMachineStatus status)
		{
			status = ret;
			return ((int)ret) < 0;
		}

		public const string UnknownStateName = "Unknown";

		public const string InvalidStateName = "Invalid";

		public static StateMachineStatus EnterState(
			this IStateMachine machine,
			IState state)
		{
			if(state == null)
				return StateMachineStatus.Failure;

			if(state.Enter().Out(
				out StateMachineStatus status) >= StateMachineStatus.Success)
			{
				machine.OnStateChangedHandler?.Invoke(state);
				return status;
			}

			return StateMachineStatus.Failure;
		}

		public static StateMachineStatus ReenterState(
			this IStateMachine machine,
			IState state
			)
		{
			return state.Reenter();
		}

		public static StateMachineStatus ExitState(
			this IStateMachine machine, IState state)
		{
			return state.Exit();
		}

		public static StateMachineStatus Stack_PushState<T>(
			this IStateMachine machine,
			T id,
			Func<IState, bool> pred = null)
			where T : Enum
		{
			if(
				machine.Get((int)(object)id, out IState state)
				)
			{
				machine.Stack_PushState(state);
			}

			return StateMachineStatus.Failure;
		}

		public static StateMachineStatus Stack_PushState(
			this IStateMachine machine,
			Type type,
			Func<IState, bool> pred = null)
		{
			if(
				machine.Get(type, out IState state)
				)
			{
				return machine.Stack_PushState(state);
			}

			return StateMachineStatus.Failure;
		}

		// TODO: When state is set, just erase stack
		public static StateMachineStatus Stack_PushState(
			this IStateMachine machine,
			IState state,
			Func<IState, bool> pred = null)
		{
			if(pred != null && !pred(state)) return StateMachineStatus.Failure;

			if(machine.Stack == null) machine.Stack = new Stack<IState>();

			if(
				machine.Stack.Count == 0 &&
				machine.State != null
				)
			{
				machine.Stack.Push(machine.State);
			}

			if(machine.SetState(state).Succeeded(out StateMachineStatus stat))
			{
				machine.Stack.Push(state);
			}

			return stat;
		}

		public static StateMachineStatus Stack_PushState(
			this IStateMachine machine,
			IEnumerable<IState> states)
		{
			if(machine.Stack == null)
			{
				machine.Stack = new Stack<IState>();
			}

			StateMachineStatus stat = StateMachineStatus.Failure;
			if(machine.Stack.Count == 0)
			{
				if(machine.State != null) machine.Stack.Push(machine.State);
			}

			foreach(var state in states)
			{
				machine.Stack.Push(state);
			}

			if(machine.SetState(machine.Stack.First()).Succeeded())
			{
				stat = StateMachineStatus.Success;
			}

			return stat;
		}

		public static StateMachineStatus Stack_PopState(
			this IStateMachine machine,
			Func<IState, bool> pred = null)
		{
			if(machine.Stack == null) machine.Stack = new Stack<IState>();

			StateMachineStatus stat = StateMachineStatus.Failure;
			if(
				machine.Stack.Count > 1 &&
				(pred == null || pred(machine.Stack.Peek()))
				)
			{
				if(machine.SetState(machine.Stack.Skip(1).First()).Succeeded())
				{
					machine.Stack.Pop();
					stat = StateMachineStatus.Success;
				}
				else stat = StateMachineStatus.Failure;
			}

			return stat;
		}

		public static StateMachineStatus PriorityQueue_Enqueue(
			this IStateMachine machine,
			IState state,
			float priority)
		{
			if(machine.PriorityQueue == null)
			{
				machine.PriorityQueue = new SimpleBHeap2<IState>(SortDirection.Descending);
			}

			StateMachineStatus stat = StateMachineStatus.Failure;
			if(machine.PriorityQueue.Count == 0)
			{
				if(machine.State != null) machine.PriorityQueue.Insert(Tuple.Create(machine.State, float.NegativeInfinity));
			}

			if(machine.SetState(state).Succeeded(out stat))
			{
				machine.PriorityQueue.Insert(Tuple.Create(machine.State, priority));
			}

			return stat;
		}

		public static StateMachineStatus PriorityQueue_Enqueue(
			this IStateMachine machine,
			IEnumerable<Tuple<IState, float>> states
			)
		{
			if(machine.PriorityQueue == null)
			{
				machine.PriorityQueue = new SimpleBHeap2<IState>(SortDirection.Descending);
			}

			StateMachineStatus stat = StateMachineStatus.Failure;
			if(machine.PriorityQueue.Count == 0)
			{
				if(machine.State != null) machine.PriorityQueue.Insert(Tuple.Create(machine.State, float.NegativeInfinity));
			}

			foreach(var state in states)
			{
				machine.PriorityQueue.Insert(state);
			}

			if(machine.SetState(machine.PriorityQueue.First.Item1).Succeeded())
			{
				stat = StateMachineStatus.Success;
			}

			return stat;
		}

		public static StateMachineStatus PriorityQueue_Dequeue(
			this IStateMachine machine,
			Func<IState, bool> pred = null)
		{
			if(machine.PriorityQueue == null)
			{
				machine.PriorityQueue = new SimpleBHeap2<IState>(SortDirection.Descending);
			}

			StateMachineStatus stat = StateMachineStatus.Failure;
			if(
				machine.PriorityQueue.Count > 1 &&
				(pred == null || pred(machine.PriorityQueue.First.Item1))
				)
			{
				if(machine.SetState(machine.PriorityQueue.Skip(1).First().Item1).Succeeded())
				{
					machine.PriorityQueue.Extract();
					stat = StateMachineStatus.Success;
				}
				else stat = StateMachineStatus.Failure;
			}

			return stat;
		}

		public static StateMachineStatus SetState(
			this IStateMachine machine,
			Type type,
			params object[] args)
		{
			if(machine.Get(type, out IState state))
			{
				return machine.SetState(state);
			}

			return StateMachineStatus.Failure;
		}
	}
}