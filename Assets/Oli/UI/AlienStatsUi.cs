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
using Cirrus.Unity.Objects;

namespace Tojam2022
{
	public class AlienStatsUi : SingletonComponentBase<AlienStatsUi>
	{
		[SerializeField]
		private AlienStatUiItem _moneyStat;

		[SerializeField]
		private AlienStatUiItem _hungerStat;

		[SerializeField]
		private AlienStatUiItem _rageStat;

		public override void Start()
		{
			base.Start();

			//_hungerStat.Name = "Hunger";
			
		}



		public void Update()
		{


			if (Alien.Instance.State == AlienState.Game)
			{
				_hungerStat.Value = Alien.Instance.Hunger;
				_moneyStat.Value = Alien.Instance.Money;
			}
		}
	}
}
