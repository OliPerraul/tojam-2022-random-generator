//using Cirrus.States.AI;
using System;

// using Cirrus.Unity.AI.BehaviourTrees;
using Cirrus.Controls;
using Cirrus.Numerics;
using Cirrus.Objects;
//using Cirrus.Salspareille;
using Cirrus.Unity.Numerics;
using UnityEngine;
using static Cirrus.FuncGenerics; //using Cirrus.Unity.States.AI;

using None = Cirrus.Objects.None;
using Cirrus.Unity.Objects;

namespace Tojam2022
{
	public enum AlienState
	{
		None,
		Game
	}

	public class Alien : SingletonComponentBase<Alien>
	{
		[SerializeField]
		public float Money = 0;

		[SerializeField]
		public float _maxDamageTime = 10;

		private Timer _damageTimer;

		public float Damage => _damageTimer.Time / _maxDamageTime;

		[SerializeField]
		public float _maxHungerTime = 10;

		private Timer _hungerTimer;

		public float Hunger => _hungerTimer.Time / _maxHungerTime;

		[SerializeField]
		public float _maxSleepinessTime = 10;

		private Timer _sleepinessTimer;

		public float Sleepiness => _sleepinessTimer.Time / _maxSleepinessTime;


		[SerializeField]
		public float _maxAngerTime = 10;

		private Timer _angerTimer;

		public float Anger => _angerTimer.Time / _maxHungerTime;


		private AlienState _alienState;

		public AlienState State => _alienState;

		//public Vector3 Direction;

		//public float Speed = 1;

		public Vector3 Velocity = Vector3.zero;

		[SerializeField]
		private Transform _transform;

		[SerializeField]
		private CharacterController _characterController;

		public CharacterController CharacterController => CharacterController;

		[SerializeField]
		private Rigidbody _rigidbody;
		public Rigidbody Rigidbody => _rigidbody;

		public Action onAlienDiedHandler;

		public override void Awake()
		{
			_damageTimer = new Timer(_DamageTimeout);
			_hungerTimer = new Timer(_HungerTimeout);
			_sleepinessTimer = new Timer(_SleepinessTimeout);
			_angerTimer = new Timer(_AngerTimeout);
		}


		private void _AngerTimeout()
		{
		}

		private void _SleepinessTimeout()
		{
		}

		private void _HungerTimeout()
		{
			onAlienDiedHandler?.Invoke();
		}

		private void _DamageTimeout()
		{
		}


		public void Update()
		{
			_characterController.Move(Velocity * Time.deltaTime);
		}

		public void FixedUpdate()
		{

		}

		public void SetState(AlienState state, params object[] args)
		{
			switch (_alienState)
			{
				case AlienState.None:
					break;

				case AlienState.Game:
					break;
			}

			switch (state)
			{
				case AlienState.None:
					break;
				case AlienState.Game:
					_damageTimer.Reset(_maxDamageTime);
					_hungerTimer.Reset(_maxHungerTime);
					_sleepinessTimer.Reset(_maxSleepinessTime);
					_angerTimer.Reset(_maxAngerTime);
					break;

			}
			_alienState = state;
		}
	}
}
