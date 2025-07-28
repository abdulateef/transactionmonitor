using System;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.DTO
{
	public class CreateAlertDto
	{
        public Guid TransactionId { get; set; }
        public string RuleName { get; set; }
        public string Message { get; set; }
        public string Severity { get; set; }
        public Guid CustomerId { get; private set; }
        public Guid ProductId { get; private set; }

        public Alert ToEntity()
        {
            return new Alert(CustomerId, ProductId, TransactionId, RuleName, Message, Severity);
        }
    }
}

