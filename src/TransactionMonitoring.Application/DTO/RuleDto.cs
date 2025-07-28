using System;
namespace TransactionMonitoring.Application.DTO
{
	public class RuleDto
	{
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid CustomerId { get; set; }

        public Guid ProductId { get; set; }

        public string Description { get; set; }

        public string Expression { get; set; }

        public bool IsActive { get; set; }

    }
}

