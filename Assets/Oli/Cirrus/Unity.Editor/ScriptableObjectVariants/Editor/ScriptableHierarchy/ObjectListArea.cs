using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEditor;


namespace Cirrus.Unity.ScriptableObjectVariants
{
    internal class ObjectListArea
    {
        private static Type _type = EditorTypeTool.GetEditorType("UnityEditor.ObjectListArea");
        private static Type _searchFilterType = EditorTypeTool.GetEditorType("SearchFilter");

        private static PropertyInfo _objectSelectedCallbackInfo = TypeTool.GetProperty(_type, "objectSelectedCallback");
        private static PropertyInfo _allowDeselectionInfo = TypeTool.GetProperty(_type, "allowDeselection");
        private static PropertyInfo _allowMultiSelectInfo = TypeTool.GetProperty(_type, "allowMultiSelect");
        private static PropertyInfo _allowRenamingInfo = TypeTool.GetProperty(_type, "allowRenaming");
        private static PropertyInfo _allowBuiltinResourcesInfo = TypeTool.GetProperty(_type, "allowBuiltinResources");
        private static PropertyInfo _gridSizeInfo = TypeTool.GetProperty(_type, "gridSize");

        private static MethodInfo _initInfo;
        
        private Action<Rect, int> _onGUI;
        private Action<int[]> _showObjectsInList;
        private Func<int[]> _getSelection;
        private object _instance;

        // Bool = double-clicked.
        public Action<bool> ObjectSelectedCallback
        {
            get { return (Action<bool>)_objectSelectedCallbackInfo.GetValue(_instance); }
            set { _objectSelectedCallbackInfo.SetValue(_instance, value); }
        }

        public bool AllowDeselection
        {
            get { return (bool)_allowDeselectionInfo.GetValue(_instance); }
            set { _allowDeselectionInfo.SetValue(_instance, value); }
        }

        public bool AllowMultiSelect
        {
            get { return (bool)_allowMultiSelectInfo.GetValue(_instance); }
            set { _allowMultiSelectInfo.SetValue(_instance, value); }
        }
        
        public bool AllowRenaming
        {
            get { return (bool)_allowRenamingInfo.GetValue(_instance); }
            set { _allowRenamingInfo.SetValue(_instance, value); }
        }
        
        public bool AllowBuiltinResources
        {
            get { return (bool)_allowBuiltinResourcesInfo.GetValue(_instance); }
            set { _allowBuiltinResourcesInfo.SetValue(_instance, value); }
        }
        
        public int GridSize
        {
            get { return (int)_gridSizeInfo.GetValue(_instance); }
            set { _gridSizeInfo.SetValue(_instance, value); }
        }
        
        public ObjectListArea(ObjectListAreaState state, EditorWindow owner, bool showNone)
        {
            _instance = Activator.CreateInstance(_type, new object[] {state.Instance, owner, showNone});
        }

        public void Init(Rect rect, HierarchyType hierarchyType, bool checkThumbnails)
        {
            if (_initInfo == null)
            {
                _initInfo = TypeTool.GetMethod(_type, "Init", typeof(Rect), typeof(HierarchyType), _searchFilterType, typeof(bool));
            }

            _initInfo.Invoke(_instance,
                new object[] { rect, hierarchyType, Activator.CreateInstance(_searchFilterType), checkThumbnails });
        }
        
        public void OnGUI(Rect rect, int controlId)
        {
            if (_onGUI == null)
                _onGUI = TypeTool.GetMethod(_type, "OnGUI", typeof(Rect), typeof(int))
                    .CreateDelegate<Action<Rect, int>>(_instance);
            _onGUI(rect, controlId);
        }

        public void ShowObjectsInList(int[] instanceIds)
        {
            if (_showObjectsInList == null)
                _showObjectsInList = TypeTool.GetMethod(_type, "ShowObjectsInList", typeof(int[]))
                    .CreateDelegate<Action<int[]>>(_instance);

            _showObjectsInList(instanceIds);
        }
        
        public int[] GetSelection()
        {
            if (_getSelection == null)
                _getSelection = TypeTool.GetMethod(_type, "GetSelection")
                    .CreateDelegate<Func<int[]>>(_instance);
            return _getSelection();
        }
    }
}
