using Cirrus.Content;
using Cirrus.Unity.Objects;
using System;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using System.Reflection;
#endif

namespace Cirrus.Unity.Objects.Libraries
{
	public static partial class LibraryUtils
	{
#if UNITY_EDITOR
		public static void __LoadAssets<ResourceType>(
			this ILibrary lib, 
			Func<ResourceType, string> identifyFunc,
			CodeGenOptions options = CodeGenOptions.None) where ResourceType : class
		{
			foreach(var file in lib.Objects)
			{
				if(file == null) continue;

				ResourceType asset = null;

				if(file is ResourceType)
				{
					asset = (ResourceType)(object)file;
				}
				else if(
					typeof(ResourceType).IsSubclassOf(typeof(Component)) &&
					file is GameObject)
				{
					var gobj = ((GameObject)file);
					if (!gobj.TryGetComponent(out asset))
					{
						asset = null;
					}					
				}
				else
				{
					List<ResourceType> candidates = ObjectUtils.GetSubObjectsOfType<ResourceType>(file);
					asset = candidates.Count == 0 ? null : candidates[0];
				}

				if(asset == null) continue;
								

				if(asset.GetType().GetCustomAttributes(typeof(SkipCodeGenAttribute), false).Length != 0) continue;

				lib.__Add(identifyFunc(asset), new __LibraryLoadObject { Object = asset, CodeGenOptions = options });
			}
		}
#endif
	}
}
