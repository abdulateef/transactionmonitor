using System;
using TransactionMonitoring.Application.DTO;

namespace TransactionMonitoring.Application.Interface.Services
{
	public interface IExpressionBuilder
	{
        string BuildExpression(List<RuleConditionDto> conditions, string logicalOperator);
    }
}

