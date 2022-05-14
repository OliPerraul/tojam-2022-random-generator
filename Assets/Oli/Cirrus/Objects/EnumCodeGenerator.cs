//#if UNITY_EDITOR

//using UnityEngine;
//using System.Collections;
//using UnityEditor;
//using System.Text;
//using System.IO;
//using System.Linq;
//using UnityEngine.Rendering;
//using Cirrus.UnityIdentifications;
//using Cirrus.Objects;

//namespace Cirrus.Materials
//{
//	public class EnumCodeGenerator : ScriptableObject
//	{

//		private const int kSpacesPerIndentLevel = 4;

//		[SerializeField]
//		private LibraryAssetBase _lib;

//		[SerializeField]
//		private string _name;

//		[SerializeField]
//		private string _namespace;

//		public string FormatClass(string cls)
//		{
//			return $"{cls}";
//		}

//		public string FormatEnumField(string state)
//		{			
//			state = state.Replace("." , "_");
//			state = state.Replace(" " , "_");
//			return state;
//		}

//		public string GenerateWrapperCode()
//		{
//			var writer = new Writer
//			{
//				buffer = new StringBuilder()
//			};


//			if(_lib == null) return "";

//			_lib.Load();

//			writer.WriteLine("using System; using Cirrus.Objects;");
//			writer.WriteLine("using System.Collections;");
//			writer.WriteLine("using System.Collections.Generic;");
//			writer.WriteLine("using UnityEngine;");
//			writer.WriteLine("");

//			// Begin namespace.

//			writer.WriteLine($"namespace {_namespace}");
//			writer.BeginBlock();

//			// Enum
//			writer.WriteLine($"public enum {FormatClass(_name)}");
//			writer.BeginBlock();
//			foreach(var res in _lib.Resources)
//			{
//				string endline = $"{FormatEnumField(res.Identifier)} = {res.FindID()},";
//				writer.WriteLine(endline);
//			}
//			writer.EndBlock();



//			// End namespace
//			writer.EndBlock();


//			return writer.buffer.ToString();
//		}

//		private struct Writer
//		{
//			public StringBuilder buffer;
//			public int indentLevel;

//			public void BeginBlock()
//			{
//				WriteIndent();
//				buffer.Append("{\n");
//				++indentLevel;
//			}

//			public void EndBlock()
//			{
//				--indentLevel;
//				WriteIndent();
//				buffer.Append("}\n");
//			}

//			public void WriteLine()
//			{
//				buffer.Append('\n');
//			}

//			public void WriteLine(string text)
//			{
//				WriteIndent();
//				buffer.Append(text);
//				buffer.Append('\n');
//			}

//			public void Write(string text)
//			{
//				buffer.Append(text);
//			}

//			public void WriteIndent()
//			{
//				for(var i = 0; i < indentLevel; ++i)
//				{
//					for(var n = 0; n < kSpacesPerIndentLevel; ++n)
//						buffer.Append(' ');
//				}
//			}
//		}

//		public void GenerateWrapperFile()
//		{
//			string filePath = Path.GetDirectoryName(AssetDatabase.GetAssetPath(this));

//			filePath += $"/{FormatClass(_name)}.cs";

//			// Generate code.
//			var code = GenerateWrapperCode();

//			// Write.
//			File.WriteAllText(filePath , code);
//		}

//	}



//	[CustomEditor(typeof(EnumCodeGenerator))]
//	public class SomeScriptEditor2 : Editor
//	{
//		public override void OnInspectorGUI()
//		{
//			DrawDefaultInspector();

//			EnumCodeGenerator myScript = (EnumCodeGenerator)target;
//			if(GUILayout.Button("Generate"))
//			{
//				myScript.GenerateWrapperFile();
//			}
//		}
//	}
//}


//#endif