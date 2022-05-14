using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Unity.Threading
{

	public class CoroutineBarrier
	{
		public Action OnBarrierPassedHandler;

		public List<Func<bool>> participants = new List<Func<bool>>();

		private MonoBehaviour _behaviour;

		private Coroutine _coroutine;

		public CoroutineBarrier(
			MonoBehaviour behaviour,
			params Func<bool>[] participants)
		{

			_behaviour = behaviour;
			foreach(var part in participants) AddParticipant(part);

		}

		public void AddParticipant(Func<bool> participant)
		{
			participants.Add(participant);
		}

		public static void Wait(
			MonoBehaviour gameObject,
			Action ev = null,
			params Func<bool>[] participants)
		{
			var barrier = new CoroutineBarrier(gameObject, participants);
			barrier.OnBarrierPassedHandler += ev;
			barrier._coroutine = barrier._behaviour.StartCoroutine(barrier.WaitUntilCoroutine());
		}

		public IEnumerator WaitUntilCoroutine()
		{
			foreach(var part in participants) yield return new WaitUntil(part);

			OnBarrierPassedHandler?.Invoke();

			OnBarrierPassedHandler = null;
			participants.Clear();
			_behaviour = null;
			_coroutine = null;
			yield return null;
		}
	}
}