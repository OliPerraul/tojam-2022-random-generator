using System;

namespace Cirrus
{
	public static class ActionGeneric<
	A
	, B
	, C
	, D	
	>
	{
		public static Action<
			A
			, B
			, C
			, D
			> 
			Action(Action<
				A
				, B
				, C
				, D
				>
			fn)
		{
			return fn;
		}
	}

	public static class FuncGeneric<
	A
	, B
	, C
	, D
	, ReturnType
	>
	{
		public static Func<
			A
			, B
			, C
			, D
			, ReturnType
			> Func(Func<
				A
				, B
				, C
				, D
				, ReturnType>
			fn)
		{
			return fn;
		}
	}

	public static class ActionGeneric<
		A
		, B
		, C
		>
	{
		public static Action<
			A
			, B
			, C
			> Action(Action<
				A
				, B
				, C				
				>
			fn)
		{
			return fn;
		}
	}

	public static class FuncGeneric<
	A
	, B
	, C
	, ReturnType
	>
	{
		public static Func<
			A
			, B
			, C
			, ReturnType
			> Func(Func<
				A
				,B
				,C
				, ReturnType>
			fn)
		{
			return fn;
		}
	}

	public static class FuncGeneric<
		A
		,B
		,ReturnType
		>
	{
		public static Func<
			A
			,B
			,ReturnType
			> Func(Func<
				A
				,B
				,ReturnType
				> 
			fn)
		{
			return fn;
		}
	}

	public static class ActionGeneric<
		A
		, B
		>
	{
		public static Action<
			A
			, B			
			> Action(Action<
				A
				, B				
				>
			fn)
		{
			return fn;
		}
	}

	public static class FuncGeneric<
	A
	, ReturnType
	>
	{
		public static Func<
			A
			,ReturnType
			> Func(Func<
				A
				,ReturnType
				> fn)
		{
			return fn;
		}
	}

	public static class ActionGeneric<
		A
		>
	{
		public static Action<
			A
			> 
			Action(Action<
				A
				>
			fn)
		{
			return fn;
		}
	}

	public static class FuncGeneric<ReturnType>
	{
		public static Func<
			ReturnType
			> Func(Func<
				ReturnType
				>
			fn)
		{
			return fn;
		}
	}

	public static class FuncGenerics
	{	
		#region Actions

		public static void EvalAction<
			A
			, B
			, C
			, D
			, E
			>
			(this object action,
			A a
			, B b
			, C c
			, D d
			, E e
			)
		{
			((Action<
				A
				, B
				, C
				, D
				, E
				>)action)(
				a
				, b
				, c
				, d
				, e
				);
		}

		public static void EmptyAction<
		A
		, B
		, C
		, D
		, E
		>
		(
		A a
		, B b
		, C c
		, D d
		, E e
		)
		{
		}

		public static Action<
			A
			, B
			, C
			, D
			, E
			>
			Action<
			A
			, B
			, C
			, D
			, E
			>
			(Action<
				A
				, B
				, C
				, D
				, E
				>
				action
			)
		{
			return action;
		}

		public static void EvalAction<
			A
			, B
			, C
			, D
			//, E
			>
			(this object action,
			A a
			, B b
			, C c
			, D d
			//, E e
			)
		{
			((Action<
				A
				, B
				, C
				, D
				//, E
				>)action)(
				a
				, b
				, c
				, d
				//, e
				);
		}

		public static void EmptyAction<
		A
		, B
		, C
		, D
		//, E
		>
		(
		A a
		, B b
		, C c
		, D d
		//, E e
		)
		{
		}

		public static Action<
			A
			, B
			, C
			, D
			//, E
			>
			Action<
			A
			, B
			, C
			, D
			//, E
			>
			(Action<
				A
				, B
				, C
				, D
				//, E
				>
				action
			)
				{
					return action;
				}

		public static void EvalAction<
			A
			, B
			, C
			//, D
			//, E
			>
			(this object action,
			A a
			, B b
			, C c
			//, D d
			//, E e
			)
		{
			((Action<
				A
				, B
				, C
				//, D
				//, E
				>)action)(
				a
				, b
				, c
				//, d
				//, e
				);
		}

		public static void EmptyAction<
		A
		, B
		, C
		//, D
		//, E
		>
		(
		A a
		, B b
		, C c
		//, D d
		//, E e
		)
		{
		}

		public static Action<
			A
			, B
			, C
			//, D
			//, E
			>
			Action<
			A
			, B
			, C
			//, D
			//, E
			>
			(Action<
				A
				, B
				, C
				//, D
				//, E
				>
				action
			)
				{
					return action;
				}

		public static void EvalAction<
			A
			, B
			//, C
			//, D
			//, E
			>
			(this object action,
			A a
			, B b
			//, C c
			//, D d
			//, E e
			)
		{
			((Action<
				A
				, B
				//, C
				//, D
				//, E
				>)action)(
				a
				, b
				//, c
				//, d
				//, e
				);
		}

		public static void EmptyAction<
		A
		, B
		//, C
		//, D
		//, E
		>
		(
		A a
		, B b
		//, C c
		//, D d
		//, E e
		)
		{
		}

		public static Action<
			A
			, B
			//, C
			//, D
			//, E
			>
			Action<
			A
			, B
			//, C
			//, D
			//, E
			>
			(Action<
				A
				, B
				//, C
				//, D
				//, E
				>
				action
			)
		{
			return action;
		}

		public static void EvalAction<
			A
			//, B
			//, C
			//, D
			//, E
			>
			(this object action,
			A a
			//, B b
			//, C c
			//, D d
			//, E e
			)
		{
			((Action<
				A
				//, B
				//, C
				//, D
				//, E
				>)action)(
				a
				//, b
				//, c
				//, d
				//, e
				);
		}

		public static void EmptyAction<
		A
		//, B
		//, C
		//, D
		//, E
		>
		(
		A a
		//, B b
		//, C c
		//, D d
		//, E e
		)
		{
		}

		public static Action<
			A
			//, B
			//, C
			//, D
			//, E
			>
			Action<
			A
			//, B
			//, C
			//, D
			//, E
			>
			(Action<
				A
				//, B
				//, C
				//, D
				//, E
				>
				action
			)
		{
			return action;
		}

		public static void EvalAction
			//A
			//, B
			//, C
			//, D
			//, E
			(this object action
			//A a
			//, B b
			//, C c
			//, D d
			//, E e
			)
		{
			((Action
				//A
				//, B
				//, C
				//, D
				//, E
				)action)(
				//a
				//, b
				//, c
				//, d
				//, e
				);
		}

		public static void EmptyAction
		//<
		//A
		//, B
		//, C
		//, D
		//, E
		//>
		(
		//A a
		//, B b
		//, C c
		//, D d
		//, E e
		)
		{
		}

		public static Action
			//<
			//A
			//, B
			//, C
			//, D
			//, E
			//>
			Action
			//<
			//A
			//, B
			//, C
			//, D
			//, E
			//>
			(Action
				//<
				//A
				//, B
				//, C
				//, D
				//, E
				//>
				action
			)
		{
			return action;
		}

		#endregion Actions

		#region Funcs

		public static ReturnType EvalFunc<
			A
			, B
			, C
			, D
			, E
			, ReturnType
			>
			(this object fn,
			A a
			, B b
			, C c
			, D d
			, E e
			)
		{
			return ((Func<
				A
				, B
				, C
				, D
				, E
				, ReturnType
				>)fn)(
				a
				, b
				, c
				, d
				, e
				);
		}

		public static ReturnType EvalFunc<
			A
			, B
			, C
			, D
			, E
			, ReturnType
			>
			(
			A a
			, B b
			, C c
			, D d
			, E e
			)
		{
			return default(ReturnType);
		}

		public static Func<
			A
			, B
			, C
			, D
			, E
			, ReturnType
			>
			Func<
			A
			, B
			, C
			, D
			, E
			, ReturnType
			>
			(Func<
				A
				, B
				, C
				, D
				, E
				, ReturnType
				>
				action
			)
		{
			return action;
		}

		public static ReturnType EvalFunc<
			A
			, B
			, C
			, D
			//, E
			, ReturnType
			>
			(this object fn,
			A a
			, B b
			, C c
			, D d
			//, E e
			)
		{
			return ((Func<
				A
				, B
				, C
				, D
				//, E
				, ReturnType
				>)fn)(
				a
				, b
				, c
				, d
				//, e
				);
		}

		public static ReturnType EvalFunc<
			A
			, B
			, C
			, D
			//, E
			, ReturnType
			>
			(
			A a
			, B b
			, C c
			, D d
			//, E e
			)
		{
			return default(ReturnType);
		}

		public static Func<
			A
			, B
			, C
			, D
			//, E
			, ReturnType
			>
			Func<
			A
			, B
			, C
			, D
			//, E
			, ReturnType
			>
			(Func<
				A
				, B
				, C
				, D
				//, E
				, ReturnType
				>
				action
			)
		{
			return action;
		}

		public static ReturnType EvalFunc<
			A
			, B
			, C
			//, D
			//, E
			, ReturnType
			>
			(this object fn,
			A a
			, B b
			, C c
			//, D d
			//, E e
			)
		{
			return ((Func<
				A
				, B
				, C
				//, D
				//, E
				, ReturnType
				>)fn)(
				a
				, b
				, c
				//, d
				//, e
				);
		}

		public static ReturnType EvalFunc<
			A
			, B
			, C
			//, D
			//, E
			, ReturnType
			>
			(
			A a
			, B b
			, C c
			//, D d
			//, E e
			)
		{
			return default(ReturnType);
		}

		public static Func<
			A
			, B
			, C
			//, D
			//, E
			, ReturnType
			>
			Func<
			A
			, B
			, C
			//, D
			//, E
			, ReturnType
			>
			(Func<
				A
				, B
				, C
				//, D
				//, E
				, ReturnType
				>
				action
			)
		{
			return action;
		}

		public static ReturnType EvalFunc<
			A
			, B
			//, C
			//, D
			//, E
			, ReturnType
			>
			(this object fn,
			A a
			, B b
			//, C c
			//, D d
			//, E e
			)
		{
			return ((Func<
				A
				, B
				//, C
				//, D
				//, E
				, ReturnType
				>)fn)(
				a
				, b
				//, c
				//, d
				//, e
				);
		}

		public static ReturnType EvalFunc<
			A
			, B
			//, C
			//, D
			//, E
			, ReturnType
			>
			(
			A a
			, B b
			//, C c
			//, D d
			//, E e
			)
		{
			return default(ReturnType);
		}

		public static Func<
			A
			, B
			//, C
			//, D
			//, E
			, ReturnType
			>
			Func<
			A
			, B
			//, C
			//, D
			//, E
			, ReturnType
			>
			(Func<
				A
				, B
				//, C
				//, D
				//, E
				, ReturnType
				>
				action
			)
		{
			return action;
		}

		public static ReturnType EvalFunc<
			A
			//, B
			//, C
			//, D
			//, E
			, ReturnType
			>
			(this object fn,
			A a
			//, B b
			//, C c
			//, D d
			//, E e
			)
		{
			return ((Func<
				A
				//, B
				//, C
				//, D
				//, E
				, ReturnType
				>)fn)(
				a
				//, b
				//, c
				//, d
				//, e
				);
		}

		public static ReturnType EvalFunc<
			A
			//, B
			//, C
			//, D
			//, E
			, ReturnType
			>
			(
			A a
			//, B b
			//, C c
			//, D d
			//, E e
			)
		{
			return default(ReturnType);
		}

		public static Func<
			A
			//, B
			//, C
			//, D
			//, E
			, ReturnType
			>
			Func<
			A
			//, B
			//, C
			//, D
			//, E
			, ReturnType
			>
			(Func<
				A
				//, B
				//, C
				//, D
				//, E
				, ReturnType
				>
				action
			)
		{
			return action;
		}

		public static ReturnType EvalFunc<
		//A
		//, B
		//, C
		//, D
		//, E
		ReturnType
		>
		(this object fn
		//A a
		//, B b
		//, C c
		//, D d
		//, E e
		)
		{
			return ((Func<
				//A
				//, B
				//, C
				//, D
				//, E
				ReturnType
				>)fn)(
				//a
				//, b
				//, c
				//, d
				//, e
				);
		}

		public static ReturnType EvalFunc
			<
			//A
			//, B
			//, C
			//, D
			//, E
			//, 
			ReturnType
			>
			(
			//A a
			//, B b
			//, C c
			//, D d
			//, E e
			)
		{
			return default(ReturnType);
		}

		public static Func<
			//A
			//, B
			//, C
			//, D
			//, E
			ReturnType
			>
			Func<
			//A
			//, B
			//, C
			//, D
			//, E
			ReturnType
			>
			(Func<
				//A
				//, B
				//, C
				//, D
				//, E
				ReturnType
				>
				action
			)
		{
			return action;
		}

		#endregion Funcs
	}


	#region Func Wrappers

	public class FuncWrapper<
		A
		//, B
		//, C
		//, D
		, Ret
		>
	{
		public static implicit operator Func<
	A
	//, B
	//, C
	//, D
	, Ret
	>
(
FuncWrapper<
	A
	//, B
	//, C
	//, D
	, Ret
	>
	fn
)
		{
			return fn.Func;
		}

		public static implicit operator FuncWrapper<
			A
			//, B
			//, C
			//, D
			, Ret
			>
		(
		Func<
			A
			//, B
			//, C
			//, D
			, Ret
			>
			fn
		)
		{
			return new FuncWrapper<
				A
				//, B
				//, C
				//, D
				, Ret
				>
				(fn);
		}

		public Func<
			A
			//, B
			//, C
			//, D
			, Ret
			> Func;

		public FuncWrapper(Func<
			A
			//, B
			//, C
			//, D
			, Ret> fn)
		{
			Func = fn;
		}

		public Ret Invoke(
			A a
			//, B b
			//, C c
			//, D d
			)
		{
			return Func.Invoke(a);
		}
	}

	public class FuncWrapper<
			A
			, B
			//, C
			//, D
			, Ret
			>
	{
		public static implicit operator Func<
	A
	, B
	//, C
	//, D
	, Ret
	>
(
FuncWrapper<
	A
	, B
	//, C
	//, D
	, Ret
	>
	fn
)
		{
			return fn.Func;
		}

		public static implicit operator FuncWrapper<
			A
			, B
			//, C
			//, D
			, Ret
			>
		(
		Func<
			A
			, B
			//, C
			//, D
			, Ret
			>
			fn
		)
		{
			return new FuncWrapper<
				A
				, B
				//, C
				//, D
				, Ret
				>
				(fn);
		}

		public Func<
			A
			, B
			//, C
			//, D
			, Ret
			> Func;

		public FuncWrapper(Func<
			A
			, B
			//, C
			//, D
			, Ret> fn)
		{
			Func = fn;
		}

		public Ret Invoke(
			A a
			, B b
			//, C c
			//, D d
			)
		{
			return Func.Invoke(a, b);
		}
	}

	public class FuncWrapper<
		A
		, B
		, C
		//, D
		, Ret
		>
	{

		public static implicit operator Func<
			A
			, B
			, C
			, Ret
			>
		(
		FuncWrapper<
			A
			, B
			, C
			, Ret
			>
			fn
		)
		{
			return fn.Func;
		}

		public static implicit operator FuncWrapper<
			A
			, B
			, C
			, Ret
			>
		(
		Func<
			A
			, B
			, C
			, Ret
			>
			fn
		)
		{
			return new FuncWrapper<
				A
				, B
				, C
				, Ret
				>
				(fn);
		}

		public Func<
			A
			, B
			, C
			//, D
			, Ret
			> Func;

		public FuncWrapper(Func<
			A
			, B
			, C
			//, D
			, Ret> fn)
		{
			Func = fn;
		}

		public Ret Invoke(
			A a
			, B b
			, C c
			//, D d
			)
		{
			return Func.Invoke(a, b, c);
		}
	}

	public class FuncWrapper<
		A
		, B
		, C
		, D
		, Ret
		>
	{

		public static implicit operator Func<
			A
			, B
			, C
			, D
			, Ret
			>
		(
		FuncWrapper<
			A
			, B
			, C
			, D
			, Ret
			>
			fn
		)
		{
			return fn.Func;
		}

		public static implicit operator FuncWrapper<
			A
			, B
			, C
			, D
			, Ret
			>
		(
		Func<
			A
			, B
			, C
			, D
			, Ret
			>
			fn
		)
		{
			return new FuncWrapper<
				A
				, B
				, C
				, D
				, Ret
				>
				(fn);
		}

		public Func<
			A
			, B
			, C
			, D
			, Ret
			> Func;

		public FuncWrapper(Func<
			A
			, B
			, C
			, D
			, Ret> fn)
		{
			Func = fn;
		}

		public Ret Invoke(
			A a
			, B b
			, C c
			, D d
			)
		{
			return Func.Invoke(a, b, c, d);
		}
	}

	#endregion

	#region Action Wrappers

	public class ActionWrapper<
		A
		//, B
		//, C
		//, D
		//, Ret
		>
	{

		public static implicit operator Action<
			A
			//, B
			//, C
			//, D
			//, Ret
			>
		(
		ActionWrapper<
			A
			//, B
			//, C
			//, D
			//, Ret
			>
			fn
		)
		{
			return fn.Action;
		}

		public static implicit operator ActionWrapper<
			A
			//, B
			//, C
			//, D
			//, Ret
			>
		(
		Action<
			A
			//, B
			//, C
			//, D
			//, Ret
			>
			fn
		)
		{
			return new ActionWrapper<
				A
				//, B
				//, C
				//, D
				//, Ret
				>
				(fn);
		}

		public Action<
			A
			//, B
			//, C
			//, D
			//, Ret
			> Action;

		public ActionWrapper(Action<
			A
			//, B
			//, C
			//, D
			> fn)
		{
			Action = fn;
		}

		public void Invoke(
			A a
			//, B b
			//, C c
			//, D d
			)
		{
			Action.Invoke(a);
		}
	}


	public class ActionWrapper<
		A
		, B
		//, C
		//, D
		//, Ret
		>
	{

		public static implicit operator Action<
			A
			, B
			//, C
			//, D
			//, Ret
			>
		(
		ActionWrapper<
			A
			, B
			//, C
			//, D
			//, Ret
			>
			fn
		)
		{
			return fn.Action;
		}

		public static implicit operator ActionWrapper<
			A
			, B
			//, C
			//, D
			//, Ret
			>
		(
		Action<
			A
			, B
			//, C
			//, D
			//, Ret
			>
			fn
		)
		{
			return new ActionWrapper<
				A
				, B
				//, C
				//, D
				//, Ret
				>
				(fn);
		}

		public Action<
			A
			, B
			//, C
			//, D
			//, Ret
			> Action;

		public ActionWrapper(Action<
			A
			, B
			//, C
			//, D
			> fn)
		{
			Action = fn;
		}

		public void Invoke(
			A a
			, B b
			//, C c
			//, D d
			)
		{
			Action.Invoke(a, b);
		}
	}


	public class ActionWrapper<
		A
		, B
		, C
		//, D
		//, Ret
		>
	{

		public static implicit operator Action<
			A
			, B
			, C
			//, D
			//, Ret
			>
		(
		ActionWrapper<
			A
			, B
			, C
			//, D
			//, Ret
			>
			fn
		)
		{
			return fn.Action;
		}

		public static implicit operator ActionWrapper<
			A
			, B
			, C
			//, D
			//, Ret
			>
		(
		Action<
			A
			, B
			, C
			//, D
			//, Ret
			>
			fn
		)
		{
			return new ActionWrapper<
				A
				, B
				, C
				//, D
				//, Ret
				>
				(fn);
		}

		public Action<
			A
			, B
			, C
			//, D
			//, Ret
			> Action;

		public ActionWrapper(Action<
			A
			, B
			, C
			//, D
			> fn)
		{
			Action = fn;
		}

		public void Invoke(
			A a
			, B b
			, C c
			//, D d
			)
		{
			Action.Invoke(a, b, c);
		}
	}


	public class ActionWrapper<
		A
		, B
		, C
		, D
		//, Ret
		>
	{

		public static implicit operator Action<
			A
			, B
			, C
			, D
			//, Ret
			>
		(
		ActionWrapper<
			A
			, B
			, C
			, D
			//, Ret
			>
			fn
		)
		{
			return fn.Action;
		}

		public static implicit operator ActionWrapper<
			A
			, B
			, C
			, D
			//, Ret
			>
		(
		Action<
			A
			, B
			, C
			, D
			//, Ret
			>
			fn
		)
		{
			return new ActionWrapper<
				A
				, B
				, C
				, D
				//, Ret
				>
				(fn);
		}

		public Action<
			A
			, B
			, C
			, D
			//, Ret
			> Action;

		public ActionWrapper(Action<
			A
			, B
			, C
			, D
			> fn)
		{
			Action = fn;
		}

		public void Invoke(
			A a
			, B b
			, C c
			, D d
			)
		{
			Action.Invoke(a, b, c, d);
		}
	}

	#endregion

}