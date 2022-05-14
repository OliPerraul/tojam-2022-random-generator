
using Cirrus.Collections;
using Cirrus.Randomness;
using Cirrus.Unity.Objects;
//using Cirrus.Unity.Numerics;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Cirrus.Unity.Randomness
{
	public static class RandomUtils
	{
		public static Vector2 RandomPointOnCircleEdge(float radius)
		{
			return Random.insideUnitCircle.normalized * radius;
		}
	}
}
