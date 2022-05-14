using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Cirrus.Unity.UI.ProgressBars
{
	[RequireComponent(typeof(Text))]
	public class BarViewValueText : ProgressBarView
	{

		[FormerlySerializedAs("text")]
		[SerializeField] Text _text;

		[FormerlySerializedAs("prefix")]
		[SerializeField] string _prefix = "";

		[FormerlySerializedAs("minValue")]
		[SerializeField] float _minValue = 0f;

		[FormerlySerializedAs("maxValue")]
		[SerializeField] float _maxValue = 100f;

		[FormerlySerializedAs("numDecimals")]
		[SerializeField] int _numDecimals = 0;

		[FormerlySerializedAs("showMaxValue")]
		[SerializeField] bool _showMaxValue = false;

		[FormerlySerializedAs("numberUnit")]
		[SerializeField] string _numberUnit = "%";

		[FormerlySerializedAs("suffix")]
		[SerializeField] string _suffix = "";

		private float _lastDisplayValue;

		public override bool CanUpdateView(float currentValue, float targetValue)
		{
			float displayValue = GetRoundedDisplayValue(currentValue);

			if(currentValue >= 0f && Mathf.Approximately(_lastDisplayValue, displayValue))
				return false;

			_lastDisplayValue = GetRoundedDisplayValue(currentValue);
			return true;
		}

		public override void UpdateView(float currentValue, float targetValue)
		{
			_text.text = _prefix + FormatNumber(GetRoundedDisplayValue(currentValue)) + _numberUnit + (_showMaxValue ? " / " + FormatNumber(_maxValue) + _numberUnit : "") + _suffix;
		}

		float GetDisplayValue(float num)
		{
			return Mathf.Lerp(_minValue, _maxValue, num);
		}

		float GetRoundedDisplayValue(float num)
		{
			float value = GetDisplayValue(num);

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