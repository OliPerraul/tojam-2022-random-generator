using Cirrus.Unity.Objects;
using UnityEngine;
using UnityEngine.UI;

namespace Cirrus.Unity.UI
{
	public class Counter : CustomMonoBehaviourBase
	{
		[SerializeField]
		private string _message = "";


		[SerializeField]
		private Text _text;

		public override void Awake()
		{
			base.Awake();

			if(!_text.text.Equals(""))
			{
				_message = _text.text;
			}

			_text.text = _message + $"{0}";
		}

		public void UpdateValue(int newValue)
		{
			_text.text = _message + $"{newValue}";
		}

		public void UpdateValue(float newValue)
		{
			_text.text = _message + $"{newValue}";
		}
	}
}
