using Cirrus.Collections;
using System.Collections.Generic;
//using Cirrus.UnityUnity.EditorExt;
//using Priority_Queue;
using System.Linq;

namespace Cirrus.States
{

	// TODO nest another state inside
	public partial class ConcurrentStateBase<StateMachineType, StateType>
	{
		// TODO: MUTEX LOCK HERE: IF WE ARE SETTING THE STATE
		//public virtual IEnumerable<StateType> GetStates() => ArrayUtils.Empty<StateType>();

		public override StateMachineType Context
		{
			set
			{
				base.Context = value;
				GetStates().UniqueForEach(state =>
				{
					var stateOfMachine = state as IState<StateMachineType>;
					if(stateOfMachine != null) return;
					// TODO can we fix this?
					stateOfMachine.Context = value;
				});
			}
			get
			{
				return base.Context;
			}
		}

		public IEnumerable<StateType> States { get; set; } = ArrayUtils.Empty<StateType>();

		public virtual IEnumerable<StateType> GetStates() => States;

		public override string Name =>
			string.Join("-", GetStates().Select(x => x.Name));

	}

	// TODO nest another state inside
	//public partial class SimultaneousStateBase<StateMachineType>
	//{
	//	// TODO: MUTEX LOCK HERE: IF WE ARE SETTING THE STATE
	//	public virtual IEnumerable<IState> GetStates() => ArrayUtils.Empty<IState>();

	//	public override string Name =>
	//		string.Join("-", GetStates().Select(x => x.Name));

	//}
}