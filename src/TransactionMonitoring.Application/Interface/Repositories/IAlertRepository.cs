using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Interface.Repositories
{
	public interface IAlertRepository
	{
        Task SaveAsync(AlertDto alert);
        Task<List<Alert>> GetByEntityIdAsync(Guid entityId);
        Task<Alert> GetByIdAsync(Guid Id);
        Task<List<Alert>> GetByProductIdAsync(Guid productId);
        Task<List<Alert>> GetByTransactionIdAsync(Guid transactionId);
        Task UpdateAsync(Alert alert);
    }
}

