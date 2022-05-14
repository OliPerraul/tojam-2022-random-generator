using UnityEngine;
namespace Cirrus.Unity.Graphics
{
	public class ViewFrustrum
	{
		public float Width;
		public float Height;
		public float Radius;

		public Vector3 NearBottomLeft { get; set; }
		public Vector3 NearTopLeft { get; set; }

		public Vector3 NearTopRight { get; set; }
		public Vector3 NearBottomRight { get; set; }
		public Vector3 FarBottomLeft { get; set; }
		public Vector3 FarTopLeft { get; set; }

		public Vector3 FarTopRight { get; set; }
		public Vector3 FarBottomRight { get; set; }

		public Vector3 Get(int i)
		{
			switch(i)
			{
				case 0: return NearBottomLeft;
				case 1: return NearTopLeft;
				case 2: return NearTopRight;
				case 3: return NearBottomRight;
				case 4: return FarBottomLeft;
				case 5: return FarTopLeft;
				case 6: return FarTopRight;
				case 7: return FarBottomRight;
				default: return FarBottomRight;
			}
		}
	}

	public static class CameraUtils
	{
		public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
		{
			Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
			return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
		}

		public static ViewFrustrum CalculateViewFrustum(Camera cam)
		{

			Vector3[] near = new Vector3[4];
			cam.CalculateFrustumCorners(
				new Rect(0, 0, 1, 1),
				cam.nearClipPlane,
				Camera.MonoOrStereoscopicEye.Mono,
				near);

			Vector3[] far = new Vector3[4];
			cam.CalculateFrustumCorners(
				new Rect(0, 0, 1, 1),
				cam.farClipPlane,
				Camera.MonoOrStereoscopicEye.Mono,
				far);

			return new ViewFrustrum()
			{
				NearBottomLeft = cam.transform.TransformPoint(near[0]),
				NearTopLeft = cam.transform.TransformPoint(near[1]),
				NearTopRight = cam.transform.TransformPoint(near[2]),
				NearBottomRight = cam.transform.TransformPoint(near[3]),

				FarBottomLeft = cam.transform.TransformPoint(far[0]),
				FarTopLeft = cam.transform.TransformPoint(far[1]),
				FarTopRight = cam.transform.TransformPoint(far[2]),
				FarBottomRight = cam.transform.TransformPoint(far[3])
			};
		}

		public static void ArrowGizmo(Vector3 pos, Vector3 direction, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20.0f)
		{
			Gizmos.DrawRay(pos, direction);

			Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * new Vector3(0, 0, 1);
			Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * new Vector3(0, 0, 1);
			Gizmos.DrawRay(pos + direction, right * arrowHeadLength);
			Gizmos.DrawRay(pos + direction, left * arrowHeadLength);
		}

		public static void ArrowGizmo(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20.0f)
		{
			Gizmos.color = color;
			Gizmos.DrawRay(pos, direction);

			Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * new Vector3(0, 0, 1);
			Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * new Vector3(0, 0, 1);
			Gizmos.DrawRay(pos + direction, right * arrowHeadLength);
			Gizmos.DrawRay(pos + direction, left * arrowHeadLength);
		}

		public static void ArrowDebug(Vector3 pos, Vector3 direction, float length = 1f, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20.0f)
		{
			Debug.DrawRay(pos, direction * length);

			Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * new Vector3(0, 0, 1);
			Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * new Vector3(0, 0, 1);
			Debug.DrawRay(pos + (direction * length), right * arrowHeadLength * length);
			Debug.DrawRay(pos + (direction * length), left * arrowHeadLength * length);
		}

		public static void ArrowDebug(Vector3 pos, Vector3 direction, Color color, float length = 1f, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20.0f)
		{
			Debug.DrawRay(pos, direction * length, color);

			Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * new Vector3(0, 0, 1);
			Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * new Vector3(0, 0, 1);
			Debug.DrawRay(pos + (direction * length), right * arrowHeadLength * length, color);
			Debug.DrawRay(pos + (direction * length), left * arrowHeadLength * length, color);
		}


		//public static void DrawDebugFrustum(Vector3[] viewFrustum)
		//{
		//	Color[] colors = new Color[] { Color.red, Color.green, Color.blue, Color.white, Color.cyan, Color.magenta, Color.yellow, Color.black };

		//	for(int i = 0; i < BottomLeftVector; i++)
		//	{
		//		// Cast lines clockwise around near clipping plane bounds
		//		Debug.DrawLine(viewFrustum[i], viewFrustum[(i + 1) % BottomLeftVector], colors[i]);
		//		Gizmos.DrawWireSphere(viewFrustum[i], 0.05f);

		//		// Cast rays clockwise out of near clipping plane bounds
		//		Debug.DrawRay(viewFrustum[i], viewFrustum[i + BottomLeftVector], colors[i + BottomLeftVector]);
		//	}
		//}


		//public static Vector3[] CalculateViewFrustum(Camera cam, out ViewFrustrum frustrum)
		//{
		//	//frustrum = new ViewFrustrum();
		//	//// Near clipping plane bounds
		//	//frustrum.Points[ViewFrustrum.BottomLeftIndex] = cam.ViewportToWorldPoint(new Vector3(0f, 0f, cam.nearClipPlane));
		//	//frustrum.Points[ViewFrustrum.TopLeftIndex] = cam.ViewportToWorldPoint(new Vector3(0f, 1f, cam.nearClipPlane));
		//	//frustrum.BottomRight = cam.ViewportToWorldPoint(new Vector3(1f, 0f, cam.nearClipPlane));
		//	//frustrum.TopRight = cam.ViewportToWorldPoint(new Vector3(1f, 1f, cam.nearClipPlane));

		//	//// Clipping planes: 0/left, 1/right, 2/bottom, 3/top, 4/near, 5/far
		//	//Plane[] planes = GeometryUtility.CalculateFrustumPlanes(cam);
		//	//frustrum.Points[BottomLeftVector] = Vector3.Cross(planes[0].normal, planes[2].normal);
		//	//frustrum.Points[TopLeftVector] = Vector3.Cross(planes[3].normal, planes[0].normal);
		//	//frustrum.Points[TopRightVector] = Vector3.Cross(planes[1].normal, planes[3].normal);
		//	//frustrum.Points[BottomRightVector] = Vector3.Cross(planes[2].normal, planes[1].normal);

		//	//frustrum.Width = (frustrum[BottomLeftPoint] - frustum[BottomRightPoint]).magnitude;
		//	//frustrum.Height = (frustum[TopLeftPoint] - frustum[BottomLeftPoint]).magnitude;

		//	//// Radius needed for sphere cast - distance from corner to center of viewport
		//	//dimensions.z = (frustum[BottomLeftPoint] - cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, cam.nearClipPlane))).magnitude;

		//	//return frustum;
		//}

	}

}