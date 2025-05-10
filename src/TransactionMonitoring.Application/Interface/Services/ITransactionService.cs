
using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Interface.Services
{
	public interface ITransactionService
	{
        Task<Transaction> AddTransactionAsync(Transaction transaction);

    }
}

