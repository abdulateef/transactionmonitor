using System;
using NCalc;

namespace TransactionMonitoring.Domain.Helper
{
	public static class EvaluatorHelper
	{
        public static bool NCalcEvaluator(string expression, Dictionary<string, object> context)
        {
            var expr = new Expression(expression);

            foreach (var kv in context)
            {
                expr.Parameters[kv.Key] = kv.Value;
            }

            var result = expr.Evaluate();
            return result is bool b && b;
        }
    }
}

