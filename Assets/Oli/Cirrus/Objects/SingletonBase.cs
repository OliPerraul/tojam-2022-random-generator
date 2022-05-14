namespace Cirrus.Objects
{
	public abstract class SingletonBase
	{
		public virtual void OnAcquired()
		{
		}

		// Force immediate clean up if needed
		public virtual void OnReset()
		{

		}
	}

	public abstract class SingletonBase<T> : SingletonBase where T : SingletonBase, new()
	{
		// https://csharpindepth.com/articles/singleton
		// TODO protect
		//private static T _instance = null = new
		/*
		 * 
		 * As you can see, this is really is extremely simple - but why is it 
		 * thread-safe and how lazy is it? Well, static constructors in C# are 
		 * specified to execute only when an instance of the class is created or a
		 * static member is referenced, and to execute only once per AppDomain. 
		 * Given that this check for the type being newly constructed needs to be 
		 * executed whatever else happens, it will be faster than adding extra 
		 * checking as in the previous examples. There are a couple of wrinkles, however: 
		 * */
		private static T _instance = null;
		private static readonly object _lock = new object();

		public static T Instance
		{
			get
			{
				if(_instance == null)
				{
					lock(_lock)
					{
						if(_instance == null)
						{
							_instance = new T();
						}
					}
				}

				_instance.OnAcquired();
				return _instance;
			}
		}


		public static void Reset()
		{
			if(_instance != null)
			{
				lock(_lock)
				{
					if(_instance != null)
					{
						_instance.OnReset();
						_instance = null;
					}
				}
			}
		}
	}
}
