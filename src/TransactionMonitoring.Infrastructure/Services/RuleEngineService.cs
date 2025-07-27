using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Application.Interface.Services;
using TransactionMonitoring.Application.Models;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Services
{
	public class RuleEngineService : IRuleEngineService
    {
		
        private readonly IExpressionBuilder _expressionBuilder;
        private readonly IUnitOfWork _iunitofwork;

        public RuleEngineService(IExpressionBuilder expressionBuilder, IUnitOfWork repository)
        {
            _expressionBuilder = expressionBuilder;
            _iunitofwork = repository;
        }
        
        public async Task<RuleDto> CreateAsync(CreateRuleRequestModel request)
        {
            var expression = _expressionBuilder.BuildExpression(request.Conditions, request.LogicalOperator);

            var rule = new RuleDto
            {
                Name = request.Name,
                CustomerId = request.EntityId,
                ProductId = request.ProductId,
                Expression = expression,
                IsActive = true,
                Description = request.Description
                
            };
            await _iunitofwork.Rules.SaveAsync(rule);
            return rule;
        }
    }
}

