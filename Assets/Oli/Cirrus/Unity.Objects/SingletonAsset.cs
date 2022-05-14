using Cirrus.Unity.Editor;
using System.Linq;

namespace Cirrus.Unity.Objects
{
	public class SingletonAssetBase : ScriptableObjectBase { }

	public class SingletonAssetBase<T> : SingletonAssetBase where T : SingletonAssetBase
	{
		private static T _instance;

		public static T Instance =>
			_instance == null ?
			_instance = UnityEngine.Resources.FindObjectsOfTypeAll<T>().FirstOrDefault() :
			_instance;
	}

#if UNITY_EDITOR
	public class EditorSingletonAssetBase : ScriptableObjectBase { }

	public class EditorSingletonAssetBase<T> : SingletonAssetBase where T : SingletonAssetBase
	{
		private static T _instance;

		public static T Instance =>
			_instance == null ?
			_instance = AssetDatabaseUtils.FindObjectOfType<T>() :
			_instance;
	}
#endif

}
