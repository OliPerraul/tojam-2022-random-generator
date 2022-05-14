//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//using System;
//using System.Collections.Generic;
//using UnityEngine;
//using Random = UnityEngine.Random;
//using Cirrus.Collections;

//namespace Cirrus.Unity.Procedural
//{

//	public static partial class PoissonDiscSampling
//	{
//		private static bool _IsPointValid(
//			Vector3 newPoint,
//			float maxRadius,
//			Vector2 sampleRegionSize,
//			float cellSize,
//			List<Vector3> points,
//			int[,] grid)
//		{
//			if(
//				newPoint.x >= 0
//				&& newPoint.x < sampleRegionSize.x
//				&& newPoint.y >= 0
//				&& newPoint.y < sampleRegionSize.y
//				)
//			{
//				int cellX = (int)(newPoint.x / cellSize);
//				int cellY = (int)(newPoint.y / cellSize);

//				float radius = newPoint.z;
//				int searchSquares = Mathf.CeilToInt(maxRadius / cellSize);

//				int searchStartX = Mathf.Max(0, cellX - searchSquares);
//				int searchStartY = Mathf.Max(0, cellY - searchSquares);
//				int searchEndX = Mathf.Min(grid.GetLength(0) - 1, cellX + searchSquares);
//				int searchEndY = Mathf.Min(grid.GetLength(1) - 1, cellY + searchSquares);

//				for(int i = searchStartX; i <= searchEndX; i++)
//				{
//					for(int j = searchStartY; j <= searchEndY; j++)
//					{
//						int pointIndex = grid[i, j] - 1;
//						if(pointIndex != -1)
//						{
//							float sqrDist = (newPoint - points[pointIndex]).sqrMagnitude;
//							float effectiveRadius = Mathf.Max(radius, points[pointIndex].z);

//							if(sqrDist < effectiveRadius * effectiveRadius)
//							{
//								return false;
//							}
//						}
//					}
//				}
//				return true;
//			}

//			return false;
//		}

//		public static bool Init(
//			List<IPdsEntry> entries,
//			Vector2 regionSize,
//			out PdsResult result
//			)
//		{
//			result = new PdsResult();

//			// Find minimum radius actually used
//			// O(N^2) (more or less depending on num of interactions)
//			//  utilize a grid of the smallest possible radius size
//			float minRadius = Mathf.Infinity;
//			for(int i = 0; i < entries.Count; i++)
//			{
//				var interacts = entries[i].Interacts;
//				for(int j = 0; j < interacts.Length; j++)
//				{
//					var interaction = interacts[j];
//					for(int k = 0; k < entries.Count; k++)
//					{
//						if(i == k) continue;

//						if(
//							interaction.Flags.Overlaps(entries[k].Flags) ||
//							interaction.Metadata.Overlaps(entries[k].Metadata)
//							)
//						{
//							if(interaction.Radius < minRadius) minRadius = interaction.Radius;
//						}
//					}
//				}
//			}

//			result.CellSize = minRadius / Mathf.Sqrt(2);
//			result.Cells = new Vector2[Mathf.CeilToInt(regionSize.x / result.CellSize) * Mathf.CeilToInt(regionSize.y / result.CellSize)];
//			return true;
//		}

//			/// <summary>
//			/// 
//			/// </summary>
//			/// <param name="entries"></param>
//			/// <param name="regionSize">Region in which we want to generate our points.</param>
//			/// <param name="result"></param>
//			/// <returns></returns>
//		public static bool Process(
//			IPdsEntryResult result,
//			Vector2 regionSize,
//			int trials=30)
//		{
			

//			return true;
//		}
//	}
//}