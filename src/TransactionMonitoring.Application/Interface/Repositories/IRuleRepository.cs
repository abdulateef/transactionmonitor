using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Interface.Repositories
{
	public interface IRuleRepository
	{
        Task SaveAsync(RuleDto ruleDto);
        Task<List<RuleDto>> GetByEntityIdAsync(Guid entityId);
        Task<RuleDto> GetByIdAsync(Guid Id);
        Task<List<RuleDto>> GetByProductIdAsync(Guid productId);
        Task UpdateAsync(RuleDto ruleDto);
    }
}

