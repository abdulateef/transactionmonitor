using System;
using MongoDB.Driver;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Repositories
{
    public class MongoTransactionRepository : ITransactionRepository
    {
        private readonly IMongoCollection<Transaction> _collection;

        public MongoTransactionRepository(IMongoDatabase database)
        {
            _collection = database.GetCollection<Transaction>("Transactions");
        }

        public async Task<Transaction> GetByIdAsync(Guid id)
            => await _collection.Find(t => t.Id == id).FirstOrDefaultAsync();

        public async Task AddAsync(Transaction transaction)
            => await _collection.InsertOneAsync(transaction);

        public async Task<IEnumerable<Transaction>> GetFailedTransactionsAsync()
        {
            var result = await _collection.Find(t => t.Status == Application.Enums.TransactionStatus.Failed ).ToListAsync();
            return result;
        }
    }

}

