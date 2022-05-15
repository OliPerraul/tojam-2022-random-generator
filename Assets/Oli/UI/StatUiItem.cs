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
	public enum AlienStatType
	{
		Default,
		Money,		
	}

	public class StatUiItem : CustomMonoBehaviourBase
	{
		[SerializeField]
		private string _name;

		private float _value;

		[SerializeField]
		private AlienStatType _type;

		public float Value
		{
			get => _value;
			set
			{
				_value = value;
				switch (_type)
				{
					case AlienStatType.Default:
					//_valueText.text = $"{_value.ToString("0.00")} $";
					_valueText.text = String.Format("{0:P0}.", _value);
					break;
					case AlienStatType.Money:
					_valueText.text = $"{_value.ToString("0.00")} $";
					//_valueText.text = String.Format("{0:P0}.", _value);
					break;
				}
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
