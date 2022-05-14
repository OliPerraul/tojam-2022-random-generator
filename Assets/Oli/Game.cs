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
		public GameState State => _gameState;

		//private RandomizationAssetBase

		public override void Awake()
		{
			if (Persist())
			{
				base.Awake();
			}
		}		

		public override void Start()
		{
			base.Start();
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

		private void _OnAlienDied()
		{
			SetState(GameState.GameOver);
		}

		public override void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			base.OnSceneLoaded(scene, mode);

			Debug.Log("Scene Loaded");

			switch (_gameState)
			{
				case GameState.None:
					if (SceneManager.GetActiveScene().name == "Game") SetState(GameState.Game);
					break;

				case GameState.Game:
					AlienArtifactManager.Instance.DoStart();
					Alien.Instance.onAlienDiedHandler += _OnAlienDied;
					Alien.Instance.SetState(AlienState.Game);
					break;
			}
		}

		// Load given scene, if already init simply re-run on scene loaded
		public void LoadScene(string scene)
		{
			if (SceneManager.GetActiveScene().name == scene)
			{
				OnSceneLoaded(SceneManager.GetActiveScene(), LoadSceneMode.Single);
			}
			else
			{
				SceneManager.LoadScene(scene);
			}
		}


		public void SetState(GameState state, params object[] args)
		{
			// Exit from state
			switch (_gameState)
			{
				case GameState.Game:
					AlienArtifactManager.Instance.DoStop();
					Alien.Instance.onAlienDiedHandler -= _OnAlienDied;
					break;
			}

			// Enter state
			switch (state)
			{
				case GameState.Game:
					_gameState = state;
					LoadScene("Game");
					break;
				case GameState.GameOver:
					_gameState = state;
					LoadScene("GameOver");
					break;
			}
			
		}

	}
}
