using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    public static class TypeTool
    {
        public const BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        public static MethodInfo GetMethod(Type type, string name, params Type[] parameterTypes)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type), "Provided type is null.");
            
            if (parameterTypes == null || parameterTypes.Length == 0)
                return type.GetMethod(name, Flags);
            else
                return type.GetMethod(name, Flags, Type.DefaultBinder, parameterTypes, null);
        }

        public static MethodInfo GetMethod<T>(string name, params Type[] parameterTypes)
        {
            return GetMethod(typeof(T), name, parameterTypes);
        }

        public static PropertyInfo GetProperty<T>(string name)
        {
            return GetProperty(typeof(T), name);
        }

        public static PropertyInfo GetProperty(Type type, string name)
        {
            return type.GetProperty(name, Flags);
        }

        public static FieldInfo GetField<T>(string name)
        {
            return GetField(typeof(T), name);
        }

        public static FieldInfo GetField(Type type, string name)
        {
            return type.GetField(name, Flags);
        }

        public static EventInfo GetEvent<T>(string name)
        {
            return GetEvent(typeof(T), name);
        }

        public static EventInfo GetEvent(Type type, string name)
        {
            return type.GetEvent(name, Flags);
        }

        public static IList CreateListOfType(Type itemType)
        {
            Type listType = typeof(List<>).MakeGenericType(itemType);
            return (IList)Activator.CreateInstance(listType);
        }

        public static T CreateDelegate<T>(this MethodInfo method, object target) where T : Delegate
        {
            return (T)method.CreateDelegate(target);
        }

        public static T CreateStaticDelegate<T>(this MethodInfo method) where T : Delegate
        {
            return (T)method.CreateDelegate(typeof(T), null);
        }

        public static Delegate CreateDelegate(this MethodInfo methodInfo, object target)
        {
            Func<Type[], Type> getType;
            var isAction = methodInfo.ReturnType.Equals(typeof(void));
            var types = methodInfo.GetParameters().Select(p => p.ParameterType);

            if (isAction)
            {
                getType = Expression.GetActionType;
            }
            else
            {
                getType = Expression.GetFuncType;
                types = types.Concat(new[] { methodInfo.ReturnType });
            }

            if (methodInfo.IsStatic)
            {
                return Delegate.CreateDelegate(getType(types.ToArray()), methodInfo);
            }

            return Delegate.CreateDelegate(getType(types.ToArray()), target, methodInfo.Name);
        }

        public static Action<T> GetCreateMethodAction<T>(Type type, string name, object target)
        {
            return (Action<T>)GetMethod(type, name, typeof(T)).CreateDelegate(target);
        }

        public static Action<T1, T2> GetCreateMethodAction<T1, T2>(Type type, string name, object target)
        {
            return (Action<T1, T2>)GetMethod(type, name, typeof(T1), typeof(T2)).CreateDelegate(target);
        }

        public static Action<T1, T2, T3> GetCreateMethodAction<T1, T2, T3>(Type type, string name, object target)
        {
            return (Action<T1, T2, T3>)GetMethod(type, name, typeof(T1), typeof(T2), typeof(T3)).CreateDelegate(target);
        }

        public static Action<T1, T2, T3, T4> GetCreateMethodAction<T1, T2, T3, T4>(Type type, string name, object target)
        {
            return (Action<T1, T2, T3, T4>)GetMethod(type, name, typeof(T1), typeof(T2), typeof(T3), typeof(T4)).CreateDelegate(target);
        }


        public static Func<TResult> GetCreateMethodFunc<TResult>(Type type, string name, object target)
        {
            return (Func<TResult>)GetMethod(type, name).CreateDelegate(target);
        }

        public static Func<T, TResult> GetCreateMethodFunc<T, TResult>(Type type, string name, object target)
        {
            return (Func<T, TResult>)GetMethod(type, name, typeof(T)).CreateDelegate(target);
        }

        public static Func<T1, T2, TResult> GetCreateMethodFunc<T1, T2, TResult>(Type type, string name, object target)
        {
            return (Func<T1, T2, TResult>)GetMethod(type, name, typeof(T1), typeof(T2)).CreateDelegate(target);
        }

        public static Func<T1, T2, T3, TResult> GetCreateMethodFunc<T1, T2, T3, TResult>(Type type, string name, object target)
        {
            return (Func<T1, T2, T3, TResult>)GetMethod(type, name, typeof(T1), typeof(T2), typeof(T3)).CreateDelegate(target);
        }

        public static Func<T1, T2, T3, T4, TResult> GetCreateMethodFunc<T1, T2, T3, T4, TResult>(Type type, string name, object target)
        {
            return (Func<T1, T2, T3, T4, TResult>)GetMethod(type, name, typeof(T1), typeof(T2), typeof(T3), typeof(T4)).CreateDelegate(target);
        }
    } 
}
