using System;
using Microsoft.EntityFrameworkCore;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Domain;
using TransactionMonitoring.Domain.Entities;
using TransactionMonitoring.Domain.Helper;

namespace TransactionMonitoring.Infrastructure.Repositories.EntityFramework
{
	public class EfFieldRepository : IFieldRepository
    {
        private readonly AppDbContext _context;

        public EfFieldRepository(AppDbContext dbContext)
		{
			_context = dbContext;
		}

        public async Task<FieldDefinitionDto> CreatFieldsAsync(FieldDefinitionDto fieldDefinitionDto)
        {
            FieldDefinition field = new FieldDefinition
            {
                CreateBy = "",
                CreateTime = DateTime.UtcNow,
                Description = fieldDefinitionDto.Description,
                FieldName = fieldDefinitionDto.FieldName,
                FieldType = fieldDefinitionDto.FieldType,
                IsActive = fieldDefinitionDto.IsActive
            };
           await _context.FieldDefinitions.AddAsync(field);
            return fieldDefinitionDto;
        }

        public async Task<HashSet<string>> GetBooleanFieldsAsync()
        {
            return (await _context.FieldDefinitions
            .Where(f => f.FieldType == FieldTypes.Boolean && f.IsActive)
            .Select(f => f.FieldName)
            .ToListAsync())
            .ToHashSet();
        }

        public async Task<HashSet<string>> GetNumericFieldsAsync()
        {
            return (await _context.FieldDefinitions
            .Where(f => f.FieldType == FieldTypes.Numeric && f.IsActive)
            .Select(f => f.FieldName)
            .ToListAsync())
            .ToHashSet();
        }
    }
}

