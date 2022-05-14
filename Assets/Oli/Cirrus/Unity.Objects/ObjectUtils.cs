 using Cirrus.Collections;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Cirrus.Unity.Objects
{
	public static class ObjectUtils
	{
		public static T[] Simplify<T>(this Object o) where T : Object
		{
			if (o is GameObject gobj)
			{
				var comps = gobj.GetComponents<MonoBehaviour>();
				T[] objs = new T[comps.Length];
				for (int i = 0; i < comps.Length; i++) objs[i] = (T)(object)comps[i];
				return objs;
			}
			else if (typeof(T).IsAssignableFrom(o.GetType()))
			{
				return new T[] { (T)o };
			}

			return ArrayUtils.Empty<T>();
		}
		
		
		public static bool NativeReferenceEquals(this Object obj1, Object obj2)
		{
			return obj1 == obj2;
		}

		public static bool IsNativeReferenceNull(this Object obj1)
		{
			return obj1 == null;
		}

		public static bool IsGameObjectNull(this MonoBehaviour obj1)
		{
			return obj1.gameObject == null;
		}

#if UNITY_EDITOR
		public static System.Collections.Generic.List<T> GetSubObjectsOfType<T>(Object asset)
		{
			Object[] objs = AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GetAssetPath(asset));
			System.Collections.Generic.List<T> ofType = new System.Collections.Generic.List<T>();
			foreach(Object o in objs)
			{
				if(o is T)
				{
					ofType.Add((T)(object)o);
				}
			}
			return ofType;
		}

		public static System.Collections.Generic.List<ScriptableObject> GetSubObjectsOfTypeAsScriptableObjects<T>(ScriptableObject asset) where T : ScriptableObject
		{
			Object[] objs = AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GetAssetPath(asset));
			System.Collections.Generic.List<ScriptableObject> ofType = new System.Collections.Generic.List<ScriptableObject>();
			foreach(Object o in objs)
			{
				if(o is T)
				{
					ofType.Add(o as ScriptableObject);
				}
			}
			return ofType;
		}

		public static System.Collections.Generic.List<T2> GetSubObjectsOfTypeAsType<T1, T2>(Object asset) where T1 : Object where T2 : T1
		{
			Object[] objs = AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GetAssetPath(asset));
			System.Collections.Generic.List<T2> ofType = new System.Collections.Generic.List<T2>();
			foreach(Object o in objs)
			{
				if(o is T1)
				{
					ofType.Add(o as T2);
				}
			}
			return ofType;
		}
#endif
	}
}
