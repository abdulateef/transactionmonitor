using System;
using System.Net.NetworkInformation;
using TransactionMonitoring.Application.Enums;

namespace TransactionMonitoring.Domain.Entities
{
    public class Transaction : BaseEntity
    {
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

