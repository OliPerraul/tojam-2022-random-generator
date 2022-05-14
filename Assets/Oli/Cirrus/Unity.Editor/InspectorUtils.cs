using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//using UnityEditor;

namespace Cirrus.Unity.Editor
{
	public static class InspectorUtils
	{
		public const string Delim = "----------------------------";
		public const int HeaderPriority = 0;
		public const int DelimPriority = 100;
		
		// TODO: look at scriptable object variant
		public static FieldInfo GetFieldViaPath(Type type, string path)
		{
			var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
			var parent = type;

			FieldInfo fi = null;

			//if (path.Contains("Backing"))
			//{
			//	string propName = ReflectionUtils.GetAutoPropertyName(path);
			//	PropertyInfo prop = type.GetProperty(propName, flags);
			//	fi = ReflectionUtils.GetBackingField(prop);
			//}
			//else
			{
				fi = parent.GetField(path, flags);
			}

			if (fi == null) return null;

			var paths = path.Split('.');

			for (int i = 0; i < paths.Length; i++)
			{
				//if (paths[i].Contains("Backing"))
				//{
				//	string propName = ReflectionUtils.GetAutoPropertyName(paths[i]);
				//	PropertyInfo prop = type.GetProperty(propName, flags);
				//	fi = ReflectionUtils.GetBackingField(prop);
				//}
				//else
				{
					fi = parent.GetField(paths[i], flags);
				}

				if (fi == null) return null;

				// there are only two container field type that can be serialized:
				// Array and List<T>
				if (fi.FieldType.IsArray)
				{
					parent = fi.FieldType.GetElementType();
					i += 2;
					continue;
				}

				if (fi.FieldType.IsGenericType)
				{
					parent = fi.FieldType.GetGenericArguments()[0];
					i += 2;
					continue;
				}

				if (fi != null)
				{
					parent = fi.FieldType;
				}
				else
				{
					return null;
				}

			}

			return fi;
		}

	}
}
