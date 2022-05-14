using UnityEngine;

namespace Cirrus.Unity.Objects
{
	public static class TransformUtils
	{
		public static void SwapPosition(this Transform first, Transform second)
		{
			Vector3 firstPos = first.position;
			Vector3 secondPos = second.position;
			first.position = secondPos;
			second.position = firstPos;
		}

		public static void SwapPosition(this RectTransform first, RectTransform second)
		{
			Vector3 firstPos = first.position;
			Vector3 secondPos = second.position;
			first.position = secondPos;
			second.position = firstPos;
		}

		public static void SwapSibling(this Transform first, Transform second)
		{
			int firstIdx = first.GetSiblingIndex();
			int secondIdx = second.GetSiblingIndex();
			first.SetSiblingIndex(secondIdx);
			second.SetSiblingIndex(firstIdx);
		}

		public static void Swap(this Transform first, Transform second)
		{
			int firstIdx = first.GetSiblingIndex();
			int secondIdx = second.GetSiblingIndex();

			Transform firstParent = first.parent;
			Transform secondParent = second.parent;

			first.SetParent(secondParent);
			first.SetParent(firstParent);

			first.SetSiblingIndex(secondIdx);
			second.SetSiblingIndex(firstIdx);
			
		}
	}
}
