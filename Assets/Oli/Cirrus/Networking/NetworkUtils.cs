using System;
using System.Net;
using System.Net.Sockets;

namespace Cirrus
{
	public static class NetworkUtils
	{
		public const ushort DefaultPort = 2024;

		public static Uri ToUri(IPAddress addr, ushort port)
		{
			switch(addr.AddressFamily)
			{
				case AddressFamily.InterNetwork: return new Uri(string.Format("http://{0}:{1}", addr, port));
				case AddressFamily.InterNetworkV6: return new Uri(string.Format("http://[{0}]:{1}", addr, port));
			}

			return null;
		}

		public static Uri ToUri(IPAddress addr, ushort port, string scheme)
		{
			switch(addr.AddressFamily)
			{
				case AddressFamily.InterNetwork: return new Uri(string.Format($"{scheme}://{0}:{1}", addr, port));
				case AddressFamily.InterNetworkV6: return new Uri(string.Format($"{scheme}://[{0}]:{1}", addr, port));
			}

			return null;
		}

		public static Uri ToUri(IPAddress addr, string scheme)
		{
			switch(addr.AddressFamily)
			{
				case AddressFamily.InterNetwork: return new Uri($"{scheme}://{addr}");
				case AddressFamily.InterNetworkV6: return new Uri($"{scheme}://[{addr}]");
			}

			return null;
		}

		public static string LocalIPAddress
		{
			get
			{
				var host = Dns.GetHostEntry(Dns.GetHostName());
				foreach(var ip in host.AddressList)
				{
					if(ip.AddressFamily == AddressFamily.InterNetwork)
					{
						return ip.ToString();
					}
				}
				throw new Exception("No network adapters with an IPv4 address in the system!");
			}
		}

		public static bool ParseAddress(this string input, out IPAddress adrs, out ushort port)
		{
			string[] splits = input.Split(':');
			port = splits.Length > 1 && ushort.TryParse(splits[1], out port) ? port : (ushort)DefaultPort;

			string res = splits[0].Equals("localhost") ? LocalIPAddress : splits[0];
			if(IPAddress.TryParse(res, out adrs))
			{
				switch(adrs.AddressFamily)
				{
					case AddressFamily.InterNetwork: return true;
					case AddressFamily.InterNetworkV6: return true;
					default: return false;
				}
			}

			return false;
		}

	}
}
