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
		//[SerializeField]
		//private StatUiItem _moneyStat;

		//[SerializeField]
		//private StatUiItem _hungerStat;

		[SerializeField]
		private StatUiItem _rageStat;

		public override void Start()
		{
			base.Start();

			//_hungerStat.Name = "Hunger";
			
		}



		public void Update()
		{


			if (Alien.Instance.State == AlienState.Game)
			{
				_rageStat.Value = Alien.Instance.Anger;
				//_moneyStat.Value = Alien.Instance.Money;
			}
		}
	}
}
