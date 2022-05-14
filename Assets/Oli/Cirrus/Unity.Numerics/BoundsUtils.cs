using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Cirrus.Unity.Numerics
{
	public static class BoundsUtils
	{

		//public static Vector3 OffsetFromOrigin(this Bounds bounds)
		//{
		//	const PxReal diagonal = (bounds.maximum - bounds.minimum).magnitude();			
		//	return offsetFromOrigin = diagonal * 2.0f;
		//}
		
		
		// return diagonal of the intersection (see drawing in notes)
		public static Vector3 IntersectionDiagonal(this Bounds first, Bounds second)
		{
			float dx1 = first.max.x - second.min.x;
			float dx2 = second.max.x - first.min.x;

			float dy1 = first.max.y - second.min.y;
			float dy2 = second.max.y - first.min.y;

			float dz1 = first.max.z - second.min.z;
			float dz2 = second.max.z - first.min.z;

			return new Vector3(
				Mathf.Min(dx1, dx2),
				Mathf.Min(dy1, dy2),
				Mathf.Min(dz1, dz2));
		}

		public static bool Intersects(this Bounds bounds, Bounds other, float threshold = 0.01f)
		{
			return
				bounds.min.x <= other.max.x - threshold &&
				bounds.max.x >= other.min.x + threshold &&
				bounds.min.y <= other.max.y - threshold &&
				bounds.max.y >= other.min.y + threshold &&
				bounds.min.z <= other.max.z - threshold &&
				bounds.max.z >= other.min.z + threshold;
		}

		#region Reflection

		public static Type ProBuilderMeshType { get; private set; }
		public static PropertyInfo ProBuilderPositionsProperty { get; private set; }

		static BoundsUtils()
		{
			FindProBuilderObjectType();
		}

		public static void FindProBuilderObjectType()
		{
			if(ProBuilderMeshType != null)
				return;

			// Look through each of the loaded assemblies in our current AppDomain, looking for
			// ProBuilder's pb_Object type
			foreach(var assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				if(assembly.FullName.Contains("ProBuilder"))
				{
					ProBuilderMeshType = assembly.GetType("UnityEngine.ProBuilder.ProBuilderMesh");

					if(ProBuilderMeshType != null)
					{
						ProBuilderPositionsProperty = ProBuilderMeshType.GetProperty("positions");

						if(ProBuilderPositionsProperty != null)
							break;
					}
				}
			}
		}

		#endregion Reflection

		public static void Restart(this System.Diagnostics.Stopwatch stopwatch)
		{
			if(stopwatch == null)
				stopwatch = System.Diagnostics.Stopwatch.StartNew();
			else
			{
				stopwatch.Reset();
				stopwatch.Start();
			}
		}

		public static bool Contains(this Bounds bounds, Bounds other)
		{
			if(other.min.x < bounds.min.x || other.min.y < bounds.min.y || other.min.z < bounds.min.z ||
				other.max.x > bounds.max.x || other.max.y > bounds.max.y || other.max.z > bounds.max.z)
				return false;

			return true;
		}

		public static Bounds TransformBounds(this Transform transform, Bounds localBounds)
		{
			Vector3 transformedCenter = transform.TransformPoint(localBounds.center);
			Vector3 transformedSize = transform.rotation * localBounds.size;

			transformedSize.x = Mathf.Abs(transformedSize.x);
			transformedSize.y = Mathf.Abs(transformedSize.y);
			transformedSize.z = Mathf.Abs(transformedSize.z);

			return new Bounds(transformedCenter, transformedSize);
		}

		public static Bounds InverseTransformBounds(this Transform transform, Bounds worldBounds)
		{
			Vector3 transformedCenter = transform.InverseTransformPoint(worldBounds.center);
			Vector3 transformedSize = Quaternion.Inverse(transform.rotation) * worldBounds.size;

			transformedSize.x = Mathf.Abs(transformedSize.x);
			transformedSize.y = Mathf.Abs(transformedSize.y);
			transformedSize.z = Mathf.Abs(transformedSize.z);

			return new Bounds(transformedCenter, transformedSize);
		}

		public static void SetLayerRecursive(GameObject gameObject, int layer)
		{
			gameObject.layer = layer;

			for(int i = 0; i < gameObject.transform.childCount; i++)
				SetLayerRecursive(gameObject.transform.GetChild(i).gameObject, layer);
		}

		// TODO put somewhere else
		public static void Destroy(UnityEngine.Object obj)
		{
			if(Application.isPlaying)
			{
				// Work-Around If we're destroying a GameObject, disable it first to avoid tile
				// colliders from contributing to the NavMesh when generating synchronously since
				// Destroy() only destroys the GameObject at the end of the frame. Are there any
				// down-sides to using DestroyImmediate() here instead?
				GameObject go = obj as GameObject;

				if(go != null)
					go.SetActive(false);

				UnityEngine.Object.Destroy(obj);
			}
			else
				UnityEngine.Object.DestroyImmediate(obj);
		}

		public static string GetUniqueName(string name, IEnumerable<string> usedNames)
		{
			if(string.IsNullOrEmpty(name))
				return GetUniqueName("New", usedNames);

			string baseName = name;
			int number = 0;
			bool hasNumber = false;

			int indexOfLastSeperator = name.LastIndexOf(' ');

			if(indexOfLastSeperator > -1)
			{
				baseName = name.Substring(0, indexOfLastSeperator);
				hasNumber = int.TryParse(name.Substring(indexOfLastSeperator + 1), out number);
				number++;
			}

			foreach(var n in usedNames)
			{
				if(n == name)
				{
					if(hasNumber)
						return GetUniqueName(baseName + " " + number.ToString(), usedNames);
					else
						return GetUniqueName(name + " 2", usedNames);
				}
			}

			return name;
		}

		public static Bounds CombineBounds(params Bounds[] bounds)
		{
			if(bounds.Length == 0)
				return new Bounds();
			else if(bounds.Length == 1)
				return bounds[0];

			Bounds combinedBounds = bounds[0];

			for(int i = 1; i < bounds.Length; i++)
				combinedBounds.Encapsulate(bounds[i]);

			return combinedBounds;
		}

		public static Bounds CombineBounds(List<Bounds> bounds)
		{
			if(bounds.Count == 0)
				return new Bounds();
			else if(bounds.Count == 1)
				return bounds[0];

			Bounds combinedBounds = bounds[0];

			for(int i = 1; i < bounds.Count; i++)
				combinedBounds.Encapsulate(bounds[i]);

			return combinedBounds;
		}

		public static Bounds CalculateObjectBounds(GameObject obj, bool includeInactive, bool ignoreSpriteRenderers, bool ignoreTriggerColliders = true)
		{
			Bounds bounds = new Bounds();
			bool hasBounds = false;

			// Renderers
			foreach(var renderer in obj.GetComponentsInChildren<Renderer>(includeInactive))
			{
				if(ignoreSpriteRenderers && renderer is SpriteRenderer)
					continue;
				if(renderer is ParticleSystemRenderer)
					continue;

				if(hasBounds)
					bounds.Encapsulate(renderer.bounds);
				else
					bounds = renderer.bounds;

				hasBounds = true;
			}

			// Colliders
			foreach(var collider in obj.GetComponentsInChildren<Collider>(includeInactive))
			{
				if(ignoreTriggerColliders && collider.isTrigger)
					continue;

				if(hasBounds)
					bounds.Encapsulate(collider.bounds);
				else
					bounds = collider.bounds;

				hasBounds = true;
			}

			// Fix any zero or negative extents
			const float minExtents = 0.01f;
			Vector3 extents = bounds.extents;

			if(extents.x == 0f)
				extents.x = minExtents;
			else if(extents.x < 0f)
				extents.x *= -1f;

			if(extents.y == 0f)
				extents.y = minExtents;
			else if(extents.y < 0f)
				extents.y *= -1f;

			if(extents.z == 0f)
				extents.z = minExtents;
			else if(extents.z < 0f)
				extents.z *= -1f;

			bounds.extents = extents;
			return bounds;
		}

		/// <summary>
		/// Positions an object by aligning one of it's own sockets to the socket of another object
		/// </summary>
		/// <param name="objectA">The object to move</param>
		/// <param name="socketA">
		/// A socket for the object that we want to move (must be a child somewhere in the object's hierarchy)
		/// </param>
		/// <param name="socketB">
		/// The socket we want to attach the object to (must not be a child in the object's hierarchy)
		/// </param>
		public static void PositionObjectBySocket(GameObject objectA, GameObject socketA, GameObject socketB)
		{
			PositionObjectBySocket(objectA.transform, socketA.transform, socketB.transform);
		}

		/// <summary>
		/// Positions an object by aligning one of it's own sockets to the socket of another object
		/// </summary>
		/// <param name="objectA">The object to move</param>
		/// <param name="socketA">
		/// A socket for the object that we want to move (must be a child somewhere in the object's hierarchy)
		/// </param>
		/// <param name="socketB">
		/// The socket we want to attach the object to (must not be a child in the object's hierarchy)
		/// </param>
		public static void PositionObjectBySocket(Transform objectA, Transform socketA, Transform socketB)
		{
			Quaternion targetRotation = Quaternion.LookRotation(-socketB.forward, socketB.up);
			objectA.rotation = targetRotation * Quaternion.Inverse(Quaternion.Inverse(objectA.rotation) * socketA.rotation);

			Vector3 targetPosition = socketB.position;
			objectA.position = targetPosition - (socketA.position - objectA.position);
		}

		public static Vector3 GetCardinalDirection(Vector3 direction, out float magnitude)
		{
			float absX = Math.Abs(direction.x);
			float absY = Math.Abs(direction.y);
			float absZ = Math.Abs(direction.z);

			float dirX = direction.x / absX;
			float dirY = direction.y / absY;
			float dirZ = direction.z / absZ;

			if(absX > absY && absX > absZ)
			{
				magnitude = dirX;
				return new Vector3(dirX, 0, 0);
			}
			else if(absY > absX && absY > absZ)
			{
				magnitude = dirY;
				return new Vector3(0, dirY, 0);
			}
			else if(absZ > absX && absZ > absY)
			{
				magnitude = dirZ;
				return new Vector3(0, 0, dirZ);
			}
			else
			{
				magnitude = dirX;
				return new Vector3(dirX, 0, 0);
			}
		}

		public static Vector3 VectorAbs(Vector3 vector)
		{
			return new Vector3(Math.Abs(vector.x), Math.Abs(vector.y), Math.Abs(vector.z));
		}

		public static void SetVector3Masked(ref Vector3 input, Vector3 value, Vector3 mask)
		{
			if(mask.x != 0)
				input.x = value.x;
			if(mask.y != 0)
				input.y = value.y;
			if(mask.z != 0)
				input.z = value.z;
		}

		public static IEnumerable<T> GetComponentsInParents<T>(GameObject obj, bool includeInactive = false) where T : Component
		{
			if(obj.activeSelf || includeInactive)
			{
				foreach(var comp in obj.GetComponents<T>())
					yield return comp;
			}

			if(obj.transform.parent != null)
				foreach(var comp in GetComponentsInParents<T>(obj.transform.parent.gameObject, includeInactive))
					yield return comp;
		}

		public static T GetComponentInParents<T>(GameObject obj, bool includeInactive = false) where T : Component
		{
			if(obj.activeSelf || includeInactive)
			{
				foreach(var comp in obj.GetComponents<T>())
					return comp;
			}

			if(obj.transform.parent != null)
				return GetComponentInParents<T>(obj.transform.parent.gameObject, includeInactive);
			else
				return null;
		}

		public static float CalculateOverlap(Bounds boundsA, Bounds boundsB)
		{
			float overlapPx = boundsA.max.x - boundsB.min.x;
			float overlapNx = boundsB.max.x - boundsA.min.x;
			float overlapPy = boundsA.max.y - boundsB.min.y;
			float overlapNy = boundsB.max.y - boundsA.min.y;
			float overlapPz = boundsA.max.z - boundsB.min.z;
			float overlapNz = boundsB.max.z - boundsA.min.z;

			return Mathf.Min(overlapPx, overlapNx, overlapPy, overlapNy, overlapPz, overlapNz);
		}

		public static Vector3 CalculatePerAxisOverlap(Bounds boundsA, Bounds boundsB)
		{
			float overlapPx = boundsA.max.x - boundsB.min.x;
			float overlapNx = boundsB.max.x - boundsA.min.x;
			float overlapPy = boundsA.max.y - boundsB.min.y;
			float overlapNy = boundsB.max.y - boundsA.min.y;
			float overlapPz = boundsA.max.z - boundsB.min.z;
			float overlapNz = boundsB.max.z - boundsA.min.z;

			return new Vector3(Mathf.Min(overlapPx, overlapNx), Mathf.Min(overlapPy, overlapNy), Mathf.Min(overlapPz, overlapNz));
		}
	}
}