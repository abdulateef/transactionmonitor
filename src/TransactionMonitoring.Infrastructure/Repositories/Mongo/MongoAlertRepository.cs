using System;
using MongoDB.Driver;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Repositories.Mongo
{
	public class MongoAlertRepository : IAlertRepository
    {
        private readonly IMongoCollection<Alert> _collection;

        public MongoAlertRepository(IMongoDatabase database)
		{
            _collection = database.GetCollection<Alert>("Alerts");

        }

        public Task<List<Alert>> GetByEntityIdAsync(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<Alert> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alert>> GetByProductIdAsync(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alert>> GetByTransactionIdAsync(Guid transactionId)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Alert alert)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(AlertDto alert)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Alert alert)
        {
            throw new NotImplementedException();
        }
    }
}

