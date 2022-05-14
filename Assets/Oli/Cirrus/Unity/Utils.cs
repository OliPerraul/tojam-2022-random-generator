

using System;
using UnityEngine;

namespace Cirrus
{
	[Serializable]
	public enum ID : int
	{
		Unknown = -1,
		_0 = 0,
		_1 = 1,
		_2 = 2,
		_3 = 3,
		_4 = 4,
		_5 = 5,
		_6 = 6,
		_7 = 7,
		_8 = 8,
		_9 = 9,
		_10 = 10,
		_11 = 11,
		_12 = 12,
		_13 = 13,
		_14 = 14,
		_15 = 15,
		_16 = 16,
		_17 = 17,
		_18 = 18,
		_19 = 19,
		_20 = 20,
		_21 = 21,
		_22 = 22,
		_23 = 23,
		_24 = 24,
		_25 = 25,
		_26 = 26,
		_27 = 27,
		_28 = 28,
		_29 = 29,
		_30 = 30,
		_31 = 31,
	}

	[System.Serializable]
	public enum Flag
	{
		//All = 0xFFFFFFF,
		//None = 0,
		_0 = 1 << 0,
		_1 = 1 << 1,
		_2 = 1 << 2,
		_3 = 1 << 3,
		_4 = 1 << 4,
		_5 = 1 << 5,
		_6 = 1 << 6,
		_7 = 1 << 7,
		_8 = 1 << 8,
		_9 = 1 << 9,
		_10 = 1 << 10,
		_11 = 1 << 11,
		_12 = 1 << 12,
		_13 = 1 << 13,
		_14 = 1 << 14,
		_15 = 1 << 15,
		_16 = 1 << 16,
		_17 = 1 << 17,
		_18 = 1 << 18,
		_19 = 1 << 19,
		_20 = 1 << 20,
		_21 = 1 << 21,
		_22 = 1 << 22,
		_23 = 1 << 23,
		_24 = 1 << 24,
		_25 = 1 << 25,
		_26 = 1 << 26,
		_27 = 1 << 27,
		_28 = 1 << 28,
		_29 = 1 << 29,
		_30 = 1 << 30,
		_31 = 1 << 31,
	}


	public enum DataType
	{
		Double,
		Float,
		Int,
		Long,
		String,
		Char,
		Bool,
		Color,
		Vector,
		Object
	}

	public enum Trilean
	{
		Unknown = -1,
		False = 0,
		True = 1,
	}

	public struct PositionRotation
	{
		Vector3 Position;
		Quaternion Rotation;
	}
	public static class ComponentUtils
	{
		public static T AddComponent<T>(this Component comp) where T : Component
		{
			return comp.gameObject.AddComponent<T>();
		}

		public static int LayerFlag(this Component comp)
		{
			return 1 << comp.gameObject.layer;
		}

		public static void SetActive(this Component comp, bool enabled)
		{
			comp.gameObject.SetActive(enabled);
		}
	}
}