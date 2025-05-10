using System;
namespace TransactionMonitoring.Application.Interface
{
	public interface IUnitOfWork
	{
        ITransactionRepository Transactions { get; }
        Task SaveChangesAsync();
    }
}

