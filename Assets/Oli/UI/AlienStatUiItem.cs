using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Cirrus.Unity.Numerics;
using Cirrus.Unity.Objects;

namespace Tojam2022
{
	public class AlienStatUiItem : CustomMonoBehaviourBase
	{
		[SerializeField]
		private string _name;

		private float _value;

		public float Value
		{
			get => _value;
			set
			{
				_value = value;
				//_valueText.text = $"{_value.ToString("0.00")} $";
				_valueText.text = String.Format("{0:P0}.", _value);
			}
		}

		public override void OnValidate()
		{
			base.OnValidate();

			Name = _name;
		}

		public string Name
		{
			get => _nameText.text;
			set => _nameText.text = value;
		}

		[SerializeField]
		private TextMeshProUGUI _nameText;

		[SerializeField]
		private TextMeshProUGUI _valueText;

		public void Awake()
		{

		}
	}
}
