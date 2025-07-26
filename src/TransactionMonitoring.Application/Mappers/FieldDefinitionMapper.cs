using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Mappers
{
	public static class FieldDefinitionMapper
	{
		public static FieldDefinition Map(this FieldDefinitionDto model) => new FieldDefinition
		{
			FieldName = model.FieldName,
			Description = model.Description,
			FieldType = model.FieldType,
			IsActive = model.IsActive
		};

        public static FieldDefinitionDto Map(this FieldDefinition model) => new FieldDefinitionDto
        {
            FieldName = model.FieldName,
            Description = model.Description,
            FieldType = model.FieldType,
            IsActive = model.IsActive
        };

    }
}

