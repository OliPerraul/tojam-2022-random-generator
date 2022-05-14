

using System.Diagnostics;

namespace Cirrus.Files
{
	public static class SystemUtils
	{
		public static string CurrentScriptDirectory => CurrentScriptFile.GetDirectoryName();

		public static string CurrentScriptFile => new StackTrace(true).GetFrame(1).GetFileName();
	}
}
