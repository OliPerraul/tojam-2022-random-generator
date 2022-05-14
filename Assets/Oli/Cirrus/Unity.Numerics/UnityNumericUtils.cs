using System;

using UnityEngine;

namespace Cirrus.Unity.Numerics
{
	public static class UnityNumericUtils
	{
		public static Range_ Range(float min, float max) => new Range_(min, max);

		public static Vector2Int ToVector2Int((int x, int y) xy) => new Vector2Int(xy.x, xy.y);

		public static Vector2Int ToPosition(this int i, int width) => new Vector2Int(i % width, i / width);
		public static int ToIndex(this Vector2Int pos, int width) => pos.x + width * pos.y;

		public static int ToIndex(this (int x, int y) pos, int width) => pos.x + width * pos.y;

		public static Vector3 CellToWorld3d(this Vector2Int cell, float cellSize) => CellToWorld3d(cell, new Vector2(cellSize, cellSize));
		public static Vector3 CellToWorld3d(this Vector2Int cell, Vector2 cellSize) => new Vector3(
			cell.x * cellSize.x,
			0,
			cell.y * cellSize.y);

		public static Vector3 CellToWorld3d(this (int x, int y) cell, float cellSize) => CellToWorld3d(cell, new Vector2(cellSize, cellSize));
		public static Vector3 CellToWorld3d(this (int x, int y) cell, Vector2 cellSize) => new Vector3(
			cell.x * cellSize.x,
			0,
			cell.y * cellSize.y);


		public static Vector2Int WorldToCell(this Vector3 pos, float cellSize) => WorldToCell(pos, new Vector3(cellSize, cellSize));
		public static Vector2Int WorldToCell(this Vector3 pos, Vector2 cellSize)
		{
			return new Vector2Int(
			Mathf.FloorToInt(pos.x / cellSize.x),
			Mathf.FloorToInt(pos.z / cellSize.y)
			);
		}

		public static Vector2Int WorldToCell(this Vector2 pos, float cellSize) => WorldToCell(pos, new Vector2(cellSize, cellSize));
		public static Vector2Int WorldToCell(this Vector2 pos, Vector2 cellSize)
		{
			return new Vector2Int(
			Mathf.FloorToInt(pos.x / cellSize.x),
			Mathf.FloorToInt(pos.y / cellSize.y)
			);
		}


		public static float RoundToDecimals(this float value, int decimals)
		{
			return Convert.ToSingle(Math.Round(value, decimals));
		}


		public static int Round(this float value)
		{
			return Convert.ToInt32(Math.Round(value, 0));
		}

		public static int Ceil(this float value)
		{
			return Convert.ToInt32(Math.Ceiling(value));
		}

		public static int Floor(this float value)
		{
			return Convert.ToInt32(Math.Floor(value));
		}

		public static float Evaluate(this Total total, Operation op)
		{
			total.Current = op.Evaluate(total.Current);
			return total.Current;
		}
	}
}
