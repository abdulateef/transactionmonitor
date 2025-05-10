using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Application.Interface.Services;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Services
{
	public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _uow;

        public TransactionService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Transaction> AddTransactionAsync(Transaction transaction)
        {
            await _uow.Transactions.AddAsync(transaction);
            await _uow.SaveChangesAsync();
            return transaction;
        }
    }
}

