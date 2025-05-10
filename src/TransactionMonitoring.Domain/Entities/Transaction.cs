using System;
using System.Net.NetworkInformation;
using TransactionMonitoring.Application.Enums;

namespace TransactionMonitoring.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string Reference { get; set; }
        public string PartnerReference { get; set; }
        public decimal Amount { get; set; }
        public TransactionStatus Status { get; set; } 
        public DateTime CreateTime { get; set; }
        public string CreateBy { get; set; }
        public string ClientKey { get; set; }

    }
}

