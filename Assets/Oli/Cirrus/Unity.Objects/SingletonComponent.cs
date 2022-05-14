using System;

namespace Cirrus.Unity.Objects
{
	public class SingletonComponentBase : CustomMonoBehaviourBase { }


	public class SingletonComponentBase<T> : SingletonComponentBase where T : SingletonComponentBase
	{
		[NonSerialized]
		protected static T _instance;

		public void Persist()
		{
			if(
				!_instance.NativeReferenceEquals(null) &&
				!_instance.gameObject.NativeReferenceEquals(null) &&
				_instance.gameObject != gameObject
				)
			{
				DestroyImmediate(gameObject);
				return;
			}

			_instance = Instance;
			transform.SetParent(null);
			DontDestroyOnLoad(gameObject);
		}

		public override void OnDestroy()
		{
			base.OnDestroy();
			_instance = null;
		}

		public static T Instance
		{
			get
			{
				if(_instance == null) _instance = FindObjectOfType<T>();

				return _instance;
			}
		}
	}

	//public class PersistentSingletonComponent<T> : SingletonComponentBase<T> where T : SingletonComponentBase
	//{
	//	//public override void Awake()
	//	//{
	//	//	if (_instance != null)
	//	//	{
	//	//		DestroyImmediate(gameObject);
	//	//		return;
	//	//	}

	//	//	DontDestroyOnLoad(gameObject);
	//	//}

	//}
}