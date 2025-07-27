using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Domain;

namespace TransactionMonitoring.Infrastructure.Repositories.EntityFramework
{
	public class EfRuleRepository : IRuleRepository
    {
        private readonly AppDbContext _context;

        public EfRuleRepository(AppDbContext context)
		{
            _context = context;
		}

        public Task<List<RuleDto>> GetByEntityIdAsync(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<RuleDto> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RuleDto>> GetByProductIdAsync(Guid productId, Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<RuleDto>> GetByTransactionIdAsync(Guid transactionId)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(RuleDto ruleDto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(RuleDto ruleDto)
        {
            throw new NotImplementedException();
        }
    }
}

