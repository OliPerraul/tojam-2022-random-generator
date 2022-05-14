using UnityEngine;
using UnityEngine.AI;

namespace Cirrus.Unity.AI
{
	public static class NavMeshUtils
	{
		public static bool GetClosestPointBetween(
			Vector3 origin,
			Vector3 destination,
			float tolerance,
			out Vector3 result)
		{
			Vector3 between = (destination - origin).normalized * tolerance;

			NavMeshHit hit;

			if(NavMesh.SamplePosition(origin + between, out hit, 2.0f, NavMesh.AllAreas))
			{
				result = hit.position;
				return true;
			}

			result = Vector3.zero;
			return false;
		}

		public static bool GetRandomPointBetween(
			Vector3 origin,
			Vector3 destination,
			float min,
			float max,
			out Vector3 result)
		{
			Vector3 between = (origin - destination).normalized * Random.Range(min, max);

			NavMeshHit hit;
			if(NavMesh.SamplePosition(destination + between, out hit, 2.0f, NavMesh.AllAreas))
			{
				result = hit.position;
				return true;
			}

			result = Vector3.zero;
			return false;
		}

		//public static bool RandomPoint(
		//	Vector3 center,
		//	float min,
		//	float max,
		//	out Vector3 result)
		//{
		//	for(int i = 0 ;i < 100 ;i++)
		//	{
		//		Vector2 pointOnCircle = Random.insideUnitCircle * Random.Range(min, max);
		//		Vector3 randomPoint = center + new Vector3(pointOnCircle.x, 0, pointOnCircle.y);
		//		NavMeshHit hit;

		//		if(NavMesh.SamplePosition(randomPoint, out hit, 4.0f, NavMesh.AllAreas))
		//		{
		//			result = hit.position;
		//			return true;
		//		}
		//	}

		//	result = Vector3.zero;
		//	return false;
		//}


		// SAME AS ABOVE
		// TODO move method to Layout/Navmesh helper class
		public static bool GetRandomPointAround(
			Vector3 point,
			float min,
			float max,
			out Vector3 result,
			float sampleTolerance = 2.0f)
		{
			for(int i = 0; i < 100; i++)
			{
				Vector2 pointOnCircle = Random.insideUnitCircle * Random.Range(min, max);
				Vector3 randomPoint = point + new Vector3(pointOnCircle.x, 0, pointOnCircle.y);

				NavMeshHit hit;
				if(NavMesh.SamplePosition(
					randomPoint,
					out hit,
					sampleTolerance,
					NavMesh.AllAreas))
				{
					result = hit.position;
					return true;
				}
			}

			result = Vector3.zero;
			return false;
		}

		public static bool GetRandomPointAround(
			Vector3 point,
			float range,
			out Vector3 result,
			float sampleTolerance = 2.0f)
		{
			return GetRandomPointAround(point, 0, range, out result, sampleTolerance);
		}

		public static bool GetSamplePosition(
			Vector3 point,
			out Vector3 result,
			float sampleTolerance = 2.0f)
		{
			NavMeshHit hit;
			result = Vector3.positiveInfinity;
			if(NavMesh.SamplePosition(
				point,
				out hit,
				sampleTolerance,
				NavMesh.AllAreas))
			{
				result = hit.position;
				return true;
			}

			return false;
		}

		/// <summary>
		/// returns the index of the least significant bit of a bitmask; -1 if mask is 0
		/// </summary>
		/// <param name="mask"></param>
		/// <returns></returns>
		public static int IndexFromMask(int mask)
		{
			for(int i = 0; i < 32; ++i)
			{
				if((1 << i & mask) != 0)
				{
					return i;
				}
			}
			return -1;
		}

		public static float GetPathDistance(this NavMeshPath path)
		{
			float lng = 0.0f;

			if((path.status != NavMeshPathStatus.PathInvalid) && (path.corners.Length > 1))
			{
				for(int i = 1; i < path.corners.Length; ++i)
				{
					lng += Vector3.Distance(path.corners[i - 1], path.corners[i]);
				}
			}

			return lng;
		}

		public static float Cost(this NavMeshPath path)
		{
			if(path.corners.Length < 2) return 0;

			float cost = 0;
			NavMeshHit hit;
			NavMesh.SamplePosition(path.corners[0], out hit, 0.1f, NavMesh.AllAreas);
			Vector3 rayStart = path.corners[0];
			int mask = hit.mask;
			int index = IndexFromMask(mask);

			for(int i = 1; i < path.corners.Length; ++i)
			{
				while(true)
				{
					NavMesh.Raycast(rayStart, path.corners[i], out hit, mask);

					cost += NavMesh.GetAreaCost(index) * hit.distance;

					if(hit.mask != 0) mask = hit.mask;

					index = IndexFromMask(mask);
					rayStart = hit.position;

					if(hit.mask == 0)
					{ //hit boundary; move startPoint of ray a bit closer to endpoint
						rayStart += (path.corners[i] - rayStart).normalized * 0.01f;
					}

					if(!hit.hit) break;
				}
			}

			return cost;
		}

	}
}
