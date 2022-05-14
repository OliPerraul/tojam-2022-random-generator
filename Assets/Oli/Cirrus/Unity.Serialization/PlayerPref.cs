using UnityEngine;

namespace Cirrus.Unity.Serialization
{

	public class PlayerPrefWrapper
	{
		private string _name;

		private bool _bool;

		private string _string;

		private float _float;

		private int _int;

		public PlayerPrefWrapper(string name="")
		{
			_name = name;
		}

		public PlayerPrefWrapper(string name, int value)
		{
			_name = name;
			Set(
				PlayerPrefs.HasKey(name) ?
					PlayerPrefs.GetInt(_name) :
					value);
		}

		public PlayerPrefWrapper(string name, float value)
		{
			_name = name;
			Set(
				PlayerPrefs.HasKey(name) ?
					PlayerPrefs.GetFloat(_name) :
					value);
		}

		public PlayerPrefWrapper(string name, string value)
		{
			_name = name;
			Set(
				PlayerPrefs.HasKey(name) ?
					PlayerPrefs.GetString(_name) :
					value);
		}

		public PlayerPrefWrapper(string name, bool value)
		{
			_name = name;
			Set(
				PlayerPrefs.HasKey(name) ?
					PlayerPrefs.GetInt(_name) != 0 :
					value);
		}

		public int Integer => _int;

		public void Set(int value)
		{
			_int = value;
			PlayerPrefs.SetInt(_name, value);
			PlayerPrefs.Save();
		}

		public float Float => _float;

		public void Set(float value)
		{
			_float = value;
			PlayerPrefs.SetFloat(_name, value);
			PlayerPrefs.Save();
		}

		public bool Boolean => _bool;

		public void Set(bool value)
		{
			_bool = value;
			PlayerPrefs.SetInt(_name, value ? 1 : 0);
			PlayerPrefs.Save();
		}

		public string String => _string;

		public void Set(string value)
		{
			_string = value;
			PlayerPrefs.SetString(_name, value);
			PlayerPrefs.Save();
		}
	}
}
