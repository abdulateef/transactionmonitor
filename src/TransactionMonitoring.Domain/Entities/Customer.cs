using System;
namespace TransactionMonitoring.Domain.Entities
{
	public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Tier { get; set; }
        public string Segment { get; set; }
        public string RiskLevel { get; set; }
        public bool IsPEP { get; set; }
        public bool IsSanctioned { get; set; }
        public int RiskScore { get; set; }
    }
}

