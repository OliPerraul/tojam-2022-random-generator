using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace Cirrus.Unity.Graphics
{
	public static partial class GraphicsUtils
	{
		private static Mesh m_quadMesh;

		static GraphicsUtils()
		{
			m_quadMesh = CreateQuad();
		}

#if UNITY_EDITOR
		public static void DrawBounds(
			Bounds bounds,
			Matrix4x4 transform,
			float width,
			Color color)
		{
			Vector3 v3Center = bounds.center;
			Vector3 v3Extents = bounds.extents;

			var v3FrontTopLeft = new Vector3(v3Center.x - v3Extents.x, v3Center.y + v3Extents.y, v3Center.z - v3Extents.z);  // Front top left corner
			var v3FrontTopRight = new Vector3(v3Center.x + v3Extents.x, v3Center.y + v3Extents.y, v3Center.z - v3Extents.z);  // Front top right corner
			var v3FrontBottomLeft = new Vector3(v3Center.x - v3Extents.x, v3Center.y - v3Extents.y, v3Center.z - v3Extents.z);  // Front bottom left corner
			var v3FrontBottomRight = new Vector3(v3Center.x + v3Extents.x, v3Center.y - v3Extents.y, v3Center.z - v3Extents.z);  // Front bottom right corner
			var v3BackTopLeft = new Vector3(v3Center.x - v3Extents.x, v3Center.y + v3Extents.y, v3Center.z + v3Extents.z);  // Back top left corner
			var v3BackTopRight = new Vector3(v3Center.x + v3Extents.x, v3Center.y + v3Extents.y, v3Center.z + v3Extents.z);  // Back top right corner
			var v3BackBottomLeft = new Vector3(v3Center.x - v3Extents.x, v3Center.y - v3Extents.y, v3Center.z + v3Extents.z);  // Back bottom left corner
			var v3BackBottomRight = new Vector3(v3Center.x + v3Extents.x, v3Center.y - v3Extents.y, v3Center.z + v3Extents.z);  // Back bottom right corner

			v3FrontTopLeft = transform.MultiplyPoint(v3FrontTopLeft);
			v3FrontTopRight = transform.MultiplyPoint(v3FrontTopRight);
			v3FrontBottomLeft = transform.MultiplyPoint(v3FrontBottomLeft);
			v3FrontBottomRight = transform.MultiplyPoint(v3FrontBottomRight);
			v3BackTopLeft = transform.MultiplyPoint(v3BackTopLeft);
			v3BackTopRight = transform.MultiplyPoint(v3BackTopRight);
			v3BackBottomLeft = transform.MultiplyPoint(v3BackBottomLeft);
			v3BackBottomRight = transform.MultiplyPoint(v3BackBottomRight);


			DrawLine(v3FrontTopLeft, v3FrontTopRight, width, color);
			DrawLine(v3FrontTopRight, v3FrontBottomRight, width, color);
			DrawLine(v3FrontBottomRight, v3FrontBottomLeft, width, color);
			DrawLine(v3FrontBottomLeft, v3FrontTopLeft, width, color);

			DrawLine(v3BackTopLeft, v3BackTopRight, width, color);
			DrawLine(v3BackTopRight, v3BackBottomRight, width, color);
			DrawLine(v3BackBottomRight, v3BackBottomLeft, width, color);
			DrawLine(v3BackBottomLeft, v3BackTopLeft, width, color);

			DrawLine(v3FrontTopLeft, v3BackTopLeft, width, color);
			DrawLine(v3FrontTopRight, v3BackTopRight, width, color);
			DrawLine(v3FrontBottomRight, v3BackBottomRight, width, color);
			DrawLine(v3FrontBottomLeft, v3BackBottomLeft, width, color);

		}

		public static void DrawLine(Vector3 p1, Vector3 p2, float width)
		{
			DrawLine(p1, p2, width, Color.white);
		}

		public static void DrawLine(Vector3 p1, Vector3 p2, float width, Color color)
		{
			Handles.color = color;

			int count = 1 + Mathf.CeilToInt(width); // how many lines are needed.
			if(count == 1)
			{
				Handles.DrawLine(p1, p2);
			}
			else
			{
				Camera c = SceneView.currentDrawingSceneView.camera;
				if(c == null)
				{
					Debug.LogError("Camera.current is null");
					return;
				}
				var scp1 = c.WorldToScreenPoint(p1);
				var scp2 = c.WorldToScreenPoint(p2);

				Vector3 v1 = (scp2 - scp1).normalized; // line direction
				Vector3 n = Vector3.Cross(v1, Vector3.forward); // normal vector

				for(int i = 0; i < count; i++)
				{
					Vector3 o = 0.99f * n * width * ((float)i / (count - 1) - 0.5f);
					Vector3 origin = c.ScreenToWorldPoint(scp1 + o);
					Vector3 destiny = c.ScreenToWorldPoint(scp2 + o);
					Handles.DrawLine(origin, destiny);
				}
			}
		}
#endif

		public static float GetScreenScale(Vector3 position, Camera camera)
		{
			float h = camera.pixelHeight;

			if(camera.orthographic)
			{

				return camera.orthographicSize * 2f / h * 90;
			}

			Transform transform = camera.transform;
			float distance = camera.stereoEnabled ?
				(position - transform.position).magnitude :
				Vector3.Dot(position - transform.position, transform.forward);

			float scale = 2.0f * distance * Mathf.Tan(camera.fieldOfView * 0.5f * Mathf.Deg2Rad);
			return scale / h * 90;
		}


		public static Mesh CreateCube(Vector3 pivot, float width = 1f, float length = 1f, float height = 0.025f)
		{
			Mesh mesh = new Mesh();

			Vector3[] vertexTemplate = new Vector3[] {
				new Vector3(-pivot.x * width, (1f-pivot.y) * height, -pivot.z * length), new Vector3(-pivot.x * width, (1f-pivot.y) * height, (1f-pivot.z) * length), new Vector3((1f - pivot.x) * width, (1f-pivot.y) * height, (1f-pivot.z) * length), new Vector3((1f - pivot.x) * width, (1f-pivot.y) * height, -pivot.z * length), // Top
				new Vector3(-pivot.x * width, -pivot.y * height, -pivot.z * length), new Vector3(-pivot.x * width, -pivot.y * height, (1f-pivot.z) * length), new Vector3((1f - pivot.x) * width, -pivot.y * height, (1f-pivot.z) * length), new Vector3((1f - pivot.x) * width, -pivot.y * height, -pivot.z * length) // Bottom
			};

			mesh.vertices = new Vector3[] {
				vertexTemplate[0], vertexTemplate[1], vertexTemplate[2], vertexTemplate[3], // Top
				vertexTemplate[4], vertexTemplate[5], vertexTemplate[6], vertexTemplate[7], // Bottom
				vertexTemplate[4], vertexTemplate[0], vertexTemplate[3], vertexTemplate[7], // Back
				vertexTemplate[7], vertexTemplate[3], vertexTemplate[2], vertexTemplate[6], // Left
				vertexTemplate[6], vertexTemplate[2], vertexTemplate[1], vertexTemplate[5], // Front 
				vertexTemplate[5], vertexTemplate[1], vertexTemplate[0], vertexTemplate[4], // Right
			};

			mesh.uv = new Vector2[] {
				new Vector2(0f, 1f), new Vector2(0f, 0f), new Vector2(1f, 0f), new Vector2(1f, 1f),
				new Vector2(0f, 1f), new Vector2(0f, 0f), new Vector2(1f, 0f), new Vector2(1f, 1f),
				new Vector2(0f, 0f), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(1f, 0f),
				new Vector2(0f, 0f), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(1f, 0f),
				new Vector2(0f, 0f), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(1f, 0f),
				new Vector2(0f, 0f), new Vector2(0f, 1f), new Vector2(1f, 1f), new Vector2(1f, 0f)
			};

			mesh.subMeshCount = 2;

			mesh.SetTriangles(new int[] {
				0, 1, 2, 2, 3, 0, // Top
				6, 5, 4, 4, 7, 6, // Bottom
			}, 0);

			mesh.SetTriangles(new int[] {
				8, 9, 10, 10, 11, 8, // Back
				12, 13, 14, 14, 15, 12, // Left
				16, 17, 18, 18, 19, 16, // Front
				20, 21, 22, 22, 23, 20  // Right
			}, 1);

			mesh.RecalculateNormals();
			mesh.RecalculateTangents();
			mesh.RecalculateBounds();

			return mesh;
		}



		public static Mesh CreateCube(float length = 1f, float width = 1f, float height = 1f)
		{
			Mesh mesh = new Mesh();
			mesh.name = "cube";

			//MeshFilter filter = gameObject.AddComponent<MeshFilter>();
			//Mesh mesh = filter.mesh;
			mesh.Clear();

			//float length = 1f;
			//float width = 1f;
			//float height = 1f;

			#region Vertices
			Vector3 p0 = new Vector3(-length * .5f, -width * .5f, height * .5f);
			Vector3 p1 = new Vector3(length * .5f, -width * .5f, height * .5f);
			Vector3 p2 = new Vector3(length * .5f, -width * .5f, -height * .5f);
			Vector3 p3 = new Vector3(-length * .5f, -width * .5f, -height * .5f);

			Vector3 p4 = new Vector3(-length * .5f, width * .5f, height * .5f);
			Vector3 p5 = new Vector3(length * .5f, width * .5f, height * .5f);
			Vector3 p6 = new Vector3(length * .5f, width * .5f, -height * .5f);
			Vector3 p7 = new Vector3(-length * .5f, width * .5f, -height * .5f);

			Vector3[] vertices = new Vector3[]
			{
				// Bottom
				p0, p1, p2, p3,
 
				// Left
				p7, p4, p0, p3,
 
				// Front
				p4, p5, p1, p0,
 
				// Back
				p6, p7, p3, p2,
 
				// Right
				p5, p6, p2, p1,
 
				// Top
				p7, p6, p5, p4
			};
			#endregion

			#region Normales
			Vector3 up = Vector3.up;
			Vector3 down = Vector3.down;
			Vector3 front = Vector3.forward;
			Vector3 back = Vector3.back;
			Vector3 left = Vector3.left;
			Vector3 right = Vector3.right;

			Vector3[] normales = new Vector3[]
			{
				// Bottom
				down, down, down, down,
 
				// Left
				left, left, left, left,
 
				// Front
				front, front, front, front,
 
				// Back
				back, back, back, back,
 
				// Right
				right, right, right, right,
 
				// Top
				up, up, up, up
			};
			#endregion

			#region UVs
			Vector2 _00 = new Vector2(0f, 0f);
			Vector2 _10 = new Vector2(1f, 0f);
			Vector2 _01 = new Vector2(0f, 1f);
			Vector2 _11 = new Vector2(1f, 1f);

			Vector2[] uvs = new Vector2[]
			{
				// Bottom
				_11, _01, _00, _10,
 
				// Left
				_11, _01, _00, _10,
 
				// Front
				_11, _01, _00, _10,
 
				// Back
				_11, _01, _00, _10,
 
				// Right
				_11, _01, _00, _10,
 
				// Top
				_11, _01, _00, _10,
			};
			#endregion

			#region Triangles
			int[] triangles = new int[]
			{
				// Bottom
				3, 1, 0,
				3, 2, 1,			
 
				// Left
				3 + 4 * 1, 1 + 4 * 1, 0 + 4 * 1,
				3 + 4 * 1, 2 + 4 * 1, 1 + 4 * 1,
 
				// Front
				3 + 4 * 2, 1 + 4 * 2, 0 + 4 * 2,
				3 + 4 * 2, 2 + 4 * 2, 1 + 4 * 2,
 
				// Back
				3 + 4 * 3, 1 + 4 * 3, 0 + 4 * 3,
				3 + 4 * 3, 2 + 4 * 3, 1 + 4 * 3,
 
				// Right
				3 + 4 * 4, 1 + 4 * 4, 0 + 4 * 4,
				3 + 4 * 4, 2 + 4 * 4, 1 + 4 * 4,
 
				// Top
				3 + 4 * 5, 1 + 4 * 5, 0 + 4 * 5,
				3 + 4 * 5, 2 + 4 * 5, 1 + 4 * 5,

			};
			#endregion

			mesh.vertices = vertices;
			mesh.normals = normales;
			mesh.uv = uvs;
			mesh.triangles = triangles;

			mesh.RecalculateBounds();
			mesh.Optimize();

			return mesh;
		}


		//public static Mesh CreateCube(Vector3 center, float scale, float cubeLength = 1, float cubeWidth = 1, float cubeHeight = 1)
		//{
		//	cubeHeight *= scale;
		//	cubeWidth *= scale;
		//	cubeLength *= scale;

		//	Vector3 vertice_0 = center + new Vector3(-cubeLength * .5f, -cubeWidth * .5f, cubeHeight * .5f);
		//	Vector3 vertice_1 = center + new Vector3(cubeLength * .5f, -cubeWidth * .5f, cubeHeight * .5f);
		//	Vector3 vertice_2 = center + new Vector3(cubeLength * .5f, -cubeWidth * .5f, -cubeHeight * .5f);
		//	Vector3 vertice_3 = center + new Vector3(-cubeLength * .5f, -cubeWidth * .5f, -cubeHeight * .5f);
		//	Vector3 vertice_4 = center + new Vector3(-cubeLength * .5f, cubeWidth * .5f, cubeHeight * .5f);
		//	Vector3 vertice_5 = center + new Vector3(cubeLength * .5f, cubeWidth * .5f, cubeHeight * .5f);
		//	Vector3 vertice_6 = center + new Vector3(cubeLength * .5f, cubeWidth * .5f, -cubeHeight * .5f);
		//	Vector3 vertice_7 = center + new Vector3(-cubeLength * .5f, cubeWidth * .5f, -cubeHeight * .5f);
		//	Vector3[] vertices = new[]
		//	{
		//		// Bottom Polygon
		//		vertice_0, vertice_1, vertice_2, vertice_3,
		//		// Left Polygon
		//		vertice_7, vertice_4, vertice_0, vertice_3,
		//		// Front Polygon
		//		vertice_4, vertice_5, vertice_1, vertice_0,
		//		// Back Polygon
		//		vertice_6, vertice_7, vertice_3, vertice_2,
		//		// Right Polygon
		//		vertice_5, vertice_6, vertice_2, vertice_1,
		//		// Top Polygon
		//		vertice_7, vertice_6, vertice_5, vertice_4
		//	};

		//	int[] triangles = new[]
		//	{
		//		// Cube Bottom Side Triangles
		//		3, 1, 0,
		//		3, 2, 1,	
		//		// Cube Left Side Triangles
		//		3 + 4 * 1, 1 + 4 * 1, 0 + 4 * 1,
		//		3 + 4 * 1, 2 + 4 * 1, 1 + 4 * 1,
		//		// Cube Front Side Triangles
		//		3 + 4 * 2, 1 + 4 * 2, 0 + 4 * 2,
		//		3 + 4 * 2, 2 + 4 * 2, 1 + 4 * 2,
		//		// Cube Back Side Triangles
		//		3 + 4 * 3, 1 + 4 * 3, 0 + 4 * 3,
		//		3 + 4 * 3, 2 + 4 * 3, 1 + 4 * 3,
		//		// Cube Rigth Side Triangles
		//		3 + 4 * 4, 1 + 4 * 4, 0 + 4 * 4,
		//		3 + 4 * 4, 2 + 4 * 4, 1 + 4 * 4,
		//		// Cube Top Side Triangles
		//		3 + 4 * 5, 1 + 4 * 5, 0 + 4 * 5,
		//		3 + 4 * 5, 2 + 4 * 5, 1 + 4 * 5,
		//	};

		//	//Color[] colors = new Color[vertices.Length];
		//	//for (int i = 0; i < colors.Length; ++i)
		//	//{
		//	//	colors[i] = color;
		//	//}

		//	Mesh cubeMesh = new Mesh();
		//	cubeMesh.name = "cube";
		//	cubeMesh.vertices = vertices;
		//	cubeMesh.triangles = triangles;
		//	//cubeMesh.colors = colors;
		//	cubeMesh.RecalculateNormals();
		//	return cubeMesh;
		//}

		public static Mesh CreateQuad(float quadWidth = 1, float quadHeight = 1)
		{
			Vector3 vertice_0 = new Vector3(-quadWidth * .5f, -quadHeight * .5f, 0);
			Vector3 vertice_1 = new Vector3(quadWidth * .5f, -quadHeight * .5f, 0);
			Vector3 vertice_2 = new Vector3(-quadWidth * .5f, quadHeight * .5f, 0);
			Vector3 vertice_3 = new Vector3(quadWidth * .5f, quadHeight * .5f, 0);

			Vector3[] vertices = new[]
			{
				vertice_2, vertice_3, vertice_1, vertice_0,
			};

			int[] triangles = new[]
			{
				// Cube Bottom Side Triangles
				3, 1, 0,
				3, 2, 1,
			};

			Vector2[] uvs =
			{
				new Vector2(1, 0),
				new Vector2(0, 0),
				new Vector2(0, 1),
				new Vector2(1, 1),
			};

			Mesh quadMesh = new Mesh();
			quadMesh.name = "quad";
			quadMesh.vertices = vertices;
			quadMesh.triangles = triangles;
			quadMesh.uv = uvs;
			quadMesh.RecalculateNormals();
			return quadMesh;
		}

		public static Mesh CreateWireQuad(float quadWidth = 1, float quadHeight = 1)
		{
			Vector3 vertice_0 = new Vector3(-quadWidth * .5f, -quadHeight * .5f, 0);
			Vector3 vertice_1 = new Vector3(quadWidth * .5f, -quadHeight * .5f, 0);
			Vector3 vertice_2 = new Vector3(quadWidth * .5f, quadHeight * .5f, 0);
			Vector3 vertice_3 = new Vector3(-quadWidth * .5f, quadHeight * .5f, 0);

			Vector3[] vertices = new[]
			{
				vertice_0, vertice_1, vertice_2, vertice_3
			};

			Mesh quadMesh = new Mesh();
			quadMesh.vertices = vertices;
			quadMesh.SetIndices(new[] { 0, 1, 1, 2, 2, 3, 3, 0 }, MeshTopology.Lines, 0);

			return quadMesh;
		}

		public static Mesh CreateWireCubeMesh()
		{
			Mesh mesh = new Mesh();
			mesh.vertices = new[]
			{
				new Vector3(-1, -1, -1),
				new Vector3(-1, -1,  1),
				new Vector3(-1,  1, -1),
				new Vector3(-1,  1,  1),
				new Vector3( 1, -1, -1),
				new Vector3( 1, -1,  1),
				new Vector3( 1,  1, -1),
				new Vector3( 1,  1,  1),
			};
			mesh.SetIndices(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 0, 2, 1, 3, 4, 6, 5, 7, 0, 4, 1, 5, 2, 6, 3, 7 }, MeshTopology.Lines, 0);
			return mesh;
		}

		public static Mesh CreateWireCircle(float radius = 1, int pointsCount = 64)
		{
			return CreateWireArc(Vector3.zero, radius, pointsCount, 0, Mathf.PI * 2);
		}

		public static Mesh CreateWireArc(Vector3 offset, float radius = 1, int pointsCount = 64, float fromAngle = 0, float toAngle = Mathf.PI * 2)
		{
			Vector3[] vertices = new Vector3[pointsCount + 1];

			List<int> indices = new List<int>();
			for(int i = 0; i < pointsCount; ++i)
			{
				indices.Add(i);
				indices.Add(i + 1);
			}

			float currentAngle = fromAngle;
			float deltaAngle = toAngle - fromAngle;
			float z = 0.0f;
			float x = Mathf.Cos(currentAngle) * radius;
			float y = Mathf.Sin(currentAngle) * radius;

			Vector3 prevPoint = new Vector3(x, y, z) + offset;
			for(int i = 0; i < pointsCount; i++)
			{
				vertices[i] = prevPoint;
				currentAngle += deltaAngle / pointsCount;
				x = Mathf.Cos(currentAngle) * radius;
				y = Mathf.Sin(currentAngle) * radius;
				Vector3 point = new Vector3(x, y, z) + offset;
				vertices[i + 1] = point;
				prevPoint = point;
			}

			Mesh mesh = new Mesh();
			mesh.vertices = vertices;
			mesh.SetIndices(indices.ToArray(), MeshTopology.Lines, 0);
			return mesh;
		}

		public static Mesh CreateWireCylinder(float radius = 1.0f, float length = 1.0f, int pointsCount = 8, float fromAngle = 0, float toAngle = Mathf.PI * 2)
		{
			Vector3[] vertices = new Vector3[pointsCount * 2];
			List<int> indices = new List<int>();
			for(int i = 0; i < vertices.Length; i += 2)
			{
				indices.Add(i);
				indices.Add(i + 1);
			}

			float currentAngle = fromAngle;
			float deltaAngle = toAngle - fromAngle;
			float z = 0.0f;

			for(int i = 0; i < vertices.Length; i += 2)
			{
				float x = radius * Mathf.Cos(currentAngle);
				float y = radius * Mathf.Sin(currentAngle);
				Vector3 point = new Vector3(x, y, z);
				Vector3 point2 = new Vector3(x, y, z) + Vector3.forward * length;
				vertices[i] = point;
				vertices[i + 1] = point2;
				currentAngle += deltaAngle / pointsCount;
			}

			Mesh mesh = new Mesh();
			mesh.vertices = vertices;
			mesh.SetIndices(indices.ToArray(), MeshTopology.Lines, 0);
			return mesh;
		}

		public static void DrawMesh(CommandBuffer commandBuffer, Mesh mesh, Matrix4x4 transform, Material material, MaterialPropertyBlock propertyBlock)
		{
			commandBuffer.DrawMesh(mesh, transform, material, 0, 0, propertyBlock);
		}

		public static Mesh CreateCone(Color color, float scale)
		{
			int segmentsCount = 12;
			float size = 1.0f / 5;
			size *= scale;

			Vector3[] vertices = new Vector3[segmentsCount * 3 + 1];
			int[] triangles = new int[segmentsCount * 6];
			Color[] colors = new Color[vertices.Length];
			for(int i = 0; i < colors.Length; ++i)
			{
				colors[i] = color;
			}

			float radius = size / 2.6f;
			float height = size;
			float deltaAngle = Mathf.PI * 2.0f / segmentsCount;

			float y = -height;

			vertices[vertices.Length - 1] = new Vector3(0, -height, 0);
			for(int i = 0; i < segmentsCount; i++)
			{
				float angle = i * deltaAngle;
				float x = Mathf.Cos(angle) * radius;
				float z = Mathf.Sin(angle) * radius;

				vertices[i] = new Vector3(x, y, z);
				vertices[segmentsCount + i] = new Vector3(0, 0.01f, 0);
				vertices[2 * segmentsCount + i] = vertices[i];
			}

			for(int i = 0; i < segmentsCount; i++)
			{
				triangles[i * 6] = i;
				triangles[i * 6 + 1] = segmentsCount + i;
				triangles[i * 6 + 2] = (i + 1) % segmentsCount;

				triangles[i * 6 + 3] = vertices.Length - 1;
				triangles[i * 6 + 4] = 2 * segmentsCount + i;
				triangles[i * 6 + 5] = 2 * segmentsCount + (i + 1) % segmentsCount;
			}

			Mesh cone = new Mesh();
			cone.name = "Cone";
			cone.vertices = vertices;
			cone.triangles = triangles;
			cone.colors = colors;

			return cone;
		}

		public static Mesh CreateSphere(float radius, int numSlices, int numStacks, Color color)
		{
			if(radius < 1e-4f || numSlices < 3 || numStacks < 2) return null;

			int numVertRows = numStacks + 1;
			int numVertsPerRow = numSlices + 1;
			int numVerts = numVertRows * numVertsPerRow;

			Vector3[] positions = new Vector3[numVerts];
			Vector3[] normals = new Vector3[numVerts];

			int vertexPtr = 0;

			float angleStep = 360.0f / (numVertsPerRow - 1);
			for(int vertRowIndex = 0; vertRowIndex < numVertRows; ++vertRowIndex)
			{
				float theta = Mathf.PI * (float)vertRowIndex / (numVertRows - 1);
				float cosTheta = Mathf.Cos(theta);
				float sinTheta = Mathf.Sin(theta);

				for(int vertIndex = 0; vertIndex < numVertsPerRow; ++vertIndex)
				{
					float centralAxisRotAngle = angleStep * vertIndex * Mathf.Deg2Rad;
					Vector3 rotatedAxis = Vector3.right * Mathf.Sin(centralAxisRotAngle) +
										  Vector3.forward * Mathf.Cos(centralAxisRotAngle);
					positions[vertexPtr] = rotatedAxis * sinTheta * radius + Vector3.up * cosTheta * radius;
					normals[vertexPtr] = Vector3.Normalize(positions[vertexPtr]);
					++vertexPtr;
				}
			}

			int indexPtr = 0;
			int numIndices = numSlices * numStacks * 6;
			int[] indices = new int[numIndices];
			for(int vertRowIndex = 0; vertRowIndex < numVertRows - 1; ++vertRowIndex)
			{
				for(int vertIndex = 0; vertIndex < numVertsPerRow - 1; ++vertIndex)
				{
					// Calculate the index of the first vertex inside the first triangle
					int baseIndex = vertRowIndex * numVertsPerRow + vertIndex;

					// First triangle
					indices[indexPtr++] = baseIndex;
					indices[indexPtr++] = baseIndex + numVertsPerRow;
					indices[indexPtr++] = baseIndex + numVertsPerRow + 1;

					// Second triangle
					indices[indexPtr++] = baseIndex + numVertsPerRow + 1;
					indices[indexPtr++] = baseIndex + 1;
					indices[indexPtr++] = baseIndex;
				}
			}

			Mesh mesh = new Mesh();
			mesh.vertices = positions;
			mesh.normals = normals;
			mesh.colors = Enumerable.Repeat(color, numVerts).ToArray();
			mesh.SetIndices(indices, MeshTopology.Triangles, 0);
			mesh.UploadMeshData(false);

			return mesh;
		}
	}
}
