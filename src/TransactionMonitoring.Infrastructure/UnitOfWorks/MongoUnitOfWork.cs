using System;
using MongoDB.Driver;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Infrastructure.Repositories;

namespace TransactionMonitoring.Infrastructure.UnitOfWorks
{
    public class MongoUnitOfWork : IUnitOfWork
    {
        public ITransactionRepository Transactions { get; }

        public MongoUnitOfWork(IMongoDatabase database)
        {
            Transactions = new MongoTransactionRepository(database);
        }

        // Mongo doesn't support SaveChanges in same way
        public Task SaveChangesAsync() => Task.CompletedTask;
    }

}

