using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object = UnityEngine.Object;

namespace Cirrus.Healer.IDs
{
	public static class IDUtils
	{
		public static string GuidString()
		{
			Guid g = Guid.NewGuid();
			string guidString = Convert.ToBase64String(g.ToByteArray());
			guidString = guidString.Replace("=", "");
			guidString = guidString.Replace("+", "");
			return guidString;
		}
	}

	public interface IIded
	{ 
		public uint Id { get; }
	}		
}
