using System;
namespace TransactionMonitoring.Domain.Entities
{
	public class BaseEntity
	{
        public DateTime CreateTime { get; set; }
        public string CreateBy { get; set; }
        public Guid Id { get; set; }
    }
}

