using Cirrus.Numerics;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Cirrus.Unity.UI.ProgressBars
{
	[RequireComponent(typeof(Graphic))]
	public class BarViewColor : ProgressBarView
	{

		[FormerlySerializedAs("graphic")]
		[SerializeField] protected Graphic _graphic;

		[Header("Color Options")]
		[Tooltip("The default color of the bar can be set by the ProgressBar.SetbarColor()")]
		[FormerlySerializedAs("canOverrideColor")]
		[SerializeField] bool _canOverrideColor;

		[FormerlySerializedAs("defaultColor")]
		[SerializeField] Color _defaultColor = Color.white;

		public Color DefaultColor => _defaultColor;

		[Tooltip("Change color of the bar automatically based on it's value.")]
		[FormerlySerializedAs("useGradient")]
		[SerializeField] bool _useGradient;

		[FormerlySerializedAs("barGradient")]
		[SerializeField] Gradient _barGradient;

		private Color _flashColor;
		private float _flashcolorAlpha = 0f;
		private float _currentValue;

		[Header("Color Animation")]
		[FormerlySerializedAs("flashOnGain")]
		[SerializeField] bool _flashOnGain;

		[FormerlySerializedAs("gainColor")]
		[SerializeField] Color _gainColor = Color.white;

		[FormerlySerializedAs("gainColor")]
		[SerializeField] bool _flashOnLoss;

		[FormerlySerializedAs("lossColor")]
		[SerializeField] Color _lossColor = Color.white;

		[FormerlySerializedAs("flashTime")]
		[SerializeField] float _flashTime = 0.2f;

		private Coroutine _colorAnim;

		void OnEnable()
		{
			_flashcolorAlpha = 0f;
			UpdateColor();
		}

		public override void NewChangeStarted(float currentValue, float targetValue)
		{
			if(!_flashOnGain && !_flashOnLoss)
				return;
			else if(targetValue > currentValue && !_flashOnGain)
				return;
			else if(targetValue < currentValue && !_flashOnLoss)
				return;
			else if(gameObject.activeInHierarchy == false)
				return; // No Coroutine if we're disabled

			if(_colorAnim != null)
				StopCoroutine(_colorAnim);

			_colorAnim = StartCoroutine(DoBarColorAnim((targetValue < currentValue ? _lossColor : _gainColor), _flashTime));
		}

		IEnumerator DoBarColorAnim(Color targetColor, float duration)
		{
			float time = 0f;

			while(time < duration)
			{
				SetOverrideColor(targetColor, NumericUtils.EaseSinInOut(time / duration, 1f, -1f));
				UpdateColor();
				time += Time.deltaTime;
				yield return null;
			}

			SetOverrideColor(targetColor, 0f);
			UpdateColor();
			_colorAnim = null;
		}

		public override void SetBarColor(Color color)
		{
			if(!_canOverrideColor)
				return;

			_defaultColor = color;
			_useGradient = false;

			if(_colorAnim == null)
				UpdateColor();
		}

		private void SetOverrideColor(Color color, float alpha)
		{
			_flashColor = color;
			_flashcolorAlpha = alpha;
		}

		public override void UpdateView(float currentValue, float targetValue)
		{
			this._currentValue = currentValue;

			if(_colorAnim == null) // if we're flashing don't update this since the coroutine handles our updates
				UpdateColor();
		}

		void UpdateColor()
		{
			_graphic.canvasRenderer.SetColor(GetCurrentColor(_currentValue));
		}

		Color GetCurrentColor(float percentage)
		{
			if(_flashcolorAlpha >= 1f)
				return _flashColor;
			else if(_flashcolorAlpha <= 0f)
				return _useGradient ? _barGradient.Evaluate(percentage) : _defaultColor;
			else
				return Color.Lerp(_useGradient ? _barGradient.Evaluate(percentage) : _defaultColor, _flashColor, _flashcolorAlpha);
		}

#if UNITY_EDITOR
		protected override void Reset()
		{
			base.Reset();

			_graphic = GetComponent<Graphic>();
		}

		void OnValidate()
		{
			UpdateColor();
		}
#endif
	}

}