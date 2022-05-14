using UnityEngine;

namespace Cirrus.Unity.Serialization
{
	public static class PlayerPrefsUtils
	{
		// TODO enumerable
		public static int NextInt(string name="")
		{
			int val = PlayerPrefs.HasKey(name) ? PlayerPrefs.GetInt(name) + 1 : 0;
			PlayerPrefs.SetInt(name, val);
			return val;

		}
	}
}
