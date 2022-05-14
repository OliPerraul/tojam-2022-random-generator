using Cirrus.Unity.Objects;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cirrus.Unity.UI
{
	public static class EditorUIElementsUtils
	{
		public static void ClearItems(this ToolbarBreadcrumbs breadcrumbs)
		{
			while (breadcrumbs.childCount > 0)
				breadcrumbs.PopItem();

		}

	}
}
