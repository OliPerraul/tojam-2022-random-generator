using Cirrus.Unity.Numerics;
using Cirrus.Unity.Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tojam2022
{
	public class Player : SingletonComponentBase<Player>
	{
		[SerializeField]
		public float Money = 0;

		[SerializeField]
		public float Health = 1;
	}
}
