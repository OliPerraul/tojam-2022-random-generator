using Cirrus.Unity.Editor;
using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Cirrus.Unity.Objects
{
	#region Func Wrappers

	public class DelegateAssetBase : ScriptableObjectBase
	{
#if UNITY_EDITOR
		[ReadOnly]
		[SerializeField]		
		public Object Owner;
#endif
	}

	public abstract class ActionAssetBase : DelegateAssetBase
	{
	}

	public abstract class FuncAssetBase : DelegateAssetBase
	{
	}

	public abstract class FuncAsset<
		//A
		//, B
		//, C
		//, D
		Ret
		> : FuncAssetBase
	{
		public static implicit operator Func<
		//A
		//, B
		//, C
		//, D
		Ret
		>
		(
		FuncAsset<
		//A
		//, B
		//, C
		//, D
		Ret
		>
		fn
		)
		{
			return fn.Invoke;
		}

		public
			virtual
			Ret
			Invoke
			(
			//A a
			//, B b
			//, C c
			//, D d
			)
		{
			return default(Ret);
		}
	}

	public abstract class FuncAsset<
		A
		//, B
		//, C
		//, D
		, Ret
		> : FuncAssetBase
	{
		public static implicit operator Func<
		A
		//, B
		//, C
		//, D
		, Ret
		>
		(
		FuncAsset<
		A
		//, B
		//, C
		//, D
		, Ret
		>
		fn
		)
		{
			return fn.Invoke;
		}

		public
			virtual
			Ret
			Invoke
			(
			A a
			//, B b
			//, C c
			//, D d
			)
		{
			return default(Ret);
		}
	}


	public abstract class FuncAsset<
		A
		, B
		//, C
		//, D
		, Ret
		> : FuncAssetBase
	{
		public static implicit operator Func<
		A
		, B
		//, C
		//, D
		, Ret
		>
		(
		FuncAsset<
		A
		, B
		//, C
		//, D
		, Ret
		>
		fn
		)
		{
			return fn.Invoke;
		}

		public
			virtual
			Ret
			Invoke
			(
			A a
			, B b
			//, C c
			//, D d
			)
		{
			return default(Ret);
		}
	}

	public abstract class FuncAsset<
		A
		, B
		, C
		//, D
		, Ret
		> : FuncAssetBase
	{
		public static implicit operator Func<
		A
		, B
		, C
		//, D
		, Ret
		>
		(
		FuncAsset<
		A
		, B
		, C
		//, D
		, Ret
		>
		fn
		)
		{
			return fn.Invoke;
		}

		public
			virtual
			Ret
			Invoke
			(
			A a
			, B b
			, C c
			//, D d
			)
		{
			return default(Ret);
		}
	}

	public abstract class FuncAsset<
		A
		, B
		, C
		, D
		, Ret
		> : FuncAssetBase
	{
		public static implicit operator Func<
		A
		, B
		, C
		, D
		, Ret
		>
		(
		FuncAsset<
		A
		, B
		, C
		, D
		, Ret
		>
		fn
		)
		{
			return fn.Invoke;
		}

		public
			virtual
			Ret
			Invoke
			(
			A a
			, B b
			, C c
			, D d
			)
		{
			return default(Ret);
		}
	}


	#endregion

	#region Action Wrappers

	public abstract class ActionAsset<
		A
		//, B
		//, C
		//, D
		//, Ret
		> : ActionAssetBase
	{
		public static implicit operator Action<
		A
		//, B
		//, C
		//, D
		//, Ret
		>
		(
		ActionAsset<
		A
		//, B
		//, C
		//, D
		//, Ret
		>
		fn
		)
		{
			return fn.Invoke;
		}

		public
			virtual
			void
			Invoke
			(
			A a
			//, B b
			//, C c
			//, D d
			)
		{
		}
	}

	public abstract class ActionAsset<
		A
		, B
		//, C
		//, D
		//, Ret
		> : ActionAssetBase
	{
		public static implicit operator Action<
		A
		, B
		//, C
		//, D
		//, Ret
		>
		(
		ActionAsset<
		A
		, B
		//, C
		//, D
		//, Ret
		>
		fn
		)
		{
			return fn.Invoke;
		}

		public
			virtual
			void
			Invoke
			(
			A a
			, B b
			//, C c
			//, D d
			)
		{
		}
	}

	public abstract class ActionAsset<
		A
		, B
		, C
		//, D
		//, Ret
		> : ActionAssetBase
	{
		public static implicit operator Action<
		A
		, B
		, C
		//, D
		//, Ret
		>
		(
		ActionAsset<
		A
		, B
		, C
		//, D
		//, Ret
		>
		fn
		)
		{
			return fn.Invoke;
		}

		public
			virtual
			void
			Invoke
			(
			A a
			, B b
			, C c
			//, D d
			)
		{
		}
	}

	public abstract class ActionAsset<
	A
	, B
	, C
	, D
	//, Ret
	> : ActionAssetBase
	{
		public static implicit operator Action<
		A
		, B
		, C
		, D
		//, Ret
		>
		(
		ActionAsset<
		A
		, B
		, C
		, D
		//, Ret
		>
		fn
		)
		{
			return fn.Invoke;
		}

		public
			virtual
			void
			Invoke
			(
			A a
			, B b
			, C c
			, D d
			)
		{
		}
	}

	#endregion

}
