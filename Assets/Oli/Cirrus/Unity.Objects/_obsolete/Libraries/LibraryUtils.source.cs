using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrus;

namespace Cirrus.Unity.Objects.Libraries
{
	public static partial class LibraryUtils
	{
		private static string _GeneratedClassSuffix = "";

		private static string _GeneratedWarningMessage = "This file was generated. DO NOT EDIT.";

		public static string FormatGeneratedClassName(this string name)
		{
			return name + _GeneratedClassSuffix;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="usings"></param>
		/// <param name="resource"></param>
		/// <param name="lib"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public static string ScriptTemplate_GeneratedClass(string usings, string resource, string lib, string name, string ns)
		{
return
$@"
/*{_GeneratedWarningMessage}*/
using Cirrus.Objects;
using Cirrus.Unity.Objects;
using UnityEngine;
using static Cirrus.Debugging.DebugUtils;
using Cirrus.Content;
{usings}

namespace {ns}
{{
	[SkipCodeGen]
	public class {FormatGeneratedClassName(name)}
		: ResourceProviderComponent<{resource}>
	{{
		protected override {resource} _Get()
		{{
			return {lib}.{name};
		}}
	}}
}}
";

		}
	}
}
