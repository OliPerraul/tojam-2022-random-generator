using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cirrus.Unity.Objects;
using UnityEngine;
using UnityEngine.AI;

namespace Tojam2022
{
	public class FishFoodTool : ToolBase
	{
		[SerializeField]
		private FishFood _fishFoodPrefab;

		[SerializeField]
		private float _fishFoodCount = 10;

		[SerializeField]
		private float _fishFoodOffset = 0.1f;

		protected override void _Use()
		{
			for (int i = 0; i < _fishFoodCount; i++)
			{
				_fishFoodPrefab.Instantiate(Transform.position + new Vector3(_fishFoodOffset * i, 0 ,0));
			}
		}
	}
}
