using Cirrus.Collections;
using Cirrus.Numerics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Healer
{
	// Discrete vs. Continous
	//https://wikidiff.com/perimeter/periphery#:~:text=As%20nouns%20the%20difference%20between,the%20sides%20of%20an%20object.
	public class DiscreteDirections : IEnumerable<Vector3>, IIndexedCollection<Vector3>
	{
		private Vector3[] _directions;

		public int Count => _directions.Length;

		private int _resolution = 0;

		public int Resolution => _resolution;

		private static readonly Vector3 _StartDirection = new Vector3(0f, 0f, 1f);


		private static readonly float _StartMagnitude = 1f;

		public DiscreteDirections(int resolution)
		{
			_resolution = resolution;
			float currentAlpha = 0f;
			float step = 360f / resolution;

			_directions = new Vector3[resolution];

			for(int i = 0; i < resolution; i++)
			{
				_directions[i] =
					(Quaternion.Euler(0f, currentAlpha, 0f) * _StartDirection).normalized *
					_StartMagnitude;

				currentAlpha += step;
			}
		}

		public Vector3 this[int index]
		{
			get => _directions[index.Mod(Count)];
			set => _directions[index.Mod(Count)] = value;
		}

		public IEnumerator<Vector3> GetEnumerator()
		{
			return ((IEnumerable<Vector3>)_directions).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _directions.GetEnumerator();
		}
	}

	public static class DiscreteDirectionUtils
	{
		[NonSerialized]
		public static readonly DiscreteDirections VeryLowResDirections = new DiscreteDirections(4);
		[NonSerialized]
		public static readonly DiscreteDirections LowResDirections = new DiscreteDirections(8);
		[NonSerialized]
		public static readonly DiscreteDirections MidResDirections = new DiscreteDirections(16);
		[NonSerialized]
		public static readonly DiscreteDirections HighResDirections = new DiscreteDirections(32);
		[NonSerialized]
		public static readonly DiscreteDirections VeryHighResDirections = new DiscreteDirections(64);

		public static int GetOppositeDirection(
			this DiscreteDirections resolution,
			int index)
		{
			return index < resolution.Count / 2 ? resolution.Count / 2 + index : index - resolution.Count / 2;
		}

		public static int GetOppositeDirection(
			this DiscreteDirections resolution,
			Vector3 direction
			)
		{
			return GetOppositeDirection(resolution, GetDirection(resolution, direction));
		}

		public static int GetDirection(
			this DiscreteDirections resolution,
			Vector3 direction
			)
		{
			float bestDot = Mathf.NegativeInfinity;
			int best = -1;
			for(int i = 0; i < resolution.Count; i++)
			{
				float dot = Vector3.Dot(direction, resolution[i]);
				if(dot > bestDot)
				{
					bestDot = dot;
					best = i;
				}
			}

			return best;
		}
		


		public static bool RaycastAll(
			this DiscreteDirections resolution,
			Vector3 pos,
			float dist,
			int layers=BitwiseUtils.MaxValue)
		{
			for(int i = 0; i < resolution.Count; i++)
			{
				if(Physics.Raycast(
					pos,
					resolution[i],
					dist,
					layers
					))
				{
					return true;
				}
			}

			return false;
		}

		public static bool Raycast(
			this DiscreteDirections resolution,
			Vector3 pos,
			int i,
			float dist,
			out RaycastHit hit,
			int layers = BitwiseUtils.MaxValue)
		{			
			if(Physics.Raycast(
				pos,
				resolution[i],
				out hit,
				dist,
				layers
				))
			{
				return true;
			}			

			return false;
		}
	}
}
