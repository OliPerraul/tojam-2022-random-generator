using Cirrus.Numerics;
using Cirrus.Unity.Numerics;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cirrus.Unity.UI.ProgressBars
{
	// TODO make part of the health bar unrecoverable (permanent damage)

	[ExecuteInEditMode]
	public class ProgressBar : MonoBehaviour
	{
		public enum AnimationType { FixedTimeForChange, ChangeSpeed }

		[FormerlySerializedAs("valuePercentage")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _valuePercentage = 1f;

		private float _displayValuePercentage = -1f;


		// CUSTOM

		private float _value = 1f;
		private float _displayValue = -1f;

		private float _maxValue = 1f;
		private float _displayMaxValue = -1f;


		[Space(10)]
		[Tooltip("Smoothes out the animation of the bar.")]
		[SerializeField]
		[FormerlySerializedAs("animateBar")]
		bool _animateBar = true;

		public bool IsBarAnimated
		{
			get => _animateBar;
			set => _animateBar = value;
		}

		[SerializeField]
		[FormerlySerializedAs("animationType")]
		AnimationType _animationType = AnimationType.FixedTimeForChange;
		[SerializeField]
		[FormerlySerializedAs("animTime")]
		float _animTime = .25f;

		[SerializeField]
		[FormerlySerializedAs("minAnimDelta")]
		private float _minAnimDelta = 1f;

		[Space(10)]
		[SerializeField]
		[FormerlySerializedAs("views")]
		ProgressBarView[] _views;

		public void Start()
		{
			if(_views == null || _views.Length == 0)
				_views = GetComponentsInChildren<ProgressBarView>();
		}

		void OnEnable()
		{
			SetDisplayValue(_valuePercentage, true);
		}

		// Public Methods 

		public float Value
		{
			get
			{
				return _valuePercentage;
			}

			set
			{
				if(value == _valuePercentage)
					return;

				SetValue(value);
			}
		}

		// TODO figure out why Health is 101 is total is 100
		public void SetValue(
			float value,
			float maxValue,
			bool animate = true)
		{
			if(_views == null) return;

			if(maxValue != 0f)
				SetValue(value / maxValue);
			else
				SetValue(0f);

			// Custom
			this._value = value;
			this._maxValue = maxValue;

			for(int i = 0; i < _views.Length; i++)
			{
				if(_views[i] == null)
					continue;

				_views[i].NewChangeStarted(
					_displayValue,
					value,
					_displayMaxValue,
					maxValue);
			}

			float delta = Mathf.Abs(_displayValue - value);
			float deltaMax = Mathf.Abs(_displayMaxValue - maxValue);

			if((animate && _animateBar) &&
				Application.isPlaying &&
				gameObject.activeInHierarchy &&
				(delta > _minAnimDelta || deltaMax > _minAnimDelta))
			{
				StartSizeAnim(
					value,
					maxValue);
			}
			else
			{
				SetDisplayValue(
					value,
					maxValue);
			}
		}

		public void SetValue(int value, int maxValue)
		{
			if(value != 0)
				SetValue((float)value, (float)maxValue);
			else
				SetValue(0f, (float)maxValue);
		}

		public void SetValue(float percentage)
		{
			if(Mathf.Approximately(_valuePercentage, percentage))
				return;

			if(_views == null) return;

			_valuePercentage = Mathf.Clamp01(percentage);

			for(int i = 0; i < _views.Length; i++)
			{
				if(_views[i] == null)
					continue;

				_views[i].NewChangeStarted(
					_displayValuePercentage,
					_valuePercentage);
			}

			float delta = Mathf.Abs(_valuePercentage - _displayValuePercentage);

			if(_animateBar &&
				Application.isPlaying &&
				gameObject.activeInHierarchy &&
				(delta > _minAnimDelta))
			{
				StartSizeAnim(_valuePercentage);
			}
			else
			{
				SetDisplayValue(_valuePercentage);
			}
		}

		public bool IsAnimating()
		{
			if(_animateBar == false)
				return false;

			return !Mathf.Approximately(_displayValuePercentage, _valuePercentage);
		}

		// COLOR SETTINGS

		public void SetBarColor(Color color)
		{
			if(_views == null) return;

			for(int i = 0; i < _views.Length; i++)
				_views[i].SetBarColor(color);
		}

		// SIZE ANIMATION

		private Coroutine sizeAnim;

		void StartSizeAnim(float percentage)
		{
			if(sizeAnim != null)
				StopCoroutine(sizeAnim);

			sizeAnim = StartCoroutine(DoBarSizeAnim());
		}

		IEnumerator DoBarSizeAnim()
		{
			float startValue = _displayValuePercentage;

			float time = 0f;

			float change = _valuePercentage - _displayValuePercentage;

			float duration = (_animationType == AnimationType.FixedTimeForChange ? _animTime : Mathf.Abs(change) / _animTime);

			while(time < duration)
			{
				time += Time.deltaTime;
				SetDisplayValue(Cirrus.Numerics.NumericUtils.EaseSinInOut(time / duration, startValue, change));
				yield return null;
			}

			SetDisplayValue(_valuePercentage, true);

			sizeAnim = null;
		}

		private Coroutine customSizeAnim = null;

		void StartSizeAnim(float value, float maxValue)
		{
			if(_views == null) return;

			if(customSizeAnim != null)
			{
				StopCoroutine(customSizeAnim);
			}

			customSizeAnim = StartCoroutine(DoCustomBarSizeAnim());
		}

		IEnumerator DoCustomBarSizeAnim()
		{
			float startValue = _displayValue;

			float startMaxValue = _displayMaxValue;

			float time = 0f;

			float valueChange = _value - _displayValue;

			float maxValueChange = _maxValue - _displayMaxValue;

			float duration =
				(_animationType == AnimationType.FixedTimeForChange ?
					_animTime :
						Mathf.Abs(valueChange) / _animTime);

			while(time < duration)
			{
				time += Time.deltaTime;
				SetDisplayValue(
					Cirrus.Numerics.NumericUtils.EaseSinInOut(time / duration, startValue, valueChange),
					Cirrus.Numerics.NumericUtils.EaseSinInOut(time / duration, startMaxValue, maxValueChange)
					);
				yield return null;
			}

			SetDisplayValue(_value, _maxValue, true);

			customSizeAnim = null;
		}



		// Set Value & Update Views

		void SetDisplayValue(
			float value,
			float maxValue,
			bool forceUpdate = false)
		{
			if(_views == null) return;

			// If the value hasn't changed don't update any views.
			if(!forceUpdate &&
				_displayValuePercentage >= 0f &&
				Mathf.Approximately(_displayValuePercentage, value))
				return;

			_displayValue = value;
			_displayMaxValue = maxValue;

			UpdateBarViews(
				_displayValue,
				value,
				_displayMaxValue,
				maxValue,
				forceUpdate);
		}

		void SetDisplayValue(float value, bool forceUpdate = false)
		{
			if(_views == null) return;

			// If the value hasn't changed don't update any views.
			if(!forceUpdate && _displayValuePercentage >= 0f && Mathf.Approximately(_displayValuePercentage, value))
				return;

			_displayValuePercentage = value;

			UpdateBarViews(
				_displayValuePercentage,
				_valuePercentage,
				forceUpdate);
		}

		void UpdateBarViews(
			float displayValue,
			float value,
			float displayMaxValue,
			float maxValue,
			bool forceUpdate = false)
		{
			if(_views == null) return;

			for(int i = 0; i < _views.Length; i++)
			{
				if(_views[i] != null)
				{
					if(
						forceUpdate ||
						_views[i].CanUpdateView(
							displayValue,
							value,
							displayMaxValue,
							maxValue))
					{
						_views[i].UpdateView(
							displayValue,
							value,
							displayMaxValue,
							maxValue);
					}
				}
			}
		}


		void UpdateBarViews(
			float currentValue,
			float targetValue,
			bool forceUpdate = false)
		{
			if(_views == null) return;

			for(int i = 0; i < _views.Length; i++)
			{
				if(_views[i] == null) continue;
				if(forceUpdate || _views[i].CanUpdateView(currentValue, targetValue))
				{
					_views[i].UpdateView(currentValue, targetValue);
				}

			}
		}

		// Update Bar in editor

#if UNITY_EDITOR
		private void OnValidate()
		{
			_valuePercentage = Mathf.Clamp01(_valuePercentage);

			// This is to also display shadows in editor
			if(_valuePercentage >= 1f)
				UpdateBarViews(_valuePercentage, 0.75f);
			else
				UpdateBarViews(_valuePercentage, _valuePercentage + (1 - _valuePercentage) / 2f);
		}

		private void Reset()
		{
			DetectViewObjects();
		}

		public void AddView(ProgressBarView view)
		{
			DetectViewObjects();
		}

		public void DetectViewObjects()
		{
			_views = GetComponentsInChildren<ProgressBarView>(true);
		}
#endif
	}
}