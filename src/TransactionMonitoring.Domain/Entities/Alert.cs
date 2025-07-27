using System;
using TransactionMonitoring.Domain.Enums;

namespace TransactionMonitoring.Domain.Entities
{
	public class Alert : BaseEntity
	{
        public Guid CustomerId { get; private set; }  
        public Guid ProductId { get; private set; } 
        public Guid TransactionId { get; private set; }
        public string RuleName { get; private set; }
        public string Severity { get; private set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public bool IsResolved { get; private set; } = false;
        public Guid RuleId { get; private set; }
        public string Reason { get; private set; }
        public string Expression { get; private set; }
        public decimal Amount { get; private set; }
        public AlertStatus Status { get; private set; }

        public Alert()
        {
                
        }

        public Alert(Guid customerId, Guid productId, Guid transactionId, string ruleName,
            string reason, string severity, string expression,
            decimal amount, AlertStatus alertStatus, Guid ruleId )
        {
            CustomerId = customerId;
            ProductId = productId;
            TransactionId = transactionId;
            RuleName = ruleName;
            Reason = reason;
            Severity = severity;
            RuleId = ruleId;
            Amount = amount;
            Status = alertStatus;
            Expression = expression;
        }
        public void Resolve() => IsResolved = true;
    }
}

