using Cirrus.Objects;
using System;
using System.Collections.Generic;

namespace Cirrus.Content
{
	//public abstract class PlaceholderBase : INameHash
	//{
	//	public IEnumerable<string> Categories { get; protected set; }

	//	public string Name { get; protected set; }

	//	public int Hash { get; set; } = -1;

	//	public string Salt { get; } = "";

	//	public int Flags { get; set; } = 0;

	//	public abstract Type Type { get; }

	//	public abstract object LoadObject();
	//}

	//public abstract class PlaceholderBase<ResourceType>
	//: PlaceholderBase
	//where ResourceType : class
	//{
	//	public static string ClassName { get; set; } = "";

	//	public override object LoadObject() => Load();

	//	public virtual ResourceType Load() { return null; }

	//	public override Type Type => typeof(ResourceType);
	//}

	//public class Placeholder<ResourceType>
	//	: PlaceholderBase<ResourceType>
	//	, INameHash
	//	where ResourceType
	//	: class
	//{

	//	public Func<PlaceholderBase, ResourceType> _load1;

	//	//public Func<PlaceholderBase, string, ResourceType> _load2;

	//	public Placeholder(
	//		string identifier,
	//		Func<PlaceholderBase, ResourceType> load
	//		)
	//	{
	//		Name = identifier;
	//		this.ComputeHash();
	//		_load1 = load;
	//	}

	//	public Placeholder(
	//		string identifier,
	//		IEnumerable<string> categories,
	//		Func<PlaceholderBase, ResourceType> load
	//		)
	//	{
	//		Categories = categories;
	//		Name = identifier;
	//		Hash = ObjectUtils.ComputeHash(this, true);
	//		_load1 = load;
	//	}

	//	//public Placeholder(
	//	//	string identifier,
	//	//	Func<PlaceholderBase, string, ResourceType> load
	//	//	)
	//	//{
	//	//	Name = identifier;
	//	//	this.ComputeID();
	//	//	_load2 = load;
	//	//}

	//	public override ResourceType Load()
	//	{
	//		return _load1(this);
	//	}
	//}

	//public class Placeholder<AssetType, ResourceType>
	//	: PlaceholderBase<ResourceType>
	//	, INameHash
	//	where AssetType : class, INamed
	//	where ResourceType : class
	//{
	//	public AssetType _asset;

	//	public Func<AssetType, ResourceType> _load;

	//	public Placeholder(
	//		AssetType asset,
	//		Func<AssetType, ResourceType> load
	//		)
	//	{
	//		Name = asset.Name;
	//		// TODO: id precomp in asset
	//		Hash = ObjectUtils.ComputeHash(this, true);
	//		_asset = asset;
	//		_load = load;
	//	}

	//	public override ResourceType Load()
	//	{
	//		return _load(_asset);
	//	}
	//}
}
