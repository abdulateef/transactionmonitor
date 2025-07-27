using System;
using TransactionMonitoring.Application.Enums;

namespace TransactionMonitoring.Application.DTO
{
	public class TransactionDTO
	{
        public Guid Id { get; set; }
        public string Reference { get; set; }
        public string PartnerReference { get; set; }
        public decimal Amount { get; set; }
        public TransactionStatus Status { get; set; }
        public string ClientKey { get; set; }
        public string SenderCountry { get; set; }
        public string BeneCountry { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
    }
}

