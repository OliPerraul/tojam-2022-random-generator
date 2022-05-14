using Cirrus.Events;
using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Tojam2022
{
	public static class TimerUtils
	{
		public static void ResetHelper(this Timer timer, Action callback, bool inactiveOnly=true, float limit=-1, bool start=true)
		{
			if (timer == null)
			{
				callback();
			}
			else if (!inactiveOnly || !timer.IsActive)
			{
				timer.Reset(callback, limit, start);
			}
		}
	}
}
