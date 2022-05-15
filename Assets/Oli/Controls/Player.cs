using Cirrus.Unity.Numerics;
using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tojam2022
{
	public class Player : SingletonComponentBase<Player>
	{
		[SerializeField]
		private AudioSource _hurtAudioSource;

		[SerializeField]
		private AudioSource _moneyGetAudioSource;

		[SerializeField]
		private AudioSource _buyAudioSource;

		[SerializeField]
		private float _money = 0;
		public float Money
		{
			get => _money;
		}

		public void UpdateMoney(float delta)
		{
			if (delta > 0)
			{
				_moneyGetAudioSource.Play();
			}
			if (delta < 0)
			{
				_buyAudioSource.Play();
			}
			_money += delta;
			if (_money <= 0)
			{
				_money = 0;
			}
		}



		[SerializeField]
		private float _health = 1;

		public Action OnPlayerDiedEvent;

		public float Health
		{
			get => _health;
			//set
			//{
			//	_health = value;
			//	if (_health <= 0)
			//	{
			//		_health = 0;
			//		OnPlayerDiedEvent?.Invoke();
			//	}
			//}
		}

		public void UpdateHealth(float delta)
		{
			if (delta < 0)
			{
				_hurtAudioSource.Play();
			}

			_health += delta;
			if (_health <= 0)
			{
				_health = 0;
				OnPlayerDiedEvent?.Invoke();
			}
		}
		
	}
}
