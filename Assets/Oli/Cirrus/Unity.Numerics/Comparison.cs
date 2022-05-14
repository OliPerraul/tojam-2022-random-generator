using Cirrus.Numerics;
using Cirrus.Objects;

//using Cirrus.Unity.EditorExt;
using UnityEngine;

namespace Cirrus.Unity.Numerics
{
	public enum ComparisonOperator
	{
		Unknown,
		GreaterThan,
		GreaterThanEqual,
		LesserThan,
		LesserThanEqual,
		Equal,
		NotEqual,
		AlwaysEqual
	}

	public static class ComparisonUtils
	{
		public static Comparison Null = new Comparison();

		public static ComparisonOperator ParseOperator(string opStr)
		{
			switch(opStr)
			{
				case "<=":
					return ComparisonOperator.LesserThanEqual;

				case "<":
					return ComparisonOperator.LesserThan;

				case ">=":
					return ComparisonOperator.GreaterThanEqual;

				case ">":
					return ComparisonOperator.GreaterThan;

				case "=":
					return ComparisonOperator.Equal;

				default:
					return ComparisonOperator.Unknown;
			}
		}
	}

	[System.Serializable]
	public class Comparison
		: Base
		// , IRealizablePrototype
	{
		[SerializeField]
		public ComparisonOperator _op { get; set; } = ComparisonOperator.Unknown;

		[SerializeReference]
		private float? _first;

		[SerializeReference]
		private float? _second;

		public object[] RealizeStepCbs { get; set; } public object ProxyCb { get; set; }

		public object ProtoData { get; set; }

		public bool IsRealizable { get; set; } = false;

		// object ICopiableObject.MemberwiseCopy()
		// {
		// 	return MemberwiseClone();
		// }

		//object ICloneable.Clone()
		//{
		//	return MemberwiseClone();
		//}

		public Comparison(
			ComparisonOperator op,
			float second
			)
		{
			_second = second;
			_op = op;
		}

		public Comparison(string op)
		{
			_op = ComparisonUtils.ParseOperator(op);
		}

		public Comparison(
			string op,
			float second
			)
		{
			_second = second;
			_op = ComparisonUtils.ParseOperator(op);
		}

		public Comparison(
			string op,
			float first,
			float second
			)
		{
			_first = second;
			_second = second;
			_op = ComparisonUtils.ParseOperator(op);
		}

		public Comparison(
			ComparisonOperator op,
			float first,
			float second
			)
		{
			_first = first;
			_second = second;
			_op = op;
		}

		public Comparison()
		{
		}

		public static implicit operator Comparison(string str)
		{
			return new Comparison(str);
		}

		private bool DoEvaluate(float firstOperand, float secondOperand)
		{
			switch(_op)
			{
				case ComparisonOperator.LesserThan:
					return firstOperand < secondOperand;

				case ComparisonOperator.GreaterThan:
					return firstOperand > secondOperand;

				case ComparisonOperator.Equal:
					return Cirrus.Numerics.NumericUtils.Almost(firstOperand, secondOperand);

				case ComparisonOperator.LesserThanEqual:
					return firstOperand < secondOperand || Cirrus.Numerics.NumericUtils.Almost(firstOperand, secondOperand);

				case ComparisonOperator.GreaterThanEqual:
					return firstOperand > secondOperand || Cirrus.Numerics.NumericUtils.Almost(firstOperand, secondOperand);

				case ComparisonOperator.Unknown:
					return true;

				default:
					return false;
			}
		}

		public bool Evaluate()
		{
			return DoEvaluate((float)_first, (float)_second);
		}

		public bool Evaluate(float second)
		{
			return DoEvaluate((float)_first, second);
		}

		public bool Evaluate(float first, float second)
		{
			return DoEvaluate(first, second);
		}
	}
}