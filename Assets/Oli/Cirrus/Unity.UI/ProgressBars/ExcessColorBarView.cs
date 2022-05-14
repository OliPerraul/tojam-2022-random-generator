using Cirrus.Numerics;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Cirrus.Unity.UI.ProgressBars
{
	public class ExcessColorBarView : ProgressBarView
	{
		[SerializeField]
		private Color _excessColor = Color.white;

		[SerializeField]
		private Color _defaultColor = Color.white;

		[SerializeField]
		private BarViewColor _colorBarView;

		[SerializeField]
		private ProgressBar _progressBar;

		[SerializeField]
		protected Graphic _graphic;

		[Header("Color Animation")]
		[SerializeField]
		bool _isFlashing = true;

		[SerializeField]
		private Color _flashColor = Color.white;

		[SerializeField]
		float _flashTime = 0.2f;


		public void OnValidate()
		{
			if(_colorBarView != null)
			{
				_defaultColor = _colorBarView.DefaultColor;
			}
		}

		public override void UpdateView(
			float value,
			float targetValue,
			float maxValue,
			float targetMaxValue)
		{
			_progressBar.SetBarColor(
				value > maxValue ?
					_excessColor :
					_defaultColor);

			if(!_isFlashing)
				return;

			if(value > maxValue && colorAnim == null)
			{
				colorAnim = StartCoroutine(DoBarColorAnim(_flashColor, _flashTime));
			}
			else if(colorAnim != null)
			{
				StopCoroutine(colorAnim);
				colorAnim = null;
			}
		}


		private Coroutine colorAnim;

		private Color _currentFlashColor;

		private float _currentFlashAlpha;

		private void SetOverrideColor(Color color, float alpha)
		{
			_currentFlashColor = color;
			_currentFlashAlpha = alpha;
		}

		Color GetCurrentColor()
		{
			if(_currentFlashAlpha >= 1f)
				return _currentFlashColor;
			else if(_currentFlashAlpha <= 0f)
				return _excessColor;
			else
				return Color.Lerp(_excessColor, _currentFlashColor, _currentFlashAlpha);
		}

		public void UpdateColor()
		{
			_graphic.canvasRenderer.SetColor(GetCurrentColor());
		}

		IEnumerator DoBarColorAnim(Color targetColor, float duration)
		{
			float time = 0f;

			while(true)
			{
				time = 0f;

				while(time < duration)
				{
					SetOverrideColor(targetColor, NumericUtils.EaseSinInOut(time / duration, 1f, -1f));
					UpdateColor();
					time += Time.deltaTime;
					yield return null;
				}

				SetOverrideColor(targetColor, 0f);
				UpdateColor();

			}
		}
	}

}