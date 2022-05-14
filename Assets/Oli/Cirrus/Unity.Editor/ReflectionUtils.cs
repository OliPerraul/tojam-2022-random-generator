using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cirrus.Unity.Editor
{
	public static class ReflectionUtils
	{
        const String BackingFieldPrefix = "<";
        const String BackingFieldSuffix = ">k__BackingField";

        public static String GetBackingFieldName(String propertyName) => $"{BackingFieldPrefix}{propertyName}{BackingFieldSuffix}";

        public static String GetAutoPropertyName(String fieldName)
        {
            var match = Regex.Match(fieldName, $"{BackingFieldPrefix}(.+?){BackingFieldSuffix}");
            return match.Success ? match.Groups[1].Value : null;
        }

        //public static Boolean IsAnAutoProperty(this PropertyInfo propertyInfo) => propertyInfo.GetBackingField() != null;

        public static Boolean IsBackingFieldOfAnAutoProperty(this FieldInfo propertyInfo) => propertyInfo.GetAutoProperty() != null;

        internal static FieldInfo GetBackingField(this PropertyInfo propertyInfo, Type source, BindingFlags bindingFlags)
        {
            FieldInfo fInfo = null;
            var typeStack = new Stack<Type>();
            typeStack.Push(source);

            while (typeStack.Any())
            {
                var type = typeStack.Pop();
                fInfo = type.GetField($"<{propertyInfo.Name}>k__BackingField", bindingFlags);

                if (fInfo != null || type.BaseType == null || type.BaseType == typeof(object))
                    break;

                typeStack.Push(type.BaseType);
            }
            return fInfo;
        }

        //public static FieldInfo GetBackingField(this PropertyInfo propertyInfo)
        //{
        //    if (propertyInfo == null)
        //        throw new ArgumentNullException(nameof(propertyInfo));
        //    if (!propertyInfo.CanRead || !propertyInfo.GetGetMethod(nonPublic: true).IsDefined(typeof(CompilerGeneratedAttribute), inherit: true))
        //        return null;
        //    var backingFieldName = GetBackingFieldName(propertyInfo.Name);
        //    var backingField = propertyInfo.DeclaringType?.GetField(backingFieldName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        //    if (backingField == null)
        //        return null;
        //    if (!backingField.IsDefined(typeof(CompilerGeneratedAttribute), inherit: true))
        //        return null;
        //    return backingField;
        //}

        public static PropertyInfo GetAutoProperty(this FieldInfo fieldInfo)
        {
            if (fieldInfo == null)
                throw new ArgumentNullException(nameof(fieldInfo));
            if (!fieldInfo.IsDefined(typeof(CompilerGeneratedAttribute), inherit: true))
                return null;
            var autoPropertyName = GetAutoPropertyName(fieldInfo.Name);
            if (autoPropertyName == null)
                return null;
            var autoProperty = fieldInfo.DeclaringType?.GetProperty(autoPropertyName);
            if (autoProperty == null)
                return null;
            if (!autoProperty.CanRead || !autoProperty.GetGetMethod(nonPublic: true).IsDefined(typeof(CompilerGeneratedAttribute), inherit: true))
                return null;
            return autoProperty;
        }
        public static List<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class, IComparable<T>
        {
            List<T> objects = new List<T>();
            foreach (Type type in
                Assembly.GetAssembly(typeof(T)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            objects.Sort();
            return objects;
        }

        public static int CountOfType<T>() where T : class, IComparable<T>
        {
            //List<T> objects = new List<T>();
            int count = 0;
            foreach (Type type in
                Assembly.GetAssembly(typeof(T)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                count++;
                //objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            //objects.Sort();
            //return objects;
            return count;
        }
        public static int CountOfType(Type baseType)
        {
            //List<T> objects = new List<T>();
            int count = 0;
            foreach (Type type in
                Assembly.GetAssembly(baseType).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(baseType)))
            {
                count++;
                //objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            //objects.Sort();
            //return objects;
            return count;
        }
    }
}
