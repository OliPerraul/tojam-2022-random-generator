using Cirrus.Events;
using Cirrus.Randomness;
using Cirrus.Unity.Numerics;
using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

namespace Tojam2022
{
	public static class Layers
	{
		public static readonly int Barrier = LayerMask.NameToLayer("Barrier");
		public static readonly int FishFood = LayerMask.NameToLayer("FishFood");
	}

	public enum GameState
	{ 
		None,
		Menu,
		Game,
		GameOver
	}

	public class Game : SingletonComponentBase<Game>
	{
		private GameState _gameState;

		private Timer _artifactDiscoveredTimer;

		[SerializeField]
		private Range_ _artifactDiscoveredTime = new Range_(1, 10);

		[SerializeField]
		private List<AlienArtifactBase> _artifacts;

		//private RandomizationAssetBase

		public override void Awake()
		{
			Persist();
			_artifactDiscoveredTimer = new Timer(_OnArtifactDiscoveredTimeout, true);
		}		

		public override void Start()
		{
			base.Start();
			if (_gameState == GameState.None)
			{
				if (SceneManager.GetActiveScene().name == "Game")
				{
					SetState(GameState.Game);
				}
			}
		}

		public void Update()
		{
			switch (_gameState)
			{
				case GameState.Menu:
					break;
				case GameState.Game:
					break;
			}
		}

		private void _OnArtifactDiscoveredTimeout()
		{
			AlienArtifactBase prefab = _artifacts.Choice(_artifacts.Select(x => x.Chance));
		}

		private void _OnAlienDied()
		{
			SetState(GameState.GameOver);
		}

		public void SetState(GameState state, params object[] args)
		{
			switch (_gameState)
			{
				case GameState.Game:
					_artifactDiscoveredTimer.Stop();
					Alien.Instance.onAlienDiedHandler -= _OnAlienDied;
					break;
			}

			switch (state)
			{
				case GameState.Menu:
					_artifactDiscoveredTimer.Stop();
					break;
				case GameState.Game:
					_artifactDiscoveredTimer.Reset(_artifactDiscoveredTime.Random());
					Alien.Instance.onAlienDiedHandler += _OnAlienDied;
					Alien.Instance.SetState(AlienState.Game);
					break;
			}

			_gameState = state;
		}

	}
}
