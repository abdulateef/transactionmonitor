using System;
namespace TransactionMonitoring.Domain.Entities
{
    public class CustomerUser : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public bool IsPEP { get; set; }
        public bool IsSanctioned { get; set; }
        public int RiskScore { get; set; }
    }

}