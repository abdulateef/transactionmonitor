using System;
namespace TransactionMonitoring.Domain.Entities
{
	public class FieldDefinition : BaseEntity
    {
        public string FieldName { get; set; } = null!;
        public string FieldType { get; set; } = null!;
        public bool IsActive { get; set; }
        public string? Description { get; set; }
    }
}

