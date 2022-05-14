using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cirrus.UI
{
	public static class UiUtils
	{
		public static bool IsUIElementActive
		{
			get
			{
				var eventData = new PointerEventData(EventSystem.current);
				eventData.position = Input.mousePosition;
				var results = new List<RaycastResult>();
				EventSystem.current.RaycastAll(eventData, results);
				return results.Count > 0;
			}
		}
	}
}