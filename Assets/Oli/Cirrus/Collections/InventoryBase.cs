using Cirrus.Collections;
using Cirrus.Objects;
using System;
using System.Collections.Generic;


// IF NEEDED extend new AbilityAsset

namespace Cirrus.Collections
{
	
	public partial class InventoryBase<TItem> 
	: ListBase<TItem>
	where TItem : class
	{
		public InventoryBase(int size = 32)
		{
			_list = new System.Collections.Generic.List<TItem>().Resize(size);
		}

		public InventoryBase(IEnumerable<TItem> items)
		{
			_list = new System.Collections.Generic.List<TItem>(items);
		}

		public InventoryBase(int size, IEnumerable<TItem> items)
		{
			_list = new System.Collections.Generic.List<TItem>().Resize(size);
			AddRange(items);
		}

		public virtual void AddRange(IEnumerable<TItem> items)
		{
			foreach (var item in items)
			{
				if (!Store(item)) break;
			}
		}

		public override void Add(TItem item)
		{
			for(int i = 0; i < _list.Count; i++)
			{
				if(_list[i] == null)
				{
					_list[i] = item;
					break;
				}
			}
		}

		public override void RemoveAt(int i)
		{
			_list[i] = null;
		}

		public override void Clear()
		{
			for(int i = 0; i < Count; i++) _list[i] = null;
		}


		//public static implicit operator ItemCollection(ItemBase[] items)
		//{
		//	ItemCollection collection = new ItemCollection()
		//	{
		//		Items = new List<ItemBase>()
		//	};

		//	foreach(var item in items)
		//	{
		//		if(item == null) continue;
		//		collection.Items.Add(item);
		//	}

		//	return collection;
		//}


		//public CollectibleInventory(
		//	ItemInventoryAsset resource,
		//	CharacterEntity source)
		//{
		//	_resource = resource;
		//	_items = new Collectible[resource._size];

		//	// Consum
		//	for (int i = 0; i < resource._consumables.Count; i++)
		//	{
		//		if (_resource._consumables[i] == null) return;

		//		_items[i] = _resource._consumables[i].Instance.Create(this, i);
		//		_items[i].SetOwner(source);			   
		//		_consumables.Add(_items[i].Id, _items[i] as Consumable);
		//	}

		//	//Weap
		//	for (int i = 0; i < resource._weapons.Count; i++)
		//	{
		//		if (_resource._weapons[i] == null) return;

		//		_items[i] = _resource._weapons[i].Instance.Create(this, i);
		//		_items[i].SetOwner(source);
		//	}

		//	// Armor
		//	for (int i = 0; i < resource._armors.Count; i++)
		//	{
		//		if (_resource._armors[i] == null) return;

		//		_items[i] = _resource._armors[i].Instance.Create(this, i);
		//		_items[i].SetOwner(source);
		//	}
		//}


		//public ItemInventory(
		//	CharacterRepresentation source,
		//	ItemInventoryResource resource) : 
		//	this(
		//		resource,
		//		source)
		//{
		//	_source = source;

		//	foreach (var item in _items)
		//	{
		//		if (item == null)
		//			continue;

		//		item.SetOwnership(source);
		//	}
		//}


		// TODO: best fit

		// TODO : cache where we last placed to accelarate finding a new place
		// TODO : Concurrent access??
		private bool _FirstFit(TItem item, out int i)
		{
			for(i = 0; i < _list.Count; i++)
			{
				if(_list[i] == null)
				{
					return true;
				}
			}

			i = -1;
			return false;
		}

		public bool Store(TItem item)
		{
			// TODO: why are we putting hearts in our inventory?
			if(item == null)
				return false;

			else if(_FirstFit(item, out int slot))
			{
				_list[slot] = item;
				return true;
			}

			return false;
		}

		public void Store(int index, TItem item)
		{
			_list[index] = item;
		}

		//public void PopulateHotbar(Hotbar hotbar)
		//{
		//	foreach (var res in _resource._hotbarItems)
		//	{
		//		if (_consumables.TryGetValue(res.Instance.Id, out Consumable consumable))
		//		{
		//			hotbar.Add(consumable);
		//		}
		//	}
		//}
	}

	public class Inventory<TItem> : InventoryBase<TItem>
		where TItem : class
	{
		public Inventory(int size = 32) : base(size)
		{
		}

		public Inventory()
		{
		}

		public Inventory(IEnumerable<TItem> items) : base(items)
		{
		}

		public Inventory(int size, IEnumerable<TItem> items) : base(size, items)
		{
		}
	}
}
