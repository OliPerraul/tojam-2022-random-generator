using System;
using UnityEngine;

namespace Cirrus.Unity.Animations
{
	public abstract class AnimCurveBase
	{
#if CIRRUS_UNITY
		public static implicit operator AnimCurveBase(AnimationCurve anim) { return new UnityAnimCurve(anim); }
#endif
		public static implicit operator AnimCurveBase(Func<float, float> anim) { return new AnimCurve(anim); }

		public abstract float Evaluate(float t);
	}

	public class AnimCurve : AnimCurveBase
	{
		private Func<float, float> _evaluateCb;
		public AnimCurve(Func<float, float> anim) { _evaluateCb = anim; }

		public override float Evaluate(float t)
		{
			return _evaluateCb.Invoke(t);
		}
	}
}
