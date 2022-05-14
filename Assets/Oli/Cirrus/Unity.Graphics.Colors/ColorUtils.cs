using System.Globalization;
using UnityEngine;

namespace Cirrus.Unity.Graphics
{
	public static class ColorUtils
	{

		public static Color GodotPink = FromHex("f58882");

		public static Color GodotBlue = FromHex("678ee6");

		public static Color GodotPurple = FromHex("8b6ce1");

		public static Color GodotTurquoise = FromHex("78e5f6");

		//blue
		public static Color BlueColor = FromHex("0055bd");
		public static Color LightBlue = FromHex("75e8f4");

		public static Color LightGreen = FromHex("90EE90");

		// yellow
		public static Color YellowColor = FromHex("ffbe37");

		public static Color OrangeColor = FromHex("ffc83b");

		//white
		public static Color WhiteColor = FromHex("FFFFFF");

		//dar
		public static Color DarkColor = FromHex("000000");

		//grey
		public static Color TextGreyColor = FromHex("1c2633");
		public static Color TextLogoutAnsverColor = FromHex("333333");

		public static Color TextLightGreyColor = FromHex("a8a89f");
		public static Color TextHintColor = FromHex("991c2633");
		public static Color ExtraLightGrey = FromHex("e8e8e8");
		public static Color SemiLightGrey = FromHex("d6d6d6");

		//red
		public static Color RedColor = FromHex("bc1414");

		//white
		public static Color TextWhiteColor = FromHex("FFFFFF");

		public static Color AppMainColorTransparent = FromHex("E60055bd");
		public static Color TransparentColor = FromHex("00000000");


		public static Color Copy(Color c)
		{
			return new Color(c.r, c.g, c.b, c.a);
		}

		public static Color FromHex(string hexaColor)
		{
			int red;
			int.TryParse(hexaColor.Substring(0, 2), NumberStyles.AllowHexSpecifier, CultureInfo.CurrentCulture, out red);
			int green;
			int.TryParse(hexaColor.Substring(2, 2), NumberStyles.AllowHexSpecifier, CultureInfo.CurrentCulture, out green);
			int blue;
			int.TryParse(hexaColor.Substring(4, 2), NumberStyles.AllowHexSpecifier, CultureInfo.CurrentCulture, out blue);
			return new Color(red / 255f, green / 255f, blue / 255f);
		}

		public static Vector3 RgbToHsv(this Color color)
		{
			float h;
			float s;
			float v;
			Color.RGBToHSV(color, out h, out s, out v);
			return new Vector3(h, s, v);
		}

		public static Color HsvToRgb(this Vector3 hsv)
		{
			return new Color(hsv.x, hsv.y, hsv.z);
		}

		public static Vector3 ToVector3(this Color color)
		{
			return new Vector3(color[0], color[1], color[2]);
		}
		public static Vector4 ToVector4(this Color color)
		{
			return new Vector4(color.r, color.g, color.b, color.a);
		}


		public static Color SetG(this Color im, float g)
		{
			//var c = im;
			im.g = g;
			//im = c;
			return im;
		}

		public static Color SetB(this Color im, float b)
		{
			//var c = im;
			im.b = b;
			//im = c;
			return im;
		}

		public static Color SetA(this Color im, float a)
		{
			im.a = a;
			return im;
		}


		public static Color Set(this Color im, float r, float g, float b, float a)
		{
			im.r = r;
			im.g = g;
			im.b = b;
			im.a = a;
			return im;
		}

		public static Color Set(this Color im, float r, float g, float b)
		{
			im.r = r;
			im.g = g;
			im.b = b;
			//im.a = a;
			return im;
		}
	}

}