using UnityEngine;

namespace Cirrus.Unity.Numerics
{
	public static class VectorIntSwizzle
	{
		#region int
		#region int->Vector2Int
		/// <summary>
		/// Extracts a Vector2Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int _X(this int self
						, int inj0
						)
		{
			return new Vector2Int(
				inj0, self
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _X(this int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self;
		}

		/// <summary>
		/// Extracts a Vector2Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int X_(this int self
						, int inj0
						)
		{
			return new Vector2Int(
				self, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void X_(this int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = self;
			other.y = inj0;
		}

		/// <summary>
		/// Extracts a Vector2Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int XX(this int self
		)
		{
			return new Vector2Int(
				self, self
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XX(this int self, ref Vector2Int other
		)
		{

			other.x = self;
			other.y = self;
		}

		#endregion
		#region int->Vector3Int
		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int __X(this int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, inj1, self
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __X(this int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = inj1;
			other.z = self;
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _X_(this int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, self, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _X_(this int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = self;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _XX(this int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self, self
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _XX(this int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self;
			other.z = self;
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int X__(this int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				self, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void X__(this int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = self;
			other.y = inj0;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int X_X(this int self
						, int inj0
						)
		{
			return new Vector3Int(
				self, inj0, self
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void X_X(this int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self;
			other.y = inj0;
			other.z = self;
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int XX_(this int self
						, int inj0
						)
		{
			return new Vector3Int(
				self, self, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void XX_(this int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self;
			other.y = self;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XXX(this int self
		)
		{
			return new Vector3Int(
				self, self, self
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XXX(this int self, ref Vector3Int other
		)
		{

			other.x = self;
			other.y = self;
			other.z = self;
		}

		#endregion		
		#endregion
		#region Vector2Int
		#region Vector2Int->Vector2Int
		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int _X(this Vector2Int self
						, int inj0
						)
		{
			return new Vector2Int(
				inj0, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _X(this Vector2Int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.x;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int _Y(this Vector2Int self
						, int inj0
						)
		{
			return new Vector2Int(
				inj0, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _Y(this Vector2Int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.y;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int X_(this Vector2Int self
						, int inj0
						)
		{
			return new Vector2Int(
				self.x, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void X_(this Vector2Int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = inj0;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int XX(this Vector2Int self
		)
		{
			return new Vector2Int(
				self.x, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XX(this Vector2Int self, ref Vector2Int other
		)
		{

			other.x = self.x;
			other.y = self.x;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int XY(this Vector2Int self
		)
		{
			return new Vector2Int(
				self.x, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XY(this Vector2Int self, ref Vector2Int other
		)
		{

			other.x = self.x;
			other.y = self.y;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int Y_(this Vector2Int self
						, int inj0
						)
		{
			return new Vector2Int(
				self.y, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Y_(this Vector2Int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = inj0;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int YX(this Vector2Int self
		)
		{
			return new Vector2Int(
				self.y, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YX(this Vector2Int self, ref Vector2Int other
		)
		{

			other.x = self.y;
			other.y = self.x;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int YY(this Vector2Int self
		)
		{
			return new Vector2Int(
				self.y, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YY(this Vector2Int self, ref Vector2Int other
		)
		{

			other.x = self.y;
			other.y = self.y;
		}

		#endregion
		#region Vector2Int->Vector3Int
		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int __X(this Vector2Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, inj1, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __X(this Vector2Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = inj1;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int __Y(this Vector2Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, inj1, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __Y(this Vector2Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = inj1;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _X_(this Vector2Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, self.x, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _X_(this Vector2Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = self.x;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _XX(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.x, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _XX(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.x;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _XY(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.x, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _XY(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.x;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _Y_(this Vector2Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, self.y, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _Y_(this Vector2Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = self.y;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _YX(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.y, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _YX(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.y;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _YY(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.y, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _YY(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.y;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int X__(this Vector2Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				self.x, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void X__(this Vector2Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = self.x;
			other.y = inj0;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int X_X(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.x, inj0, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void X_X(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = inj0;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int X_Y(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.x, inj0, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void X_Y(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = inj0;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int XX_(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.x, self.x, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void XX_(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = self.x;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XXX(this Vector2Int self
		)
		{
			return new Vector3Int(
				self.x, self.x, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XXX(this Vector2Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.x;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XXY(this Vector2Int self
		)
		{
			return new Vector3Int(
				self.x, self.x, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XXY(this Vector2Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.x;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int XY_(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.x, self.y, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void XY_(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = self.y;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XYX(this Vector2Int self
		)
		{
			return new Vector3Int(
				self.x, self.y, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XYX(this Vector2Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.y;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XYY(this Vector2Int self
		)
		{
			return new Vector3Int(
				self.x, self.y, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XYY(this Vector2Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.y;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Y__(this Vector2Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				self.y, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void Y__(this Vector2Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = self.y;
			other.y = inj0;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Y_X(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.y, inj0, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Y_X(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = inj0;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Y_Y(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.y, inj0, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Y_Y(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = inj0;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int YX_(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.y, self.x, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void YX_(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = self.x;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YXX(this Vector2Int self
		)
		{
			return new Vector3Int(
				self.y, self.x, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YXX(this Vector2Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.x;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YXY(this Vector2Int self
		)
		{
			return new Vector3Int(
				self.y, self.x, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YXY(this Vector2Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.x;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int YY_(this Vector2Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.y, self.y, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void YY_(this Vector2Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = self.y;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YYX(this Vector2Int self
		)
		{
			return new Vector3Int(
				self.y, self.y, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YYX(this Vector2Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.y;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YYY(this Vector2Int self
		)
		{
			return new Vector3Int(
				self.y, self.y, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector2Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YYY(this Vector2Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.y;
			other.z = self.y;
		}

		#endregion		
		#endregion
		#region Vector3Int
		#region Vector3Int->Vector2Int
		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int _X(this Vector3Int self
						, int inj0
						)
		{
			return new Vector2Int(
				inj0, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _X(this Vector3Int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.x;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int _Y(this Vector3Int self
						, int inj0
						)
		{
			return new Vector2Int(
				inj0, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _Y(this Vector3Int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.y;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int _Z(this Vector3Int self
						, int inj0
						)
		{
			return new Vector2Int(
				inj0, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _Z(this Vector3Int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.z;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int X_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector2Int(
				self.x, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void X_(this Vector3Int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = inj0;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int XX(this Vector3Int self
		)
		{
			return new Vector2Int(
				self.x, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XX(this Vector3Int self, ref Vector2Int other
		)
		{

			other.x = self.x;
			other.y = self.x;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int XY(this Vector3Int self
		)
		{
			return new Vector2Int(
				self.x, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XY(this Vector3Int self, ref Vector2Int other
		)
		{

			other.x = self.x;
			other.y = self.y;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int XZ(this Vector3Int self
		)
		{
			return new Vector2Int(
				self.x, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XZ(this Vector3Int self, ref Vector2Int other
		)
		{

			other.x = self.x;
			other.y = self.z;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int Y_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector2Int(
				self.y, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Y_(this Vector3Int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = inj0;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int YX(this Vector3Int self
		)
		{
			return new Vector2Int(
				self.y, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YX(this Vector3Int self, ref Vector2Int other
		)
		{

			other.x = self.y;
			other.y = self.x;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int YY(this Vector3Int self
		)
		{
			return new Vector2Int(
				self.y, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YY(this Vector3Int self, ref Vector2Int other
		)
		{

			other.x = self.y;
			other.y = self.y;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int YZ(this Vector3Int self
		)
		{
			return new Vector2Int(
				self.y, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YZ(this Vector3Int self, ref Vector2Int other
		)
		{

			other.x = self.y;
			other.y = self.z;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector2Int Z_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector2Int(
				self.z, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Z_(this Vector3Int self, ref Vector2Int other
		, int inj0
		)
		{

			other.x = self.z;
			other.y = inj0;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int ZX(this Vector3Int self
		)
		{
			return new Vector2Int(
				self.z, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZX(this Vector3Int self, ref Vector2Int other
		)
		{

			other.x = self.z;
			other.y = self.x;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int ZY(this Vector3Int self
		)
		{
			return new Vector2Int(
				self.z, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZY(this Vector3Int self, ref Vector2Int other
		)
		{

			other.x = self.z;
			other.y = self.y;
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector2Int ZZ(this Vector3Int self
		)
		{
			return new Vector2Int(
				self.z, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector2Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZZ(this Vector3Int self, ref Vector2Int other
		)
		{

			other.x = self.z;
			other.y = self.z;
		}

		#endregion
		#region Vector3Int->Vector3Int
		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int __X(this Vector3Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, inj1, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __X(this Vector3Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = inj1;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int __Y(this Vector3Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, inj1, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __Y(this Vector3Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = inj1;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int __Z(this Vector3Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, inj1, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __Z(this Vector3Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = inj1;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _X_(this Vector3Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, self.x, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _X_(this Vector3Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = self.x;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _XX(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.x, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _XX(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.x;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _XY(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.x, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _XY(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.x;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _XZ(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.x, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _XZ(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.x;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _Y_(this Vector3Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, self.y, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _Y_(this Vector3Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = self.y;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _YX(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.y, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _YX(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.y;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _YY(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.y, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _YY(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.y;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _YZ(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.y, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _YZ(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.y;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _Z_(this Vector3Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				inj0, self.z, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _Z_(this Vector3Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = inj0;
			other.y = self.z;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _ZX(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.z, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ZX(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.z;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _ZY(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.z, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ZY(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.z;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int _ZZ(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				inj0, self.z, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ZZ(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = inj0;
			other.y = self.z;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int X__(this Vector3Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				self.x, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void X__(this Vector3Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = self.x;
			other.y = inj0;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int X_X(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.x, inj0, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void X_X(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = inj0;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int X_Y(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.x, inj0, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void X_Y(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = inj0;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int X_Z(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.x, inj0, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void X_Z(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = inj0;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int XX_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.x, self.x, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void XX_(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = self.x;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XXX(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.x, self.x, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XXX(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.x;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XXY(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.x, self.x, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XXY(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.x;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XXZ(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.x, self.x, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XXZ(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.x;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int XY_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.x, self.y, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void XY_(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = self.y;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XYX(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.x, self.y, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XYX(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.y;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XYY(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.x, self.y, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XYY(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.y;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XYZ(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.x, self.y, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XYZ(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.y;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int XZ_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.x, self.z, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void XZ_(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.x;
			other.y = self.z;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XZX(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.x, self.z, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XZX(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.z;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XZY(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.x, self.z, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XZY(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.z;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int XZZ(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.x, self.z, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void XZZ(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.x;
			other.y = self.z;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Y__(this Vector3Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				self.y, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void Y__(this Vector3Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = self.y;
			other.y = inj0;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Y_X(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.y, inj0, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Y_X(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = inj0;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Y_Y(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.y, inj0, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Y_Y(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = inj0;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Y_Z(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.y, inj0, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Y_Z(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = inj0;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int YX_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.y, self.x, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void YX_(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = self.x;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YXX(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.y, self.x, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YXX(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.x;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YXY(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.y, self.x, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YXY(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.x;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YXZ(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.y, self.x, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YXZ(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.x;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int YY_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.y, self.y, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void YY_(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = self.y;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YYX(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.y, self.y, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YYX(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.y;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YYY(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.y, self.y, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YYY(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.y;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YYZ(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.y, self.y, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YYZ(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.y;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int YZ_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.y, self.z, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void YZ_(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.y;
			other.y = self.z;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YZX(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.y, self.z, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YZX(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.z;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YZY(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.y, self.z, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YZY(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.z;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int YZZ(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.y, self.z, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void YZZ(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.y;
			other.y = self.z;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Z__(this Vector3Int self
						, int inj0
								, int inj1
						)
		{
			return new Vector3Int(
				self.z, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void Z__(this Vector3Int self, ref Vector3Int other
		, int inj0
				, int inj1
		)
		{

			other.x = self.z;
			other.y = inj0;
			other.z = inj1;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Z_X(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.z, inj0, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Z_X(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.z;
			other.y = inj0;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Z_Y(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.z, inj0, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Z_Y(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.z;
			other.y = inj0;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int Z_Z(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.z, inj0, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void Z_Z(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.z;
			other.y = inj0;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int ZX_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.z, self.x, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ZX_(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.z;
			other.y = self.x;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int ZXX(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.z, self.x, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZXX(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.z;
			other.y = self.x;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int ZXY(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.z, self.x, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZXY(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.z;
			other.y = self.x;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int ZXZ(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.z, self.x, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZXZ(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.z;
			other.y = self.x;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int ZY_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.z, self.y, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ZY_(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.z;
			other.y = self.y;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int ZYX(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.z, self.y, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZYX(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.z;
			other.y = self.y;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int ZYY(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.z, self.y, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZYY(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.z;
			other.y = self.y;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int ZYZ(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.z, self.y, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZYZ(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.z;
			other.y = self.y;
			other.z = self.z;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Vector3Int ZZ_(this Vector3Int self
						, int inj0
						)
		{
			return new Vector3Int(
				self.z, self.z, inj0
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ZZ_(this Vector3Int self, ref Vector3Int other
		, int inj0
		)
		{

			other.x = self.z;
			other.y = self.z;
			other.z = inj0;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int ZZX(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.z, self.z, self.x
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZZX(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.z;
			other.y = self.z;
			other.z = self.x;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int ZZY(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.z, self.z, self.y
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZZY(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.z;
			other.y = self.z;
			other.z = self.y;
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Vector3Int ZZZ(this Vector3Int self
		)
		{
			return new Vector3Int(
				self.z, self.z, self.z
			);
		}

		/// <summary>
		/// Extracts a Vector3Int from a Vector3Int using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ZZZ(this Vector3Int self, ref Vector3Int other
		)
		{

			other.x = self.z;
			other.y = self.z;
			other.z = self.z;
		}

		#endregion

		#endregion
	
	}
}