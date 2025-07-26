using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Interface.Repositories
{
	public interface IAlertRepository
	{
        Task SaveAsync(AlertDto alert);
        Task<List<AlertDto>> GetByEntityIdAsync(Guid entityId);
        Task<AlertDto> GetByIdAsync(Guid Id);
        Task<List<AlertDto>> GetByProductIdAsync(Guid productId);
        Task<List<AlertDto>> GetByTransactionIdAsync(Guid transactionId);
        Task UpdateAsync(AlertDto alert);
    }
}

