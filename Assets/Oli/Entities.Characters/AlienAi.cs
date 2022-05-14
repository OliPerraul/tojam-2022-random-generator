//using Cirrus.States.AI;
using System;

// using Cirrus.Unity.AI.BehaviourTrees;
using Cirrus.Controls;
using Cirrus.Numerics;
using Cirrus.Objects;
using Cirrus.Broccoli;
//using Cirrus.Salspareille;
using Cirrus.Unity.Numerics;
using UnityEngine;
using static Cirrus.FuncGenerics; //using Cirrus.Unity.States.AI;

using None = Cirrus.Objects.None;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using Cirrus.Unity.Objects;

namespace Tojam2022
{
	public enum AlienAiState
	{ 
		None,
		PauseMenu,
		Wandering,
		Idle,
		Following,
		Asleep,
		Angry,		
	}

	public partial class AlienAi :  CustomMonoBehaviourBase
	{
		[SerializeField]
		private Alien _alien;

		[SerializeField]
		private Transform _transform;

		[SerializeField]
		private NavMeshAgent _navmeshAgent;

		// Wandering

		[SerializeField]
		private Vector3 _wanderDirection;

		[SerializeField]

		public float _wanderCircleRadius = 4f;

		[SerializeField]
		public float _wanderAngle = 2f;

		[SerializeField]
		public float _wanderAngleChange = 0.5f;

		[SerializeField]
		private Range_ _wanderRange = new Range_(-1f, 1f);

		private AlienAiState _alienAiState;

		private float WanderSpeed = 1.0f;


		private void _OnCursorEntered()
		{
			//_blackboard.Set(AlienAiState.Following);
		}


		public void SetState(AlienAiState state, params object[] args)
		{
			switch (state)
			{
				case AlienAiState.Wandering:
					_alien.Speed = WanderSpeed;
					//if (_tool != null)
					//{
					//	_tool.SetState(ToolState.Shelved);
					//}
					//_tool = null;
					//_handMesh.SetActive(true);
					break;
				case AlienAiState.Idle:
					_alien.Speed = 0.0f;
					break;

				case AlienAiState.Following:
					//_handMesh.SetActive(false);
					break;
			}
			_alienAiState = state;
		}


		public override void Awake()
		{

			Environment.Instance.onCursorEnteredEvent += _OnCursorEntered;
		}

		public override void Start()
		{
			SetState(AlienAiState.Wandering);
		}

		public void Update()
		{
			switch (_alienAiState)
			{
				case AlienAiState.Following:

					break;

				case AlienAiState.Idle:

					break;


				case AlienAiState.Wandering:

					_wanderDirection = new Vector3(0, 0, -1) * _wanderCircleRadius;
					// Randomly change the vector direction by making it change its current angle Set angle..
					_wanderDirection = new Vector3(
						Mathf.Cos(_wanderAngle),
						_wanderDirection.y,
						Mathf.Sin(_wanderAngle))
						.normalized;

					_alien.Direction = _wanderDirection;

					// Change wanderAngle just a bit, so it won't have the same value in the next game frame.
					_wanderAngle += (Random.value * _wanderAngleChange) - (_wanderAngleChange * .5f);
					break;
			}
		}
	}
}

