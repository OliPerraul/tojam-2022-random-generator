using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Unity.Inputs
{
	public struct CursorState
	{
		public bool Visible { get; set; }
		public CursorLockMode LockMode { get; set; }
		public static bool operator ==(CursorState first, CursorState second)
		{
			return
				first.Visible == second.Visible &&
				first.LockMode == second.LockMode;
		}
		public static bool operator !=(CursorState first, CursorState second)
		{
			return !(first == second);
		}
	}

	public static class UnityInputUtils
	{
		private static CursorState? _top = null;
		private static Stack<CursorState> _cursorLockModeStack = new Stack<CursorState>();
		public static CursorState CursorState => _top.Value;

		public static bool PushLockState(CursorState state)
		{
			if(_top != null && _top == state) return false;
			if(_top != null) _cursorLockModeStack.Push(_top.Value);
			_top = new CursorState
			{
				LockMode = Cursor.lockState = state.LockMode,
				Visible = Cursor.visible = state.Visible
			};
			return true;
		}

		public static bool PopLockState(CursorState state)
		{
			if(_top == null) return false;
			if(_cursorLockModeStack.Count == 0) return false;
			if(_top != state) return false;
			_top = _cursorLockModeStack.Pop();
			Cursor.lockState = _top.Value.LockMode;
			Cursor.visible = _top.Value.Visible;
			return true;
		}
	}
}
