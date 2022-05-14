#if UNITY_EDITOR

using Cirrus.Unity.Numerics;
using Cirrus.Unity.Objects;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Cirrus.Unity.Editor
{
	public class HierarchyUtils : EditorWindow
	{

		[MenuItem("GameObject/Cirrus/Delete Children", false, -1)]
		public static void DeleteChildren(MenuCommand menuCommand)
		{
			if(menuCommand.context == null || menuCommand.context.GetType() != typeof(GameObject))
			{
				EditorUtility.DisplayDialog("Error", "You must select an item to sort in the frame", "Okay");
				return;
			}

			GameObject selected = (GameObject)menuCommand.context;

			if(selected.GetComponentInChildren<Image>())
			{
				EditorUtility.DisplayDialog("Error", "You are trying to sort a GUI element. This will screw up EVERYTHING, do not do", "Okay");
				return;
			}

			Transform[] transforms = new Transform[selected.transform.childCount];
			for(int i = 0; i < selected.transform.childCount; i++)
				transforms[i] = selected.transform.GetChild(i);

			// Build a list of all the Transforms in this player's hierarchy
			for(int i = 0; i < transforms.Length; i++)
			{
				//if(transform.gameObject.name.StartsWith("_")) continue;
				transforms[i].gameObject.DestroyImmediate();
			}

			EditorUtility.SetDirty(selected);
		}

		[MenuItem("GameObject/Cirrus/Delete Children (only \"(Clone)\")", false, -1)]
		public static void DeleteChildrenOnly(MenuCommand menuCommand)
		{
			if(menuCommand.context == null || menuCommand.context.GetType() != typeof(GameObject))
			{
				EditorUtility.DisplayDialog("Error", "You must select an item to sort in the frame", "Okay");
				return;
			}

			GameObject selected = (GameObject)menuCommand.context;

			if(selected.GetComponentInChildren<Image>())
			{
				EditorUtility.DisplayDialog("Error", "You are trying to sort a GUI element. This will screw up EVERYTHING, do not do", "Okay");
				return;
			}


			Transform[] transforms = new Transform[selected.transform.childCount];
			for(int i = 0; i < selected.transform.childCount; i++)
				transforms[i] = selected.transform.GetChild(i);

			// Build a list of all the Transforms in this player's hierarchy
			for(int i = 0; i < transforms.Length; i++)
			{
				//if(transform.gameObject.name.StartsWith("_")) continue;
				if(!transforms[i].gameObject.name.Contains("(Clone)")) continue;
				transforms[i].gameObject.DestroyImmediate();
			}

			EditorUtility.SetDirty(selected);
		}

		public void __ComputeBounds()
		{
			//List<Bounds> bounds = new List<Bounds>();
			//GameObjectUtils.TraverseChildren(
			//    gameObject,
			//    (MeshRenderer rend) =>
			//    {
			//        if(rend.CompareTag(Layers.Tag_EditorOnly)) return;
			//        bounds.Add(rend.bounds);
			//    });

			//Bounds = Bound.CombineBounds(bounds);
		}

		[MenuItem("GameObject/Cirrus/Adjust collider", false, -1)]
		public static void AdjustCollider(MenuCommand menuCommand)
		{
			if(menuCommand.context == null || menuCommand.context.GetType() != typeof(GameObject))
			{
				EditorUtility.DisplayDialog("Error", "You must select an item to sort in the frame", "Okay");
				return;
			}

			GameObject selected = (GameObject)menuCommand.context;
			List<Bounds> boundsList = new List<Bounds>();
			GameObjectUtils.TraverseChildren(
				selected,
				(MeshRenderer rend) =>
				{
					if(rend.CompareTag(EditorUtils.EditorOnlyTag)) return;
					boundsList.Add(rend.bounds);
				});

			Bounds bounds = BoundsUtils.CombineBounds(boundsList);
			BoxCollider boxCollider = null;
			SphereCollider sphereCollider = null;
			if((boxCollider = selected.GetComponent<BoxCollider>()) != null)
			{
				boxCollider.center = bounds.center;
				boxCollider.size = bounds.size;
			}
			else if((sphereCollider = selected.GetComponent<SphereCollider>()) != null)
			{
				sphereCollider.center = bounds.center;
				sphereCollider.radius = bounds.extents.x;
			}

			EditorUtility.SetDirty(selected);
		}

		[MenuItem("GameObject/Cirrus/Adjust collider from root", false, -1)]
		public static void AdjustColliderFromRoot(MenuCommand menuCommand)
		{
			if(menuCommand.context == null || menuCommand.context.GetType() != typeof(GameObject))
			{
				EditorUtility.DisplayDialog("Error", "You must select an item to sort in the frame", "Okay");
				return;
			}

			GameObject selected = (GameObject)menuCommand.context;

			GameObject root = selected.transform.root.gameObject;

			List<Bounds> boundsList = new List<Bounds>();
			GameObjectUtils.TraverseChildren(
				root,
				(MeshRenderer rend) =>
				{
					if(rend.CompareTag(EditorUtils.EditorOnlyTag)) return;
					boundsList.Add(rend.bounds);
				});

			Bounds bounds = BoundsUtils.CombineBounds(boundsList);
			BoxCollider boxCollider = null;
			SphereCollider sphereCollider = null;
			if((boxCollider = selected.GetComponent<BoxCollider>()) != null)
			{
				boxCollider.center = bounds.center;
				boxCollider.size = bounds.size;
			}
			else if((sphereCollider = selected.GetComponent<SphereCollider>()) != null)
			{
				sphereCollider.center = bounds.center;
				sphereCollider.radius = bounds.extents.x;
			}

			EditorUtility.SetDirty(selected);
		}



		[MenuItem("GameObject/Cirrus/Add mesh collider", false, -1)]
		public static void AddMeshColliders(MenuCommand menuCommand)
		{
			if(menuCommand.context == null || menuCommand.context.GetType() != typeof(GameObject))
			{
				EditorUtility.DisplayDialog("Error", "You must select an item to sort in the frame", "Okay");
				return;
			}

			GameObject selected = (GameObject)menuCommand.context;


			GameObjectUtils.TraverseChildren<MeshRenderer>(
				selected,
				(MeshRenderer rend) =>
				{
					if(!rend.gameObject.TryGetComponent(out MeshCollider _))
					{
						rend.gameObject.AddComponent<MeshCollider>();
						EditorUtility.SetDirty(rend.gameObject);
					}
				});

			EditorUtility.SetDirty(selected);
		}

		[MenuItem("GameObject/Cirrus/Revert Prefab Names (Except root)", false, -1)]
		public static void RevertPrefabNames1(MenuCommand menuCommand)
		{
			_RevertPrefabNames(menuCommand, false);
		}

		[MenuItem("GameObject/Cirrus/Revert Prefab Names", false, -1)]
		public static void RevertPrefabNames2(MenuCommand menuCommand)
		{
			_RevertPrefabNames(menuCommand, true);
		}

		public static void _RevertPrefabNames(MenuCommand menuCommand, bool root)
		{
			if(menuCommand.context == null || menuCommand.context.GetType() != typeof(GameObject))
			{
				EditorUtility.DisplayDialog("Error", "You must select an item to sort in the frame", "Okay");
				return;
			}

			GameObject selected = (GameObject)menuCommand.context;

			GameObjectUtils.TraverseChildren(
				selected,
				(GameObject obj) =>
				{
					var prefab = PrefabUtility.GetCorrespondingObjectFromSource(obj);

					if(prefab != null)
					{
						List<GameObject> objects = new List<GameObject>();
						if(obj.transform.parent != null)
						{
							foreach(Transform child in obj.transform.parent)
								objects.Add(child.gameObject);
						}
						else objects.AddRange(obj.scene.GetRootGameObjects());

						int count = 0;
						foreach(var obj2 in objects)
						{
							if(obj2 == null) continue;
							var prefab2 = PrefabUtility.GetCorrespondingObjectFromSource(obj2);
							if(prefab2 == null) continue;
							if(prefab == prefab2)
							{
								count++;
								obj2.name = prefab.name + $" ({count})";
								EditorUtility.SetDirty(obj2);
							}
						}

						if(count == 1)
						{
							obj.name = prefab.name;
							EditorUtility.SetDirty(obj);
						}
					}
				},
				true,
				root
				);

			EditorUtility.SetDirty(selected);
		}


		[MenuItem("GameObject/Cirrus/Delete Children (except \"_\")", false, -1)]
		public static void DeleteChildrenExcept1(MenuCommand menuCommand)
		{
			if(menuCommand.context == null || menuCommand.context.GetType() != typeof(GameObject))
			{
				EditorUtility.DisplayDialog("Error", "You must select an item to sort in the frame", "Okay");
				return;
			}

			GameObject selected = (GameObject)menuCommand.context;

			if(selected.GetComponentInChildren<Image>())
			{
				EditorUtility.DisplayDialog("Error", "You are trying to sort a GUI element. This will screw up EVERYTHING, do not do", "Okay");
				return;
			}


			Transform[] transforms = new Transform[selected.transform.childCount];
			for(int i = 0; i < selected.transform.childCount; i++)
				transforms[i] = selected.transform.GetChild(i);

			// Build a list of all the Transforms in this player's hierarchy
			for(int i = 0; i < transforms.Length; i++)
			{
				//if(transform.gameObject.name.StartsWith("_")) continue;
				if(transforms[i].gameObject.name.StartsWith("_")) continue;
				transforms[i].gameObject.DestroyImmediate();
			}

			EditorUtility.SetDirty(selected);
		}


		[MenuItem("GameObject/Cirrus/Sort By Name", false, -1)]
		public static void SortGameObjectsByName(MenuCommand menuCommand)
		{
			if(menuCommand.context == null || menuCommand.context.GetType() != typeof(GameObject))
			{
				EditorUtility.DisplayDialog("Error", "You must select an item to sort in the frame", "Okay");
				return;
			}

			GameObject selected = (GameObject)menuCommand.context;

			if(selected.GetComponentInChildren<Image>())
			{
				EditorUtility.DisplayDialog("Error", "You are trying to sort a GUI element. This will screw up EVERYTHING, do not do", "Okay");
				return;
			}

			// Build a list of all the Transforms in this player's hierarchy
			Transform[] objectTransforms = new Transform[selected.transform.childCount];
			for(int i = 0; i < objectTransforms.Length; i++)
				objectTransforms[i] = selected.transform.GetChild(i);

			int sortTime = System.Environment.TickCount;

			bool sorted = false;
			// Perform a bubble sort on the objects
			while(sorted == false)
			{
				sorted = true;
				for(int i = 0; i < objectTransforms.Length - 1; i++)
				{
					// Compare the two strings to see which is sooner
					int comparison = objectTransforms[i].name.CompareTo(objectTransforms[i + 1].name);

					if(comparison > 0) // 1 means that the current value is larger than the last value
					{
						objectTransforms[i].transform.SetSiblingIndex(objectTransforms[i + 1].GetSiblingIndex());
						sorted = false;
					}
				}

				// resort the list to get the new layout
				for(int i = 0; i < objectTransforms.Length; i++)
					objectTransforms[i] = selected.transform.GetChild(i);
			}

			Debug.Log("Sort took " + (System.Environment.TickCount - sortTime) + " milliseconds");

			EditorUtility.SetDirty(selected);

		}
	}
}

#endif