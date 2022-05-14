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


	public class Game : CustomMonoBehaviourBase
	{
	}
}
