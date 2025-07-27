using System;
using MongoDB.Driver;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Application.Mappers;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Repositories.Mongo
{
	public class MongoCustomerUserRepository : ICustomerUserRepository
    {
        private readonly IMongoCollection<CustomerUser> _collection;

        public MongoCustomerUserRepository(IMongoDatabase database)
		{
            _collection = database.GetCollection<CustomerUser>("CustomerUsers");
        }

        public async Task<CustomerUserDto> GetByIdAsync(Guid customerUserId , Guid customerId)
        {
            var user = await _collection.Find(r => r.CustomerId == customerId && r.Id == customerUserId).FirstOrDefaultAsync();
            return user == null ? null : user.Map();
        }

        public async Task<CustomerUserDto> GetCustomerUserAsync(Guid customerUserId, Guid customerId, string name, string countryCode)
        {
            var user = await _collection.Find(r => r.CustomerId == customerId && r.Id == customerUserId && r.CountryCode == countryCode && r.Name == name).FirstOrDefaultAsync();
            return user == null ? null : user.Map();
        }

        public async Task<CustomerUserDto> SaveAsync(CustomerUserDto model)
        {
            var customerUser = model.Map();
            customerUser.Id = Guid.NewGuid();
            customerUser.CreateBy = "";
            customerUser.CreateTime = DateTime.UtcNow;
            await _collection.InsertOneAsync(customerUser);
            return model;
        }

        public async Task<CustomerUserDto> UpdateAsync(Guid customerUserId, CustomerUserDto customer)
        {
            var filter = Builders<CustomerUser>.Filter.Eq(r => r.Id, customerUserId);
            var update = Builders<CustomerUser>.Update
                .Set(r => r.Name, customer.Name)
                .Set(r => r.IsPEP, customer.IsPEP)
                .Set(r => r.IsSanctioned, customer.IsSanctioned)
                .Set(r => r.RiskScore, customer.RiskScore)
                .Set(r => r.CountryCode, customer.CountryCode);
            await _collection.UpdateOneAsync(filter, update);
            return await GetByIdAsync(customerUserId, customer.CustomerId);
        }
    }
}

