using Cirrus.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Cirrus.Unity.Objects
{
	public static class MonoBehaviourUtils
	{
		public static bool TryGetComponentInParent<T>(
			this GameObject source, out T component)
		{
			component = source.GetComponentInParent<T>();
			return component != null;
		}

		public static bool TryGetComponentInChildren<T>(
			this GameObject source, out T component)
		{
			component = source.GetComponentInChildren<T>();
			return component != null;
		}

		public static bool TryGetComponentInParent<T>(
			this Component source, out T component)
		{
			component = source.GetComponentInParent<T>();
			return component != null;
		}

		public static bool TryGetComponentInChildren<T>(
			this Component source, out T component)
		{
			component = source.GetComponentInChildren<T>();
			return component != null;
		}

		public static bool TryGetComponentInParent<T>(
			this Transform source, out T component)
		{
			component = source.GetComponentInParent<T>();
			return component != null;
		}

		public static bool TryGetComponentInChildren<T>(
			this Transform source, out T component)
		{
			component = source.GetComponentInChildren<T>();
			return component != null;
		}

		public static int GetComponentIndex<T>(this MonoBehaviour source)
		{
			T[] components = source.GetComponents<T>();
			Debug.Assert(Enumerable.Count(components) == 1);
			return
				components.IsEmpty() ?
					-1 :
					Array.IndexOf(
						source.GetComponents<MonoBehaviour>(),
						components.First());
		}

		public static int GetThisComponentIndex(this MonoBehaviour source)
		{
			Component[] components = source.GetComponents(source.GetType());
			return
				components.IsEmpty() ?
					-1 :
					Array.IndexOf(
						source.GetComponents<MonoBehaviour>(),
						source);
		}


		public static T[] GetComponentsInImmediateChildren<T>(this GameObject gobj, bool activeOnly = false)
		{
			return GetComponentsInImmediateChildren<T>(gobj.transform, activeOnly);
		}

		public static T[] GetComponentsInImmediateChildren<T>(this MonoBehaviour mono, bool activeOnly = false)
		{
			return GetComponentsInImmediateChildren<T>(mono.transform, activeOnly);
		}

		public static T[] GetComponentsInImmediateChildren<T>(this Transform transform, bool activeOnly = false)
		{
			System.Collections.Generic.List<T> retList = new System.Collections.Generic.List<T>();
			for(int i = 0; i < transform.childCount; i++)
			{
				Transform childTrans = transform.GetChild(i);
				if(activeOnly && !childTrans.gameObject.activeSelf) continue;
				T[] comps = childTrans.GetComponents<T>();
				for (int j = 0; j < comps.Length; j++)
				{
					retList.Add(comps[j]);
				}
			}
			return retList.ToArray();
		}

		public static GameObject[] GetImmediateChildren(this GameObject go, bool activeOnly = false)
		{
			System.Collections.Generic.List<GameObject> childList = new System.Collections.Generic.List<GameObject>();
			Transform trans = go.transform;
			for(int i = 0; i < trans.childCount; i++)
			{
				Transform childTrans = trans.GetChild(i);
				if(activeOnly && !childTrans.gameObject.activeSelf) continue;
				childList.Add(childTrans.gameObject);
			}
			return childList.ToArray();
		}
	}
}
