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
		private Collider _cursorInteractionTrigger;

		[SerializeField]
		private EventForwarderComponent _cursorTriggerEvents;

		[SerializeField]
		public Transform Transform;

		[SerializeField]
		private ToolState _toolState;

		[SerializeField]
		private Vector3 _shelfPosition;

		[SerializeField]
		private Quaternion _shelfRotation;

		public void Awake()
		{
			_cursorTriggerEvents = _cursorInteractionTrigger.GetOrAddComponent<EventForwarderComponent>();
			_cursorTriggerEvents.OnTriggerStayEvent += _OnTriggerStay;
			_shelfPosition = Transform.position;
			_shelfRotation = Transform.rotation;
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

