namespace Cirrus.Unity.UI.ProgressBars
{
	public class BarViewPosAnchors : BarViewSizeAnchors
	{

		public override void UpdateView(float currentValue, float targetValue)
		{
			SetPivot(currentValue, currentValue);
		}
	}
}