//using Cirrus.Objects;
//using System;
//using UnityEngine;

//namespace Cirrus.Unity.Objects
//{
//	public class ResourceComponent
//	{


//	}

//	public interface ILegacyEngineObject
//	{
//		object RawResource { get; set; }
//		void OnResourceRealized(ILegacyEngineObject prefab);
//	}


//	public interface ILegacyEngineObject<R>
//		: ILegacyEngineObject
//		// where R 
//		// : IRealizablePrototype
//	{
//		R Resource { get; set; }
//	}

//	public abstract class LegacyEngineObjectComponentBase
//		: CustomMonoBehaviourBase
//		, ILegacyEngineObject
//	{
//		public abstract object RawResource { get; set; }

//		public virtual void OnResourceRealized(ILegacyEngineObject prefab) { }
//	}

//	public abstract class EngineObjectComponentBase<R>
//		: LegacyEngineObjectComponentBase
//		// , ILegacyEngineObject<R>
//		// where R : IRealizablePrototype
//	{
//		public override object RawResource { get => Resource; set => Resource = (R)value; }

//		[field: SerializeReference]
//		public R Resource { get; set; }
//	}

//	public interface IEngineObjectResource 
//	// : IRealizablePrototype
//	{
//		object RawObject { get; set; }
//	}

//	public interface IEngineObjectResource<O>
//		: IEngineObjectResource
//		where O : LegacyEngineObjectComponentBase
//	{
//		O ObjectComp { get; set; }

//		O PrefabComp { get; }

//		Action<O> OnEngineObjectCreatedHandler { get; set; }
//	}

//	public abstract class EngineObjectResourceBase
//		: Base
//		, IEngineObjectResource
//	{
//		public abstract object[] RealizeStepCbs { get; set; }

//		public object ProtoData { get; set; }

//		public bool IsRealizable { get; set; } = false;
//		public object ProxyCb { get; set; }

		
//		public abstract object MemberwiseCopy();

//		public abstract object RawObject { get; set; }
//	}

//	public abstract class ComponentResourceBase<O>
//		: EngineObjectResourceBase
//		, IEngineObjectResource<O>
//		where O : LegacyEngineObjectComponentBase
//	{
//		public Action<O> OnEngineObjectCreatedHandler { get; set; }

//		public static implicit operator O(ComponentResourceBase<O> resource)
//		{
//			return resource.ObjectComp;
//		}

//		public override object RawObject 
//		{ 
//			get => ObjectComp;
//			set => ObjectComp = (O)value;			
//		}

//		// NOTE: resource override component reference, not the other way around to prevent stack overflow
//		// note that to circumvent that we could do a prefab check (only allow prefab override)
//		//public O ObjectComp { get; set; } = null;

//		private O _object;
//		public O ObjectComp
//		{
//			get => _object;
//			set
//			{
//				if (_prefabComp == null) _prefabComp = (O)value;
//				_object = (O)value;
//			}
//		}

//		private O _prefabComp;
//		public O PrefabComp => _prefabComp;
//	}

//}
