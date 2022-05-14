using UnityEngine;
using UnityEngine.UI;

namespace Cirrus.Unity.UI.ProgressBars
{
	public class ExcessValueTextBarView : ProgressBarView
	{
		[SerializeField]
		private Text _text;

		[SerializeField]
		private string _prefix = "";

		[SerializeField]
		private float _minValue = 0f;

		[SerializeField]
		private float _maxValue = 100f;

		[SerializeField]
		private int _numDecimals = 0;

		[SerializeField]
		private bool _showMaxValue = false;

		[SerializeField]
		private string _numberUnit = "%";

		[SerializeField]
		private string _suffix = "";

		private float _lastDisplayValue = -1;

		public override bool CanUpdateView(float currentValue, float targetValue)
		{
			float displayValue = currentValue;

			if(currentValue >= 0f && Mathf.Approximately(_lastDisplayValue, displayValue))
				return false;

			_lastDisplayValue = currentValue;
			return true;
		}

		public override void UpdateView(
			float value,
			float targetValue,
			float maxValue,
			float targetMaxValue)
		{
			_text.text = _prefix +
				FormatNumber(
					GetRoundedDisplayValue(value)) +
					_numberUnit +
					(_showMaxValue ? " / " +
						FormatNumber(maxValue) +
						_numberUnit : "") +
					_suffix;
		}

		float GetRoundedDisplayValue(float value)
		{
			if(_numDecimals == 0)
				return Mathf.Round(value);

			float multiplier = Mathf.Pow(10, _numDecimals);
			value = Mathf.Round(value * multiplier) / multiplier;

			return value;
		}

		string FormatNumber(float num)
		{
			return num.ToString("N" + _numDecimals);
		}

#if UNITY_EDITOR
		protected override void Reset()
		{
			base.Reset();
			_text = GetComponent<Text>();
		}
#endif
	}

}