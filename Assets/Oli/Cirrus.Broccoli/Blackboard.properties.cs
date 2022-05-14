using Cirrus.Collections;
using System;
using System.Collections.Generic;

namespace Cirrus.Broccoli
{
	public enum BtBlackboardOp
	{
		Add,
		Remove,
		Change,
		Touch
	}

	public partial class Blackboard
	{
		private struct Notification
		{
			public object Key;
			public BtBlackboardOp Op;
			public object Value;

			public Notification(object key, BtBlackboardOp op, object value)
			{
				Key = key;
				Op = op;
				Value = value;
			}
		}

		private Clock _clock;
		private Dictionary<object, object> _data = new Dictionary<object, object>();

		private Dictionary<object, System.Collections.Generic.List<Action<BtBlackboardOp, object>>> _observers = new Dictionary<object, System.Collections.Generic.List<Action<BtBlackboardOp, object>>>();
		private bool _isNotifiyng = false;
		private Dictionary<object, System.Collections.Generic.List<Action<BtBlackboardOp, object>>> _addObservers = new Dictionary<object, System.Collections.Generic.List<Action<BtBlackboardOp, object>>>();
		private Dictionary<object, System.Collections.Generic.List<Action<BtBlackboardOp, object>>> _removeObservers = new Dictionary<object, System.Collections.Generic.List<Action<BtBlackboardOp, object>>>();
		private System.Collections.Generic.List<Notification> _notifications = new System.Collections.Generic.List<Notification>();
		private System.Collections.Generic.List<Notification> _notificationsDispatch = new System.Collections.Generic.List<Notification>();
		private Blackboard _parentBlackboard;
		private HashSet<Blackboard> _children = new HashSet<Blackboard>();

#if UNITY_EDITOR

		public System.Collections.Generic.List<object> Keys
		{
			get
			{
				if(_parentBlackboard != null)
				{
					System.Collections.Generic.List<object> keys = _parentBlackboard.Keys;
					keys.AddRange(_data.Keys);
					return keys;
				}
				else
				{
					return new System.Collections.Generic.List<object>(_data.Keys);
				}
			}
		}

		public int NumObservers
		{
			get
			{
				int count = 0;
				foreach(string key in _observers.Keys)
				{
					count += _observers[key].Count;
				}
				return count;
			}
		}

#endif
	}
}