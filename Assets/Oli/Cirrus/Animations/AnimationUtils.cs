using UnityEngine;

namespace Cirrus.Animations
{
	public static class AnimationUtils
	{
		public static float EaseInSine(float start, float end, float value)
		{
			end -= start;
			return -end * Mathf.Cos(value * (Mathf.PI * 0.5f))
			+ end + start;
		}

		public static float EaseOutSine(float start, float end, float value)
		{
			end -= start;
			return end * Mathf.Sin(value * (Mathf.PI * 0.5f)) + start;
		}

		public static float EaseInOutSine(float start, float end, float value)
		{
			end -= start;
			return -end * 0.5f * (Mathf.Cos(Mathf.PI * value) - 1) + start;
		}
		public static float EaseOutQuad(float start, float end, float value)
		{
			end -= start;
			return -end * value * (value - 2) + start;
		}

		public static float EaseOutCubic(float start, float end, float value)
		{
			value--;
			end -= start;
			return end * (value * value * value + 1) + start;
		}

		public static float EaseOutElastic(float value)
		{
			float p = 0.3f;
			float s = p * 0.25f;

			return Mathf.Pow(2, -10 * value) * Mathf.Sin((value - s) * (2 * Mathf.PI) / p) + 1;
		}

		public static float EaseOutExpo(float value, float totalTime)
		{
			return -Mathf.Pow(2, -10 * value / totalTime) + 1;
		}
	}
}
