//using Formula.ExpressionParser;
//using Formula.ExpressionParser;
//using NReco.Linq;
using System;
using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Linq;
//using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using B83.ExpressionParser;

namespace Cirrus.Numerics
{
	public static class ExpressionUtils
	{
		//public static LambdaParser lambdaParser = new LambdaParser();
		private static ExpressionParser _expressionParser = new ExpressionParser();

		public static Expression Evaluate(string expressionString)
		{
			return _expressionParser.EvaluateExpression(expressionString);
		}
	}
}
