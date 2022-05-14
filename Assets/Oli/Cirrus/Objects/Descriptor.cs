using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

using Cirrus.Collections;
using Cirrus.Objects;
using Cirrus.Debugging;
using Cirrus.Unity;

using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using static UnityEngine.ParticleSystem;
using Cirrus.Unity.Objects;
using Cirrus.Unity.Numerics;
using static Cirrus.Debugging.DebugUtils;
using UnityEngine.UIElements;
using System;
using Random = UnityEngine.Random;

namespace Cirrus.Objects
{
	public enum EnumBase : int
	{ 
	}

	public interface IIdentification
	{
		public HashSet<object> Metadata { get; set; }

		uint Flags { get; }

		int Id { get; }

		Type Type { get; }
	}

	public class Identification : IIdentification
	{
		private static Dictionary<int, Identification> _ided = new Dictionary<int, Identification>();
		private static Dictionary<uint, Identification> _flagged = new Dictionary<uint, Identification> ();
		private static Dictionary<Base, Identification> _resources = new Dictionary<Base, Identification>();
		private static Dictionary<Type, Identification> _typed = new Dictionary<Type, Identification>();

		public HashSet<object> Metadata { get; set; }

		public uint Flags { get; set; }

		public int Id { get; set; } = (int)(object) -1;

		public Type Type { get; set; } = null;

		public static implicit operator Identification(int id)
		{
			Identification ident;
			if (!_ided.TryGetValue(id, out ident))
			{
				_ided.Add(id, ident = new Identification());
				ident.Id = id;
			}
			return ident;
		}
		public static implicit operator Identification(Base res)
		{
			Identification ident;
			if (!_resources.TryGetValue(res, out ident))
			{
				_resources.Add(res, ident = new Identification());
				ident.Metadata.Add(res);
			}
			return ident;
		}
		public static implicit operator Identification(uint flags)
		{
			Identification ident;
			if (!_flagged.TryGetValue(flags, out ident))
			{
				_flagged.Add(flags, ident = new Identification());
				ident.Flags |= flags;
			}
			return ident;
		}
		public static implicit operator Identification(Type type)
		{
			Identification ident;
			if (!_typed.TryGetValue(type, out ident))
			{				
				_typed.Add(type, ident = new Identification());
				ident.Type = type;
			}
			return ident;
		}
	}

	//public class Descriptor
	//	: ResourceBase
	//	, IDescribed
	//{
	//	public object[] MixinsCbs { get; set; }

	//	object IRealizableResource.Copy()
	//	{
	//		return MemberwiseClone();
	//	}

	//	public Color Color { get; set; } = Color.white;

	//	public Sprite Icon { get; set; } = null;

	//	public string Name { get; set; } = "";

	//	public string Category { get; set; } = "";

	//	public string Description { get; set; } = "";

	//	public Descriptor()
	//	{
	//	}

	//	public Descriptor(string name="")
	//	{
	//		this.Name = name;
	//	}
	//}

	public static class DescriptorUtils
	{
		public static bool Intersects(this IIdentification ident, IIdentification other)
		{
			return
				ident.Flags.Intersects(other.Flags) ||
				(((int)(object)ident.Id) != -1 && ident.Id == other.Id) ||
				(ident.Metadata != null && ident.Metadata.Intersects(other.Metadata)) ||
				(
				ident.Type != null &&
					(ident.Type == other.Type ||
					ident.Type.IsAssignableFrom(other.Type))
				)
				;
		}

		//public static bool Intersects(this IIdentification ident, HashSet<object> tags)
		//{
		//	return
		//		//ident.Flags.Intersects(other.Flags) ||
		//		//(((int)(object)ident.ID) != -1 && ident.ID == other.ID) ||
		//		ident.Metadata != null && ident.Metadata.Intersects(tags);
				
		//		//ident.Type != null &&
		//		//	(ident.Type == other.Type ||
		//		//	ident.Type.IsAssignableFrom(other.Type))
		//		//)
		//		;
		//}

		public static bool Intersects(this IIdentification ident, object tag)
		{
			return
				//ident.Flags.Intersects(other.Flags) ||
				//(((int)(object)ident.ID) != -1 && ident.ID == other.ID) ||
				ident.Metadata != null && ident.Metadata.Contains(tag);

			//ident.Type != null &&
			//	(ident.Type == other.Type ||
			//	ident.Type.IsAssignableFrom(other.Type))
			//)
			;
		}
	}
}