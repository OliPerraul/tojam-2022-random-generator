using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Cirrus.Unity.Objects
{
	public static class GameObjectUtils
	{
		public static bool IsDestroyed(this Object o)
		{
			return o == null || o.name.Equals("null");
		}

		public static bool IsPrefab(this GameObject obj)
		{
			return obj.scene.name == null;
		}

		public static bool IsPrefab(this MonoBehaviour comp)
		{
			return comp.gameObject.scene.name == null;
		}



		private static void _RecurseCollapseChildrenToList<TComponent>(GameObject parent, ref List<TComponent> collapsedChildren)
		{
			foreach(Transform child in parent.transform)
			{
				var component = child.gameObject.GetComponent<TComponent>();
				if(component != null)
				{
					collapsedChildren.Add(component);
				}

				_RecurseCollapseChildrenToList(child.gameObject, ref collapsedChildren);
			}
		}

		public static List<TComponent> CollapseChildrenToList<TComponent>(GameObject parent)
		{
			List<TComponent> collapsedChildren = new List<TComponent>();

			foreach(Transform child in parent.transform)
			{
				_RecurseCollapseChildrenToList(child.gameObject, ref collapsedChildren);
			}

			return collapsedChildren;
		}

		private static void _RecurseTraverseChildren<TObject>(
			GameObject parent,
			Action<TObject> visitor,
			bool visitInactive) where TObject : Object
		{

			TObject obj = null;
			if(typeof(TObject) == typeof(GameObject))
			{
				obj = (TObject)(object)(parent.gameObject);
			}
			else if(typeof(TObject) == typeof(Transform))
			{
				obj = (TObject)(object)parent.transform;
			}
			else
			{
				obj = parent.gameObject.GetComponent<TObject>();
			}
			if(
				obj != null &&
				!obj.name.Equals("null") &&
				(visitInactive || parent.gameObject.activeInHierarchy))
			{
				visitor.Invoke(obj);
			}

			foreach(Transform child in parent.transform)
			{
				if(child == parent) continue;
				_RecurseTraverseChildren(child.gameObject, visitor, visitInactive);
			}
		}

		public static void TraverseChildren<TObject>(
			GameObject parent,
			Action<TObject> visitor,
			bool visitInactive = false,
			bool visitRoot = false)
			where TObject : Object
		{
			if(visitRoot)
			{
				TObject obj;
				if(typeof(TObject) == typeof(GameObject))
				{
					obj = (TObject)(object)(parent.gameObject);
				}
				else if(typeof(TObject) == typeof(Transform))
				{
					obj = (TObject)(object)parent.transform;
				}
				else
				{
					obj = parent.gameObject.GetComponent<TObject>();
				}

				visitor(obj);
			}

			foreach(Transform child in parent.transform)
			{
				if(child == parent) continue;
				_RecurseTraverseChildren(child.gameObject, visitor, visitInactive);
			}
		}


		public static void Destroy(this GameObject gobj)
		{
			Object.Destroy(gobj);
		}

		public static void DestroyImmediate(this GameObject gobj)
		{
			Object.DestroyImmediate(gobj);
		}

		public static GameObject Instantiate(
			this GameObject gobj,
			Transform parent,
			Vector3 position,
			Action<GameObject> action = null)
		{
			var obj = Object.Instantiate(gobj, position, Quaternion.identity, parent);
			if(action != null) action(obj);
			return obj;
		}

		public static GameObject Instantiate(
			this GameObject gobj,
			Transform parent,
			Vector3 position,
			Quaternion rotation,
			Action<GameObject> action = null)
		{
			var obj = Object.Instantiate(gobj, position, rotation, parent);
			if (action != null) action(obj);
			return obj;
		}

		public static GameObject Instantiate(
			this GameObject gobj,
			Action<GameObject> action = null)
		{
			var obj = Object.Instantiate(gobj);
			if(action != null) action(obj);
			return obj;
		}

		public static GameObject Instantiate(
			this GameObject gobj,
			Transform parent,
			Action<GameObject> action = null)
		{
			var obj = Object.Instantiate(gobj, parent);
			if(action != null) action(obj);
			return obj;
		}

		public static T Instantiate<T>(
			this GameObject gobj,
			Transform parent,
			Vector3 position,			
			Action<T> action = null)
		{
			var obj = Object.Instantiate(gobj, position, Quaternion.identity, parent).GetComponent<T>();
			if(action != null) action(obj);
			return obj;
		}


		public static T Instantiate<T>(
			this T gobj,
			Action<T> action = null) where T : MonoBehaviour
		{
			var obj = Object.Instantiate(gobj.gameObject, Vector3.zero, Quaternion.identity).GetComponent<T>();
			if(action != null) action(obj);
			return obj;
		}

		public static T Instantiate<T>(
			this T gobj,
			Vector3 position,
			Quaternion rotation,
			Action<T> action = null) where T : MonoBehaviour
		{
			var obj = Object.Instantiate(gobj.gameObject, position, rotation).GetComponent<T>();
			if(action != null) action(obj);
			return obj;
		}

		public static T Instantiate<T>(
			this T gobj,
			Vector3 position,
			Action<T> action = null) where T : MonoBehaviour
		{
			var obj = Object.Instantiate(gobj.gameObject, position, Quaternion.identity).GetComponent<T>();
			if(action != null) action(obj);
			return obj;
		}

		public static T Instantiate<T>(
			this T behv,
			Vector3 position,
			Quaternion rot,
			Transform parent, Action<T> action = null) where T : MonoBehaviour
		{
			var obj = Object.Instantiate(behv.gameObject, position, rot, parent).GetComponent<T>();
			if(action != null) action(obj);
			return obj;
		}

		public static T Instantiate<T>(
			this T behv,
			Transform parent,
			Vector3 position,
			Action<T> action = null) where T : MonoBehaviour
		{
			var obj = Object.Instantiate(behv.gameObject, position, Quaternion.identity, parent).GetComponent<T>();
			if(action != null) action(obj);
			return obj;
		}

		public static T Instantiate<T>(
			this T behv,
			Transform parent,
			Action<T> action = null) where T : MonoBehaviour
		{
			var obj = Object.Instantiate(behv.gameObject, parent).GetComponent<T>();
			if(action != null) action(obj);
			return obj;
		}

		public static T GetOrAddComponent<T>(this GameObject target) where T : Component
		{
			if(null == target) return null;
			T comp = target.GetComponent<T>();
			if(null == comp) comp = target.AddComponent<T>();
			return comp;
		}

		public static T GetOrAddComponent<T>(this Component target) where T : Component
		{
			if(null == target) return null;
			T comp = target.GetComponent<T>();
			if(null == comp) comp = target.AddComponent<T>();
			return comp;
		}

		public static T AddComponent<T>(this GameObject target, Action<T> action) where T : Component
		{
			if (null == target) return null;
			var result = target.AddComponent<T>();
			action(result);
			return result;
		}
	}
}