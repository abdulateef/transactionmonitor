using System;
using System.Data;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;
using TransactionMonitoring.Domain.Enums;

namespace TransactionMonitoring.Application.Mappers
{
	public static class AlertMapper
	{
        public static AlertDto ToDto(Alert alert)
        {
            return new AlertDto
            {
                Id = alert.Id,
                CustomerId = alert.CustomerId,
                ProductId = alert.ProductId,
                TransactionId = alert.TransactionId,
                RuleName = alert.RuleName,
                Message = alert.Message,
                Severity = alert.Severity,
                CreatedAt = alert.CreatedAt,
                IsResolved = alert.IsResolved
            };
        }

        public static Alert ToDto(this CreateAlertDto alert, TransactionDTO transaction)
        {
            return new Alert(alert.CustomerId, alert.ProductId, transaction.Id, alert.RuleName, alert.Message, alert.Severity);
            
        }

        public static Alert ToDto(this RuleDto ruleDto, TransactionDTO tx)
        {
           return new Alert
            {
                Id = Guid.NewGuid(),
                TransactionId = tx.Id,
                RuleId = rule.Id,
                ProductId = tx.ProductId,
                c = tx.EntityId,
                CustomerId = tx.CustomerId,
                Amount = tx.Amount,
                Reason = $"Rule violated: {rule.Name}",
                Expression = rule.Expression,
                CreatedAt = DateTime.UtcNow,
                Status = AlertStatus.New
            };
        }

    }
}

