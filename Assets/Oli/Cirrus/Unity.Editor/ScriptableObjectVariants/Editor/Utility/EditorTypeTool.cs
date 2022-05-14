using System;
using System.Reflection;
using UnityEngine;
using UnityEditor;
using Object = UnityEngine.Object;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    public static class EditorTypeTool
    {
        public static readonly Assembly EditorAssembly = typeof(EditorWindow).Assembly;

        private static Func<Type, bool, Type> _findCustomEditorTypeByType; 

        public static Type GetEditorType(string name)
        {
            if (!name.StartsWith("UnityEditor."))
                name = "UnityEditor." + name;

            return EditorAssembly.GetType(name);
        }

        internal static Type FindCustomEditorTypeByType(Type objectType, bool multiEdit)
        {
            if (_findCustomEditorTypeByType == null)
            {
                _findCustomEditorTypeByType =
                    TypeTool.GetCreateMethodFunc<Type, bool, Type>(GetEditorType("CustomEditorAttributes"), "FindCustomEditorTypeByType", null);
            }

            return _findCustomEditorTypeByType(objectType, multiEdit);
        }

        internal static bool DoesCustomEditorOverrideHeader(Object target)
        {
            var editorType = FindCustomEditorTypeByType(target.GetType(), false);
            if (editorType == null)
                return false;

            var headerMethod = TypeTool.GetMethod(editorType, "OnHeaderGUI");
            return headerMethod.DeclaringType != typeof(UnityEditor.Editor);
        }
    }
}
