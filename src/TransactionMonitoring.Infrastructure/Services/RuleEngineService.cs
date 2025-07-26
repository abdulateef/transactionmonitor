using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Application.Interface.Services;
using TransactionMonitoring.Application.Models;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Services
{
	public class RuleEngineService
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

            var rule = new Rule
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                EntityId = request.EntityId,
                ProductId = request.ProductId,
                Expression = expression,
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            };

            await _repository.SaveAsync(rule);
            return rule;
        }
    }
}

