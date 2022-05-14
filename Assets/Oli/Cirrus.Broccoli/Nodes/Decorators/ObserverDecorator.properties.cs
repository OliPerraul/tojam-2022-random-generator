using Cirrus.Broccoli;
using System;

using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Broccoli
{
	public enum ObserverNodeResult
	{
		None,
		Success,
		Failure
	}

	/// <summary>
	/// stopsOnChange
	/// </summary>
	public enum ObserverNodeStopMode
	{
		/// <summary>
		/// the decorator will only check it's condition once it is started and will never stop any
		/// running nodes.
		/// </summary>
		None,

		/// <summary>
		/// the decorator will check it's condition once it is started and if it is met, it will
		/// observe the blackboard for changes. Once the condition is no longer met, it will stop
		/// itself allowing the parent composite to proceed with it's next node.
		/// </summary>
		Self,

		/// <summary>
		/// the decorator will check it's condition once it is started and if it's not met, it will
		/// observe the blackboard for changes. Once the condition is met, it will stop the lower
		/// priority node allowing the parent composite to proceed with it's next node.
		/// </summary>
		LowerPriority,

		/// <summary>
		/// the decorator will stop both: self and lower priority nodes.
		/// </summary>
		Both,

		/// <summary>
		/// the decorator will check it's condition once it is started and if it's not met, it will
		/// observe the blackboard for changes. Once the condition is met, it will stop the lower
		/// priority node and order the parent composite to restart the Decorator immediately
		/// </summary>
		ImmediateRestart,

		/// <summary>
		/// the decorator will check it's condition once it is started and if it's not met, it will
		/// observe the blackboard for changes. Once the condition is met, it will stop the lower
		/// priority node and order the parent composite to restart the Decorator immediately. As in
		/// BOTH it will also stop itself as soon as the condition is no longer met.
		/// </summary>
		LowerPriorityImmediateRestart
	}

	public abstract partial class ObserverDecoratorBase : DecoratorNodeBase
	{
		public ObserverNodeStopMode StopsOnChange = ObserverNodeStopMode.Self;

		private bool _isObserving;	
	}
}