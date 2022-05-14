//using Cirrus.Objects;

//namespace Cirrus.Unity.Objects
//{
//	public class ResourceAsset
//	{
//	}

//	public interface IResourceAsset
//	{
//		object ResourceObject { get; set; }
//		void OnResourceRealized(IResourceAsset prefab);
//	}


//	public interface IResourceAsset<R>
//		: IResourceAsset
//		// where R 
//		// : IRealizablePrototype
//	{
//		R Resource { get; set; }
//	}

//	public abstract class ResourceAssetBase
//		: ScriptableObjectBase
//		, IResourceAsset
//	{
//		public abstract object ResourceObject { get; set; }

//		public virtual void OnResourceRealized(IResourceAsset prefab) { }
//	}

//	public abstract class ResourceAssetBase<R>
//		: ResourceAssetBase
//		, IResourceAsset<R>
//		// where R : IRealizablePrototype
//	{
//		public override object ResourceObject { get => Resource; set => Resource = (R)value; }

//		public R Resource { get; set; }
//	}

//	public interface IAssetResource 
//	// : IRealizablePrototype
//	{
//		object AssetObject { get; set; }
//	}

//	public interface IAssetResource<T>
//		: IAssetResource
//		where T : ResourceAssetBase
//	{
//		T Asset { get; set; }
//	}

//	public abstract class AssetResourceBase
//		: Base
//		, IAssetResource
//	{
//		public abstract object[] RealizeStepCbs { get; set; }

//		public bool IsRealizable { get; set; } = false;

//		public object ProtoData { get; set; }

//		public object ProxyCb { get; set; }

		

//		public abstract object MemberwiseCopy();

//		public abstract object AssetObject { get; set; }
//	}

//	public abstract class AssetResourceBase<T>
//		: AssetResourceBase
//		, IAssetResource<T>
//		where T : ResourceAssetBase
//	{
//		public static implicit operator T(AssetResourceBase<T> resource)
//		{
//			return resource.Asset;
//		}

//		public override object AssetObject { get => Asset; set => Asset = (T)value; }

//		// NOTE: resource override component reference, not the other way around to prevent stack overflow
//		// note that to circumvent that we could do a prefab check (only allow prefab override)
//		public T Asset { get; set; }
//	}

//}
