using System;
using MongoDB.Driver;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Application.Mappers;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Repositories.Mongo
{
	public class MongoCustomerRepository : ICustomerRepository
    {
        private readonly IMongoCollection<Customer> _collection;

        public MongoCustomerRepository(IMongoDatabase database)
		{
            _collection = database.GetCollection<Customer>("Customers");

        }

        public async Task<CustomerDto> GetByIdAsync(Guid customerId)
        {
            var customer = await _collection.Find(r => r.Id == customerId).FirstOrDefaultAsync();
            return customer == null ? null : customer.Map();
        }

        public async Task<CustomerDto> SaveAsync(CustomerDto model)
        {
            var customer = model.Map();
            customer.Id = Guid.NewGuid();
            customer.CreateBy = "";
            customer.CreateTime = DateTime.UtcNow;
            await _collection.InsertOneAsync(customer);
            return model;
        }

        public async Task<CustomerDto> UpdateAsync(Guid customerId,CustomerDto customer)
        {
            var filter = Builders<Customer>.Filter.Eq(r => r.Id, customerId);
            var update = Builders<Customer>.Update
                .Set(r => r.Name, customer.Name)
                .Set(r => r.IsPEP, customer.IsPEP)
                .Set(r => r.IsSanctioned, customer.IsSanctioned)
                .Set(r => r.RiskLevel, customer.RiskLevel)
                .Set(r => r.RiskScore, customer.RiskScore)
                .Set(r => r.Tier, customer.Tier)
                .Set(r => r.Segment, customer.Segment);

            await _collection.UpdateOneAsync(filter, update);
            return await GetByIdAsync(customerId);
        }
    }
}

