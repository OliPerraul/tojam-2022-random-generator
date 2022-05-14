﻿using Cirrus.Content;
using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

// TODO generate #define GEN_OPTION_LIBRARY at the top most of the file to enable default ids if 
// no class has been generated


namespace Cirrus.Unity.Objects.Libraries
{
	// TODO make the libraries and generator into menu item rather than asset
	// This way we can bulk generate etc..

	// TODO generate legacy attributes with some warnign
	// This is after we clear up the remainder of the warnigns
	public abstract partial class LibraryComponentBase
	{
		public virtual string DefinePrefix => "";

		public virtual Type StaticClassType => null;

		//public bool IsLoaded => _objects != null && _objects.Count != 0;

		public bool IsArray => false;

		[SerializeField]
		public List<Object> _assets = new List<Object>();

		public List<Object> Objects => _assets;

#if UNITY_EDITOR
		public Dictionary<string, __LibraryLoadObject> __EditorObjects { get; set; } = new Dictionary<string, __LibraryLoadObject>();

		public bool __IsLoaded => __EditorObjects.Count != 0;
#endif
		//public Dictionary<int, object> _objects;

		//public abstract string CurrentScriptDirectory { get; }

		//public abstract string CurrentScriptFile { get; }

		public abstract string GeneratedFile { get; }
	}
}