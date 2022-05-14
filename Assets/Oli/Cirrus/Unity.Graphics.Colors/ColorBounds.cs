using Cirrus.Unity.Numerics;
using UnityEngine;

namespace Cirrus.Unity.Graphics
{
	class ColorBounds
	{
		public Range_ HueRange { get; private set; }
		public Range_ SaturationRange { get; private set; }
		public AnimationCurve BrightnessCurve { get; private set; }

		public float SMin { get { return SaturationRange.Min; } }
		public float SMax { get { return SaturationRange.Max; } }

		public float BMin { get { return BrightnessCurve.Evaluate(0); } }
		public float BMax { get { return BrightnessCurve.Evaluate(1); } }

		public ColorBounds(Range_ hueRange, Range_ saturationRange, int[] brightnessSteps)
		{
			HueRange = hueRange;
			SaturationRange = saturationRange;

			BrightnessCurve = new AnimationCurve();
			// Ensure zed timing
			BrightnessCurve.AddKey(0, brightnessSteps[0]);

			// Assume even spacing for all steps
			var incrementsize = 1 / (float)(brightnessSteps.Length - 1);
			for(var i = 1; i < brightnessSteps.Length - 2; ++i)
			{
				BrightnessCurve.AddKey(incrementsize * i, brightnessSteps[i]);
			}

			// Ensure one timing
			BrightnessCurve.AddKey(1, brightnessSteps[brightnessSteps.Length - 1]);
		}
	}
}
