using System;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Domain;
using TransactionMonitoring.Infrastructure.Repositories.EntityFramework;

namespace TransactionMonitoring.Infrastructure.Repositories
{
	public class EfUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public ITransactionRepository Transactions { get; }
        public IFieldRepository Fields { get; }
        public IAlertRepository Alerts { get; }

        public EfUnitOfWork(AppDbContext context)
        {
            _context = context;
            Transactions = new EfTransactionRepository(context);
            Fields = new EfFieldRepository(context);
            Alerts = new EfAlertRepository(context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

