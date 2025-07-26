using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Mappers
{
	public static class RuleMapper
	{
        public static RuleDto Map(this Rule rule) => new RuleDto
        {
            Name = rule.Name,
            EntityId = rule.EntityId,
            ProductId = rule.ProductId,
            Description = rule.Description,
            Expression = rule.Expression,
            IsActive = rule.IsActive
        };

        public static Rule Map(this RuleDto dto) => new Rule
        {
            Name = dto.Name,
            EntityId = dto.EntityId,
            ProductId = dto.ProductId,
            Description = dto.Description,
            Expression = dto.Expression,
            IsActive = dto.IsActive
        };
    }
}

