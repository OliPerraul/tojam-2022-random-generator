using Cirrus.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Cirrus.Unity.Numerics
{
	public static class VectorUtils
	{
		public static Vector3 Dir(this Vector3 first, Vector3 second)
		{
			return (second - first).normalized;
		}

		public static Vector3 ClampMagnitude(this Vector3 v, float maxLength)
		{
			return Vector3.ClampMagnitude(v, maxLength);
		}

		public static bool HasNaN(this Vector3 vec)
		{
			return float.IsNaN(vec.x) || float.IsNaN(vec.y) || float.IsNaN(vec.z);
		}

		/// <summary>
		/// Return speed and direction
		/// </summary>
		/// <param name="velocity"></param>
		/// <returns></returns>
		public static Vector2 ClampMagnitude(this Vector2 v, float maxLength)
		{
			return Vector2.ClampMagnitude(v, maxLength);
		}

		public static float Distance(
		this Vector3 source,
		Vector3 target
		)
		{
			return (target - source).magnitude;
		}


		/// <summary>
		/// Return speed and direction
		/// </summary>
		/// <param name="velocity"></param>
		/// <returns></returns>
		public static void FromVelocity(this Vector3 velocity, out Vector3 dir, out float speed)
		{
			dir = velocity.normalized;
			speed = velocity.magnitude;
		}


		public static float Dot(this Vector3 lhs, Vector3 rhs)
		{
			return Vector3.Dot(lhs, rhs);
		}

		public static bool Dot(this Vector3 lhs, Vector3 rhs, out float dot)
		{
			dot = Vector3.Dot(lhs, rhs);
			return dot > 0;
		}


		public static bool Dot(this Vector3 lhs, Vector3 rhs, float threshold, out float dot)
		{
			dot = Vector3.Dot(lhs, rhs);
			return dot > threshold;
		}

		public static bool Dot(this Vector3 lhs, Vector3 rhs, float threshold)
		{
			return Vector3.Dot(lhs, rhs) > threshold;
		}

		public static float NonZeroSign(this Vector3 vec)
		{
			if(vec.x < 0 || vec.x > 0) return vec.x;
			if(vec.y < 0 || vec.y > 0) return vec.y;
			if(vec.z < 0 || vec.z > 0) return vec.z;
			return 0;
		}

		public static Vector3 RotateAbout(this Vector3 vec, Vector3 axis, float ang)
		{
			return Quaternion.AngleAxis(ang, axis) * vec;
		}

		public static Vector3 RotateAboutWorldAxis(this Vector3 vec, Vector3 eulerAngle)
		{
			return Quaternion.Euler(eulerAngle) * vec;
		}

		public static Vector3 RotateAboutWorldAxis(this Vector3 vec, float xang, float yang, float zang)
		{
			return Quaternion.Euler(xang, yang, zang) * vec;
		}

		public static void Set(ref this Vector3Int vector, Vector3Int newVector)
		{
			vector = newVector;
		}

		public static void Set(ref this Vector3 vector, Vector3 newVector)
		{
			vector = newVector;
		}

		#region To Vector

		public static Vector2Int ToVector(this int i, int width)
		{
			return new Vector2Int(
				i % width,
				i / width);
		}

		public static Vector3Int ToVector(this int i, int width, int height)
		{
			return new Vector3Int(
				i % width,
				(i / width) % height,
				i / (width * height));
		}


		//public static Vector2Int Xyi2(this Vector2 vec2)
		//{
		//	return new Vector2Int((int)vec2.x, (int)vec2.y);// (int)vec3.z);
		//}

		//public static Vector3Int Xy0i3(this Vector2Int vec)
		//{
		//	return new Vector3Int((int)vec.x, (int)vec.y, 0);
		//}


		//public static Vector3Int X0yi3(this Vector2Int vec)
		//{
		//	return new Vector3Int((int)vec.x, 0, (int)vec.y);
		//}

		//public static Vector3Int Xyzi3(this Vector3 vec3)
		//{
		//	return new Vector3Int((int)vec3.x, (int)vec3.y, (int)vec3.z);
		//}

		//public static Vector3 X0y3(this Vector2 vector)
		//{
		//	return new Vector3(vector.x, 0, vector.y);
		//}

		//public static Vector3 Xyz3(this Vector3Int vec3)
		//{
		//	return new Vector3(vec3.x, vec3.y, vec3.z);
		//}

		//#endregion

		//#region Set

		//public static Vector3 Xyz3(this Vector3 vec3, float x, float y, float z)
		//{
		//	vec3.x = x;
		//	vec3.y = y;
		//	vec3.z = z;
		//	return vec3;
		//}

		//public static Vector3 Xz3(this Vector3 vec3)
		//{
		//	vec3.y = 0;
		//	return vec3;
		//}


		//public static Vector3Int Xyzi3(this Vector3Int vec3, int x, int y, int z)
		//{
		//	vec3.x = x;
		//	vec3.y = y;
		//	vec3.z = z;
		//	return vec3;
		//}

		//public static Vector3Int Xyi3(this Vector3Int vec3, int x, int y)
		//{
		//	vec3.x = x;
		//	vec3.y = y;
		//	//vec3.z = z;
		//	return vec3;
		//}

		//public static Vector3Int Xzi3(this Vector3Int vec3, int x, int z)
		//{
		//	//return new Vector3Int(x, vec3.y, z);
		//	vec3.x = x;
		//	//vec3.y = y;
		//	vec3.z = z;
		//	return vec3;
		//}

		//public static Vector3 Z3(this Vector3 vector, float z)
		//{
		//	return new Vector3(vector.x, vector.y, z);//.z);
		//}

		//public static Vector3Int Zi3(this Vector3Int vec3, int z)
		//{
		//	//vec3.x = x;
		//	//vec3.y = y;
		//	vec3.z = z;
		//	return vec3;
		//}

		//public static Vector3Int Yi3(this Vector3Int vec3, int y)
		//{
		//	//vec3.x = x;
		//	//vec3.y = y;
		//	vec3.y = y;
		//	return vec3;
		//}

		//public static Vector3Int Xi3(this Vector3Int vec3, int x)
		//{
		//	//vec3.x = x;
		//	//vec3.y = y;
		//	vec3.x = x;
		//	return vec3;
		//}

		//public static Vector3 Y3(this Vector3 vector, float y)
		//{
		//	return new Vector3(vector.x, y, vector.z);
		//}
		//public static Vector2Int Y3(this Vector2Int vec3, int y)
		//{
		//	//vec3.x = x;
		//	//vec3.y = y;
		//	vec3.y = y;
		//	return vec3;
		//}


		//public static Vector3 X3(this Vector3 vector, float x)
		//{
		//	return new Vector3(x, vector.y, vector.z);
		//}


		//public static Vector2Int Xi2(this Vector2Int vec3, int x)
		//{
		//	//vec3.x = x;
		//	//vec3.y = y;
		//	vec3.x = x;
		//	return vec3;
		//}

		//public static Vector2Int Xyi2(this Vector3Int vec3)
		//{
		//	//vec3.x = x;
		//	//vec3.y = y;
		//	return new Vector2Int(vec3.x, vec3.y);
		//}

		//public static Vector2 Xy2(this Vector3 vec3)
		//{
		//	//vec3.x = x;
		//	//vec3.y = y;
		//	return new Vector2(vec3.x, vec3.y);
		//}


		#endregion

		// https://softwareengineering.stackexchange.com/questions/212808/treating-a-1d-data-structure-as-2d-grid
		//public static int ToIndex(this Vector3Int v, int width, int height)
		//{
		//	return v.x + width * v.y + width * height * v.z;
		//}

		//public static int ToIndex(int x, int y, int z, int width, int height)
		//{
		//	return x + width * y + width * height * z;
		//}

		public static Quaternion ToEulerRotation(this Vector3 v)
		{
			return Quaternion.Euler(v);
		}

		public static Vector3Int[] VectorIntDirections =
			new Vector3Int[] {
				new Vector3Int(1, 0, 0),
				new Vector3Int(1, 0, 1),
				new Vector3Int(0, 0, 1),
				new Vector3Int(-1, 0, 1),
				new Vector3Int(-1, 0, 0),
				new Vector3Int(-1, 0, -1),
				new Vector3Int(0, 0, -1),
				new Vector3Int(1, 0, -1)
			};


		//public static int ToIndex(this Vector2Int v, int width)
		//{
		//	return v.x + width * v.y;
		//}

		//public static int ToIndex(int x, int y, int width)
		//{
		//	return x + width * y;
		//}

		// Slope  between point in radian
		public static float Slope(Vector2 p1, Vector2 p2)
		{
			/*
				m = y2−y1/x2−x1
				tan(theta)=m
				theta = atan(m)
			 */
			var direction = p2 - p1;
			return Mathf.Atan2(direction.x, direction.y);
		}


		public static bool Almost(
			this Vector3 pos0,
			Vector3 pos1,
			float tolerance = 0.1f)
		{
			return (pos0 - pos1).magnitude <= tolerance;
		}

		public static bool Almost(
			this Vector2 pos0,
			Vector2 pos1,
			float tolerance = 0.1f)
		{
			return (pos0 - pos1).magnitude <= tolerance;
		}


		/// <summary>
		/// inclusive min, exclusive max
		/// </summary>
		/// <param name="pos1"></param>
		/// <param name="pos2"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static bool IsBetween(
			this Vector3 pos1,
			Vector3 pos2,
			float min,
			float max)
		{
			float dist = Vector3.Distance(pos1, pos2);
			return min < dist && dist < max;
		}


		/// <summary>
		/// Rounds Vector3.
		/// </summary>
		/// <param name="vector3"></param>
		/// <param name="decimalPlaces"></param>
		/// <returns></returns>
		public static Vector3 Round(
			this Vector3 vector3,
			int decimalPlaces = 2)
		{
			float multiplier = 1;
			for(int i = 0; i < decimalPlaces; i++)
			{
				multiplier *= 10f;
			}

			return new Vector3(
				Mathf.Round(vector3.x * multiplier) / multiplier,
				Mathf.Round(vector3.y * multiplier) / multiplier,
				Mathf.Round(vector3.z * multiplier) / multiplier);
		}

		public static Vector2 Mul(this Vector2 value, Vector2 scale)
		{
			return new Vector2(value.x * scale.x, value.y * scale.y);
		}

		public static Vector2 Div(this Vector2 value, Vector2 scale)
		{
			return new Vector2(value.x / scale.x, value.y / scale.y);
		}

		public static Vector3 Mul(this Vector3 value, Vector3 scale)
		{
			return new Vector3(value.x * scale.x, value.y * scale.y, value.z * scale.z);
		}

		public static Vector3 Div(this Vector3 value, Vector3 scale)
		{
			return new Vector3(value.x / scale.x, value.y / scale.y, value.z / scale.z);
		}

		//public static Vector3 RotateAround(this Vector3 point, Vector3 pivot, Quaternion rotation)
		//{
		//	return rotation * (point - pivot) + pivot;
		//}

		////public static Vector3 RotateAround(this Vector3 point, Vector3 pivot, float angle)
		////{
		////	Vector3 direction = point - pivot;
		////	direction = Quaternion.Euler(new Vector3(0, angle, 0)) * direction;
		////	point = direction + pivot;
		////	return point;
		////}

		//public static Vector3 RotateAround(Vector3 point, Vector3 axis, float angle)
		//{
		//	//Vector3 vector = this.position;
		//	return RotateAround(point, axis, Quaternion.AngleAxis(angle, axis));
		//	//Vector3 vector2 = vector - point;
		//	//vector2 = rotation * vector2;
		//	//vector = point + vector2;
		//	//this.position = vector;
		//	//this.RotateAroundInternal(axis, angle * 0.0174532924f);
		//	//return
		//}

		public static Vector3 RotateAround(
			this Vector3 position,
			Vector3 center,
			Vector3 axis,
			float angle)
		{
			Quaternion rotation = Quaternion.AngleAxis(angle, axis);
			Vector3 centerToPosition = position - center;
			position = center + (rotation * centerToPosition);
			return position;
		}

		//public static Vector3 RotateAround(
		//	this Vector3 position,
		//	Vector3 center,
		//	Vector3 axis,
		//	Vector3 eulerAngle)
		//{
		//	Quaternion rotation = Quaternion.Euler(angle, axis);
		//	Vector3 centerToPosition = position - center;
		//	position = center + (rotation * centerToPosition);
		//	return position;
		//}

		//public static Vector3 RotateAround(this Vector3 point, Vector3 pivot, Vector3 eulerAngles)
		//{
		//	return RotateAround(point, pivot, Quaternion.Euler(eulerAngles));
		//}

		public static Vector3 TransformPoint(this Vector3 point, Vector3 translation, Quaternion rotation, Vector3 lossyScale)
		{
			return rotation * Vector3.Scale(lossyScale, point) + translation;
		}

		public static Vector3 InverseTransformPoint(this Vector3 point, Vector3 translation, Quaternion rotation, Vector3 lossyScale)
		{
			var scaleInv = new Vector3(1 / lossyScale.x, 1 / lossyScale.y, 1 / lossyScale.z);
			return Vector3.Scale(scaleInv, (Quaternion.Inverse(rotation) * (point - translation)));
		}

		public static Vector2 Average(this IEnumerable<Vector2> vectors)
		{
			float x = 0f;
			float y = 0f;
			int count = 0;
			foreach(var pos in vectors)
			{
				x += pos.x;
				y += pos.y;
				count++;
			}
			return new Vector2(x / count, y / count);
		}

		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			float x = 0f;
			float y = 0f;
			float z = 0f;
			int count = 0;
			foreach(var pos in vectors)
			{
				x += pos.x;
				y += pos.y;
				z += pos.z;
				count++;
			}
			return new Vector3(x / count, y / count, z / count);
		}

		public static Vector2 Average(this ICollection<Vector2> vectors)
		{
			int count = vectors.Count;
			if(count == 0)
			{
				return Vector2.zero;
			}

			float x = 0f;
			float y = 0f;
			foreach(var pos in vectors)
			{
				x += pos.x;
				y += pos.y;
			}
			return new Vector2(x / count, y / count);
		}

		public static Vector3 Average(this ICollection<Vector3> vectors)
		{
			int count = vectors.Count;
			if(count == 0)
			{
				return Vector3.zero;
			}

			float x = 0f;
			float y = 0f;
			float z = 0f;
			foreach(var pos in vectors)
			{
				x += pos.x;
				y += pos.y;
				z += pos.z;
			}
			return new Vector3(x / count, y / count, z / count);
		}

		public static Vector2 Median(this IEnumerable<Vector2> vectors)
		{
			int count = vectors.FastCount();
			if(count == 0)
			{
				return Vector2.zero;
			}

			return vectors.OrderBy(v => v.sqrMagnitude).ElementAt(count / 2);
		}

		public static Vector3 Median(this IEnumerable<Vector3> vectors)
		{
			int count = vectors.FastCount();
			if(count == 0)
			{
				return Vector3.zero;
			}

			return vectors.OrderBy(v => v.sqrMagnitude).ElementAt(count / 2);
		}

		public static Vector2 Median(this ICollection<Vector2> vectors)
		{
			int count = vectors.Count;
			if(count == 0)
			{
				return Vector2.zero;
			}

			return vectors.OrderBy(v => v.sqrMagnitude).ElementAt(count / 2);
		}

		public static Vector3 Median(this ICollection<Vector3> vectors)
		{
			int count = vectors.Count;
			if(count == 0)
			{
				return Vector3.zero;
			}

			return vectors.OrderBy(v => v.sqrMagnitude).ElementAt(count / 2);
		}


		public static float GetAreaOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			var vx = p2 - p1;
			var vy = p3 - p1;
			var dotvxy = Vector3.Dot(vx, vy);
			var sqrArea = vx.sqrMagnitude * vy.sqrMagnitude - dotvxy * dotvxy;
			return 0.5f * Mathf.Sqrt(sqrArea);
		}

		/// <summary>
		/// get the line length between two points
		/// </summary>
		/// <param name="p1"></param>
		/// <param name="p2"></param>
		/// <returns></returns>
		//public static double getLineLength(Vector3 p1, Vector3 p2)
		//{
		//	double length;
		//	length = Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2);
		//	length = Math.Sqrt(length);
		//	return length;
		//}

		///// <summary>
		///// get triangle's area Using Heron's formula
		///// </summary>
		///// <param name="p1"></param>
		///// <param name="p2"></param>
		///// <param name="p3"></param>
		///// <returns></returns>
		//public static double GetAreaOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3)
		//{
		//	double area = 0;
		//	double p1p2 = getLineLength(p1, p2);
		//	double p2p3 = getLineLength(p2, p3);
		//	double p1p3 = getLineLength(p1, p3);

		//	double s = (p1p2 + p2p3 + p1p3) / 2;
		//	area = s * (s - p1p2) * (s - p2p3) * (s - p1p3);
		//	area = Math.Sqrt(area);

		//	return area;
		//}
	}
}
