using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Application.Interface.Services;

namespace TransactionMonitoring.Infrastructure.Services
{
	public class AlertService : IAlertService
    {
        private readonly IUnitOfWork _iunitofwork;
		public AlertService(IUnitOfWork unitOfWork)
		{
            _iunitofwork = unitOfWork;
		}

        public Task<CreateAlertDto> CreateAlert(CreateAlertDto createAlertDto)
        {
            throw new NotImplementedException();
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

