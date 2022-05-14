#if UNITY_EDITOR

using Cirrus.Objects;
using Cirrus.Source;
using System;
using System.Collections.Generic;
using System.Text;
using static Cirrus.Source.CodeGenUtils;
using System.IO;
using UnityEditor;
using Cirrus.Content;
using Cirrus.Unity.Objects.Libraries;
using System.Linq;
using System;
using Object = UnityEngine.Object;

namespace Cirrus.Content
{
	// TODO Put in #if CIRRUS_MY_GEN_FILE in the gened files

	// TODO: unity addressable
	// Forgo load step..

	// TODO: Just index library by id instead of caching
	public enum GeneratorFlags
	{
		None,
		WriteAsStaticProps = 1 << 0,
		// Put asset files into seperate "Assets" class
		AssetClassScope = 1 << 1,
		GenerateStaticFieldFiles = 1 << 2,
		//WriteAsStaticProps = 1 << 1
	}

	public partial class LibraryCodeGenerator
	{
		//private static string EName = "Id";

		private static string IDSuffix = "ID";

		private static string AssetsClassName = "Assets";

		private static string UnknownEnumEntryName = "Unknown";

		private static string GetNamespace(ILibrary lib)
		{
			return lib.GetType().Namespace;
		}

		public static string FormatClass(string cls) => $"{cls}";

		private static void WritePropertyCode(Writer writer, CodeGenEntry entry, bool writeStatic)
		{
			writer.WriteLine(NonSerializedAttr);

			string scope = entry.Options.Intersects(CodeGenOptions.PrivateProperty) ? "private" : "public";
			string propertyName = entry.Options.Intersects(CodeGenOptions.PrivateProperty) ? entry.Name.FormatPrivateProperty() : entry.Name.FormatPublicProperty();
			string internalPropertyName = entry.Name.FormatSecretPrivateProperty();
			string privateFieldName = entry.Name.FormatSecretPrivateField();

			string typeName = entry.TypeName;
			writer.WriteLine($"private {typeName} {privateFieldName} = null;");			
			writer.WriteLine($"{scope} {typeName} {(writeStatic ? internalPropertyName : propertyName)} => {privateFieldName} == null ?");
			writer.WriteIndent();
			//writer.WriteLine($"{privateFieldName} = ({typeName})_dictionary[(int){EnumName}.{fieldName}] :");			
			writer.WriteLine($"{privateFieldName} = Get<{typeName}>((int)ID.{entry.Name.FormatPublicProperty()}) :");
			writer.WriteIndent();			
			writer.WriteLine($"{privateFieldName};");
			// static
			if(writeStatic)
			{
				writer.WriteLine($"{scope} static {typeName} {propertyName} => Instance.{internalPropertyName};");
			}
		}

		private static void WritePropertyCode2(Writer writer, CodeGenEntry entry, bool writeStatic)
		{
			writer.WriteLine(NonSerializedAttr);

			string scope = entry.Options.Intersects(CodeGenOptions.PrivateProperty) ? "private" : "public";
			string propertyName = entry.Options.Intersects(CodeGenOptions.PrivateProperty) ? entry.Name.FormatPrivateProperty() : entry.Name.FormatPublicProperty();
			string internalPropertyName = entry.Name.FormatSecretPrivateProperty();
			string privateFieldName = entry.Name.FormatSecretPrivateField();

			string typeName = entry.TypeName;
			writer.WriteLine($"private static {typeName} {privateFieldName} = null;");
			writer.WriteLine($"{scope} static {typeName} {(writeStatic ? internalPropertyName : propertyName)} => {privateFieldName} == null ?");
			writer.WriteIndent();
			//writer.WriteLine($"{privateFieldName} = ({typeName})_dictionary[(int){EnumName}.{fieldName}] :");			
			writer.WriteLine($"{privateFieldName} = Instance.Get<{typeName}>((int)ID.{entry.Name.FormatPublicProperty()}) :");
			writer.WriteIndent();
			writer.WriteLine($"{privateFieldName};");
			// static
			if(writeStatic)
			{
				writer.WriteLine($"{scope} static {typeName} {propertyName} => {internalPropertyName};");
			}
		}

		private static void WriteStaticContentPropertyCode(Writer writer, CodeGenEntry entry)
		{
			//string propertyName = entry.Name.FormatProperty();
			////string typeName = entry.TypeName;
			//if(typeof(IResourceProvider).IsAssignableFrom(entry.Type))
			//{
			//	// TODO: Check lazy
			//	// TODO: Check attribute
			//	Type[] generics = entry.Type.GetGenericArguments();
			//	if(generics.Length == 2)
			//	{					
			//		if(
			//			generics[0].IsAssignableFrom(typeof(int)) ||
			//			generics[1].IsEnum
			//			)
			//		{
			//			string enumField = entry.Name.FormatEnumField(true);
			//			writer.WriteLine($"{propertyName}.Input = (int)ID.{enumField};");
			//		}
			//	}
			//}

			string propertyName = entry.Name.FormatPublicProperty();
			string enumName = Disambiguate(entry.Name.FormatPublicProperty());
			string internalPropertyName = Disambiguate(entry.Name.FormatSecretPrivateProperty());
			string privateFieldName = Disambiguate(entry.Name.FormatSecretPrivateField());

			string typeName = entry.TypeName;

			//if(typeof(IProvider).IsAssignableFrom(entry.Type))
			//{
			//	Type[] generics = entry.Type.GetGenericArguments();
			//	if(generics.Length != 0)
			//	{
			//		typeName = generics[0].FullName;
			//	}
			//}

			writer.WriteLine($"private static {typeName} {privateFieldName} = null;");
			writer.WriteLine($"private static {typeName} {internalPropertyName} => {privateFieldName} == null ?");
			writer.WriteIndent();
			//writer.WriteLine($"{privateFieldName} = ({typeName})_dictionary[(int){EnumName}.{fieldName}] :");			
			writer.WriteLine($"{privateFieldName} = Instance.Get<{typeName}>((int)ID.{enumName}) :");
			writer.WriteIndent();
			writer.WriteLine($"{privateFieldName};");
			// static			
			
			writer.WriteLine($"public static {typeName} {propertyName} => {internalPropertyName};");
			
		}

		//private static void WriteAltPropertyCode(Writer writer, EntryInfo entry)
		//{
		//	writer.WriteLine(CodeGenUtils.NonSerializedAttr);			
		//	writer.WriteLine($"private {entry.TypeName} {entry.Name.FormatPrivateField()} = null;");
		//	writer.WriteLine($"public {entry.TypeName} {(writeStatic ? "_" : "")}{entry.Name.FormatProperty()} => {entry.Name.FormatPrivateField()} == null ?");
		//	writer.WriteIndent();
		//	//writer.WriteLine($"{privateFieldName} = ({typeName})_dictionary[(int){EnumName}.{fieldName}] :");			
		//	writer.WriteLine($"{entry.Name.FormatPrivateField()} = Get<{entry.TypeName}>((int)ID.{entry.Name}) :");
		//	writer.WriteIndent();
		//	writer.WriteLine($"{entry.Name.FormatPrivateField()};");
		//	// static
		//	if(writeStatic)
		//	{
		//		writer.WriteLine($"public static {entry.TypeName} {entry.Name.FormatProperty()} => Instance._{entry.Name.FormatProperty()};");
		//	}
		//}

		public static void ProcessStaticEntry(List<CodeGenEntry> staticEntries, System.Reflection.MemberInfo p, Type memberType)
		{
			//if(!typeof(IProvider).IsAssignableFrom(memberType)) return;
			//if(p.GetCustomAttributes(typeof(GenerateCodeAttribute), false).Length == 0) return;

			//Type underlyingType = null;
			//if(typeof(IProvider).IsAssignableFrom(memberType))
			//{
			//	Type[] generics = memberType.GetGenericArguments();
			//	if(generics.Length != 0)
			//	{
			//		underlyingType = generics[0];
			//	}
			//}

			//staticEntries.Add(new CodeGenEntry
			//{
			//	Name = p.Name,
			//	Type = memberType,
			//	UnderlyingType = underlyingType
			//});
		}


		public static string GenerateCode(
			ILibrary library,
			GeneratorFlags flags,
			Action<ILibrary, Writer, IEnumerable<CodeGenEntry>> generateCustomClassCode = null,
			Action<ILibrary, Writer, IEnumerable<CodeGenEntry>> generateCustomLoadCode = null,
			Action<ILibrary, Writer, IEnumerable<CodeGenEntry>> generateCustomCode = null
			)
		{						
			library.Clear();
			library.Load();

			var writer = new Writer
			{
				buffer = new StringBuilder()
			};

			string className = library.GetType().Name;

			// collect fields
			List<CodeGenEntry> entries = new List<CodeGenEntry>();
			Dictionary<string, List<CodeGenEntry>> categories = new Dictionary<string, List<CodeGenEntry>>();
			foreach(var pair in library.__EditorObjects)
			{
				__LibraryLoadObject loadEntry = pair.Value;
				var obj = loadEntry.Object;
				entries.Add(new CodeGenEntry
				{
					Name = pair.Key,
					Namespace = obj.GetType().Namespace,
					TypeName = obj.GetType().Name,
					Type = obj.GetType(),
					Options = loadEntry.CodeGenOptions
				}); ;
			}

			// Sort by name
			entries.Sort((x, y) => x.Name.CompareTo(y.Name));

			//writer.WriteLine($"#define {(_lib.GetType().Namespace.Replace(".","")+_lib.GetType().Name).FormatDefine()}_GENERATED");
			writer.WriteLine("using System.Collections;");
			writer.WriteLine("using System.Collections.Generic;");
			writer.WriteLine("using UnityEngine;");
			writer.WriteLine("using Cirrus.Unity.Animations;");
			writer.WriteLine("using Cirrus.Objects;");
			List<string> usings = new List<string>();
			foreach(var entry in entries)
			{
				var ns = entry.Type.Namespace;
				if(!usings.Contains(ns))
				{
					writer.WriteLine($"using {entry.Type.Namespace};");
					usings.Add(ns);
				}
			}
			writer.WriteLine();

			// Begin namespace.

			writer.WriteLine($"namespace {GetNamespace(library)}");
			writer.BeginBlock();

			string endline;

			// Partial class (field access)
			writer.WriteLine($"public partial class {FormatClass(className)}");
			writer.BeginBlock();
			// Enum
			writer.WriteLine(CodeGenUtils.SerializableAttr);
			writer.WriteLine($"public enum {FormatClass(IDSuffix)} : int");
			writer.BeginBlock();
			endline = $"{$"{UnknownEnumEntryName}".FormatPublicProperty()} = {-1},";
			writer.WriteLine(endline);
			foreach(var res in entries)
			{
				endline = $"{res.Name.FormatPublicProperty()},";
				writer.WriteLine(endline);
			}
			// Enum static class
			List<CodeGenEntry> staticEntries = new List<CodeGenEntry>();
			Type type = library.GetType();
			foreach(var p in type.GetProperties(
				System.Reflection.BindingFlags.Static |
				System.Reflection.BindingFlags.NonPublic |
				System.Reflection.BindingFlags.Public
				))
			{
				ProcessStaticEntry(staticEntries, p, p.PropertyType);
			}

			foreach(var p in type.GetFields(
				System.Reflection.BindingFlags.Static |
				System.Reflection.BindingFlags.NonPublic |
				System.Reflection.BindingFlags.Public
				))
			{
				ProcessStaticEntry(staticEntries, p, p.FieldType);
			}

			staticEntries.Sort((x, y) => x.Name.CompareTo(y.Name));
			foreach(var entry in staticEntries)
			{
				writer.WriteLine($"{Disambiguate(entry.Name.FormatPublicProperty())},");
			}

			writer.EndBlock();


			// Properties
			writer.WriteLine();

			if(flags.Intersects(GeneratorFlags.AssetClassScope))
			{
				writer.WriteLine($"public static partial class {FormatClass(AssetsClassName)}");
				writer.BeginBlock();
			}
			foreach(var entry in entries)
			{
				if(flags.Intersects(GeneratorFlags.AssetClassScope))
					WritePropertyCode2(writer, entry, flags.Intersects(GeneratorFlags.WriteAsStaticProps));
				else
					WritePropertyCode(writer, entry, flags.Intersects(GeneratorFlags.WriteAsStaticProps));

				writer.WriteLine();
			}
			if(flags.Intersects(GeneratorFlags.AssetClassScope))
			{
				writer.EndBlock();
			}
			// Static
			/*
			 *         protected override bool _Get<ResourceType>(int key, out ResourceType res)
        {
            res = null;
            switch((ID)key)
            {
                case ID.Modifier_Hidden:
                    res = (ResourceType) (object) ModifierContentUtils.Modifier_Hidden.Resource;
                    return true;
                case ID.Modifier_ModifierBase:
                    res = (ResourceType)(object)ModifierContentUtils.Modifier_ModifierBase.Resource;
                    return true;

                default: return false;
            }
        }
			 * 
			 */
			if(staticEntries.Count != 0)
			{				
				//writer.WriteLine();
				writer.WriteLine($"public override bool _Get<ResourceType>(int key, out ResourceType res)");
				writer.BeginBlock();
				writer.WriteLine($"res = null;");
				writer.WriteLine($"switch((ID)key)");
				writer.BeginBlock();
				writer.WriteLine($"\t// TODO: remove");
				//foreach(var entry in staticEntries)
				//{
				//	string enumField = Disambiguate(entry.Name.FormatPublicProperty());
				//	writer.WriteLine($"case ID.{enumField}:");
				//	writer.WriteLine($"\tres = (ResourceType) (object) {entry.Name}.Object;");
				//	// TODO: Only write code line if assignable from IIDed here
				//	if(typeof(IResourceProvider).IsAssignableFrom(entry.Type))
				//	{
				//		Type[] generics = entry.Type.GetGenericArguments();
				//		if(generics.Length != 0 && typeof(IIDed).IsAssignableFrom(generics[0]))
				//		{
				//			writer.WriteLine($"\t(({nameof(IIDed)})res).{nameof(IIDed.ContentID)} = (int)ID.{enumField};");
				//		}
				//	}
				//	writer.WriteLine($"\treturn true;");
				//}
				writer.WriteLine($"default: return false;");
				writer.EndBlock();
				writer.EndBlock();

				writer.WriteLine();
				foreach(var entry in staticEntries)
				{
					WriteStaticContentPropertyCode(writer, entry);					
				}				
			}

			// Custom class code
			generateCustomClassCode?.Invoke(library, writer, entries);

			// Load code
			writer.WriteLine($"protected override void _CustomLoad()");
			writer.BeginBlock();
			generateCustomLoadCode?.Invoke(library, writer, entries);
			writer.EndBlock();
			writer.EndBlock();

			// End namespace
			writer.EndBlock();
			generateCustomCode?.Invoke(library, writer, entries);


			if(flags.Intersects(GeneratorFlags.GenerateStaticFieldFiles))
			{

				// Write static field files
				string usingString =
				string.Join(
					"\n",
					usings.Select(s => $"using {s};")
				);
				Type libType = library.GetType();

				string dir = Path.GetDirectoryName(AssetDatabase.GetAssetPath((Object)library)) + $"/_Generated";
				System.IO.Directory.CreateDirectory(dir);

				foreach(var entry in staticEntries)
				{
					string staticEntryClassName = entry.Name.FormatPublicProperty();

					File.WriteAllText(
						dir + $"/{staticEntryClassName.FormatGeneratedClassName()}.cs",
						LibraryUtils.ScriptTemplate_GeneratedClass(
							usingString,
							entry.UnderlyingType.Name,
							libType.Name,
							staticEntryClassName,
							libType.Namespace));
				}
			}			

			return writer.buffer.ToString();
		}
	}
}

#endif