using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEditor;

using Object = UnityEngine.Object;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    public static class AssetUtility
    {
        // Source: AssetDatabase.bindings.cs.
        private static Lazy<Func<string, int>> _getMainAssetInstanceID = new Lazy<Func<string, int>>(() =>
        (Func<string, int>)typeof(AssetDatabase)
        .GetMethod("GetMainAssetInstanceID", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static)
        .CreateDelegate(typeof(Func<string, int>)));

        // Source: AssetPreview.bindings.cs
        private static Lazy<Func<string, Texture2D>> _getAssetPreviewFromGUID = new Lazy<Func<string, Texture2D>>(() =>
       (Func<string, Texture2D>)typeof(AssetPreview)
       .GetMethod("GetAssetPreviewFromGUID", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static, Type.DefaultBinder, new Type[] { typeof(string) }, null)
       .CreateDelegate(typeof(Func<string, Texture2D>)));

        // Source: AssetPreview.bindings.cs
        private static Lazy<Func<int, Texture2D>> _getAssetPeview = new Lazy<Func<int, Texture2D>>(() =>
        (Func<int, Texture2D>)typeof(AssetPreview)
        .GetMethod("GetAssetPreview", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static, Type.DefaultBinder, new Type[] { typeof(int) }, null)
        .CreateDelegate(typeof(Func<int, Texture2D>)));

        public static Object LoadAssetFromGUID(string guid, Type type)
        {
            return AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(guid), type);
        }

        public static T LoadAssetFromGUID<T>(string guid) where T : Object
        {
            return AssetDatabase.LoadAssetAtPath<T>(AssetDatabase.GUIDToAssetPath(guid));
        }

        public static T[] LoadAssetsAtPath<T>(string path) where T : Object
        {
            string[] guids = AssetDatabase.FindAssets("t:" + typeof(T).FullName, new string[] { path });
            T[] assets = new T[guids.Length];

            for (int i = 0; i < guids.Length; i++)
            {
                assets[i] = LoadAssetFromGUID<T>(guids[i]);
            }

            return assets;
        }

        public static string[] FindAllAssetsOfType<T>()
        {
            return FindAllAssetsOfType(typeof(T));
        }

        public static string[] FindAllAssetsOfType(Type type)
        {
            return AssetDatabase.FindAssets("t:" + type.FullName);
        }

        public static Object[] LoadAllAssetsOfType(Type type)
        {
            var guids = FindAllAssetsOfType(type);
            var assets = new Object[guids.Length];
            for (int i = 0; i < guids.Length; i++)
            {
                assets[i] = LoadAssetFromGUID(guids[i], type);
            }
            
            return assets;
        }

        public static T[] LoadAllAssetsOfType<T>() where T : Object
        {
            var guids = FindAllAssetsOfType<T>();
            var assets = new T[guids.Length];
            for (int i = 0; i < guids.Length; i++)
            {
                assets[i] = LoadAssetFromGUID<T>(guids[i]);
            }

            return assets;
        }

        /// <summary>
        /// Returns the InstanceID of an asset object from the provided GUID.
        /// </summary>
        /// <param name="guid">The GUID of the asset to get the InstacneID of.</param>
        public static int GetMainAssetInstanceIDFromGUID(string guid)
        {
            return GetMainAssetInstanceID(AssetDatabase.GUIDToAssetPath(guid));
        }

        public static int GetMainAssetInstanceID(string assetPath)
        {
            return _getMainAssetInstanceID.Value(assetPath);
        }

        public static Texture2D GetAssetPreviewFromGUID(string guid)
        {
            return _getAssetPreviewFromGUID.Value(guid);
        }

        public static Texture2D GetAssetPreview(int instanceID)
        {
            return _getAssetPeview.Value(instanceID);
        }

        public static string GetAssetGUID(Object assetObject)
        {
            return AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(assetObject));
        }


        public struct LoadAssetScope : IDisposable
        {
            private readonly bool _wasLoaded;

            public readonly Object asset;
            public readonly string path;

            public LoadAssetScope(string guid)
            {
                path = AssetDatabase.GUIDToAssetPath(guid);
                _wasLoaded = AssetDatabase.IsMainAssetAtPathLoaded(path);
                asset = AssetDatabase.LoadMainAssetAtPath(path);
            }

            public LoadAssetScope(GUID guid)
            {
                path = AssetDatabase.GUIDToAssetPath(guid);
                _wasLoaded = AssetDatabase.IsMainAssetAtPathLoaded(path);
                asset = AssetDatabase.LoadMainAssetAtPath(path);
            }

            public void Dispose()
            {
                if (!_wasLoaded)
                {
                    if (asset != null && !asset.hideFlags.HasFlag(HideFlags.DontUnloadUnusedAsset) && !(asset is GameObject) && !(asset is Component) && !(asset is AssetBundle))
                    {
                        Resources.UnloadAsset(asset);
                    }
                }
            }
        }
    }
}