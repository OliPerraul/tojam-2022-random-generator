//using Cirrus.Objects;
//using System;
//using UnityEngine;
//using Object = UnityEngine.Object;

//namespace Cirrus.Unity.Objects
//{
//	public static class PrototypeUtils
//	{
//		// TODO: It would be best to seperate realize object and component
//		// easier to cleanup
//		public static T RealizeResourceAndCreateEngineObject<T>(
//			this IEngineObjectResource<T> resource,
//			Vector3 position,
//			Transform parent = null,
//			Action<T> action = null) where T : LegacyEngineObjectComponentBase
//		{
//			T result = Object.Instantiate(
//				((CustomMonoBehaviourBase)resource.RawObject).gameObject,
//				position,
//				Quaternion.identity, parent)
//				.GetComponent<T>();
//			// Component.OnObjectRealizedHandler?.Invoke(this);
//			//result.RawResource = resource.Realize(realized =>
//			//{
//			//	realized.ObjectComp = result;
//			//});
//			result.OnResourceRealized(resource.PrefabComp);
//			((IEngineObjectResource<T>)result.RawResource).OnEngineObjectCreatedHandler?.Invoke(result);
//			if (action != null) action(result);
//			return result;
//		}

//		public static T CreateEngineObject<T>(
//			this IEngineObjectResource<T> resource,
//			Vector3 position,
//			Transform parent = null,
//			Action<T> action = null) where T : LegacyEngineObjectComponentBase
//		{
//			T result = Object.Instantiate(
//				((CustomMonoBehaviourBase)resource.PrefabComp).gameObject,
//				position,
//				Quaternion.identity, parent)
//				.GetComponent<T>();
//			result.RawResource = resource;
//			resource.ObjectComp = result;
//			result.OnResourceRealized(resource.PrefabComp);
//			resource.OnEngineObjectCreatedHandler?.Invoke(result);
//			if (action != null) action(result);
//			return result;
//		}
//	}
//}
