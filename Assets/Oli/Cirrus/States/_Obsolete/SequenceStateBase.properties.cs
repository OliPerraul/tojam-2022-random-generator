using Cirrus.Collections;
using System.Collections.Generic;

namespace Cirrus.States
{
	public partial class StateSequenceBase<StateMachineType, StateType>
	{
		public virtual IEnumerable<StateType> GetStates() => States;

		public virtual IEnumerable<StateType> States { get; set; } = ArrayUtils.Empty<StateType>();

		private IEnumerator<StateType> _enumerator;

		private bool _hasEnumeratorStarted = false;

		protected IState _Current => _enumerator.Current;

		public override string Name =>
			_enumerator == null ?
			StateMachineUtils.InvalidStateName :
			_Current.Name;

		public override StateMachineType Context
		{
			set
			{
				base.Context = value;
				GetStates().UniqueForEach(state =>
				{
					state.Context = value;
				});
			}
			get
			{
				return base.Context;
			}
		}
	}
}
