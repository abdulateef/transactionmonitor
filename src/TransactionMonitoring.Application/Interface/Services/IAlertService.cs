using System;
using TransactionMonitoring.Application.DTO;

namespace TransactionMonitoring.Application.Interface.Services
{
	public interface IAlertService
	{
        Task<bool> ResolveAlert(Guid Id);
        Task<CreateAlertDto> RaiseAlert(RuleDto ruleDto, TransactionDTO transaction);
        Task<List<AlertDto>> GetAlertsByEntityId(Guid entityId);
        Task<List<AlertDto>> GetAlertsByProductId(Guid productId);
        Task<List<AlertDto>> GetAlertsByTransactionId(Guid transactionId);
        Task<List<AlertDto>> GetAlertsByStatus(bool isResolved);
    }
}

