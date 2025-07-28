using System;
using System.Data;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Application.Interface.Services;
using TransactionMonitoring.Domain.Entities;
using static MongoDB.Driver.WriteConcern;
using TransactionMonitoring.Domain.Enums;
using System.Text;

namespace TransactionMonitoring.Infrastructure.Services
{
	public class AlertService : IAlertService
    {
        private readonly IUnitOfWork _iunitofwork;
		public AlertService(IUnitOfWork unitOfWork)
		{
            _iunitofwork = unitOfWork;
		}

        public Task<CreateAlertDto> RaiseAlert(RuleDto ruleDto, TransactionDTO transaction)
        {

            Alert(Guid customerId, Guid productId, Guid transactionId, string ruleName,
            string reason, string severity, string expression,
           decimal amount, AlertStatus alertStatus, Guid ruleId)

            var alert = new Alert(
                transaction.CustomerId,
                transaction.ProductId,
                 ruleDto.Name,
                 $"Rule violated: {ruleDto.Name}",
                 "",
                 ruleDto.Expression,
                 transaction.Amount,
                 AlertStatus.New,
                 ruleDto.ii
                )
          

            await _alertRepository.SaveAsync(alert);

            // Optionally: notify an external system
            await _notificationService.NotifyAlertAsync(alert);
        }

        public Task<List<AlertDto>> GetAlertsByEntityId(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AlertDto>> GetAlertsByProductId(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AlertDto>> GetAlertsByStatus(bool isResolved)
        {
            throw new NotImplementedException();
        }

        public Task<List<AlertDto>> GetAlertsByTransactionId(Guid transactionId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResolveAlert(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}

