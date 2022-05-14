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
	public class GameOverUi : SingletonComponentBase<AlienStatsUi>
	{
		[SerializeField]
		private Button _replayButton;

		[SerializeField]
		private Button _menuButton;

		public override void Awake()
		{
			base.Awake();
			_replayButton.onClick.AddListener(() =>
			{
				Game.Instance.SetState(GameState.Game);
			});
			_menuButton.onClick.AddListener(() =>
			{
				Game.Instance.SetState(GameState.Menu);
			});
		}
	}
}
