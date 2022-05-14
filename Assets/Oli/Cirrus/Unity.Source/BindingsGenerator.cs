using Cirrus.Reflection;
using Cirrus.Source;
using Cirrus.Unity.Objects;
using System.Linq;
using System.Reflection;
using System.Text;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;
using System.IO;
using Cirrus.Collections;

namespace Cirrus.Unity.Source
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class GenerateBindingsAttribute : Attribute
    {
        public GenerateBindingsAttribute()
        {
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class BindingsGeneratorAttribute : Attribute
    {
        public BindingsGeneratorAttribute()
        {
        }
    }

    public class BindingsGeneratorUtils
    {
        [MenuItem("Assets/Cirrus.Unity/Source/Generate Bindings", priority = PackageUtils.MenuItemPackagePriority)]
        public static void GenerateBindings()
        {
            Type type = null;
            foreach (Object o in Selection.objects)
            {
                foreach (var self in o.Simplify<Object>())
                {
                    MonoScript script = null;
                    if (typeof(MonoBehaviourBase).IsAssignableFrom(self.GetType()))
                    {
                        script = MonoScript.FromMonoBehaviour((MonoBehaviourBase)self);
                    }
                    else if (typeof(ScriptableObjectBase).IsAssignableFrom(self.GetType()))
                    {
                        script = MonoScript.FromScriptableObject((ScriptableObjectBase)self);
                    }

                    type = self.GetType();
                    var methods = type.GetMethods();
					System.Collections.Generic.List<Tuple<Type, object>> values = new System.Collections.Generic.List<Tuple<Type, object>>();
                    Dictionary<Type, MethodInfo> generatorMethods = new Dictionary<Type, MethodInfo>();
                    HashSet<string> namespaces = new HashSet<string>();
                    foreach (var method in methods)
                    {
                        if (method.GetCustomAttributes(typeof(BindingsGeneratorAttribute), false).Length == 0) continue;
                        var parameters = method.GetParameters();
                        if (parameters.Length == 0) continue;
                        if (!parameters[0].ParameterType.IsGenericType) continue;
                        Type[] generics = parameters[0].ParameterType.GetGenericArguments();
                        if (generics.Length == 0) continue;
                        generatorMethods.Add(generics[0], method);
                    }

                    var fields = type.GetFields();
                    Type elemType = null;
                    foreach (var field in fields)
                    {
                        if (field.GetCustomAttributes(typeof(GenerateBindingsAttribute), false).Length == 0) continue;
                        
                        if (field.FieldType.IsArray)
                        {
                            elemType = field.FieldType.GetElementType();
                            values.Add(Tuple.Create(elemType, field.GetValue(self)));
                        }
                        else if (field.FieldType.IsGenericType && field.FieldType.GetGenericClassName() == "List")
                        {
                            elemType = field.FieldType.GetGenericArguments()[0];
                            values.Add(Tuple.Create(elemType, field.GetValue(self)));
                        }

                        if (elemType != null) namespaces.Add(elemType.Namespace);
                    }
                    var props = type.GetProperties();
                    foreach (var prop in props)
                    {
                        if (prop.GetCustomAttributes(typeof(GenerateBindingsAttribute), false).Length == 0) continue;
                        
                        if (prop.PropertyType.IsArray)
                        {
                            elemType = prop.PropertyType.GetElementType();
                            values.Add(Tuple.Create(elemType, prop.GetValue(self)));
                        }
                        else if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericClassName() == "List")
                        {
                            elemType = prop.PropertyType.GetGenericArguments()[0];
                            values.Add(Tuple.Create(elemType, prop.GetValue(self)));
                        }

                        if (elemType != null) namespaces.Add(elemType.Namespace);
                    }

                    Writer writer = new Writer { buffer = new StringBuilder() };
                    writer.Write($@"
                    using System.Collections.Generic;
                    using System.Threading.Tasks;
                    using UnityEditor;
                    using UnityEngine;
                    using Object = UnityEngine.Object;
                    ");
                    foreach (var ns in namespaces)
                    {
                        writer.WriteLine($"using {ns};");
                    }
                    foreach (var value in values)
                    {
                        if (generatorMethods.TryGetValue(value.Item1, out MethodInfo method))
                        {
                            method.Invoke(self, new object[] { value.Item2, writer });
                        }
                    }

                    var scriptType = script.GetClass();
                    string path  = AssetDatabase.GetAssetPath(script);
                    string filePath = $"{Path.GetDirectoryName(AssetDatabase.GetAssetPath(script))}/{scriptType.Name}.gen.cs";

                    File.WriteAllText(filePath, writer.buffer.ToString());
                    AssetDatabase.Refresh();
                }
            }
        }
    }
}
