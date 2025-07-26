using System;
using TransactionMonitoring.Application.DTO;

namespace TransactionMonitoring.Application.Interface.Repositories
{
	public interface IFieldRepository
	{
        Task<HashSet<string>> GetNumericFieldsAsync();
        Task<HashSet<string>> GetBooleanFieldsAsync();
        Task<FieldDefinitionDto> CreatFieldsAsync(FieldDefinitionDto fieldDefinitionDto);

    }
}

