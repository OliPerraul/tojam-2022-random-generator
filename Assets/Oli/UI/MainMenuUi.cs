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
	public class MainMenuUi : SingletonComponentBase<AlienStatsUi>
	{
		[SerializeField]
		private Button _playButton;

		public override void Awake()
		{
			base.Awake();
			_playButton.onClick.AddListener(() => Game.Instance.SetState(GameState.Game));
		}
	}
}
