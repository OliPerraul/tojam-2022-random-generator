
using System.Threading;

namespace Cirrus.Threading
{
	public class MutexWrapper
	{
		public Mutex _mutex = new Mutex();
		private bool _isAcquired = false;
		public bool IsAcquired => _isAcquired;

		public bool WaitOne()
		{
			if(_mutex.WaitOne())
			{
				_isAcquired = true;
				return true;
			}

			// timeout
			return false;
		}
		public bool WaitOne(int timeoutmilis)
		{
			if(_mutex.WaitOne(timeoutmilis))
			{
				_isAcquired = true;
				return true;
			}

			// timeout
			return false;
		}

		public void Release()
		{
			_mutex.ReleaseMutex();
			_isAcquired = false;
		}

	}
}