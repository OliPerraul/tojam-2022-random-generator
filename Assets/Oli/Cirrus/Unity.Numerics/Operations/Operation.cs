using B83.ExpressionParser;
using Cirrus.Numerics;
using System;
using UnityEngine;

namespace Cirrus.Unity.Numerics
{
	public enum Operator
	{
		Unknown,
		Mul,
		Add,
		Assign
	}

	[Serializable]
	public struct Operation : ISerializationCallbackReceiver
	{
		[SerializeField]
		public string _expression;

		[SerializeField]
		private string _previousExpression;

		[SerializeField]
		public Operator _op;

		public float _operand;

		public void OnValidate()
		{
			if (_expression != _previousExpression)
			{

				try
				{
					Expression expr = ExpressionUtils.Evaluate(_expression);
					_op = Operator.Unknown;
					if (expr.ExpressionTree is OperationProduct)
					{
						_op = Operator.Mul;
					}
					if (expr.ExpressionTree is OperationSum or OperationNegate or Number)
					{
						_op = Operator.Add;
					}

					_operand = expr.Value;
	
				}
				catch (Exception)
				{ }
				_previousExpression = _expression;
			}
			//var exp = _expression.EvaluateExpression();
			//var multiValues = exp.MultiValue;
			//_first = exp.MultiValue.Length > 0 ? exp.MultiValue[0] : 1;
			//_second = exp.MultiValue.Length > 1 ? exp.MultiValue[1] : 1;
						
			
		}

		public float EvaluateFirstSecond(float first, float second)
		{
			switch (_op)
			{
				case Operator.Mul:
					return first * second;

				case Operator.Add:
					return first + second;

				default:
				case Operator.Unknown:
					return first;
			}
		}


		public float Evaluate(Total first)
		{
			return EvaluateFirstSecond(first, _operand);
		}

		public float Evaluate(float first)
		{
			return EvaluateFirstSecond(first, _operand);
		}

		public float GetDelta(float current)
		{
			return Evaluate(current) - current;
		}

		public void OnBeforeSerialize() => this.OnValidate();

		public void OnAfterDeserialize()
		{			
		}
	}
}
