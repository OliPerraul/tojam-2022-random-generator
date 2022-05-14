using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using EditorCoroutines = Unity.EditorCoroutines.Editor;

namespace Cirrus.Unity.Editor
{
	public class EditorLibrary : EditorSingletonAssetBase<EditorLibrary>
	{
		[SerializeField]
		private float _saveWaitForSeconds = 0.5f;

		//[ReadOnly]
		[SerializeField]
		private uint _idCount = 0;
		public uint NextAvailableId => _idCount++;

		[SerializeField]
		private List<IdAsset> _ids;
		public List<IdAsset> Ids => _ids;

		//[ReadOnly]
		[SerializeField]
		private uint _actionCount = 0;
		public uint NextAvailableAction => _actionCount++;


		[SerializeField]
		private uint _funcCount = 0;
		public uint NextAvailableFunc => _funcCount++;

		[SerializeField]
		private List<DelegateAssetBase> _delegates;

		private IEnumerator _Save()
		{
			yield return new EditorCoroutines.EditorWaitForSeconds(_saveWaitForSeconds);

			AssetDatabase.SaveAssetIfDirty(this);

			yield return null;
		}

		public void Save(IdAsset asset)
		{
			_ids.Add(asset);
			EditorUtility.SetDirty(this);
			EditorCoroutines.EditorCoroutineUtility.StartCoroutine(_Save(), this);
		}

		public void Save(DelegateAssetBase asset)
		{
			_delegates.Add(asset);
			EditorUtility.SetDirty(this);
			EditorCoroutines.EditorCoroutineUtility.StartCoroutine(_Save(), this);
		}
	}

#if UNITY_EDITOR

	[CustomEditor(typeof(EditorLibrary))]
	[CanEditMultipleObjects]
	public class EditorLibraryEditor : UnityEditor.Editor
	{
		private EditorLibrary _lib;

		public void OnEnable()
		{
			_lib = (EditorLibrary)target;
		}

		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			if (GUILayout.Button("Rename"))
			{
				foreach (var id in _lib.Ids)
				{
					if (id == null) continue;
					var path = AssetDatabase.GetAssetPath(id);
					AssetDatabase.RenameAsset(path, $"Id_{id.Id}");
				}
			}
		}
	}

#endif
}
