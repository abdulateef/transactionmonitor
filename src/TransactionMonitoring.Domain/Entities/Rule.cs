using System;
namespace TransactionMonitoring.Domain.Entities
{
    public class Rule : BaseEntity
    {
        public string Name { get; set; }

        public Guid? CustomerId { get; set; }

        public Guid? ProductId { get; set; }

        public string Description { get; set; }

        public string Expression { get; set; }

        public bool IsActive { get; set; }
    }
}