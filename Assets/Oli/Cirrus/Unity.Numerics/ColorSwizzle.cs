using UnityEngine;

namespace Cirrus.Unity.Numerics
{
	public static class ColorSwizzle
	{
		
		#region Color->Color
		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color ___R(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, inj1, inj2, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void ___R(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = inj2;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color ___G(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, inj1, inj2, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void ___G(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = inj2;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color ___B(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, inj1, inj2, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void ___B(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = inj2;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color ___A(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, inj1, inj2, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void ___A(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = inj2;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color __R_(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, inj1, self.r, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void __R_(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.r;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __RR(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __RR(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __RG(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __RG(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __RB(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __RB(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __RA(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __RA(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color __G_(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, inj1, self.g, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void __G_(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.g;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __GR(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __GR(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __GG(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __GG(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __GB(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __GB(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __GA(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __GA(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color __B_(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, inj1, self.b, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void __B_(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.b;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __BR(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __BR(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __BG(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __BG(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __BB(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __BB(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __BA(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __BA(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color __A_(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, inj1, self.a, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void __A_(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.a;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __AR(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __AR(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __AG(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __AG(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __AB(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __AB(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color __AA(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, inj1, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void __AA(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = inj1;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color _R__(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, self.r, inj1, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void _R__(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = inj1;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _R_R(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.r, inj1, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _R_R(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = inj1;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _R_G(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.r, inj1, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _R_G(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = inj1;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _R_B(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.r, inj1, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _R_B(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = inj1;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _R_A(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.r, inj1, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _R_A(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = inj1;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RR_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.r, self.r, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _RR_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.r;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RRR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RRR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RRG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RRG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RRB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RRB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RRA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RRA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RG_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.r, self.g, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _RG_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.g;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RGR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RGR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RGG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RGG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RGB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RGB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RGA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RGA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RB_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.r, self.b, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _RB_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.b;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RBR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RBR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RBG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RBG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RBB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RBB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RBA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RBA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RA_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.r, self.a, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _RA_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.a;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RAR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RAR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RAG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RAG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RAB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RAB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _RAA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.r, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _RAA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.r;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color _G__(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, self.g, inj1, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void _G__(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = inj1;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _G_R(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.g, inj1, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _G_R(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = inj1;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _G_G(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.g, inj1, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _G_G(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = inj1;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _G_B(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.g, inj1, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _G_B(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = inj1;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _G_A(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.g, inj1, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _G_A(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = inj1;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GR_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.g, self.r, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _GR_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.r;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GRR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GRR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GRG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GRG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GRB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GRB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GRA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GRA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GG_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.g, self.g, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _GG_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.g;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GGR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GGR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GGG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GGG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GGB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GGB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GGA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GGA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GB_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.g, self.b, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _GB_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.b;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GBR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GBR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GBG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GBG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GBB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GBB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GBA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GBA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GA_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.g, self.a, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _GA_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.a;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GAR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GAR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GAG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GAG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GAB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GAB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _GAA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.g, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _GAA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.g;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color _B__(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, self.b, inj1, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void _B__(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = inj1;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _B_R(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.b, inj1, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _B_R(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = inj1;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _B_G(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.b, inj1, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _B_G(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = inj1;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _B_B(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.b, inj1, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _B_B(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = inj1;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _B_A(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.b, inj1, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _B_A(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = inj1;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BR_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.b, self.r, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _BR_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.r;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BRR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BRR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BRG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BRG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BRB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BRB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BRA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BRA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BG_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.b, self.g, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _BG_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.g;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BGR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BGR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BGG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BGG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BGB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BGB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BGA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BGA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BB_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.b, self.b, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _BB_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.b;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BBR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BBR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BBG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BBG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BBB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BBB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BBA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BBA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BA_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.b, self.a, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _BA_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.a;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BAR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BAR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BAG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BAG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BAB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BAB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _BAA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.b, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _BAA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.b;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color _A__(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				inj0, self.a, inj1, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void _A__(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = inj1;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _A_R(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.a, inj1, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _A_R(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = inj1;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _A_G(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.a, inj1, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _A_G(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = inj1;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _A_B(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.a, inj1, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _A_B(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = inj1;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _A_A(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.a, inj1, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _A_A(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = inj1;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AR_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.a, self.r, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _AR_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.r;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _ARR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ARR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _ARG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ARG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _ARB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ARB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _ARA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ARA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AG_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.a, self.g, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _AG_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.g;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AGR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _AGR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AGG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _AGG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AGB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _AGB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AGA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _AGA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AB_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.a, self.b, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _AB_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.b;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _ABR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ABR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _ABG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ABG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _ABB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ABB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _ABA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _ABA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AA_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				inj0, self.a, self.a, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void _AA_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.a;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AAR(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _AAR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AAG(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _AAG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AAB(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _AAB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color _AAA(this Color self
						, float inj0
						)
		{
			return new Color(
				inj0, self.a, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void _AAA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = inj0;
			other.g = self.a;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color R___(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				self.r, inj0, inj1, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void R___(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = inj1;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color R__R(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, inj0, inj1, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void R__R(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = inj1;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color R__G(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, inj0, inj1, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void R__G(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = inj1;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color R__B(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, inj0, inj1, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void R__B(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = inj1;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color R__A(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, inj0, inj1, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void R__A(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = inj1;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_R_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, inj0, self.r, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void R_R_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.r;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_RR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_RR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_RG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_RG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_RB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_RB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_RA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_RA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_G_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, inj0, self.g, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void R_G_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.g;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_GR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_GR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_GG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_GG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_GB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_GB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_GA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_GA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_B_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, inj0, self.b, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void R_B_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.b;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_BR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_BR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_BG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_BG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_BB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_BB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_BA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_BA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_A_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, inj0, self.a, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void R_A_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.a;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_AR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_AR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_AG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_AG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_AB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_AB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color R_AA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, inj0, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void R_AA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = inj0;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color RR__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, self.r, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void RR__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RR_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.r, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RR_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RR_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.r, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RR_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RR_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.r, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RR_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RR_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.r, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RR_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RRR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.r, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RRR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRRR(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRRR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRRG(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRRG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRRB(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRRB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRRA(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRRA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RRG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.r, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RRG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRGR(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRGR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRGG(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRGG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRGB(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRGB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRGA(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRGA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RRB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.r, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RRB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRBR(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRBR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRBG(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRBG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRBB(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRBB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRBA(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRBA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RRA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.r, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RRA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRAR(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRAR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRAG(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRAG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRAB(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRAB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RRAA(this Color self
		)
		{
			return new Color(
				self.r, self.r, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RRAA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.r;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color RG__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, self.g, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void RG__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RG_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.g, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RG_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RG_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.g, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RG_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RG_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.g, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RG_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RG_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.g, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RG_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RGR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.g, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RGR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGRR(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGRR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGRG(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGRG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGRB(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGRB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGRA(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGRA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RGG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.g, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RGG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGGR(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGGR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGGG(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGGG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGGB(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGGB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGGA(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGGA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RGB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.g, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RGB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGBR(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGBR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGBG(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGBG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGBB(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGBB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGBA(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGBA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RGA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.g, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RGA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGAR(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGAR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGAG(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGAG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGAB(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGAB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RGAA(this Color self
		)
		{
			return new Color(
				self.r, self.g, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RGAA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.g;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color RB__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, self.b, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void RB__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RB_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.b, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RB_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RB_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.b, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RB_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RB_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.b, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RB_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RB_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.b, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RB_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RBR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.b, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RBR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBRR(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBRR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBRG(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBRG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBRB(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBRB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBRA(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBRA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RBG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.b, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RBG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBGR(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBGR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBGG(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBGG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBGB(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBGB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBGA(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBGA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RBB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.b, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RBB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBBR(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBBR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBBG(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBBG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBBB(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBBB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBBA(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBBA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RBA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.b, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RBA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBAR(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBAR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBAG(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBAG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBAB(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBAB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RBAA(this Color self
		)
		{
			return new Color(
				self.r, self.b, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RBAA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.b;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color RA__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.r, self.a, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void RA__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RA_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.a, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RA_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RA_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.a, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RA_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RA_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.a, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RA_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RA_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.a, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RA_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RAR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.a, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RAR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RARR(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RARR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RARG(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RARG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RARB(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RARB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RARA(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RARA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RAG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.a, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RAG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RAGR(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RAGR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RAGG(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RAGG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RAGB(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RAGB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RAGA(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RAGA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RAB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.a, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RAB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RABR(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RABR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RABG(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RABG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RABB(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RABB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RABA(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RABA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color RAA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.r, self.a, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void RAA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RAAR(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RAAR(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RAAG(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RAAG(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RAAB(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RAAB(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color RAAA(this Color self
		)
		{
			return new Color(
				self.r, self.a, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void RAAA(this Color self, ref Color other
		)
		{

			other.r = self.r;
			other.g = self.a;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color G___(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				self.g, inj0, inj1, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void G___(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = inj1;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color G__R(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, inj0, inj1, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void G__R(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = inj1;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color G__G(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, inj0, inj1, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void G__G(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = inj1;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color G__B(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, inj0, inj1, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void G__B(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = inj1;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color G__A(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, inj0, inj1, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void G__A(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = inj1;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_R_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, inj0, self.r, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void G_R_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.r;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_RR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_RR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_RG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_RG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_RB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_RB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_RA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_RA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_G_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, inj0, self.g, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void G_G_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.g;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_GR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_GR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_GG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_GG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_GB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_GB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_GA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_GA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_B_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, inj0, self.b, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void G_B_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.b;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_BR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_BR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_BG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_BG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_BB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_BB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_BA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_BA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_A_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, inj0, self.a, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void G_A_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.a;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_AR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_AR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_AG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_AG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_AB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_AB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color G_AA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, inj0, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void G_AA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = inj0;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color GR__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, self.r, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void GR__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GR_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.r, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GR_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GR_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.r, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GR_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GR_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.r, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GR_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GR_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.r, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GR_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GRR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.r, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GRR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRRR(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRRR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRRG(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRRG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRRB(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRRB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRRA(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRRA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GRG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.r, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GRG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRGR(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRGR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRGG(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRGG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRGB(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRGB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRGA(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRGA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GRB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.r, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GRB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRBR(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRBR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRBG(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRBG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRBB(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRBB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRBA(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRBA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GRA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.r, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GRA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRAR(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRAR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRAG(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRAG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRAB(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRAB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GRAA(this Color self
		)
		{
			return new Color(
				self.g, self.r, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GRAA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.r;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color GG__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, self.g, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void GG__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GG_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.g, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GG_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GG_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.g, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GG_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GG_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.g, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GG_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GG_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.g, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GG_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GGR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.g, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GGR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGRR(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGRR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGRG(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGRG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGRB(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGRB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGRA(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGRA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GGG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.g, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GGG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGGR(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGGR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGGG(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGGG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGGB(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGGB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGGA(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGGA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GGB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.g, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GGB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGBR(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGBR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGBG(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGBG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGBB(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGBB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGBA(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGBA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GGA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.g, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GGA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGAR(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGAR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGAG(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGAG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGAB(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGAB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GGAA(this Color self
		)
		{
			return new Color(
				self.g, self.g, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GGAA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.g;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color GB__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, self.b, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void GB__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GB_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.b, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GB_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GB_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.b, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GB_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GB_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.b, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GB_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GB_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.b, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GB_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GBR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.b, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GBR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBRR(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBRR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBRG(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBRG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBRB(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBRB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBRA(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBRA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GBG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.b, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GBG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBGR(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBGR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBGG(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBGG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBGB(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBGB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBGA(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBGA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GBB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.b, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GBB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBBR(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBBR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBBG(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBBG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBBB(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBBB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBBA(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBBA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GBA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.b, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GBA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBAR(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBAR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBAG(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBAG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBAB(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBAB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GBAA(this Color self
		)
		{
			return new Color(
				self.g, self.b, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GBAA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.b;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color GA__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.g, self.a, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void GA__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GA_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.a, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GA_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GA_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.a, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GA_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GA_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.a, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GA_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GA_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.a, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GA_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GAR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.a, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GAR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GARR(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GARR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GARG(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GARG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GARB(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GARB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GARA(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GARA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GAG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.a, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GAG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GAGR(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GAGR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GAGG(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GAGG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GAGB(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GAGB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GAGA(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GAGA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GAB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.a, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GAB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GABR(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GABR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GABG(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GABG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GABB(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GABB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GABA(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GABA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color GAA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.g, self.a, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void GAA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GAAR(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GAAR(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GAAG(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GAAG(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GAAB(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GAAB(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color GAAA(this Color self
		)
		{
			return new Color(
				self.g, self.a, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void GAAA(this Color self, ref Color other
		)
		{

			other.r = self.g;
			other.g = self.a;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color B___(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				self.b, inj0, inj1, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void B___(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = inj1;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color B__R(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, inj0, inj1, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void B__R(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = inj1;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color B__G(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, inj0, inj1, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void B__G(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = inj1;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color B__B(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, inj0, inj1, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void B__B(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = inj1;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color B__A(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, inj0, inj1, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void B__A(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = inj1;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_R_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, inj0, self.r, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void B_R_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.r;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_RR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_RR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_RG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_RG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_RB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_RB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_RA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_RA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_G_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, inj0, self.g, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void B_G_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.g;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_GR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_GR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_GG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_GG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_GB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_GB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_GA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_GA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_B_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, inj0, self.b, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void B_B_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.b;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_BR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_BR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_BG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_BG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_BB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_BB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_BA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_BA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_A_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, inj0, self.a, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void B_A_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.a;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_AR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_AR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_AG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_AG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_AB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_AB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color B_AA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, inj0, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void B_AA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = inj0;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color BR__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, self.r, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void BR__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BR_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.r, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BR_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BR_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.r, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BR_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BR_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.r, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BR_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BR_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.r, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BR_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BRR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.r, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BRR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRRR(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRRR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRRG(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRRG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRRB(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRRB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRRA(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRRA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BRG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.r, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BRG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRGR(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRGR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRGG(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRGG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRGB(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRGB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRGA(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRGA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BRB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.r, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BRB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRBR(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRBR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRBG(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRBG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRBB(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRBB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRBA(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRBA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BRA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.r, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BRA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRAR(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRAR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRAG(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRAG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRAB(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRAB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BRAA(this Color self
		)
		{
			return new Color(
				self.b, self.r, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BRAA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.r;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color BG__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, self.g, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void BG__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BG_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.g, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BG_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BG_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.g, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BG_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BG_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.g, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BG_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BG_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.g, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BG_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BGR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.g, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BGR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGRR(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGRR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGRG(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGRG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGRB(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGRB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGRA(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGRA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BGG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.g, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BGG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGGR(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGGR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGGG(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGGG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGGB(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGGB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGGA(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGGA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BGB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.g, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BGB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGBR(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGBR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGBG(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGBG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGBB(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGBB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGBA(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGBA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BGA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.g, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BGA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGAR(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGAR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGAG(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGAG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGAB(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGAB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BGAA(this Color self
		)
		{
			return new Color(
				self.b, self.g, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BGAA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.g;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color BB__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, self.b, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void BB__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BB_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.b, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BB_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BB_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.b, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BB_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BB_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.b, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BB_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BB_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.b, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BB_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BBR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.b, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BBR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBRR(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBRR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBRG(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBRG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBRB(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBRB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBRA(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBRA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BBG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.b, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BBG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBGR(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBGR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBGG(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBGG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBGB(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBGB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBGA(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBGA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BBB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.b, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BBB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBBR(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBBR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBBG(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBBG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBBB(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBBB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBBA(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBBA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BBA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.b, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BBA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBAR(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBAR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBAG(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBAG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBAB(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBAB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BBAA(this Color self
		)
		{
			return new Color(
				self.b, self.b, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BBAA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.b;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color BA__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.b, self.a, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void BA__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BA_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.a, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BA_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BA_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.a, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BA_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BA_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.a, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BA_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BA_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.a, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BA_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BAR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.a, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BAR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BARR(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BARR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BARG(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BARG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BARB(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BARB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BARA(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BARA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BAG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.a, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BAG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BAGR(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BAGR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BAGG(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BAGG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BAGB(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BAGB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BAGA(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BAGA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BAB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.a, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BAB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BABR(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BABR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BABG(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BABG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BABB(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BABB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BABA(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BABA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color BAA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.b, self.a, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void BAA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BAAR(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BAAR(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BAAG(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BAAG(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BAAB(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BAAB(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color BAAA(this Color self
		)
		{
			return new Color(
				self.b, self.a, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void BAAA(this Color self, ref Color other
		)
		{

			other.r = self.b;
			other.g = self.a;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static Color A___(this Color self
						, float inj0
								, float inj1
								, float inj2
						)
		{
			return new Color(
				self.a, inj0, inj1, inj2
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj2">Injected component. The '_' will be replaces with this value.</param>
		public static void A___(this Color self, ref Color other
		, float inj0
				, float inj1
				, float inj2
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = inj1;
			other.a = inj2;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color A__R(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, inj0, inj1, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void A__R(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = inj1;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color A__G(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, inj0, inj1, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void A__G(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = inj1;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color A__B(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, inj0, inj1, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void A__B(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = inj1;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color A__A(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, inj0, inj1, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void A__A(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = inj1;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_R_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, inj0, self.r, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void A_R_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.r;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_RR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_RR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_RG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_RG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_RB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_RB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_RA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_RA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_G_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, inj0, self.g, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void A_G_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.g;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_GR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_GR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_GG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_GG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_GB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_GB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_GA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_GA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_B_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, inj0, self.b, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void A_B_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.b;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_BR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_BR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_BG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_BG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_BB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_BB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_BA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_BA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_A_(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, inj0, self.a, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void A_A_(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.a;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_AR(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_AR(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_AG(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_AG(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_AB(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_AB(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color A_AA(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, inj0, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void A_AA(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = inj0;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color AR__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, self.r, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void AR__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AR_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.r, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AR_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AR_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.r, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AR_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AR_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.r, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AR_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AR_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.r, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AR_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color ARR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.r, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ARR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARRR(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARRR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARRG(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARRG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARRB(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARRB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARRA(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARRA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color ARG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.r, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ARG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARGR(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARGR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARGG(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARGG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARGB(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARGB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARGA(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARGA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color ARB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.r, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ARB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARBR(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARBR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARBG(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARBG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARBB(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARBB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARBA(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARBA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color ARA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.r, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ARA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARAR(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARAR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARAG(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARAG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARAB(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARAB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ARAA(this Color self
		)
		{
			return new Color(
				self.a, self.r, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ARAA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.r;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color AG__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, self.g, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void AG__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AG_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.g, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AG_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AG_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.g, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AG_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AG_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.g, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AG_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AG_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.g, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AG_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AGR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.g, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AGR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGRR(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGRR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGRG(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGRG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGRB(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGRB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGRA(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGRA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AGG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.g, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AGG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGGR(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGGR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGGG(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGGG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGGB(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGGB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGGA(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGGA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AGB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.g, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AGB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGBR(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGBR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGBG(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGBG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGBB(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGBB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGBA(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGBA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AGA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.g, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AGA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGAR(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGAR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGAG(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGAG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGAB(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGAB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AGAA(this Color self
		)
		{
			return new Color(
				self.a, self.g, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AGAA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.g;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color AB__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, self.b, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void AB__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AB_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.b, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AB_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AB_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.b, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AB_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AB_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.b, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AB_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AB_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.b, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AB_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color ABR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.b, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ABR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABRR(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABRR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABRG(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABRG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABRB(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABRB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABRA(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABRA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color ABG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.b, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ABG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABGR(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABGR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABGG(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABGG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABGB(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABGB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABGA(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABGA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color ABB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.b, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ABB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABBR(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABBR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABBG(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABBG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABBB(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABBB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABBA(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABBA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color ABA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.b, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void ABA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABAR(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABAR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABAG(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABAG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABAB(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABAB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color ABAA(this Color self
		)
		{
			return new Color(
				self.a, self.b, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void ABAA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.b;
			other.b = self.a;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static Color AA__(this Color self
						, float inj0
								, float inj1
						)
		{
			return new Color(
				self.a, self.a, inj0, inj1
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		/// <param name="inj1">Injected component. The '_' will be replaces with this value.</param>
		public static void AA__(this Color self, ref Color other
		, float inj0
				, float inj1
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = inj0;
			other.a = inj1;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AA_R(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.a, inj0, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AA_R(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = inj0;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AA_G(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.a, inj0, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AA_G(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = inj0;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AA_B(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.a, inj0, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AA_B(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = inj0;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AA_A(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.a, inj0, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AA_A(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = inj0;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AAR_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.a, self.r, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AAR_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.r;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AARR(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.r, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AARR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.r;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AARG(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.r, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AARG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.r;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AARB(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.r, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AARB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.r;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AARA(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.r, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AARA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.r;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AAG_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.a, self.g, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AAG_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.g;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AAGR(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.g, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AAGR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.g;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AAGG(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.g, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AAGG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.g;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AAGB(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.g, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AAGB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.g;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AAGA(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.g, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AAGA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.g;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AAB_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.a, self.b, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AAB_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.b;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AABR(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.b, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AABR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.b;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AABG(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.b, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AABG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.b;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AABB(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.b, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AABB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.b;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AABA(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.b, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AABA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.b;
			other.a = self.a;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static Color AAA_(this Color self
						, float inj0
						)
		{
			return new Color(
				self.a, self.a, self.a, inj0
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		/// <param name="inj0">Injected component. The '_' will be replaces with this value.</param>
		public static void AAA_(this Color self, ref Color other
		, float inj0
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.a;
			other.a = inj0;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AAAR(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.a, self.r
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AAAR(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.a;
			other.a = self.r;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AAAG(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.a, self.g
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AAAG(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.a;
			other.a = self.g;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AAAB(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.a, self.b
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AAAB(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.a;
			other.a = self.b;
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		public static Color AAAA(this Color self
		)
		{
			return new Color(
				self.a, self.a, self.a, self.a
			);
		}

		/// <summary>
		/// Extracts a Color from a Color using swizzle.
		/// </summary>
		/// <param name="self">The source component</param>
		/// <param name="other">The target component</param>
		public static void AAAA(this Color self, ref Color other
		)
		{

			other.r = self.a;
			other.g = self.a;
			other.b = self.a;
			other.a = self.a;
		}

		#endregion		
	}
}