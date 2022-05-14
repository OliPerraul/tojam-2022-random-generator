using UnityEngine;

namespace Cirrus.Unity.Animations
{
	public static partial class AnimationUtils
	{
		public static AnimationCurve Reverse(this AnimationCurve curve)
		{
			AnimationCurve copy = new AnimationCurve(curve.keys);

			Keyframe[] keys = curve.keys;
			for(int i = 0; i < keys.Length; i++)
			{
				keys[i].value = 1 - keys[i].value;
				keys[i].inTangent *= -1;
				keys[i].outTangent *= -1;
			}
			copy.keys = keys;
			return copy;
		}


		public static float GetClipLength(RuntimeAnimatorController animator, string clipname)
		{
			if(animator == null)
				return -1;

			for(int i = 0; i < animator.animationClips.Length; i++)                 //For all animations
			{
				if(animator.animationClips[i].name == clipname)        //If it has the same name as your clip
				{
					return animator.animationClips[i].length;
				}
			}

			return -1;
		}
	}

	public class UnityAnimCurve : AnimCurveBase
	{
		private AnimationCurve _animCurve;
		public UnityAnimCurve(AnimationCurve anim) { _animCurve = anim; }

		public override float Evaluate(float t)
		{
			return _animCurve.Evaluate(t);
		}
	}
}
