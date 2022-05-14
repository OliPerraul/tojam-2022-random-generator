////using Priority_Queue;
////using Cirrus.UnityDH.Attributes;
//using Cirrus.Collections;
//using System;
//using System.Collections.Generic;
//using System.Threading;
//using UnityEngine;

//namespace Cirrus.States
//{
//	using Queue = BHeap<IState>;

//	// TODO deprecate this?
//	public partial class MultiplePriorityQueueStateMachine : StateMachineBase, IStateMachine
//	{
//		public override bool Get(int id, out IState state)
//		{
//			state = null;

//			if(id < 0) state = _defaultQueue.First;

//			if(_dictionary.TryGetValue(id, out Queue queue) && queue.Count != 0)
//			{
//				state = queue.First;
//			}

//			return state != null;
//		}

//		public override bool Get(Type type, out IState state)
//		{
//			state = null;

//			foreach(var pair in _dictionary)
//			{
//				var queue = pair.Value;
//				if(queue.First.GetType() == type)
//				{
//					state = queue.First;
//					return true;
//				}
//			}

//			return false;

//		}

//		public override StateMachineStatus SetNextState(params object[] args)
//		{
//			IState previous = State;
//			if(State == null) return StateMachineStatus.NullState;
//			if(State.SetNextState(args).Succeeded(out StateMachineStatus ret)) return ret;
//			if(this.ExitState(previous).Succeeded())
//			{
//				_currentQueue.Extract();
//				if(_currentQueue.Count == 0) _currentQueue = _defaultQueue;

//				if(State != null)
//				{
//					return
//						previous == State ?
//							this.ReenterState(State, args) :
//							this.EnterState(State, args);										
//				}

//				return StateMachineStatus.Exited;
//			}

//			return StateMachineStatus.HasNextFailed;
//		}

//		public static Queue MakeQueue()
//		{
//			return new Queue(
//				SortDirection.Descending,
//				Comparer<IState>.Create((x, y) =>
//				{
//					if (x.Priority > y.Priority) return -1;
//					else if (x.Priority == y.Priority) return 0;
//					else return 1;
//				}));
//		}

//		public override void OnDrawGizmos_()
//		{
//			base.OnDrawGizmos_();
//		}

//		public MultiplePriorityQueueStateMachine(params IState[] states) : base(states)
//		{
//			_currentQueue = _defaultQueue;
//		}

//		// TODO
//		public override StateMachineStatus SetState(IState state, params object[] args)
//		{
//			var previous = State;
//			StateMachineStatus ret = StateMachineStatus.Failed;

//			if(_dictionary.TryGetValue(state.ID, out Queue queue) && queue.Count != 0)
//			{
//				if(queue.First != previous)
//				{
//					if(!_enabled) ret = StateMachineStatus.Disabled;
//					else if(this.ExitState(previous).Succeeded())
//					{
//						ret = this.EnterState(queue.First, args);
//					}

//					_currentQueue = queue;
//				}
//				else if(queue.First == previous)
//				{
//					ret = this.ReenterState(queue.First, args);
//				}
//			}

//			if(previous != State) OnStateChangedHandler?.Invoke(State);

//			return ret;
//		}


//		public override StateMachineStatus SetState(int id, params object[] args)
//		{
//			var previous = State;
//			StateMachineStatus ret = StateMachineStatus.Failed;

//			if (_dictionary.TryGetValue(id, out Queue queue) && queue.Count != 0)
//			{
//				if (queue.First != previous)
//				{
//					if (!_enabled) ret = StateMachineStatus.Disabled;
//					else if(this.ExitState(previous).Succeeded())
//					{
//						return this.EnterState(queue.First, args);						
//					}

//					_currentQueue = queue;
//				}
//				else if(queue.First == previous)
//				{
//					return this.ReenterState(queue.First, args);					
//				}
//			}

//			if (previous != State) OnStateChangedHandler?.Invoke(State);

//			return ret;
//		}

//		public override StateMachineStatus AddState(
//			IState state,
//			params object[] args)
//		{
//			Queue queue = null;

//			StateMachineStatus ret = StateMachineStatus.Failed;

//			var previous = State;

//			if (state.ID < 0) queue = _defaultQueue;

//			else if (
//				!_dictionary.TryGetValue(
//				state.ID,
//				out queue))
//			{
//				queue = MakeQueue();
//				_dictionary.Add(state.ID, queue);				
//			}

//			if(queue != null)
//			{ 
//				queue.Insert(state);
//				ret = StateMachineStatus.Added;
//				// Only enter new state if pushed into current queue
//				// and new state is at the top
//				if(!_enabled)
//				{
//					ret = StateMachineStatus.Disabled;
//				}
//				else
//				{
//					if(previous != State)
//					{
//						if(previous == null || this.ExitState(previous).Succeeded())
//						{
//							this.EnterState(state, args);
//							OnStateChangedHandler?.Invoke(State);
//							ret = StateMachineStatus.Success;
//						}
//						else ret = StateMachineStatus.ExitFailed;
//					}
//					else
//					{
//						this.ReenterState(state, args);
//						ret = StateMachineStatus.Reentered;
//					}
//				}
//			}

//			if(
//				State == null &&
//				ret.Succeeded())
//			{
//				ret = SetState(state);				
//			}

//			return ret;
//		}	
//	}
//}