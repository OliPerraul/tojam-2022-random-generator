#if UNITY_EDITOR

// TODO: batch apply within same property block

using Cirrus.Source;
using Cirrus.Unity.Editor;
using System.Globalization;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using static Cirrus.Source.CodeGenUtils;

namespace Cirrus.Unity.Graphics
{
	public class ShaderWrapperGenerator : ScriptableObject
	{
		[MenuItem("Assets/Create/Cirrus.Unity/Graphics/ShaderWrapperGenerator", false, priority = PackageUtils.MenuItemAssetFrameworkPriority)]
		public static void CreateAsset() => EditorScriptableObjectUtils.CreateAsset<ShaderWrapperGenerator>();

		
		public string DefinePrefix = "HEALER_";

		[SerializeField]
		public Shader _shader;

		[SerializeField]
		public string _name;

		[SerializeField]
		public string _namespace;

		private const int kSpacesPerIndentLevel = 4;

		public static string FormatField(string field)
		{
			return field.ToLower().Replace(" ", "");
		}

		public string FormatProperty1(string property)
		{
			string res = property.First().ToString().ToUpper() + property.Substring(1);
			return _name + "_" + res.Replace(" ", "");
		}

		public static string FormatProperty2(string property)
		{
			string res = property.First().ToString().ToUpper() + property.Substring(1);
			return res.Replace(" ", "");
		}

		public static string FormatStaticProperty(string property)
		{
			string res = "_" + property.First().ToString().ToUpper() + property.Substring(1) + "NameID";
			return res.Replace(" ", "");
		}


		public static string GetTypeString1(ShaderPropertyType type)
		{
			switch(type)
			{
				case ShaderPropertyType.Range:
				case ShaderPropertyType.Float:
					return "float";
				case ShaderPropertyType.Texture:
					return "Texture2D";
				case ShaderPropertyType.Color:
					return "Color";
				case ShaderPropertyType.Vector:
					return "Vector4";
				default:
					return "";
			}
		}

		public static string GetTypeString2(ShaderPropertyType type)
		{
			switch(type)
			{
				case ShaderPropertyType.Range:
				case ShaderPropertyType.Float:
					return "Float";
				case ShaderPropertyType.Texture:
					return "Texture";
				case ShaderPropertyType.Color:
					return "Color";
				case ShaderPropertyType.Vector:
					return "Vector";
				default:
					return "";

			}
		}


		public static string FormatClass(string cls)
		{
			return $"{cls}ShaderWrapper";
		}

		public static string FormatDelta(string cls)
		{
			return $"{cls}ShaderDelta";
		}

		public static string FormatDeltaFlag(string cls)
		{
			return $"{cls}ShaderDeltaFlag";
		}


		public static string FormatInterface(string cls)
		{
			return "I" + FormatClass(cls);
		}


		public static string FormatEnum(string cls)
		{
			return $"{cls}Enum";
		}


		public string FormatClip(string state)
		{
			return state.Replace("_", ".");
		}

		public string GenerateWrapperCode()
		{
			if(string.IsNullOrEmpty(_name))
			{
			}

			var writer = new Writer
			{
				buffer = new StringBuilder()
			};


			// Usings.
			writer.WriteLine("using System; using Cirrus.Objects; using Cirrus.Content;");
			writer.WriteLine("using System.Collections;");
			writer.WriteLine("using System.Collections.Generic;");
			writer.WriteLine("using UnityEngine;");
			writer.WriteLine("");

			// Begin namespace.

			writer.WriteLine($"namespace {_namespace}");
			writer.BeginBlock();

			// Interface
			writer.WriteLine($"public interface {FormatInterface(_name)}");
			writer.BeginBlock();

			writer.WriteLine($"void Apply({FormatDelta(_name)} delta);");
			string endline = "";
			for(int i = 0; i < _shader.GetPropertyCount(); i++)
			{
				var name = _shader.GetPropertyDescription(i);
				if(name.StartsWith("Unity", true, CultureInfo.InvariantCulture)) continue;
				if(name.StartsWith("_", true, CultureInfo.InvariantCulture)) continue;
				var type = _shader.GetPropertyType(i);

				endline = $"{GetTypeString1(type)} {FormatProperty1(name)} {{ set; }}";
				writer.WriteLine(endline);
			}
			writer.EndBlock();

			// Delta Flags
			writer.WriteLine($"public enum {FormatDeltaFlag(_name)}");
			writer.BeginBlock();
			endline = "None = 0,";
			writer.WriteLine(endline);
			int idx = 0;
			for(int i = 0; i < _shader.GetPropertyCount(); i++)
			{
				var name = _shader.GetPropertyDescription(i);
				if(name.StartsWith("Unity", true, CultureInfo.InvariantCulture)) continue;
				if(name.StartsWith("_", true, CultureInfo.InvariantCulture)) continue;
				writer.WriteLine($"{FormatProperty2(name)} = 1 << {idx},");
				idx++;
			}
			writer.EndBlock();


			// Delta
			writer.WriteLine($"public class {FormatDelta(_name)}");
			writer.BeginBlock();
			writer.WriteLine($"public {FormatDeltaFlag(_name)} Flags {{get; set;}}");
			for(int i = 0; i < _shader.GetPropertyCount(); i++)
			{
				var name = _shader.GetPropertyDescription(i);
				if(name.StartsWith("Unity", true, CultureInfo.InvariantCulture)) continue;
				if(name.StartsWith("_", true, CultureInfo.InvariantCulture)) continue;

				var type = _shader.GetPropertyType(i);

				endline = $"private {GetTypeString1(type)} {name.FormatPublicField()};";
				writer.WriteLine(endline);

				endline = $"public {GetTypeString1(type)} {FormatProperty2(name)}" +
				$"{{ get => {name.FormatPublicField()}; " +
				$"set {{ {name.FormatPublicField()} = value; Flags |= {FormatDeltaFlag(_name)}.{FormatProperty2(name)}; }} }}";
				writer.WriteLine(endline);
			}
			writer.EndBlock();


			// Begin class.
			writer.WriteLine($"public class {FormatClass(_name)} : {FormatInterface(_name)}");
			writer.BeginBlock();


			writer.WriteLine($"private MaterialPropertyBlock _propertyBlock;");
			writer.WriteLine($"private Renderer _rend;");
			writer.WriteLine($"private static Shader _shader = null;");

			// Apply delta
			writer.WriteLine($"public void Apply({FormatDelta(_name)} delta)");
			writer.BeginBlock();
			for(int i = 0; i < _shader.GetPropertyCount(); i++)
			{
				var name = _shader.GetPropertyDescription(i);
				if(name.StartsWith("Unity", true, CultureInfo.InvariantCulture)) continue;
				if(name.StartsWith("_", true, CultureInfo.InvariantCulture)) continue;

				endline = $"if((delta.Flags & {FormatDeltaFlag(_name)}.{FormatProperty2(name)}) != 0) {FormatProperty1(name)} = delta.{FormatProperty2(name)};";
				writer.WriteLine(endline);
			}
			writer.EndBlock();


			// Properties
			for(int i = 0; i < _shader.GetPropertyCount(); i++)
			{
				var name = _shader.GetPropertyDescription(i);
				var type = _shader.GetPropertyType(i);
				if(name.StartsWith("Unity", true, CultureInfo.InvariantCulture)) continue;
				if(name.StartsWith("_", true, CultureInfo.InvariantCulture)) continue;

				endline = $"{{ set {{ if(_rend != null) {{ _rend.GetPropertyBlock(_propertyBlock);";
				string endline2 = $"_propertyBlock.Set{ GetTypeString2(type)}({FormatStaticProperty(name)}, value); ";
				string endline3 = $"_rend.SetPropertyBlock(_propertyBlock); }} }} }}";
				writer.WriteLine($"public {GetTypeString1(type)} {FormatProperty1(name)}" + endline + endline2 + endline3);
				writer.WriteLine($"private static int {FormatStaticProperty(name)};");
			}

			// Constructor
			writer.WriteLine($"public {FormatClass(_name)}(Renderer renderer)");
			writer.BeginBlock();
			writer.WriteLine("if(renderer==null)return;");
			writer.WriteLine("_rend = renderer;");
			writer.WriteLine("if(_shader == null)");
			// init Name Id props static field
			writer.BeginBlock();
			writer.WriteLine("_shader = _rend.material.shader;");
			for(int i = 0; i < _shader.GetPropertyCount(); i++)
			{
				var name = _shader.GetPropertyDescription(i);
				if(name.StartsWith("Unity", true, CultureInfo.InvariantCulture)) continue;
				if(name.StartsWith("_", true, CultureInfo.InvariantCulture)) continue;
				writer.WriteLine($"{FormatStaticProperty(name)} = _shader.GetPropertyNameId({i});");
			}
			writer.EndBlock();
			writer.WriteLine("_propertyBlock = new MaterialPropertyBlock();");

			writer.EndBlock();


			// End class
			writer.EndBlock();

			// End namespace
			writer.EndBlock();


			return writer.buffer.ToString();
		}

		private struct Writer
		{
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
					for(var n = 0; n < kSpacesPerIndentLevel; ++n)
						buffer.Append(' ');
				}
			}
		}

		public void GenerateWrapperFile()
		{
			string filePath = Path.GetDirectoryName(AssetDatabase.GetAssetPath(this));

			filePath += $"/{FormatClass(_name)}.gen.cs";

			// Generate code.
			var code = GenerateWrapperCode();

			// Write.
			File.WriteAllText(filePath, code);
		}

	}



	[CustomEditor(typeof(ShaderWrapperGenerator))]
	public class SomeScriptEditor : UnityEditor.Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			ShaderWrapperGenerator o = (ShaderWrapperGenerator)target;
			if(GUILayout.Button("Generate"))
			{
				o.GenerateWrapperFile();
				ProjectUtils.AddDefineSymbols($"{CodeGenUtils.DefinePrefix}{o.DefinePrefix}{ShaderWrapperGenerator.FormatClass(o._name).FormatDefine()}");
			}
		}
	}
}


#endif