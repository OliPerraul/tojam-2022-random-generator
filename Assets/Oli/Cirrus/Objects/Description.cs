// Allow text management via json

namespace Cirrus.Objects
{
	public class Description
	{
		public static string FormatName(string name="")
		{
			string n = name;
			if(n == string.Empty || n == "[?]")
			{
				n = n.After(".");
				n = n.Replace("Large", " ");
				n = n.Replace("Small", " ");
				n = n.Replace("Medium", " ");
				n = n.Replace(".", " ");
			}

			return n;
		}
	}
}