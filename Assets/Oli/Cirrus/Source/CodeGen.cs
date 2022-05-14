using Cirrus.Content;
using Cirrus.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Cirrus.Source
{
	public class CodeGenEntry
	{
		//public object Object;
		public IEnumerable<string> Categories;
		public string Name;
		public string Namespace;
		public string TypeName;
		//public int ID;
		public Type Type;
		public Type UnderlyingType;
		public CodeGenOptions Options;
	}

	public static class CodeGenUtils
	{
		public static string SerializeFieldAttr = "[SerializeField]";
		public static string NonSerializedAttr = "[System.NonSerialized]";		
		public static string SerializableAttr = "[System.Serializable]";
		public static string DefinePrefix = "CIRRUS_";


		// This is the set of types from the C# keyword list.
		public static Dictionary<Type, string> _typeAlias = new Dictionary<Type, string>
		{
			{ typeof(bool), "bool" },
			{ typeof(byte), "byte" },
			{ typeof(char), "char" },
			{ typeof(decimal), "decimal" },
			{ typeof(double), "double" },
			{ typeof(float), "float" },
			{ typeof(int), "int" },
			{ typeof(long), "long" },
			{ typeof(object), "object" },
			{ typeof(sbyte), "sbyte" },
			{ typeof(short), "short" },
			{ typeof(string), "string" },
			{ typeof(uint), "uint" },
			{ typeof(ulong), "ulong" },
			// Yes, this is an odd one.  Technically it's a type though.
			{ typeof(void), "void" }
		};
		public static bool GetAliasName(Type type, out string aliasName)
		{
			return _typeAlias.TryGetValue(type, out aliasName);
		}


		public static string FormatIdentifierName(this string name)
		{
			name = name.Replace(".", "");
			name = name.Replace(" ", "");
			name = string.Join("", name.AsEnumerable()
						   .Select(chr => char.IsLetter(chr) || char.IsDigit(chr) || chr == '_'
										  ? chr.ToString()      // valid symbol
										  : "_" + (short)chr + "_") // numeric code for invalid symbol
					 );
			name = char.IsLetter(name[0]) || name[0] == '_' ?
				name :
				"_" + name;
			return name;
		}

		public static string FormatGeneratedFileName(this string file)
			=> file.StripExtension() + ".gen.cs";

		public static string FormatDefine(this string input)
		{
			input = Regex.Replace(input, "([A-Z][a-z]*[a-z])", "_$0", RegexOptions.Compiled);
			input = Regex.Replace(input, "([A-Z]*[A-Z])", "_$0", RegexOptions.Compiled);
			input = input.Replace("__", "_");
			input = input[0] == '_' ? input.Substring(1, input.Length - 1) : input;
			input = input.Replace("__", "_");
			return input.ToUpper();
		}

		public static string FormatPublicField(this string s)
		{
			s = s.Replace('.', '_');
			s = s.Replace(' ', '_');
			string[] splits = (s[0] =='_' ? s.Substring(1) : s).Split('_');
			for(int i = 0; i < splits.Length; i++)
			{
				splits[i] = splits[i].FromPascalToCamelCase();
			}

			s = string.Join("_", splits);
			return s;
		}

		public static string FormatPrivateField(this string s)
		{
			s = FormatPublicField(s);
			s = s[0] != '_' ? "_" + s : s;
			return s;
		}

		public static string FormatSecretPrivateField(this string s)
		{
			s = FormatPublicField(s);			
			s = s[s.Length - 1] != '_' ? s + "__" : s + "_";
			s = s[0] != '_' ? "__" + s : "_" + s;
			return s;
		}

		public static string FormatPublicProperty(this string s)
		{
			s = s.Replace('.', '_');
			s = s.Replace(" ", "");
			string[] splits = (s[0] == '_' ? s.Substring(1) : s).Split('_');
			for(int i = 0; i < splits.Length; i++)
			{
				splits[i] = splits[i].FromCamelToPascalCase();
			}

			s = string.Join("_", splits);
			return s;
		}		

		public static string FormatPrivateProperty(this string s)
		{
			s = FormatPublicProperty(s);
			s = s[0] != '_' ? "_" + s : s;
			return s;
		}

		public static string FormatSecretPrivateProperty(this string s)
		{
			s = FormatPublicProperty(s);
			s = s[s.Length - 1] != '_' ? s + "__" : s + "_";
			s = s[0] != '_' ? "__" + s : "_" + s;
			return s;
		}

		public static string Disambiguate(string s)
		{
			return s + "_";
		}
	}

	public class Writer
	{
		private const int _SpacesPerIndentLevel = 4;

		public StringBuilder buffer;
		public int indentLevel;

		public void BeginBlock()
		{
			WriteIndent();
			buffer.Append("{\n");
			++indentLevel;
		}

		public void EndBlock()
		{
			--indentLevel;
			WriteIndent();
			buffer.Append("}\n");
		}

		public void WriteLine()
		{
			buffer.Append('\n');
		}

		public void WriteLine(string text)
		{
			WriteIndent();
			buffer.Append(text);
			buffer.Append('\n');
		}

		public void Write(string text)
		{
			buffer.Append(text);
		}

		public void WriteIndent()
		{
			for(var i = 0; i < indentLevel; ++i)
			{
				for(var n = 0; n < _SpacesPerIndentLevel; ++n)
					buffer.Append(' ');
			}
		}
	}
}
