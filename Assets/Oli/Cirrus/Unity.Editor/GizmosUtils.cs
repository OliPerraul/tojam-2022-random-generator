#if UNITY_EDITOR


using System;
using UnityEngine;

namespace Cirrus.Unity.Editor
{
	public class GizmosUtils
	{
		public static void DrawString(string text, Vector3 worldPos, Color? colour = null)
		{
			UnityEditor.Handles.BeginGUI();
			if(colour.HasValue) GUI.color = colour.Value;
			var view = UnityEditor.SceneView.currentDrawingSceneView;
			Vector3 screenPos = view.camera.WorldToScreenPoint(worldPos);
			Vector2 size = GUI.skin.label.CalcSize(new GUIContent(text));
			GUI.Label(new Rect(screenPos.x - (size.x / 2), -screenPos.y + view.position.height + 4, size.x, size.y), text);
			UnityEditor.Handles.EndGUI();
		}
	}

	public class ScopedGizmosColor : IDisposable
	{
		private Color _previousColor;

		public ScopedGizmosColor(Color color)
		{
			_previousColor = Gizmos.color;
			Gizmos.color = color;
		}

		public void Dispose()
		{
			Gizmos.color = _previousColor;
		}
	}

}

#endif