#if UNITY_EDITOR

using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace Cirrus.Unity.Editor
{
	public static class ProjectUtils
	{
		public static void AddDefineSymbols(string symbol)
		{
			//if(format) symbol = CodeGenUtils.FormatDefine(symbol);

			string definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
			List<string> allDefines = definesString.Split(';').ToList();
			if(!allDefines.Contains(symbol))
			{
				allDefines.Add(symbol);
				PlayerSettings.SetScriptingDefineSymbolsForGroup(
					BuildTargetGroup.Standalone,
					string.Join(";", allDefines.ToArray()));
			}
		}
	}
}

#endif
