using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Mappers
{
	public static class AlertMapper
	{
        public static AlertDto ToDto(Alert alert)
        {
            return new AlertDto
            {
                Id = alert.Id,
                EntityId = alert.EntityId,
                ProductId = alert.ProductId,
                TransactionId = alert.TransactionId,
                RuleName = alert.RuleName,
                Message = alert.Message,
                Severity = alert.Severity,
                CreatedAt = alert.CreatedAt,
                IsResolved = alert.IsResolved
            };
        }
    }
}

