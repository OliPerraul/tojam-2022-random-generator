using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.States
{

	public enum StateMachineStatus : int
	{
		/// StateMachine
		Obsolete = -4,
		Unknown = -3,
		Invalid = -2,
		Failure = -1,
		Canceled,
		Success
	}


	public partial class StateMachine
	{
		// public object[] Context { get; set; }

		//private Mutex _mutex = new Mutex();

		private Dictionary<int, IState> _dictionary = new Dictionary<int, IState>();

		private IState _current = null;

		[SerializeField]
		public override IState State => _current;

		public string StateName = "";
	}
}
