using Cirrus.Events;
using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Tojam2022
{
    public class Environment : SingletonComponentBase<Environment>
    {
        [SerializeField]
        public NavMeshSurface NavmeshSurface;

        [SerializeField]
        private Collider _barrierCollider;

        // Detect when hand has entered
        [SerializeField]
        private Collider _barrierTrigger;

        private EventForwarderComponent _barrierTriggerEvents;


        public Action onCursorEnteredEvent;


        public Action onCursorExitedEvent;


        public override void Awake()
        {
            Physics.IgnoreCollision(_barrierCollider, Cursor.Instance.Collider);
            Physics.IgnoreCollision(_barrierCollider, _barrierTrigger);

            _barrierTriggerEvents = _barrierTrigger.GetOrAddComponent<EventForwarderComponent>();
            _barrierTriggerEvents.OnTriggerExitEvent += _OnBarrierTriggerExit;
        }

        private void _OnBarrierTriggerExit(GameObject o, Collider other)
        {
            var cursor = other.GetComponentInParent<Cursor>();

            if (cursor != null)
            {
                Vector3 exitDir = (cursor.Position - _barrierTrigger.transform.position).normalized;

                // use dot prod to determine if entered or exit
                if (Vector3.Dot(exitDir, _barrierTrigger.transform.forward) > 0)
                {
                    Debug.Log("Cursor Entered");
                    onCursorEnteredEvent?.Invoke();
                }
                else
                {
                    Debug.Log("Cursor Exited");
                    onCursorExitedEvent?.Invoke();
                }
            }
        }
    }
}
