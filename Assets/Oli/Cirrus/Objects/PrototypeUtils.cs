// using Cirrus.Content;
// using System;
// using UnityEngine;
// using static Cirrus.Debugging.DebugUtils;
// using static Cirrus.FuncGenerics;

// namespace Cirrus.Objects
// {
// 	// NOTE: This is mostly about functional inheritance here

// 	// TODO:
// 	// Delayed clone until operation only..


// 	// TODO: Add recycle call which just resets the values
// 	// whithout clearing
	
// 	// ANYTHING STATEFUL MUST BE ADDED IN THE REALIZE STEP
// 	// OTHERWISE IT CAN BE SHARED ACROSS PROTOTYPE CHAIN

// 	// TODO:
// 	// Generate copy constructor for all classes in an assembly. (CopyTo)

// 	public static class PrototypeUtils
// 	{
// 		//private static TProto _RealizeWithData<TProto, TData>(
// 		//	TProto prototype,
// 		//	TData data,
// 		//	Action<TData, TProto> preRealizeCb,
// 		//	Action<TData, TProto> postRealizeCb,
// 		//	bool inplace
// 		//	)
// 		//	where TProto : IRealizableResource
// 		//{
// 		//	Assert(prototype.IsRealizable, "This resource is unrealizable", true);
// 		//	TProto instance = default(TProto);
// 		//	if (prototype.IsProxy)
// 		//	{
// 		//		instance = ((Func<TProto>)prototype.ProxyCb)();
// 		//	}
// 		//	else
// 		//	{
// 		//		instance = inplace ? prototype : (TProto)prototype.Copy();
// 		//	}
// 		//	preRealizeCb?.Invoke(data, instance);
// 		//	if (instance.RealizeStepCbs != null)
// 		//	{
// 		//		for (int i = 0; i < instance.RealizeStepCbs.Length -1; i++)
// 		//		{
// 		//			var step = (Action<TProto>)instance.RealizeStepCbs[i];
// 		//			step.Invoke(instance);
// 		//		}
// 		//		// The last realize step uses data
// 		//	}
// 		//	postRealizeCb?.Invoke(data, instance);
// 		//	instance.OnResourceRealized();
// 		//	return instance;
// 		//}


// 		private static TProto _Realize<TProto>(
// 			TProto prototype,
// 			Action<TProto> preRealizeCb,
// 			Action<TProto> postRealizeCb,
// 			bool inplace
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			//Assert(prototype.IsRealizable, "This resource is unrealizable", true);
// 			TProto instance = prototype.ProxyCb != null ?
// 				((Func<TProto>)prototype.ProxyCb)() :
// 				inplace ? prototype : (TProto)prototype.Copy()
// 				;
// 			preRealizeCb?.Invoke(instance);
// 			if(instance.RealizeStepCbs != null)
// 			{
// 				if (instance.ProtoData != null)
// 				{
// 					for (int i = 0; i < instance.RealizeStepCbs.Length; i++)
// 					{
// 						var rawStep = instance.RealizeStepCbs[i];
// 						if (rawStep.IsAssignableFrom<Action<object, object>>())
// 						{
// 							((Action<object, object>)rawStep).Invoke(instance.ProtoData, instance);
// 						}
// 						else
// 						{
// 							((Action<TProto>)rawStep).Invoke(instance);
// 						}
// 					}
// 				}
// 				else
// 				{
// 					for (int i = 0; i < instance.RealizeStepCbs.Length; i++)
// 					{
// 						var step = (Action<TProto>)instance.RealizeStepCbs[i];
// 						step.Invoke(instance);
// 					}
// 				}
// 			}
// 			postRealizeCb?.Invoke(instance);
// 			instance.OnResourceRealized();
// 			return instance;
// 		}

// 		// TODO: maybe different data at different steps
// 		private static TProto _Realize<TData, TProto>(
// 			TProto prototype,
// 			TData data,
// 			Action<TData, TProto> preRealizeCb,
// 			Action<TData, TProto> postRealizeCb,			
// 			bool inplace
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			Assert(prototype.IsRealizable, "This resource is unrealizable", true);
// 			TProto instance = default(TProto);
// 			if (prototype.ProxyCb != null)
// 			{
// 				instance = ((Func<TProto>)prototype.ProxyCb)();
// 			}
// 			else
// 			{
// 				instance = inplace ? prototype : (TProto)prototype.Copy();
// 			}
// 			preRealizeCb?.Invoke(data, instance);
// 			if (instance.RealizeStepCbs != null)
// 			{
// 				for (int i = 0; i < instance.RealizeStepCbs.Length; i++)
// 				{
// 					var rawStep = instance.RealizeStepCbs[i];
// 					if (rawStep.GetType().IsAssignableFrom(typeof(Action<object, object>)))
// 					{
// 						((Action<TData, TProto>)rawStep).Invoke(data, instance);
// 					}
// 					else
// 					{
// 						((Action<TProto>)rawStep).Invoke(instance);
// 					}
// 				}
// 			}
// 			postRealizeCb?.Invoke(data, instance);
// 			instance.OnResourceRealized();
// 			return instance;
// 		}


// 		private static TProto _CopyPrototype<TProto>(
// 			TProto prototype,
// 			Action<TProto> prototypeCb,
// 			Action<TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			var myCopy = (TProto)prototype.Copy();
// 			myCopy.IsRealizable = true;
// 			return _PopulatePrototype(myCopy, prototypeCb, realizeStepCb);
// 		}

// 		private static TProto _CopyPrototype<TData, TProto>(
// 			TProto prototype,
// 			Action<TProto> prototypeCb,
// 			Action<TData, TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			var myCopy = (TProto)prototype.Copy();
// 			myCopy.IsRealizable = true;
// 			return _PopulatePrototype(myCopy, prototypeCb, realizeStepCb);
// 		}

// 		private static TProto _CopyPrototype<TData, TProto>(
// 			TProto prototype,
// 			Action<TData, TProto> prototypeCb,
// 			Action<TData, TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 			where TData : new()
// 		{
// 			var myCopy = (TProto)prototype.Copy();
// 			myCopy.IsRealizable = true;
// 			myCopy.ProtoData = new TData();
// 			return _PopulatePrototype(myCopy, prototypeCb, realizeStepCb);
// 		}


// 		private static TProto _PopulatePrototype<TProto>(
// 			TProto prototype,
// 			Action<TProto> prototypeCb,
// 			Action<TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			//T instance = (T)prototype.ShallowCopy();			
// 			Assert(prototype.IsRealizable, "This resource is unrealizable", true);
// 			prototype.AddRealizeStep(realizeStepCb);
// 			if(prototypeCb != null) prototypeCb.Invoke(prototype);
// 			return prototype;
// 		}

// 		private static TProto _PopulatePrototype<TData, TProto>(
// 			TProto prototype,
// 			Action<TProto> prototypeCb,
// 			Action<TData, TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			//T instance = (T)prototype.ShallowCopy();			
// 			Assert(prototype.IsRealizable, "This resource is unrealizable", true);
// 			prototype.AddRealizeStep(realizeStepCb);
// 			if (prototypeCb != null) prototypeCb.Invoke(prototype);
// 			return prototype;
// 		}

// 		private static TProto _PopulatePrototype<TData, TProto>(
// 			TProto prototype,
// 			Action<TData, TProto> prototypeCb,
// 			Action<TData, TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			//T instance = (T)prototype.ShallowCopy();			
// 			Assert(prototype.IsRealizable, "This resource is unrealizable", true);
// 			prototype.AddRealizeStep(realizeStepCb);
// 			if (prototypeCb != null) prototypeCb.Invoke((TData)prototype.ProtoData, prototype);
// 			return prototype;
// 		}



// 		private static TProto _Proxy<TProto>(
// 			TProto prototype,
// 			Func<TProto> proxyCb,
// 			Action<TProto> prototypeCb,
// 			Action<TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{			
// 			prototype.ProxyCb = proxyCb;
// 			_PopulatePrototype(prototype, prototypeCb, realizeStepCb);
// 			return prototype;
// 		}

// 		private static TProto _AddRealizeStep<TProto>(
// 			TProto prototype,
// 			Action<TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			if(realizeStepCb == null) return prototype;

// 			Assert(prototype.IsRealizable, "This resource is unrealizable", true);

// 			if (prototype.RealizeStepCbs == null)
// 			{
// 				prototype.RealizeStepCbs = new object[1];
// 			}
// 			else
// 			{
// 				prototype.RealizeStepCbs.CopyTo(
// 					prototype.RealizeStepCbs = new object[prototype.RealizeStepCbs.Length + 1],
// 					0);
// 			}
// 			// TODO can we do better than this?
// 			// Cannot support Action<Parent> casr Action<Derived> etc.
// 			prototype.RealizeStepCbs[prototype.RealizeStepCbs.Length - 1] = Action<object>(o => realizeStepCb.Invoke((TProto)o));
// 			return prototype;
// 		}

// 		private static TProto _AddRealizeStep<TData, TProto>(
// 			TProto prototype,
// 			Action<TData, TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			if (realizeStepCb == null) return prototype;

// 			Assert(prototype.IsRealizable, "This resource is unrealizable", true);

// 			if (prototype.RealizeStepCbs == null)
// 			{
// 				prototype.RealizeStepCbs = new object[1];
// 			}
// 			else
// 			{
// 				prototype.RealizeStepCbs.CopyTo(
// 					prototype.RealizeStepCbs = new object[prototype.RealizeStepCbs.Length + 1],
// 					0);
// 			}
// 			// TODO can we do better than this?
// 			// Cannot support Action<Parent> cast Action<Derived> etc.
// 			prototype.RealizeStepCbs[prototype.RealizeStepCbs.Length - 1] = Action<object, object>((data, o) => realizeStepCb.Invoke((TData)data, (TProto)o));
// 			return prototype;
// 		}

// 		// NOT TODO :)
// 		// Prototype Clone Number does not work well for range .. this the range is lost if cloned
// 		// No it is not lost..
// 		// But we could be dealing with ranges at unspected levels in the code
// 		// until the range is overwritten
// 		// We can do a plus one
// 		// NOTE:
// 		// I think this is fine, if as soon as we read the number the range is destroed.
// 		// They can still be cloned with no problem.



// 		// IPrototype should not depend on type
// 		// Because of this a lot of boiler plate code is added such
// 		// as interface specific Clone and also, Prototype member
// 		// I belive clone should operate on object...
// 		// the template argument just specifies the return type cast..


// 		//////////////////////////////////////////////////////////////

 

// 		public static TProto PrototypeExt<TProto>(
// 			this IResourceProvider<TProto> provider,
// 			Action<TProto> prototypeCb = null,
// 			Action<TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype(provider.Resource, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto Prototype<TProto>(
// 			this IResourceProvider<TProto> provider,
// 			Action<TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype(provider.Resource, null, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TData, TProto>(
// 			this IResourceProvider<TProto> provider,
// 			Action<TProto> prototypeCb = null,
// 			Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype(provider.Resource, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TData, TProto>(
// 			this IResourceProvider<TProto> provider,
// 			Action<TData, TProto> prototypeCb = null,
// 			Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 			where TData : new()
// 		{
// 			return _CopyPrototype(provider.Resource, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto Prototype<TData, TProto>(
// 			this IResourceProvider<TProto> provider,
// 			Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype(provider.Resource, (Action<TProto>)null, realizeStepCb);
// 		}


// 		// TODO rename Defered

// 		//public static T Defer<T>(
// 		//	this IResourceProvider<T> provider,
// 		//	Action<T> prototypeCb,
// 		//	Action<T> realizeStepCb
// 		//	)
// 		//	where T : IRealizableResource
// 		//{
// 		//	return _Copy(provider.Resource, prototypeCb, realizeStepCb);
// 		//}

// 		public static TProto Finalize<TProto>(this IResourceProvider<TProto> provider)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _Realize(provider.Resource, null, null, true);
// 		}

// 		public static TProto Realize<TProto>(
// 			this IResourceProvider<TProto> provider
// 			, Action<TProto> postCb = null
// 			, bool inplace = false
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _Realize(provider.Resource, null, postCb, inplace);
// 		}

// 		public static TProto RealizeExt<TProto>(
// 		this IResourceProvider<TProto> provider
// 		, Action<TProto> preCb
// 		, Action<TProto> postCb=null
// 		, bool inplace=false
// 		)
// 		where TProto : IRealizablePrototype
// 		{
// 			return _Realize(provider.Resource, preCb, postCb, inplace);
// 		}


// 		public static TProto Realize<TData, TProto>(
// 			this IResourceProvider<TProto> provider
// 			, TData data
// 			, Action<TData, TProto> postCb = null
// 			, bool inplace = false
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _Realize(provider.Resource, data, null, postCb, inplace);
// 		}

// 		public static TProto RealizeExt<TData, TProto>(
// 		this IResourceProvider<TProto> provider
// 		, TData data
// 		, Action<TData, TProto> preCb
// 		, Action<TData, TProto> postCb = null
// 		, bool inplace = false
// 		)
// 		where TProto : IRealizablePrototype
// 		{
// 			return _Realize(provider.Resource, data, preCb, postCb, inplace);
// 		}

// 		//public static TProto Realize<TData, TProto>(
// 		//	this IResourceProvider<TProto> provider,
// 		//	Action<TData, TProto> postCb = null
// 		//	)
// 		//	where TProto : IRealizableResource
// 		//{
// 		//	return _Realize(provider.Resource, null, postCb, false);
// 		//}

// 		//public static TProto RealizeExt<TProto>(
// 		//this IResourceProvider<TProto> provider,
// 		//Action<TProto> preCb,
// 		//Action<TProto> postCb = null
// 		//)
// 		//where TProto : IRealizableResource
// 		//{
// 		//	return _Realize(provider.Resource, preCb, postCb, false);
// 		//}



// 		//////////////////////////////////////////////////////////////
// 		///
// 		public static TProto PrototypeExt<TProto>(
// 			this IResourceProvider provider
// 			, Action<TProto> prototypeCb = null
// 			, Action<TProto> realizeStepCb = null
// 			)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _CopyPrototype((TProto)provider.Object, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto Prototype<TProto>(
// 			this IResourceProvider provider
// 			, Action<TProto> realizeStepCb = null
// 			)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _CopyPrototype((TProto)provider.Object, null, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TData, TProto>(
// 			this IResourceProvider provider
// 			, Action<TProto> prototypeCb = null
// 			, Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _CopyPrototype((TProto)provider.Object, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TData, TProto>(
// 			this IResourceProvider provider
// 			, Action<TData, TProto> prototypeCb = null
// 			, Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : class, IRealizablePrototype
// 			where TData : new()
// 		{
// 			return _CopyPrototype((TProto)provider.Object, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto Prototype<TData, TProto>(
// 			this IResourceProvider provider
// 			, Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _CopyPrototype((TProto)provider.Object, (Action<TProto>)null, realizeStepCb);
// 		}

// 		public static TProto Finalize<TProto>(this IResourceProvider provider)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _Realize((TProto)provider.Object, null, null, true);
// 		}


// 		public static TProto Realize<TProto>(
// 			this IResourceProvider provider
// 			, Action<TProto> postCb = null
// 			, bool inplace = false
// 			)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _Realize((TProto)provider.Object, null, postCb, inplace);
// 		}

// 		public static TProto RealizeExt<TProto>(
// 			this IResourceProvider provider,
// 			Action<TProto> preCb
// 			, Action<TProto> postCb=null
// 			, bool inplace = false
// 			)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _Realize((TProto)provider.Object, preCb, postCb, inplace);
// 		}

// 		public static TProto Realize<TData, TProto>(
// 			this IResourceProvider provider,
// 			TData data
// 			, Action<TData, TProto> postCb = null
// 			, bool inplace = false
// 			)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _Realize((TProto)provider.Object, data, null, postCb, inplace);
// 		}

// 		public static TProto RealizeExt<TData, TProto>(
// 			this IResourceProvider provider
// 			, TData data
// 			, Action<TData, TProto> preCb
// 			, Action<TData, TProto> postCb = null
// 			, bool inplace = false
// 			)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _Realize((TProto)provider.Object, data, preCb, postCb, inplace);
// 		}


// 		//////////////////////////////////////////////////////////////
// 		public static TProto PrototypeExt<TProto>(
// 			this TProto prototype
// 			, Action<TProto> prototypeCb=null
// 			, Action<TProto> realizeStepCb=null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype(prototype, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto Prototype<TProto>(
// 			this TProto prototype
// 			, Action<TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype(prototype, null, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TData, TProto>(
// 			this TProto prototype
// 			, Action<TProto> prototypeCb = null
// 			, Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype(prototype, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TData, TProto>(
// 			this TProto prototype
// 			, Action<TData, TProto> prototypeCb = null
// 			, Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 			where TData : new()
// 		{
// 			return _CopyPrototype(prototype, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto Prototype<TData, TProto>(
// 			this TProto prototype
// 			, Action<TData, TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype(prototype, (Action<TProto>)null, realizeStepCb);
// 		}

// 		//public static T Defer<T>(
// 		//	this T prototype,
// 		//	Action<T> prototypeCb,
// 		//	Action<T> realizeStepCb
// 		//	)
// 		//	where T : IRealizableResource
// 		//{
// 		//	return _Copy(prototype, prototypeCb, realizeStepCb);
// 		//}

// 		public static TProto Finalize<TProto>(this TProto prototype) where TProto : IRealizablePrototype
// 		{
// 			return _Realize(prototype, null, null, true);
// 		}

// 		public static TProto Realize<TProto>(
// 			this TProto prototype
// 			, Action<TProto> postCb = null
// 			, bool inplace = false
// 			) where TProto : IRealizablePrototype

// 		{
// 			return _Realize(prototype, null, postCb, inplace);
// 		}
// 		public static TProto RealizeExt<TProto>(
// 			this TProto prototype
// 			, Action<TProto> preCb
// 			, Action<TProto> postCb=null
// 			, bool inplace = false
// 			) where TProto : IRealizablePrototype

// 		{
// 			return _Realize(prototype, preCb, postCb, inplace);
// 		}

// 		public static TProto Realize<TData, TProto>(
// 			this TProto prototype
// 			, TData data
// 			, Action<TData, TProto> postCb = null
// 			, bool inplace = false
// 			) where TProto : IRealizablePrototype

// 		{
// 			return _Realize(prototype, data, null, postCb, inplace);
// 		}
// 		public static TProto RealizeExt<TData, TProto>(
// 			this TProto prototype
// 			, TData data
// 			, Action<TData, TProto> preCb
// 			, Action<TData, TProto> postCb = null
// 			, bool inplace = false
// 			) where TProto : IRealizablePrototype

// 		{
// 			return _Realize(prototype, data, preCb, postCb, inplace);
// 		}

// 		//////////////////////////////////////////////////////////////
// 		public static TProto PrototypeExt<TProto>(
// 			this IRealizablePrototype prototype
// 			, Action<TProto> prototypeCb = null
// 			, Action<TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype((TProto)prototype, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto Prototype<TProto>(
// 			this IRealizablePrototype prototype
// 			, Action<TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype((TProto)prototype, null, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TData, TProto>(
// 			this IRealizablePrototype prototype
// 			, Action<TProto> prototypeCb = null
// 			, Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype((TProto)prototype, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TData, TProto>(
// 			this IRealizablePrototype prototype
// 			, Action<TData, TProto> prototypeCb = null
// 			, Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 			where TData : new()
// 		{
// 			return _CopyPrototype((TProto)prototype, prototypeCb, realizeStepCb);
// 		}


// 		public static TProto Prototype<TData, TProto>(
// 			this IRealizablePrototype prototype
// 			, Action<TData, TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _CopyPrototype((TProto)prototype, (Action<TProto>)null, realizeStepCb);
// 		}

// 		//////////////////////////////////////////////////////////////		


// 		public static TProto Prototype<TProto>(
// 			Action<TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype, new()
// 		{
// 			return _PopulatePrototype(new TProto() { IsRealizable = true }, (Action<TProto>)null, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TProto>(
// 			Action<TProto> prototypeCb=null
// 			, Action<TProto> realizeStepCb=null
// 			)
// 			where TProto : IRealizablePrototype, new()
// 		{
// 			return _PopulatePrototype(new TProto() { IsRealizable = true }, prototypeCb, realizeStepCb);
// 		}

// 		//TODO: We would need CopyTo method for this to work
// 		// This is simply a bad workaround for CopyTo
// 		// TODO: Problem with this is no prototypeCb
// 		public static TProto Proxy<TProto>(
// 		Func<TProto> proxyCb = null
// 		, Action<TProto> realizeStepCb = null
// 		)
// 		where TProto : IRealizablePrototype, new()
// 		{
// 			return _Proxy(new TProto() { IsRealizable = true }, proxyCb, null, realizeStepCb);
// 		}



// 		public static TProto Prototype<TData, TProto>(
// 			Action<TData, TProto> realizeStepCb
// 			)
// 			where TProto : IRealizablePrototype, new()
// 		{
// 			return _PopulatePrototype(new TProto() { IsRealizable = true }, (Action<TProto>)null, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TData, TProto>(
// 			Action<TProto> prototypeCb = null
// 			, Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype, new()
// 		{
// 			return _PopulatePrototype(new TProto() { IsRealizable = true }, prototypeCb, realizeStepCb);
// 		}

// 		public static TProto PrototypeExt<TData, TProto>(
// 			Action<TData, TProto> prototypeCb = null
// 			, Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype, new()
// 			where TData : new()
// 		{
// 			return _PopulatePrototype(new TProto() { IsRealizable = true }, prototypeCb, realizeStepCb);
// 		}



// 		public static TProto Finalize<TProto>(this IRealizablePrototype prototype)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _Realize((TProto)prototype, null, null, true);
// 		}

// 		public static TProto Realize<TProto>(
// 			this IRealizablePrototype prototype
// 			, Action<TProto> postCb = null
// 			, bool inplace = false
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _Realize((TProto)prototype, null, postCb, inplace);
// 		}

// 		public static TProto RealizeExt<TProto>(
// 			this IRealizablePrototype prototype
// 			, Action<TProto> preCb
// 			, Action<TProto> postCb=null
// 			, bool inplace = false
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _Realize((TProto)prototype, preCb, postCb, inplace);
// 		}


// 		public static TProto Realize<TData, TProto>(
// 			this IRealizablePrototype prototype
// 			, TData data
// 			, Action<TData, TProto> postCb = null
// 			, bool inplace = false
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _Realize((TProto)prototype, data, null, postCb, inplace);
// 		}

// 		public static TProto RealizeExt<TData, TProto>(
// 			this IRealizablePrototype prototype
// 			, TData data
// 			, Action<TData, TProto> preCb
// 			, Action<TData, TProto> postCb = null
// 			, bool inplace = false
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _Realize((TProto)prototype, data, preCb, postCb, inplace);
// 		}


// 		//////////////////////////////////////////////////////////////		

// 		public static T Realize<T>(
// 			Action<T> realizeCb = null
// 			)
// 			where T : IRealizablePrototype, new()
// 		{
// 			return _Realize(new T() { IsRealizable = true }, null, realizeCb, true);
// 		}

// 		public static T RealizeExt<T>(
// 			Action<T> preCb,
// 			Action<T> postCb = null
// 			)
// 			where T : IRealizablePrototype, new()
// 		{
// 			return _Realize(new T() { IsRealizable = true }, preCb, postCb, true);
// 		}



// 		//////////////////////////////////////////////////////////////		



// 		//////////////////////////////////
// 		///
// 		public static TProto AddRealizeStep<TProto>(
// 			this IResourceProvider<TProto> provider,
// 			Action<TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{

// 			return _AddRealizeStep(provider.Resource, realizeStepCb);
// 		}

// 		public static TProto AddRealizeStep<TProto>(
// 			this IResourceProvider provider,
// 			Action<TProto> realizeStepCb = null
// 			)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _AddRealizeStep((TProto)provider.Object, realizeStepCb);
// 		}

// 		public static TProto AddRealizeStep<TProto>(
// 			this TProto prototype,
// 			Action<TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _AddRealizeStep(prototype, realizeStepCb);
// 		}

// 		public static TProto AddRealizeStep<TProto>(
// 			this IRealizablePrototype prototype,
// 			Action<TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _AddRealizeStep((TProto)prototype, realizeStepCb);
// 		}

// 		///////////


// 		public static TProto AddRealizeStep<TData, TProto>(
// 		this IResourceProvider<TProto> provider,
// 		Action<TProto> realizeStepCb = null
// 		)
// 		where TProto : IRealizablePrototype
// 		{

// 			return _AddRealizeStep(provider.Resource, realizeStepCb);
// 		}

// 		public static TProto AddRealizeStep<TData, TProto>(
// 			this IResourceProvider provider,
// 			Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : class, IRealizablePrototype
// 		{
// 			return _AddRealizeStep((TProto)provider.Object, realizeStepCb);
// 		}

// 		public static TProto AddRealizeStep<TData, TProto>(
// 			this TProto prototype,
// 			Action<TData, TProto> realizeStepCb = null
// 			)
// 			where TProto : IRealizablePrototype
// 		{
// 			return _AddRealizeStep(prototype, realizeStepCb);
// 		}

// 		public static TProto AddRealizeStep<TData, TProto>(
// 		this IRealizablePrototype prototype,
// 		Action<TData, TProto> realizeStepCb = null
// 		)
// 		where TProto : IRealizablePrototype
// 		{
// 			return _AddRealizeStep((TProto)prototype, realizeStepCb);
// 		}

// 	}
// }
