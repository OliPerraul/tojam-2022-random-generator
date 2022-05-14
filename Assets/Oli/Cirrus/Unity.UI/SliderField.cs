using Cirrus.Numerics;
using Cirrus.Unity.Numerics;
using System;
using UnityEditor;
using UnityEngine;

namespace Cirrus.Unity.UI
{
	public class SliderField : MonoBehaviour
	{
		private float _value;

		[SerializeField]
		public float Value
		{
			get => _value;
			set
			{
				_value = value;
				_slider.SetValueWithoutNotify(_value);
				_inputField.SetTextWithoutNotify(_value.ToString());
				OnValueChangedHandler?.Invoke(_value);
			}
		}

		public Action<float> OnValueChangedHandler;




		[SerializeField]
		private UnityEngine.UI.InputField _inputField;

		[SerializeField]
		private UnityEngine.UI.Slider _slider;

		[SerializeField]
		public float _min;

		[SerializeField]
		public float _max;

		[SerializeField]
		public bool _wholeValues;

		public void OnValidate()
		{

#if UNITY_EDITOR
			if(Application.isPlaying) return;

			if(_slider != null)
			{
				_slider.wholeNumbers = _wholeValues;
				_slider.minValue = _min;
				_slider.maxValue = _max;
				EditorUtility.SetDirty(_slider.gameObject);
			}
#endif
		}

		// Start is called before the first frame update
		public void Awake()
		{
			_inputField.onValueChanged.AddListener((x) =>
			{
				Value =
					_wholeValues ?
						int.TryParse(x, out int intValue) ?
							intValue.Clamp((int)_min, (int)_max) :
							_value :

						float.TryParse(x, out float floatValue) ?
							floatValue.Clamp(_min, _max) :
							_value;
			}); ;

			_slider.onValueChanged.AddListener(
				(x) =>
				{
					Value =
						_wholeValues ?
							(int)_slider.value :
							_slider.value;
				}
				);
		}

	}
}