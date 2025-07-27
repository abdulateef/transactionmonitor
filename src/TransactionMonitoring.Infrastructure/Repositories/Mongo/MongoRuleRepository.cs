using System;
using MongoDB.Driver;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Application.Mappers;
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

        public async Task<List<RuleDto>> GetByEntityIdAsync(Guid entityId)
        {
            var rules = await _collection.Find(r => r.CustomerId == entityId).ToListAsync();
            return rules.Select(x => x.Map()).ToList();
        }

        public async Task<RuleDto> GetByIdAsync(Guid id)
        {
            var rule = await _collection.Find(r => r.Id == id).FirstOrDefaultAsync();
            return rule == null ? null : rule.Map();
        }

        public async Task<List<RuleDto>> GetByProductIdAsync(Guid productId, Guid customerId)
        {
            var rules = await _collection.Find(r => r.ProductId == productId && r.CustomerId == customerId).ToListAsync();
            return rules.Select(x => x.Map()).ToList();
        }

        public async Task SaveAsync(RuleDto ruleDto)
        {
            var rule = ruleDto.Map();
            rule.Id = Guid.NewGuid();
            await _collection.InsertOneAsync(rule);
        }

        public async Task UpdateAsync(RuleDto ruleDto)
        {
            var filter = Builders<Rule>.Filter.Eq(r => r.Id, ruleDto.CustomerId);
            var update = Builders<Rule>.Update
                .Set(r => r.Name, ruleDto.Name)
                .Set(r => r.Description, ruleDto.Description)
                .Set(r => r.Expression, ruleDto.Expression)
                .Set(r => r.IsActive, ruleDto.IsActive)
                .Set(r => r.ProductId, ruleDto.ProductId)
                .Set(r => r.CustomerId, ruleDto.CustomerId);

            await _collection.UpdateOneAsync(filter, update);
        }

    }
}

