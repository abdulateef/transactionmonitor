using System;
using TransactionMonitoring.Application.Interface.Repositories;

namespace TransactionMonitoring.Application.Interface
{
	public interface IUnitOfWork
	{
        ITransactionRepository Transactions { get; }
        IAlertRepository Alerts { get; }
        IFieldRepository  Fields { get; }
        IRuleRepository Rules { get; }
        Task SaveChangesAsync();
    }
}

