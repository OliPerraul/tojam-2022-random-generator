using UnityEngine;
//using Cirrus.UnityDH.Conditions;

namespace Cirrus.Unity.Objects
{
	public class ProcessorComponent : CustomMonoBehaviourBase { }

	public abstract class ProcessorComponent<A> : ProcessorComponent where A : class
	{
		private A _a;
		private A Provided
		{
			get
			{
				if(_a == null) _a = Provide();
				return _a;
			}
		}

		public virtual A Provide()
		{
			_a = GetComponent<A>();
			if(_a == null) _a = GetComponentInChildren<A>();
			if(_a == null) _a = GetComponentInParent<A>();
			return _a;
		}

		public override void Start()
		{
			Start(Provided);
		}

		public override void Awake()
		{
			Awake(Provided);
		}

		public override void LateStart()
		{
			LateStart(Provided);
		}

		protected virtual void Awake(A processed)
		{
			Debug.Assert(false, "You must override the 'Awake' method");
		}

		protected virtual void Start(A processed)
		{
			Debug.Assert(false, "You must override the 'Start' method");
		}

		protected virtual void LateStart(A processed)
		{
			Debug.Assert(false, "You must override the 'Start' method");
		}
	}

}
