namespace Cirrus
{
	public static class BooleanUtils
	{
		public static bool Implies(this bool a, bool b) => !a || b;
	}
}
