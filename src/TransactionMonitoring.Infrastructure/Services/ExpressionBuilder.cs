using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Application.Interface.Services;

namespace TransactionMonitoring.Infrastructure.Services
{
	public class ExpressionBuilder : IExpressionBuilder
    {
        private static readonly HashSet<string> NumericFields = new()
    {
        "Amount", "Velocity", "Volume", "TransactionCount"
    };

        private static readonly HashSet<string> BooleanFields = new()
    {
        "IsPEP", "IsSanctioned"
    };
        private readonly IUnitOfWork _unitOfWork;
        public ExpressionBuilder(IUnitOfWork unitOfWork)
		{
            _unitOfWork = unitOfWork;
		}

        public string BuildExpression(List<RuleConditionDto> conditions, string logicalOperator)
        {
            if (conditions == null || !conditions.Any())
                throw new ArgumentException("Rule must have at least one condition");

            logicalOperator = NormalizeLogicalOperator(logicalOperator);

            var expressions = conditions.Select(BuildClause).ToList();

            return string.Join($" {logicalOperator} ", expressions);
        }

        private string BuildClause(RuleConditionDto cond)
        {
            var op = cond.Operator.Trim();

            var formattedValue = FormatValue(cond.Field, cond.Value);
            return $"{cond.Field} {op} {formattedValue}";
        }

        private string FormatValue(string field, string value)
        {
            if (_unitOfWork.Transactions.Contains(field))
                return value;

            if (BooleanFields.Contains(field))
                return value.ToLower() == "true" ? "true" : "false";

            return $"\"{value}\""; // treat as string
        }

        private string NormalizeLogicalOperator(string op) =>
            op.ToUpper() switch
            {
                "AND" => "&&",
                "OR" => "||",
                _ => throw new ArgumentException("Invalid logical operator. Use 'AND' or 'OR'.")
            };
    }
}

