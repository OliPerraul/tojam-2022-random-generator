using System;
using System.Security.Cryptography;
using System.Text;

namespace Cirrus
{
	public static class CryptoUtils
	{
		public static HashAlgorithm algorithm = SHA256.Create();

		public static byte[] GetHash(string input)
		{
			return algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
		}

		public static long LongHashCode(this string input)
		{
			var hashed = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
			return BitConverter.ToInt64(hashed, 0);
		}

		public static int HashCode(this string input)
		{
			var hashed = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
			return BitConverter.ToInt32(hashed, 0);
		}


	}
}
