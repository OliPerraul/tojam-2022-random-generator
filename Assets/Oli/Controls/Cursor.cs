using Cirrus.Unity.Numerics;
using Cirrus.Unity.Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tojam2022
{
	public enum CursorState
	{ 
		Default,
		Tool
	}

	public class Cursor : SingletonComponentBase<Cursor>
	{
		[SerializeField]
		private Collider _collider;
		public Collider Collider => _collider;

		[SerializeField]
		private GameObject _handMesh;

		[SerializeField]
		private Transform _transform;
		public Transform Transform => _transform;

		public Vector3 Position => Transform.position;

		[SerializeField]
		private ToolBase _tool;

		private CursorState _cursorState;
	

		public void Update()
		{
			_transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition).X_Z(_transform.position.y);

			switch (_cursorState)
			{
				case CursorState.Default:
					break;

				case CursorState.Tool:
					if (Input.GetKeyDown(KeyCode.Escape))
					{
						SetState(CursorState.Default);
						break;
					}
					_tool.Transform.position = _transform.position;
					break;
			}
		}

		public void OnToolHilighted(ToolBase tool)
		{
			if (Input.GetMouseButtonDown(0))
			{
				if (_tool != null)
				{
					_tool.SetState(ToolState.Active);
				}
				_tool = tool;

				if (_tool != null)
				{
					SetState(CursorState.Tool);
					_tool.SetState(ToolState.Active);
				}
			}
		}
				

		public void SetState(CursorState state, params object[] args)
		{
			switch (state)
			{
				case CursorState.Default:
					if (_tool != null)
					{
						_tool.SetState(ToolState.Shelved);
					}
					_tool = null;
					_handMesh.SetActive(true);
					break;
				case CursorState.Tool:
					_handMesh.SetActive(false);
					break;
			}
			_cursorState = state;
		}
	}
}
