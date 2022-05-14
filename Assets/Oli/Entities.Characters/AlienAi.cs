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
		public float _mass = 1;

		//[SerializeField]
		//private NavMeshAgent _navmeshAgent;

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

		[SerializeField]
		private float WanderSpeed = 10.0f;


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
		[SerializeField]
		public float _followMaxSpeed = 100f;
		[SerializeField]
		public float _followSlowingRadius = 200f;
		[SerializeField]
		public float _followDistance = 2f;

		public Vector3 _Seek(Vector3 target)
		{
			float slowingRadius = _followSlowingRadius;

			Vector3 desired = target - _transform.position;

			float distance = desired.magnitude;
			desired.Normalize();

			if (distance <= slowingRadius)
			{
				desired = (_followMaxSpeed * distance / slowingRadius) * desired;
			}
			else
			{
				desired = _followMaxSpeed * desired;
			}

			Vector3 force = desired - _alien.Velocity;
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
					_idleTimer.Stop();
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
			var val = 0f;

			val = max / vector.magnitude;
			val = val< 1.0f ? val : 1.0f;
			
			return vector = val * vector;
		}


		public void Update()
		{
			switch (_alienAiState)
			{
				case AlienAiState.Following:

					Vector3 follow = _followDistance * ((Cursor.Instance.Position - _transform.position).XY_()).normalized;

					Vector3 arrival = Cursor.Instance.Position.XY_() - follow;

					if (_transform.position.Almost(arrival))
					{
						_alien.Velocity = Vector3.zero;
					}
					else
					{
						// Seek mouse cursor
						Vector3 steering = _Seek(arrival);

						steering = _Truncate(steering, _followMaxForce);

						//steering = (1 / _mass) * steering;
						_alien.Velocity = steering;

						//steering = _Truncate(_alien.Velocity, _followMaxSpeed);
					}					

					break;

				case AlienAiState.Idle:

					break;


				case AlienAiState.Wandering:

					_wanderDirection = new Vector3(0, -1, 0) * _wanderCircleRadius;
					// Randomly change the vector direction by making it change its current angle Set angle..
					_wanderDirection = new Vector3(
						Mathf.Cos(_wanderAngle),						
						Mathf.Sin(_wanderAngle),
						_wanderDirection.z)
						.normalized;

					_alien.Velocity = WanderSpeed * _wanderDirection;

					// Change wanderAngle just a bit, so it won't have the same value in the next game frame.
					_wanderAngle += (Random.value * _wanderAngleChange) - (_wanderAngleChange * .5f);
					break;
			}
		}
	}
}

