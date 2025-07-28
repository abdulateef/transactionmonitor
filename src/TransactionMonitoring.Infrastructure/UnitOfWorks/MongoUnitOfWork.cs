using System;
using MongoDB.Driver;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Infrastructure.Repositories;
using TransactionMonitoring.Infrastructure.Repositories.Mongo;

namespace TransactionMonitoring.Infrastructure.UnitOfWorks
{
    public class MongoUnitOfWork : IUnitOfWork
    {
        public ITransactionRepository Transactions { get; }

        public IAlertRepository Alerts { get; }

        public IFieldRepository Fields { get; }

        public IRuleRepository Rules { get; }

        public ICustomerRepository Customers { get; }

        public ICustomerUserRepository CustomerUsers { get; }

        public MongoUnitOfWork(IMongoDatabase database)
        {
            Transactions = new MongoTransactionRepository(database);
            Alerts = new MongoAlertRepository(database);
            Fields = new MongoFieldRepository(database);
            Rules = new MongoRuleRepository(database);
            CustomerUsers = new MongoCustomerUserRepository(database);
            Customers = new MongoCustomerRepository(database);
        }
        // Mongo doesn't support SaveChanges in same way
        public Task SaveChangesAsync() => Task.CompletedTask;
    }

}

