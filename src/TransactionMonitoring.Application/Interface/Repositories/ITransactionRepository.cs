using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Interface
{
	public interface ITransactionRepository
	{
        Task<Transaction> GetByIdAsync(Guid id);
        Task AddAsync(Transaction transaction);
        Task<IEnumerable<Transaction>> GetFailedTransactionsAsync();
    }
}

