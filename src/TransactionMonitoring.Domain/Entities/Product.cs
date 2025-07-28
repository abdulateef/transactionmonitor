using System;
namespace TransactionMonitoring.Domain.Entities
{
	public class Product
	{
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string ApiKey { get; set; }
        public string SecurityKey { get; set; }
        public string BusinessTypes { get; set; }
    }
}

