using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Interface.Repositories
{
	public interface ICustomerRepository
	{
        Task<CustomerDto> GetByIdAsync(Guid customerId);
        Task<CustomerDto> SaveAsync(CustomerDto customer);
        Task<CustomerDto> UpdateAsync(Guid customerId, CustomerDto customer);


    }
}

