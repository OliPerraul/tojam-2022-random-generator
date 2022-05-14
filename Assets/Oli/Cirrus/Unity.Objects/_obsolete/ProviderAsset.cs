//using Cirrus.Content;
//using Cirrus.Objects;
//using System;
//using UnityEngine;
////using Cirrus.UnityDH.Conditions;

//namespace Cirrus.Unity.Objects
//{
//	public abstract class ProviderAsset<A>
//	: ScriptableObjectBase
//	, IProvider<A>
//	where A 
//	: class
//	{
//		[NonSerialized]
//		public A _object = null;
//		public virtual A Object
//		{
//			get
//			{
//				if(_object == null) _Populate();
//				return _object;
//			}
//		}

//		public object RawObject => Object;

//		public static implicit operator A(ProviderAsset<A> a)
//		{
//			return a.Object;
//		}

//		private void _Populate()
//		{
//			_object = _Create();
//			_Populate(_object);
//		}

//		protected virtual A _Create()
//		{
//			Debug.Assert(false, "You must override the 'Populate' method");
//			return null;
//		}

//		protected virtual void _Populate(A resource)
//		{
//		}
//	}
//}