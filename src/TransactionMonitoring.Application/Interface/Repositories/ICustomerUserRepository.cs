using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Domain.Entities;

namespace TransactionMonitoring.Application.Interface.Repositories
{
	public interface ICustomerUserRepository
	{
        Task<CustomerUserDto> GetByIdAsync(Guid customerUserId , Guid customerId);
        Task<CustomerUserDto> GetCustomerUserAsync(Guid customerUserId, Guid customerId, string name, string countryCode);
        Task<CustomerUserDto> SaveAsync(CustomerUserDto customer);
        Task<CustomerUserDto> UpdateAsync(Guid Id, CustomerUserDto customer);
    }
}

