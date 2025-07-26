using System;
using MongoDB.Driver;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Application.Mappers;
using TransactionMonitoring.Domain.Entities;
using TransactionMonitoring.Domain.Helper;

namespace TransactionMonitoring.Infrastructure.Repositories.Mongo
{
	public class MongoFieldRepository : IFieldRepository
    {
        private readonly IMongoCollection<FieldDefinition> _collection;

        public MongoFieldRepository(IMongoDatabase database)
		{
            _collection = database.GetCollection<FieldDefinition>("FieldDefinitions");
        }

        public async Task<FieldDefinitionDto> CreatFieldsAsync(FieldDefinitionDto fieldDefinitionDto)
        {
            var fieldDefinition = fieldDefinitionDto.Map();
            fieldDefinition.Id = Guid.NewGuid();
            fieldDefinition.CreateTime = DateTime.UtcNow;
            fieldDefinition.CreateBy = "";
            await _collection.InsertOneAsync(fieldDefinition);
            return fieldDefinitionDto;
        }

        public async Task<HashSet<string>> GetBooleanFieldsAsync()
        {
            var rules = await _collection.Find(r => r.FieldType == FieldTypes.Boolean).ToListAsync();
            return rules.Select(x => x.FieldName).ToHashSet();
        }

        public async Task<HashSet<string>> GetNumericFieldsAsync()
        {
            var rules = await _collection.Find(r => r.FieldType == FieldTypes.Numeric).ToListAsync();
            return rules.Select(x => x.FieldName).ToHashSet();
        }
    }
}

