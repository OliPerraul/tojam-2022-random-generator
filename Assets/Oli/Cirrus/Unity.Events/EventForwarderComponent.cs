using System;
using UnityEngine;

namespace Cirrus.Events
{
	/**
	 * Utility component to add to game objects whose events you want forwarded from Unity's message	 	 
	 */
	public class EventForwarderComponent : MonoBehaviour
	{
		public event Action<GameObject> AwakeEvent;
		public event Action<GameObject> OnAnimatorMoveEvent;
		public event Action<GameObject, bool> OnApplicationFocusEvent;
		public event Action<GameObject, bool> OnApplicationPauseEvent;
		public event Action<GameObject> OnApplicationQuitEvent;
		public event Action<GameObject, float[], int> OnAudioFilterReadEvent;
		public event Action<GameObject> OnBecameInvisibleEvent;
		public event Action<GameObject> OnBecameVisibleEvent;
		public event Action<GameObject, Collision> OnCollisionEnterEvent;
		public event Action<GameObject, Collision2D> OnCollisionEnter2DEvent;
		public event Action<GameObject, Collision> OnCollisionExitEvent;
		public event Action<GameObject, Collision2D> OnCollisionExit2DEvent;
		public event Action<GameObject, Collision> OnCollisionStayEvent;
		public event Action<GameObject, Collision2D> OnCollisionStay2DEvent;
		public event Action<GameObject> OnConnectedToServerEvent;
		public event Action<GameObject, ControllerColliderHit> OnControllerColliderHitEvent;
		public event Action<GameObject> OnDestroyEvent;
		public event Action<GameObject> OnDisableEvent;
		public event Action<GameObject> OnDrawGizmosEvent;
		public event Action<GameObject> OnDrawGizmosSelectedEvent;
		public event Action<GameObject> OnEnableEvent;
		public event Action<GameObject> OnGUIEvent;
		public event Action<GameObject, float> OnJointBreakEvent;
		public event Action<GameObject, int> OnLevelWasLoadedEvent;
		public event Action<GameObject> OnMouseDownEvent;
		public event Action<GameObject> OnMouseDragEvent;
		public event Action<GameObject> OnMouseEnterEvent;
		public event Action<GameObject> OnMouseExitEvent;
		public event Action<GameObject> OnMouseOverEvent;
		public event Action<GameObject> OnMouseUpEvent;
		public event Action<GameObject> OnMouseUpAsButtonEvent;
		public event Action<GameObject, GameObject> OnParticleCollisionEvent;
		public event Action<GameObject> OnPostRenderEvent;
		public event Action<GameObject> OnPreCullEvent;
		public event Action<GameObject> OnPreRenderEvent;
		public event Action<GameObject, RenderTexture, RenderTexture> OnRenderImageEvent;
		public event Action<GameObject> OnRenderObjectEvent;
		public event Action<GameObject> OnServerInitializedEvent;
		public event Action<GameObject, Collider> OnTriggerEnterEvent;
		public event Action<GameObject, Collider2D> OnTriggerEnter2DEvent;
		public event Action<GameObject, Collider> OnTriggerExitEvent;
		public event Action<GameObject, Collider2D> OnTriggerExit2DEvent;
		public event Action<GameObject, Collider> OnTriggerStayEvent;
		public event Action<GameObject, Collider2D> OnTriggerStay2DEvent;
		public event Action<GameObject> OnValidateEvent;
		public event Action<GameObject> OnWillRenderObjectEvent;
		public event Action<GameObject> ResetEvent;
		public event Action<GameObject> StartEvent;

		public void Awake()
		{
			AwakeEvent?.Invoke(gameObject);
		}

		//public void OnAnimatorMove()
		//{
		//	OnAnimatorMoveEvent?.Invoke(gameObject);
		//}

		public void OnApplicationFocus(bool focusStatus)
		{
			OnApplicationFocusEvent?.Invoke(gameObject, focusStatus);
		}

		public void OnApplicationPause(bool pauseStatus)
		{
			OnApplicationPauseEvent?.Invoke(gameObject, pauseStatus);
		}

		public void OnApplicationQuit()
		{
			OnApplicationQuitEvent?.Invoke(gameObject);
		}

		public void OnAudioFilterRead(float[] data, int channels)
		{
			OnAudioFilterReadEvent?.Invoke(gameObject, data, channels);
		}

		public void OnBecameInvisible()
		{
			OnBecameInvisibleEvent?.Invoke(gameObject);
		}

		public void OnBecameVisible()
		{
			OnBecameVisibleEvent?.Invoke(gameObject);
		}

		public void OnCollisionEnter(Collision collision)
		{
			OnCollisionEnterEvent?.Invoke(gameObject, collision);
		}

		public void OnCollisionEnter2D(Collision2D collision)
		{
			OnCollisionEnter2DEvent?.Invoke(gameObject, collision);
		}

		public void OnCollisionExit(Collision collision)
		{
			OnCollisionExitEvent?.Invoke(gameObject, collision);
		}

		public void OnCollisionExit2D(Collision2D collision)
		{
			OnCollisionExit2DEvent?.Invoke(gameObject, collision);
		}

		public void OnCollisionStay(Collision collision)
		{
			OnCollisionStayEvent?.Invoke(gameObject, collision);
		}

		public void OnCollisionStay2D(Collision2D collision)
		{
			OnCollisionStay2DEvent?.Invoke(gameObject, collision);
		}

		//public void OnConnectedToServer()
		//{
		//	OnConnectedToServerEvent?.Invoke(gameObject);
		//}

		//public void OnControllerColliderHit(ControllerColliderHit hit)
		//{
		//	OnControllerColliderHitEvent?.Invoke(gameObject, hit);
		//}

		public void OnDestroy()
		{
			OnDestroyEvent?.Invoke(gameObject);
		}

		public void OnDisable()
		{
			OnDisableEvent?.Invoke(gameObject);
		}

		//public void OnDrawGizmos()
		//{
		//	OnDrawGizmosEvent?.Invoke(gameObject);
		//}

		//public void OnDrawGizmosSelected()
		//{
		//	OnDrawGizmosSelectedEvent?.Invoke(gameObject);
		//}

		public void OnEnable()
		{
			OnEnableEvent?.Invoke(gameObject);
		}

		//public void OnGUI()
		//{
		//	OnGUIEvent?.Invoke(gameObject);
		//}

		//public void OnJointBreak(float breakForce)
		//{
		//	OnJointBreakEvent?.Invoke(gameObject, breakForce);
		//}

		//public void OnLevelWasLoaded(int level)
		//{
		//	OnLevelWasLoadedEvent?.Invoke(gameObject, level);
		//}


		//public void OnMouseDown()
		//{
		//	OnMouseDownEvent?.Invoke(gameObject);
		//}

		//public void OnMouseDrag()
		//{
		//	OnMouseDragEvent?.Invoke(gameObject);
		//}

		//public void OnMouseEnter()
		//{
		//	OnMouseEnterEvent?.Invoke(gameObject);
		//}

		//public void OnMouseExit()
		//{
		//	OnMouseExitEvent?.Invoke(gameObject);
		//}

		//public void OnMouseOver()
		//{
		//	OnMouseOverEvent?.Invoke(gameObject);
		//}

		//public void OnMouseUp()
		//{
		//	OnMouseUpEvent?.Invoke(gameObject);
		//}

		//public void OnMouseUpAsButton()
		//{
		//	OnMouseUpAsButtonEvent?.Invoke(gameObject);
		//}


		//public void OnParticleCollision(GameObject other)
		//{
		//	OnParticleCollisionEvent?.Invoke(gameObject, other);
		//}

		//public void OnPostRender()
		//{
		//	OnPostRenderEvent?.Invoke(gameObject);
		//}

		//public void OnPreCull()
		//{
		//	OnPreCullEvent?.Invoke(gameObject);
		//}

		//public void OnPreRender()
		//{
		//	OnPreRenderEvent?.Invoke(gameObject);
		//}

		//public void OnRenderImage(RenderTexture src, RenderTexture dest)
		//{
		//	OnRenderImageEvent?.Invoke(gameObject, src, dest);
		//}

		//public void OnRenderObject()
		//{
		//	OnRenderObjectEvent?.Invoke(gameObject);
		//}


		//public void OnServerInitialized()
		//{
		//	OnServerInitializedEvent?.Invoke(gameObject);
		//}

		public void OnTriggerEnter(Collider other)
		{
			OnTriggerEnterEvent?.Invoke(gameObject, other);
		}

		public void OnTriggerEnter2D(Collider2D other)
		{
			OnTriggerEnter2DEvent?.Invoke(gameObject, other);
		}

		public void OnTriggerExit(Collider other)
		{
			OnTriggerExitEvent?.Invoke(gameObject, other);
		}

		public void OnTriggerExit2D(Collider2D other)
		{
			OnTriggerExit2DEvent?.Invoke(gameObject, other);
		}

		public void OnTriggerStay(Collider other)
		{
			OnTriggerStayEvent?.Invoke(gameObject, other);
		}

		public void OnTriggerStay2D(Collider2D other)
		{
			OnTriggerStay2DEvent?.Invoke(gameObject, other);
		}

		public void OnValidate()
		{
			OnValidateEvent?.Invoke(gameObject);
		}

		//public void OnWillRenderObject()
		//{
		//	OnWillRenderObjectEvent?.Invoke(gameObject);
		//}

		public void Reset()
		{
			ResetEvent?.Invoke(gameObject);
		}

		public void Start()
		{
			StartEvent?.Invoke(gameObject);
		}

		//public void Update()
		//{
		//	UpdateEvent?.Invoke(gameObject);
		//}
	}
}