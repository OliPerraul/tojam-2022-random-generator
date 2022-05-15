using Cirrus.Events;
using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Tojam2022
{
	// TODO
	// Coroutine timer attach on game object..
	// TODO we should use coroutine or something instead..
	[Serializable]
	public class Timer
	{
		[SerializeField]
		bool _repeat = false;

		[SerializeField]
		float _limit = -1;

		public float Limit => _limit;

		[SerializeField]
		float _time = 0f;

		public float Time => _time;

		[SerializeField]
		private bool _isFixedUpdate;

		private bool _active = false;
		public bool IsActive => _active;

		//private bool _subscribed = false;

		// TODO
		//public float Increment;

		public float DeltaTime =>
			_isFixedUpdate ? UnityEngine.Time.fixedDeltaTime : UnityEngine.Time.deltaTime;

		public Action<float> OnTickHandler;

		public Action OnTimeoutHandler;

		private Action _OnClockUpdateHandler
		{
			get
			{
				return _isFixedUpdate ?
					Clock.Instance.OnFixedUpdateHandler :
					Clock.Instance.OnUpdateHandler;
			}

			set
			{
				if(_isFixedUpdate)
					Clock.Instance.OnFixedUpdateHandler = value;
				else
					Clock.Instance.OnUpdateHandler = value;
			}
		}
		public Timer(
			bool repeat = false,
			bool fixedUpdate = false
			)
		{			
			_repeat = repeat;
			_isFixedUpdate = fixedUpdate;
		}
		
		public Timer(
			float limit = 1,
			bool start = false,
			bool repeat = false,
			bool fixedUpdate = false
			)
		{
			_time = 0;
			_limit = limit;
			_repeat = repeat;
			_isFixedUpdate = fixedUpdate;
			if(start) Reset();
		}

		public Timer(
			Action OnTimeout,
			bool repeat,
			bool fixedUpdate = false
			)
		{
			OnTimeoutHandler += OnTimeout;
			_repeat = repeat;
			_isFixedUpdate = fixedUpdate;
		}

		public Timer(
			Action OnTimeout,
			float limit = 1,
			bool start = false,
			bool repeat = false,
			bool fixedUpdate = false
			)
		{
			OnTimeoutHandler += OnTimeout;
			_time = 0;
			_limit = limit;
			_repeat = repeat;
			_isFixedUpdate = fixedUpdate;
			if(start) Reset();
		}


		public void AddTime(float time, bool resume = true)
		{
			_time -= time;
			if(_time < 0) _time = 0;
			if(resume) Resume();
		}

		public void Reset(float limit = -1, bool start = true)
		{
			Reset(limit, null, start);
		}

		public void Reset(Action cb, float limit=-1, bool start = true)
		{
			Reset(limit, cb, start);
		}

		public void Reset(float limit, Action cb, bool start = true)
		{
			if (cb != null) OnTimeoutHandler += cb;

			if (limit > 0) _limit = limit;
			_time = 0;

			if(start)
			{
				if(!_active) _OnClockUpdateHandler += _OnTicked;
				_active = true;
			}
		}

		public void Resume()
		{
			if(_time < _limit)
			{
				if(!_active) _OnClockUpdateHandler += _OnTicked;
				_active = true;
			}
		}

		public void Stop()
		{
			if(_active) _OnClockUpdateHandler -= _OnTicked;
			_active = false;
		}

		private void _OnTicked()
		{
			_time += DeltaTime;
			OnTickHandler?.Invoke(_time);
			if(_time >= _limit)
			{
				_time = _limit;

				OnTimeoutHandler?.Invoke();

				if (_time >= _limit) // Only repeat if past limit
				{
					if (_repeat) Reset();
					else Stop();
				}
			}
		}

		~Timer()
		{
			Stop();
		}

	}
}
