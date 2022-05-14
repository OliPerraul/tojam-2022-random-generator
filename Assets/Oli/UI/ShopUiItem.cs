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

namespace Tojam2022
{
	public class ShopUiItem : MonoBehaviour
	{
		private string _name;

		private float _price;

		public float Price
		{
			get => _price;
			set
			{
				_price = value;
				_priceText.text = $"{_price.ToString("0.00")} $";
			}
		}

		public string Name
		{
			get => _nameText.text;
			set => _nameText.text = value;
		}

		[SerializeField]
		private TextMeshProUGUI _nameText;

		[SerializeField]
		private TextMeshProUGUI _priceText;

		public void Awake()
		{
			
		}
	}
}
