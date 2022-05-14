//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//using System;
//using System.Collections.Generic;
//using UnityEngine;
//using Random = UnityEngine.Random;
//using Cirrus.Objects;

//namespace Cirrus.Unity.Procedural
//{

//	public class PdsInteraction
//	{
//		public int Flags;
//		public HashSet<object> Metadata;
//		public float Radius;

//		public static implicit operator PdsInteraction[](PdsInteraction pt)
//		{
//			return new PdsInteraction[] { pt };
//		}
//	}

//	public interface IPdsEntryResult
//	{
//		Vector3 Position { get; set; }
//	}

//	public interface IPdsEntry
//	{
//		int Flags { get; set; }
//		HashSet<object> Metadata { get; set; }
//		// interaction profiles
//		/// <summary>
//		/// How does this point interact with other points
//		/// </summary>
//		PdsInteraction[] Interacts { get; set; }
//	}
	
//	public class PdsResult
//	{
//		public float CellSize;
//		public Vector2[] Cells;
//	}

//	public static partial class PoissonDiscSampling
//	{
//	}	
//}
