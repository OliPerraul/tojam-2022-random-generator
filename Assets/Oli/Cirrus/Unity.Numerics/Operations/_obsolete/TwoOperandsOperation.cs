//#if NEWTONSOFT_JSON
//#endif

//using Cirrus.Unity.Editor;
//using Cirrus.Unity.Objects;
//using UnityEditor;
//using UnityEngine;

//namespace Cirrus.Unity.Numerics
//{
//	public partial class TwoOperandsOperation : OperationBase
//	{
//#if UNITY_EDITOR
//		[MenuItem("Assets/Cirrus.Unity.Numerics/Two Operands Op", false, priority = PackageUtils.MenuItemAssetProjectPriority)]
//		public static void CreateAsset() => EditorScriptableObjectUtils.CreateAsset<TwoOperandsOperation>();
//#endif

//		[SerializeField]
//		protected float _first = 1;
//		protected override float _First => _first;

//		[SerializeField]
//		protected float _second = 1;
//		protected override float _Second => _second;

//	}
//}