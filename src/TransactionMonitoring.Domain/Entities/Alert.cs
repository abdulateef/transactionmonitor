using System;
namespace TransactionMonitoring.Domain.Entities
{
	public class Alert : BaseEntity
	{
        public Guid EntityId { get; private set; }  
        public Guid ProductId { get; private set; } 
        public Guid TransactionId { get; private set; }

        public string RuleName { get; private set; }
        public string Message { get; private set; }
        public string Severity { get; private set; }

        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public bool IsResolved { get; private set; } = false;

        public Alert(Guid entityId, Guid productId, Guid transactionId, string ruleName, string message, string severity)
        {
            EntityId = entityId;
            ProductId = productId;
            TransactionId = transactionId;
            RuleName = ruleName;
            Message = message;
            Severity = severity;
        }

        public void Resolve() => IsResolved = true;
    }
}

