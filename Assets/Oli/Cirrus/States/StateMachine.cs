using System;

namespace Cirrus.States
{
	public partial class StateMachine : StateMachineBase, IStateMachine
	{
		public StateMachine(params IState[] states) : base(states) { }

		public override bool Get(int id, out IState state)
		{
			return _dictionary.TryGetValue(id, out state);
		}

		public override bool Get(Type type, out IState state)
		{
			state = null;
			foreach(var pair in _dictionary)
			{
				if(pair.Value.GetType() == type)
				{
					state = pair.Value;
					return true;
				}
			}

			return false;
		}

		private StateMachineStatus _SetState(IState state)
		{
			StateMachineStatus ret = StateMachineStatus.Failure;

			if(_current != state)
			{
				if(_enabled)
				{
					if(this.ExitState(State).Succeeded())
					{
						ret = this.EnterState(state);
						_current = state;
					}
				}
				else
				{
					_current = state;
					ret = StateMachineStatus.Success;
				}
			}
			else if(_current == state && _enabled)
			{
				ret = this.ReenterState(state);
			}

			return ret;
		}

		public override StateMachineStatus SetState(IState state)
		{
			return _SetState(state);
		}

		public override StateMachineStatus SetState(int id)
		{
			StateMachineStatus ret = StateMachineStatus.Failure;

			if(_dictionary.TryGetValue(id, out IState state))
			{
				ret = _SetState(state);
			}

			return ret;
		}

		//public override

		public override StateMachineStatus AddState(IState state)
		{
			StateMachineStatus ret = StateMachineStatus.Failure;

			if(_dictionary.TryGetValue(
				state.ID,
				out IState result))
			{
				//if(result.Priority <= state.Priority)
				if(state != result)
				{
					_dictionary.Remove(state.ID);
					_dictionary.Add(state.ID, state);

					if(!_enabled)
						ret = StateMachineStatus.Failure;
					else if(this.ExitState(result).Succeeded())
						ret = this.EnterState(state);

				}
				else ret = this.ReenterState(state);
			}
			else
			{
				_dictionary.Add(state.ID, state);
				ret = StateMachineStatus.Success;
			}

			if(ret.Succeeded())
			{
				if(_current == null)
				{
					SetState(state);
				}
			}

			return ret;
		}
	}
}