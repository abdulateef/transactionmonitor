using System;
using MongoDB.Driver;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Infrastructure.Repositories.Mongo
{
	public class MongoFieldRepository : IFieldRepository
    {
        private readonly IMongoCollection<FieldDefinition> _collection;

        public MongoFieldRepository(IMongoDatabase database)
		{
            _collection = database.GetCollection<FieldDefinition>("FieldDefinitions");
        }

        public Task<FieldDefinitionDto> CreatFieldsAsync(FieldDefinitionDto fieldDefinitionDto)
        {
            throw new NotImplementedException();
        }

        public Task<HashSet<string>> GetBooleanFieldsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<HashSet<string>> GetNumericFieldsAsync()
        {
            throw new NotImplementedException();
        }
    }
}

