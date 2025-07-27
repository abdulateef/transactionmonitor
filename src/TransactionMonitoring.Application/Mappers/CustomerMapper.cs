using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Mappers
{
	public static class CustomerMapper
	{
		public static CustomerDto Map(this Customer model) => new CustomerDto
		{
			IsPEP = model.IsPEP,
			IsSanctioned = model.IsSanctioned,
			Name = model.Name,
			RiskLevel = model.RiskLevel,
			RiskScore = model.RiskScore,
			Segment = model.Segment,
			Tier = model.Tier
		};


        public static Customer Map(this CustomerDto model) => new Customer
        {
            IsPEP = model.IsPEP,
            IsSanctioned = model.IsSanctioned,
            Name = model.Name,
            RiskLevel = model.RiskLevel,
            RiskScore = model.RiskScore,
            Segment = model.Segment,
            Tier = model.Tier
        };

        public static CustomerUserDto Map(this CustomerUser model) => new CustomerUserDto
        {
            IsPEP = model.IsPEP,
            IsSanctioned = model.IsSanctioned,
            Name = model.Name,
            RiskScore = model.RiskScore,
            CountryCode = model.CountryCode,
            CustomerId = model.CustomerId
        };


        public static CustomerUser Map(this CustomerUserDto model) => new CustomerUser
        {
            IsPEP = model.IsPEP,
            IsSanctioned = model.IsSanctioned,
            Name = model.Name,
            RiskScore = model.RiskScore,
            CountryCode = model.CountryCode,
            CustomerId = model.CustomerId
        };


    }
}

