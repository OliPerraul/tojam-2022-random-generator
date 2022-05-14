using UnityEngine;
using UnityEngine.UI;

namespace Cirrus.Unity.UI.ProgressBars
{
	[RequireComponent(typeof(Image))]
	public class BarViewSizeImageFill : ProgressBarView
	{

		[SerializeField] protected Image _image;
		[SerializeField] bool _hideOnEmpty = true;
		[SerializeField] bool _useDiscreteSteps = false;
		[SerializeField] int _numSteps = 10;

		private bool isDisplaySizeZero;

		public override bool CanUpdateView(float currentValue, float targetValue)
		{
			// This ensures that we can update, even if the object has been updated cause it was set to 0
			return isActiveAndEnabled || isDisplaySizeZero;
		}

		public override void UpdateView(float currentValue, float targetValue)
		{
			if(_hideOnEmpty && currentValue <= 0f)
			{
				_image.gameObject.SetActive(false);
				isDisplaySizeZero = true;
				return;
			}

			isDisplaySizeZero = false;
			_image.gameObject.SetActive(true);
			_image.fillAmount = GetDisplayValue(currentValue);
		}

		float GetDisplayValue(float display)
		{
			if(!_useDiscreteSteps)
				return display;

			return Mathf.Round(display * _numSteps) / _numSteps;
		}

#if UNITY_EDITOR
		protected override void Reset()
		{
			base.Reset();
			_image = GetComponent<Image>();
		}
#endif
	}

}