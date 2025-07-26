using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Domain;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Repositories
{
	public class EfAlertRepository : IAlertRepository
    {
        private readonly AppDbContext _context;

        public EfAlertRepository(AppDbContext appDbContext)
		{
            _context = appDbContext;
        }

        public Task<List<AlertDto>> GetByEntityIdAsync(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public Task<AlertDto> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AlertDto>> GetByProductIdAsync(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AlertDto>> GetByTransactionIdAsync(Guid transactionId)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync(AlertDto dto)
        {
            var alert = new Alert(
                        dto.EntityId,
                        dto.ProductId,
                        dto.TransactionId,
                        dto.RuleName,
                        dto.Message,
                        dto.Severity
                    );
            await  _context.AddAsync(alert);
            await _context.SaveChangesAsync();
        }

        public Task UpdateAsync(AlertDto alert)
        {
            throw new NotImplementedException();
        }
    }
}

