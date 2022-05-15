
//using Cirrus.Unity.Editor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace Cirrus.Unity.Objects
{
	public static class ScriptableObjectUtils
	{
		public static T Create<T>(Action<T> eval=null) where T : ScriptableObject
		{
			T so = ScriptableObject.CreateInstance<T>();
			if(eval != null) eval(so);
			return so;
		}
	}
}
