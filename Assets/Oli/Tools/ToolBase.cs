using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cirrus.Unity.Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cirrus.Events;

namespace Tojam2022
{

	public enum ToolState
	{
		Shelved,
		Active
	}


	public class ToolBase : MonoBehaviour
	{
		[SerializeField]
		private float _cooldownTime = 2;


		[SerializeField]
		private Timer _cooldownTimer;


		[SerializeField]
		protected Collider _cursorInteractionTrigger;

		//[SerializeField]
		protected EventForwarderComponent _cursorTriggerEvents;

		[SerializeField]
		public Transform Transform;

		[SerializeField]
		protected ToolState _toolState;

		//[SerializeField]
		//protected Collider _actionTrigger;

		//[SerializeField]
		protected Vector3 _shelfPosition;

		//[SerializeField]
		protected Quaternion _shelfRotation;


		[SerializeField]
		protected float _actionRange = 10;


		public void Awake()
		{
			_cursorTriggerEvents = _cursorInteractionTrigger.GetOrAddComponent<EventForwarderComponent>();
			_cursorTriggerEvents.OnTriggerStayEvent += _OnTriggerStay;
			_shelfPosition = Transform.position;
			_shelfRotation = Transform.rotation;

			_cooldownTimer = new Timer(_OnCooldownTimeout);
		}

		private void _OnCooldownTimeout()
		{
			//_actionTrigger.gameObject.SetActive(false);
		}

		public void Use()
		{
			if (!_cooldownTimer.IsActive)
			{
				
				Physics.OverlapSphere(Transform.position, _actionRange);

				_Use();
				_cooldownTimer.Reset(_cooldownTime);
			}
		}

		protected virtual void _Use()
		{ 
		
		}


		private void _OnTriggerStay(GameObject o, Collider other)
		{
			switch (_toolState)
			{
				case ToolState.Shelved:
					var cursor = other.GetComponentInParent<Cursor>();
					if (cursor != null)
					{
						cursor.OnToolHilighted(this);
					}
					break;
				case ToolState.Active:
					break;
			}
		}

		public void SetState(ToolState state, params object[] args)
		{
			switch (state)
			{
				case ToolState.Shelved:
					Transform.rotation = _shelfRotation;
					Transform.position = _shelfPosition;
					//_handMesh.SetActive(true);
					break;
				case ToolState.Active:
					//_toolState.SetActive(false);
					break;
			}
			_toolState = state;
		}
	}
}

