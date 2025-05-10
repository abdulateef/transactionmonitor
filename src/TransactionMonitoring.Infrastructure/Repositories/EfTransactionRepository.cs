using System;
using Microsoft.EntityFrameworkCore;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Enums;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Domain;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Repositories
{
	public class EfTransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext _context;

        public EfTransactionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Transaction> GetByIdAsync(Guid id)
            => await _context.Transactions.FindAsync(id);

        public async Task AddAsync(Transaction transaction)
        {
            await _context.Transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }


        public async Task<IEnumerable<Transaction>> GetFailedTransactionsAsync()
            => await _context.Transactions
                            .Where(t => t.Status == TransactionStatus.Failed)
                            .ToListAsync();
    }
}

