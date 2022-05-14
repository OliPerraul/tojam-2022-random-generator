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
		Scared,
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

		[Header("Wander")]
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


		private Timer _wanderTimer;

		[SerializeField]
		private Range_ _wanderTime = new Range_(1, 2);


		// Idle

		[Header("Idle")]
		[SerializeField]
		private Range_ _idleTime = new Range_(1, 2);

		private Timer _idleTimer;


		// Follow

		[Header("Follow")]
		[SerializeField]
		public float _followMaxForce = 0.6f;
		public float _followMexSpeed = 100f;
		public float _followSlowingRadius = 200f;
						

		public Vector3 _Seek(Vector3 target)
		{
			Vector3 force;
			float distance;
			float slowingRadius = _followSlowingRadius;

			Vector3 desired = target - _transform.position;

			distance = desired.magnitude;
			desired.Normalize();

			if (distance <= slowingRadius)
			{
				desired = (_followMexSpeed * distance / slowingRadius) * desired;
			}
			else
			{
				desired = _followMexSpeed * desired;
			}

			force = desired - _alien.Velocity;
			return force;
		}


		private void _OnCursorEntered()
		{
			SetState(AlienAiState.Following);
		}

		private void _OnCursorExited()
		{
			SetState(AlienAiState.Wandering);
		}

		public void SetState(AlienAiState state, params object[] args)
		{
			// exit state
			switch (_alienAiState)
			{
				case AlienAiState.Wandering:
					_wanderTimer.Stop();
					break;
				case AlienAiState.Idle:
					_wanderTimer.Stop();
					break;
			}

			// enter state
			switch (state)
			{
				case AlienAiState.Wandering:
					//_alien.Velocity = WanderSpeed;
					_wanderTimer.Reset(_wanderTime.Random());
					//if (_tool != null)
					//{
					//	_tool.SetState(ToolState.Shelved);
					//}
					//_tool = null;
					//_handMesh.SetActive(true);
					break;
				case AlienAiState.Idle:
					_alien.Velocity = Vector3.zero;
					_idleTimer.Reset(_idleTime.Random());
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
			Environment.Instance.onCursorExitedEvent += _OnCursorExited;
			_wanderTimer = new Timer(_OnWanderTimeout);
			_idleTimer = new Timer(_OnIdleTimeout);
		}

		private void _OnWanderTimeout()
		{
			SetState(AlienAiState.Idle);
		}

		private void _OnIdleTimeout()
		{
			SetState(AlienAiState.Wandering);
		}


		public override void Start()
		{
			SetState(AlienAiState.Wandering);
		}

		public Vector3 _Truncate(Vector3 vector, float max)
		{
			var i = 0f;

			i = max / vector.magnitude;
			i = i< 1.0f ? i : 1.0f;
			
			return vector = i * vector;
		}


		public void Update()
		{
			switch (_alienAiState)
			{
				case AlienAiState.Following:


					// Seek mouse cursor
					Vector3 steering = _Seek(Cursor.Instance.Position.X_Z(_transform.position.y));

					_Truncate(steering, _followMaxForce);
					_alien.Velocity = steering;
					
					_Truncate(_alien.Velocity, _followMexSpeed);

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

					_alien.Velocity = WanderSpeed * _wanderDirection;

					// Change wanderAngle just a bit, so it won't have the same value in the next game frame.
					_wanderAngle += (Random.value * _wanderAngleChange) - (_wanderAngleChange * .5f);
					break;
			}
		}
	}
}

