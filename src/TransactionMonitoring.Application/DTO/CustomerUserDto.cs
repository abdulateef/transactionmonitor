using System;
namespace TransactionMonitoring.Application.DTO
{
	public class CustomerUserDto
	{
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public bool IsPEP { get; set; }
        public bool IsSanctioned { get; set; }
        public int RiskScore { get; set; }
    }
}

