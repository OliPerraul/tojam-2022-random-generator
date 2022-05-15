using Cirrus.Healer.IDs;
//using Cirrus.Unity.Editor;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;
////using Cirrus.Events;
//using Event = Cirrus.Event;

namespace Cirrus.Unity.Objects
{
	// Because nullcheck of native object is slow
	// same reason op== is overloaded
	public class ObjectWrapper<T> where T : Object
	{
		private T _object;
		public T Object => _object;

		public ObjectWrapper(T o)
		{
			_object = o;
		}

		public static implicit operator T(ObjectWrapper<T> handle)
		{
			return handle._object;
		}

		public static implicit operator ObjectWrapper<T>(T o)
		{
			return new ObjectWrapper<T>(o);
		}
	}

	public abstract class MonoBehaviourBase : MonoBehaviour
	{
		public static bool operator ==(MonoBehaviourBase obj1, MonoBehaviourBase obj2)
		{
			return (object)obj1 == obj2;
		}

		public static bool operator !=(MonoBehaviourBase obj1, MonoBehaviourBase obj2)
		{
			return (object)obj1 != obj2;
		}
	}

	// This is because null check of native UnityEngine.Object is slow

	public abstract class CustomMonoBehaviourBase : MonoBehaviourBase
	{
		private bool _isApplicationQuit = false;
		protected bool _IsApplicationQuit => _isApplicationQuit;

		public Action<Collider> OnTriggerEnterHandler;

		public Action<Collider> OnTriggerExitHandler;

		public Action<Collider> OnTriggerStayHandler;

		public Action<Collision> OnCollisionEnterHandler;

		public Action<Collision> OnCollisionExitHandler;

		public Action<Collision> OnCollisionStayHandler;

		public Action OnAwakeHandler;

		public Action OnLateLateStartHandler;

		public Action OnLateStartHandler;

		public Action OnStartHandler;

		public Action OnEnableHandler;

		public Action OnDisableHandler;

		public Action OnValidateHandler;

		public Action OnDestroyHandler;

		public Action<Scene, LoadSceneMode> OnSceneLoadedHandler;

		public virtual void Awake()
		{
			OnAwakeHandler?.Invoke();
			SceneManager.sceneLoaded += OnSceneLoaded;
		}

		public virtual void OnDestroy()
		{
			OnDestroyHandler?.Invoke();
		}

		public virtual void OnApplicationQuit()
		{
			_isApplicationQuit = true;
		}

		public virtual void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{		
			OnSceneLoadedHandler?.Invoke(scene, mode);
		}

		private WaitForEndOfFrame _waitForEndOfFrame = new WaitForEndOfFrame();

		private IEnumerator LateStartCoroutine()
		{
			yield return _waitForEndOfFrame;
			LateStart();
			yield return _waitForEndOfFrame;
			LateLateStart();
		}

		public virtual void Start()
		{
			OnStartHandler?.Invoke();
			StartCoroutine(LateStartCoroutine());
		}

		public virtual void LateStart()
		{
			OnLateStartHandler?.Invoke();
		}

		public virtual void LateLateStart()
		{
			OnLateLateStartHandler?.Invoke();
		}

		public virtual void OnEnable()
		{
			OnEnableHandler?.Invoke();
		}

		public virtual void OnDisable()
		{
			OnDisableHandler?.Invoke();
		}


		public virtual void OnValidate()
		{
			OnValidateHandler?.Invoke();
		}

		public virtual void OnTriggerEnter(Collider collider)
		{
			OnTriggerEnterHandler?.Invoke(collider);
		}

		public virtual void OnTriggerStay(Collider collider)
		{
			OnTriggerStayHandler?.Invoke(collider);
		}

		public virtual void OnTriggerExit(Collider collider)
		{
			OnTriggerExitHandler?.Invoke(collider);
		}

		public virtual void OnCollisionEnter(Collision collision)
		{
			OnCollisionEnterHandler?.Invoke(collision);
		}

		public virtual void OnCollisionStay(Collision collision)
		{
			OnCollisionStayHandler?.Invoke(collision);
		}

		public virtual void OnCollisionExit(Collision collision)
		{
			OnCollisionExitHandler?.Invoke(collision);
		}
	}
}
