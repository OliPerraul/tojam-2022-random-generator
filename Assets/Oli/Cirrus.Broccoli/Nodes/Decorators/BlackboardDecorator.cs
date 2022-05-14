using Cirrus.Objects;
using Cirrus.Debugging;
using System;
using static Cirrus.Debugging.DebugUtils;

namespace Cirrus.Broccoli
{
	public partial class BlackboardDecorator<TValue>
	{
		public BlackboardDecorator(
			string name
			, TValue value
			) : base(name)
		{
			Key = value.GetType();
			Value = value;
		}


		/// <summary>
		/// TODO: we must have blackboards which handles multiple states (if the nodes are redundante)
		/// </summary>
		/// <param name="value"></param>
		/// <param name="ctorCb"></param>
		public BlackboardDecorator(TValue value, Func<TValue, TValue, bool> compare=null) : base()
		{
			Name = value.ToString();
			Key = value.GetType();
			Value = value;
			CompareCb = compare;
		}
	}

	public partial class BlackboardDecorator<TKey, TValue>
	{
		public BlackboardDecorator() : base()
		{
		}

		public BlackboardDecorator(string name) : base(name)
		{
		}
		public BlackboardDecorator(string name, object obj) : base(name, obj)
		{
		}

		public BlackboardDecorator(object obj) : base(obj)
		{
		}

		public BlackboardDecorator(TKey key, TValue value, Func<TValue, TValue, bool> compare=null) : base()
		{
			Key = key;
			Value = value;
			CompareCb = compare;
		}

		protected override void _Init()
		{
			//InitCb?.Invoke(Context, this);
		}

		protected override void _OnObservedSubjectChanged()
		{
			_Evaluate(Root.Blackboard.Get(Key));
		}

		protected override void _StartObserving()
		{
			Root.Blackboard.AddObserver(Key, _OnBlackboardValueChanged);
		}

		protected override void _StopObserving()
		{
			Root.Blackboard.RemoveObserver(Key, _OnBlackboardValueChanged);
		}

		private void _OnBlackboardValueChanged(BtBlackboardOp op, object newValue)
		{
			_Evaluate(newValue);
		}

		protected override ObserverNodeResult _IsSatisfiedInternal()
		{
			object result = Root.Blackboard.Get(Key);
			return _IsSatisfiedInternal(result);
		}

		protected override void _OnStopped(bool success)
		{
			base._OnStopped(success);

			// TODO: problem here/ for now just make sure to set blackboard value on exit then
			//if (
			//	Cleanup &&
			//	SatisfCb == null &&
			//	Root.Blackboard.Get<TValue>(Key).CompareTo(Value) == 0
			//	)
			//{
			//	Root.Blackboard.Unset(Key, true);
			//}
		}

		protected bool _IsSatisfied(TValue value)
		{
			return CompareCb == null ? ((IComparable)value).CompareTo(Value) == 0 : CompareCb(value, Value);
		}

		protected override ObserverNodeResult _IsSatisfiedInternal(object newValue)
		{
			//if(!AssertDidNotFail(newValue != null, AssertType.One, "", true)) return ObserverNodeResult.Failure;
			if (newValue == null) return ObserverNodeResult.Failure;
			if (_IsSatisfied((TValue)newValue))
			{
				OnSatisfiedHandler?.Invoke(this);
				return ObserverNodeResult.Success;
			}

			return ObserverNodeResult.Failure;
		}
	}
}