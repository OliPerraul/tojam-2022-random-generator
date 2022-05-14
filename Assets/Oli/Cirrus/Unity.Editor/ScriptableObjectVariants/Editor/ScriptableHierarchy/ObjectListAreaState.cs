using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    internal class ObjectListAreaState
    {
        private static Type _type = EditorTypeTool.GetEditorType("ObjectListAreaState");

        private static FieldInfo _gridSizeInfo = TypeTool.GetField(_type, "m_GridSize");
        
        public object Instance { get; private set; }

        public int GridSize
        {
            get { return (int)_gridSizeInfo.GetValue(Instance); }
            set { _gridSizeInfo.SetValue(Instance, value); }
        }

        public ObjectListAreaState()
        {
            Instance = Activator.CreateInstance(_type);
        }
    }
}
