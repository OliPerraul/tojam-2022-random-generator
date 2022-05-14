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
using Cirrus.Unity.Objects;

namespace Tojam2022
{
	public class Alien : CustomMonoBehaviourBase
	{
		[SerializeField]
		public float Health;

		[SerializeField]
		public float Hunger;

		[SerializeField]
		public float Sleepiness;
		
		//public Vector3 Direction;

		//public float Speed = 1;

		public Vector3 Velocity;

		[SerializeField]
		private CharacterController _characterController;

		public void Update()
		{
			_characterController.Move(Velocity * Time.deltaTime);
		}
	}
}
