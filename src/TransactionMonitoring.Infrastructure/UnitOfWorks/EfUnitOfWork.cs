using System;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Domain;

namespace TransactionMonitoring.Infrastructure.Repositories
{
	public class EfUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public ITransactionRepository Transactions { get; }

        public EfUnitOfWork(AppDbContext context)
        {
            _context = context;
            Transactions = new EfTransactionRepository(context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

