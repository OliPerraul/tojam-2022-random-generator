using Cirrus.Events;
using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Tojam2022
{
	public static class Layers
	{
		public static readonly int Barrier = LayerMask.NameToLayer("Barrier");
		public static readonly int FishFood = LayerMask.NameToLayer("FishFood");
	}

	public enum GameState
	{ 
		Menu,
		Game,
	}

	public class Game : SingletonComponentBase<Game>
	{
		private GameState _gameState;

		public void SetState(CursorState state, params object[] args)
		{
			//switch (state)
			//{
			//	case CursorState.Default:
			//		if (_tool != null)
			//		{
			//			_tool.SetState(ToolState.Shelved);
			//		}
			//		_tool = null;
			//		_handMesh.SetActive(true);
			//		break;
			//	case CursorState.Tool:
			//		_handMesh.SetActive(false);
			//		break;
			//}
			//_cursorState = state;
		}

		public override void Awake()
		{
			DontDestroyOnLoad(gameObject);
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

	}
}
