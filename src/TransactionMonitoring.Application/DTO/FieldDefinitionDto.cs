using System;
namespace TransactionMonitoring.Application.DTO
{
	public class FieldDefinitionDto
	{
        public string FieldName { get; set; } = null!;
        public string FieldType { get; set; } = null!;
        public bool IsActive { get; set; }
        public string? Description { get; set; }
    }
}

