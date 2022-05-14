//using Cirrus.Unity.Numerics;
using System;
using System.Reflection;

namespace Cirrus.Reflection
{
	public static class ReflectionUtils
	{
		private static void RecurseUpdate(this object obj, object prototype)
		{
			var membs = obj.GetType().GetMembers();
			foreach(MemberInfo memb in membs)
			{
				if(!(memb is PropertyInfo || memb is FieldInfo)) continue;

				if(memb is PropertyInfo)
				{
					PropertyInfo prop = (PropertyInfo)memb;

					if(!prop.CanWrite) continue;
					if(prop.PropertyType.IsEnum) continue;
					if(prop.PropertyType.Namespace.StartsWith("System")) continue;
					if(prop.PropertyType.Namespace.StartsWith("UnityEngine")) continue;
					//if (prop.PropertyType.IsAssignableFrom(typeof(Numerical))) continue;
					//if (prop.PropertyType.IsAssignableFrom(typeof(Range))) continue;

					var propValue = prop.GetValue(obj);
					var prototypeValue = prop.GetValue(prototype);

					if(propValue == null && prototypeValue != null)
					{
						prop.SetValue(obj, prototypeValue);
					}
					else if(propValue != null && prototypeValue != null)
					{
						RecurseUpdate(propValue, prototypeValue);
					}
				}
				else if(memb is FieldInfo)
				{
					FieldInfo field = (FieldInfo)memb;

					if(field.IsPrivate) continue;
					if(field.FieldType.IsEnum) continue;
					if(field.FieldType.Namespace.StartsWith("System")) continue;
					if(field.FieldType.Namespace.StartsWith("UnityEngine")) continue;
					//if (field.FieldType.IsAssignableFrom(typeof(Numerical))) continue;
					//if (field.FieldType.IsAssignableFrom(typeof(Range))) continue;

					var propValue = field.GetValue(obj);
					var prototypeValue = field.GetValue(prototype);
					if(propValue == null && prototypeValue != null)
					{
						field.SetValue(obj, prototypeValue);
					}
					else if(propValue != null && prototypeValue != null)
					{
						RecurseUpdate(propValue, prototypeValue);
					}
				}
			}
		}
		public static string GetGenericClassName(this Type t)
		{
			if (!t.IsGenericType)
				return t.Name;
			string genericTypeName = t.GetGenericTypeDefinition().Name;
			genericTypeName = genericTypeName.Substring(0,
				genericTypeName.IndexOf('`'));
			return genericTypeName;
		}
		public static void ReflectionUpdate(this object obj, object prototype)
		{
			RecurseUpdate(obj, prototype);
		}
		//// Return a list of an enumerated type's values.
		//private List<string> GetEnumValues<T>()
		//{
		//	// Get the type's Type information.
		//	Type t_type = typeof(T);

		//	// Enumerate the Enum's fields.
		//	FieldInfo[] field_infos = t_type.GetFields();

		//	// Loop over the fields.
		//	List results = new List();
		//	foreach (FieldInfo field_info in field_infos)
		//	{
		//		// See if this is a literal value (set at compile time).
		//		if (field_info.IsLiteral)
		//		{
		//			// Add it.
		//			T value = (T)field_info.GetValue(null);
		//			results.Add(value);
		//		}
		//	}

		//	return results;
		//}
	}
}