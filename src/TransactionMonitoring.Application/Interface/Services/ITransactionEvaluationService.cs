using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Enums;

namespace TransactionMonitoring.Application.Interface.Services
{
	public interface ITransactionEvaluationService
	{
        Task<AlertFlag> EvaluateTransactionRealTimeAsync(TransactionDTO tx);
        Task EvaluateTransactionBatchAsync(IEnumerable<TransactionDTO> transactions);
    }
}

