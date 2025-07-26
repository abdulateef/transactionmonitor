using System;
namespace TransactionMonitoring.Application.DTO
{
	public class AlertDto
	{
        public Guid Id { get; set; }
        public Guid TransactionId { get; set; }
        public string RuleName { get; set; }
        public string Message { get; set; }
        public string Severity { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsResolved { get; set; }
        public Guid EntityId { get;  set; }
        public Guid ProductId { get;  set; }
    }
}

