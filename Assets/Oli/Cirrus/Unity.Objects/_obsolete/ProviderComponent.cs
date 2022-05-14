////using Cirrus.DH.Conditions;
//using Cirrus.Content;
//using Cirrus.Objects;
//using System;
//using UnityEngine;

//namespace Cirrus.Unity.Objects
//{
//	public abstract class ProviderComponent 
//		: CustomMonoBehaviourBase 
//		, IProvider
//	{
//		public abstract object RawObject { get; }
//	}

//	public abstract class ProviderComponent<T>
//		: ProviderComponent
//		, IProvider<T>
//		where T 
//		: class
//		// , IRealizablePrototype
//		//, ICopiableObject
//	{
//		public static implicit operator T(ProviderComponent<T> res)
//		{
//			return res.Object;
//		}

//		[NonSerialized]
//		public T _object = null;
//		public T Object
//		{
//			get
//			{
//				if(_object == null) _PopulateInternal();
//				return _object;
//			}
//		}

//		public override object RawObject => Object;

//		private void _PopulateInternal()
//		{
//			_object = _Get();
//			_Populate(_object);
//		}

//		protected virtual T _Get()
//		{
//			Debug.Assert(false, "You must override the 'Populate' method");
//			return null;
//		}

//		protected virtual void _Populate(T resource)
//		{
//		}		
//	}
//}