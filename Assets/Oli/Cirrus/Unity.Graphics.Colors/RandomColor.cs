using Cirrus.Unity.Numerics;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Unity.Graphics
{
	public class RandomColor
	{
		public enum LuminosityLevel
		{
			Unspecified = 0,
			Random,
			Bright,
			Dark,
			Light
		}

		public enum PredefinedColor
		{
			Random = 0,
			Monochrome,
			Red,
			Orange,
			Yellow,
			Green,
			Blue,
			Purple,
			Pink
		}

		static readonly Dictionary<PredefinedColor, ColorBounds> s_ColorPalette = new Dictionary<PredefinedColor, ColorBounds> {
			{ PredefinedColor.Red, new ColorBounds(new Range_(-26, 18), new Range_(20, 100), new[] { 100, 92, 89, 85, 78, 70, 60, 55, 50 }) },
			{ PredefinedColor.Orange, new ColorBounds(new Range_(19, 46), new Range_(20, 100), new[] { 100, 93, 88, 86, 85, 70, 70 }) },
			{ PredefinedColor.Yellow, new ColorBounds(new Range_(47, 62), new Range_(25, 100), new[] { 100, 94, 89, 86, 84, 82, 80, 75 }) },
			{ PredefinedColor.Green, new ColorBounds(new Range_(63, 178), new Range_(30, 100), new[] { 100, 90, 85, 81, 74, 64, 50, 40 }) },
			{ PredefinedColor.Blue, new ColorBounds(new Range_(179, 257), new Range_(20, 100), new[] { 100, 86, 80, 74, 60, 52, 44, 39, 35 }) },
			{ PredefinedColor.Purple, new ColorBounds(new Range_(258, 282), new Range_(20, 100), new[] { 100, 87, 79, 70, 65, 59, 52, 45, 42 }) },
			{ PredefinedColor.Pink, new ColorBounds(new Range_(283, 334), new Range_(20, 100), new[] { 100, 90, 86, 84, 80, 75, 73}) }
		};

		static readonly ColorBounds s_Monochrome = new ColorBounds(new Range_(0), new Range_(0), new[] { 0, 0 });

		System.Random m_Generator;

		public RandomColor()
		{
			m_Generator = new System.Random();
		}

		public RandomColor(int seed)
		{
			m_Generator = new System.Random(seed);
		}

		public Color GetColor(PredefinedColor color, LuminosityLevel luminosity = LuminosityLevel.Unspecified)
		{
			if(color == PredefinedColor.Random)
			{
				return GetColor(RandomWithin(0, 359));
			}

			var bounds = color == PredefinedColor.Monochrome ? s_Monochrome : s_ColorPalette[color];

			return GetColor(luminosity, bounds);
		}

		public Color GetColor(int hue, LuminosityLevel luminosity = LuminosityLevel.Unspecified)
		{
			var h = hue % 360;
			foreach(var v in s_ColorPalette.Values)
			{
				if(v.HueRange.Min <= h && h <= v.HueRange.Max)
				{
					return GetColor(luminosity, v);
				}
			}

			return GetColor(luminosity, s_ColorPalette[PredefinedColor.Red]);
		}

		private Color GetColor(LuminosityLevel luminosity, ColorBounds bounds)
		{
			// Pick Hue
			var hue = PickHue(bounds.HueRange);

			// Pick Saturation
			var saturation = PickSaturation(bounds.SaturationRange, luminosity);

			// Pick Brightness based on Saturation
			var brightness = PickBrightness(bounds.BrightnessCurve, saturation, bounds.SaturationRange, luminosity);

			// Convert to Color object
			return HSBtoColor(hue, saturation, brightness);
		}

		int PickHue(Range_ hueRange)
		{
			if(hueRange == new Range_(0))
			{
				return 0;
			}

			var hue = RandomWithin(hueRange);
			if(hue < 0)
			{
				hue += 360;
			}

			return hue;
		}

		int PickSaturation(Range_ range, LuminosityLevel luminosity)
		{
			if(range == null)
			{
				return 0;
			}

			switch(luminosity)
			{
				case LuminosityLevel.Random:
					return RandomWithin(0, 100);
				case LuminosityLevel.Bright:
					return RandomWithin(55, (int)range.Max);
				case LuminosityLevel.Dark:
					return RandomWithin((int)range.Max - 10, (int)range.Max);
				case LuminosityLevel.Light:
					return RandomWithin((int)range.Min, 55);
			}

			return RandomWithin(range);
		}

		int PickBrightness(AnimationCurve brightnessCurve, int saturation, Range_ saturationRange, LuminosityLevel luminosity)
		{
			if(luminosity == LuminosityLevel.Random)
			{
				return RandomWithin(0, 100);
			}

			var t = saturationRange == null ? 0 : Mathf.InverseLerp(saturationRange.Min, saturationRange.Max, saturation);
			var brightness = (int)brightnessCurve.Evaluate(t);

			switch(luminosity)
			{
				case LuminosityLevel.Dark:
					return RandomWithin(brightness, brightness + 20);
				case LuminosityLevel.Light:
					return RandomWithin((brightness + 100) / 2, 100);
			}

			return RandomWithin(brightness, 100);
		}

		#region Random Ranges
		int RandomWithin(Range_ range)
		{
			return m_Generator.Next((int)range.Min, (int)range.Max);
		}

		int RandomWithin(int min, int max)
		{
			return m_Generator.Next(min, max);
		}
		#endregion

		Color HSBtoColor(int hue, int saturation, int brightness)
		{
			var s = saturation / 100f;
			var b = brightness / 100f;

			var h = hue / 60f;
			var i = (int)h;
			var f = h - i;
			var p = b * (1 - s);
			var q = b * (1 - s * f);
			var t = b * (1 - s * (1 - f));

			switch(i)
			{
				case 0:
					return new Color(b, t, p);
				case 1:
					return new Color(q, b, p);
				case 2:
					return new Color(p, b, t);
				case 3:
					return new Color(p, q, b);
				case 4:
					return new Color(t, p, b);
				case 5:
					return new Color(b, p, q);
			}

			return new Color(b, p, q);
		}
	}
}