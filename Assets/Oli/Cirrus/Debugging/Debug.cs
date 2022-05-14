using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Cirrus.Debugging
{
	public enum AssertType
	{
		One,
		Two,
		Three,
		Four
	}

	public static class DebugUtils
	{
		private static bool AssertOfType(AssertType type)
		{
			if(
				false
#if CIRRUS_ASSERT_TYPE_1
				|| type == AssertType.One
#endif
#if CIRRUS_ASSERT_TYPE_2
				|| type == AssertType.Two
#endif
#if CIRRUS_ASSERT_TYPE_3
				|| type == AssertType.Three
#endif
#if CIRRUS_ASSERT_TYPE_4
				|| type == AssertType.Four
#endif
				)
			{
				return true;
			}

			return false;
		}

		public static bool AssertDidNotFail(bool cond, string msg, bool doBreak = false)
		{
			return AssertSucceeded(cond, AssertType.One, msg, doBreak);
		}
		public static bool AssertSucceeded(bool cond, AssertType type = AssertType.One, string msg = "", bool doBreak = false)
		{
			if(!cond)
			{
#if UNITY_EDITOR
				if(AssertOfType(type))
				{
					msg = msg.IsNullOrEmpty() ? msg : ": " + msg;
					Debug.LogError($"ASSERT FAILED{msg}");
					if(doBreak) Debugger.Break();
				}
#endif
				return false;
			}

			return true;
		}

		[Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
		public static void Assert(bool cond, bool break_=true)
		{
			Assert(cond, AssertType.One, "", break_);
		}

		[Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
		public static void Assert(bool cond, string msg, bool break_=true)
		{
			Assert(cond, AssertType.One, msg, break_);
		}

		[Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
		public static void Assert(bool cond, AssertType type, string msg = "", bool break_ = true)
		{
#if UNITY_EDITOR

			if(!cond)
			{
				if(AssertOfType(type))
				{
					msg = msg.IsNullOrEmpty() ? msg : ": " + msg;
					Debug.LogError($"ASSERT FAILED{msg}");
					if(break_) Debugger.Break();
				}
			}
#endif
		}

		[Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
		public static void AssertFatal(bool cond, string msg = "")
		{
#if UNITY_EDITOR
			if(!cond)
			{
				msg = msg.IsNullOrEmpty() ? msg : ": " + msg;
				Debug.LogError($"ASSERT FATAL{msg}");
				UnityEditor.EditorApplication.isPlaying = false;
				Application.Quit();
			}
#endif
		}

		[Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
		public static void Error(string msg)
		{
#if UNITY_EDITOR
			msg = msg.IsNullOrEmpty() ? msg : ": " + msg;
			Debug.LogError($"ERROR{msg}");
#endif
		}

		[Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
		public static void Warn(string msg)
		{
#if UNITY_EDITOR
			msg = msg.IsNullOrEmpty() ? msg : ": " + msg;
			Debug.LogWarning($"WARNING{msg}");
#endif
		}


		[Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
		public static void Warn(bool cond, bool break_)
		{
			Warn(cond, AssertType.One, "", break_);
		}

		[Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
		public static void Warn(bool cond, string msg, bool break_ = false)
		{
			Warn(cond, AssertType.One, msg, break_);
		}

		[Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
		public static void Warn(bool cond, AssertType type = AssertType.One, string msg = "", bool break_ = false)
		{
#if UNITY_EDITOR

			if (!cond)
			{
				if (AssertOfType(type))
				{
					msg = msg.IsNullOrEmpty() ? msg : ": " + msg;
					Debug.LogWarning($"ASSERT FAILED{msg}");
					if (break_) Debugger.Break();
				}
			}
#endif
		}


		[Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
		public static void Log(string msg)
		{
#if UNITY_EDITOR
			msg = msg.IsNullOrEmpty() ? msg : ": " + msg;
			Debug.Log($"LOG{msg}");
#endif
		}
	}
}