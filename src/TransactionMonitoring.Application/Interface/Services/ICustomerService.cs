using System;
using TransactionMonitoring.Application.DTO;

namespace TransactionMonitoring.Application.Interface.Services
{
	public interface ICustomerService
	{
        Task<CustomerDto> GetCustomerByIdAsync(Guid customerId);
        Task<CustomerUserDto> GetCustomerUserByIdAsync(Guid customerUserId, Guid customerId);
        Task<CustomerUserDto> GetCustomerUserAsync(Guid customerUserId, Guid customerId, string name, string countryCode);


    }
}

