using System;
using MongoDB.Driver;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Repositories.Mongo
{
	public class MongoRuleRepository : IRuleRepository
    {
        private readonly IMongoCollection<Rule> _collection;

        public MongoRuleRepository(IMongoDatabase database)
		{
            _collection = database.GetCollection<Rule>("Rules");
        }

        public Task<List<RuleDto>> GetByEntityIdAsync(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<RuleDto> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RuleDto>> GetByProductIdAsync(Guid productId)
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

