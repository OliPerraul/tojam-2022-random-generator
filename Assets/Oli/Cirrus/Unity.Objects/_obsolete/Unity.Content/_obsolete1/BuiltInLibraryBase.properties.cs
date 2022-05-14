//using Cirrus.Collections;
//using System;
//using System.Collections.Generic;
//using UnityEngine;

//namespace Cirrus.Content
//{
//	public abstract partial class BuiltInLibraryBase<T>
//	{
//		public virtual string GeneratedFile => "";

//		public virtual string DefinePrefix => "";

//		public virtual Type UtilsType => null;

//		public bool IsLoaded => _objects != null && _objects.Count != 0;


//		public bool IsArray => false;

//		//[SerializeField]
//		//public List<Object> _assets = new List<Object>();

//#if UNITY_EDITOR
//		public Dictionary<string, int> _identifiers;

//		public IDictionary<string, int> Identifiers => _identifiers;

//		public IDictionary<int, object> Objects => _objects;

//#endif
//		public Dictionary<int, object> _objects;

//	}
//}
