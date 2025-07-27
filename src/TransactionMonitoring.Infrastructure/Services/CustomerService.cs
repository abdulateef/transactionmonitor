using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Application.Interface.Services;

namespace TransactionMonitoring.Infrastructure.Services
{
	public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _iunitofwork;
		public CustomerService(IUnitOfWork unitOfWork)
		{
            _iunitofwork = unitOfWork;
		}

        public Task<CustomerDto> GetCustomerByIdAsync(Guid customerId)
        {
            return _iunitofwork.Customers.GetByIdAsync(customerId);
        }

        public Task<CustomerUserDto> GetCustomerUserAsync(Guid customerUserId, Guid customerId, string name, string countryCode)
        {
            return _iunitofwork.CustomerUsers.GetCustomerUserAsync(customerUserId, customerId, name, countryCode);
        }

        public Task<CustomerUserDto> GetCustomerUserByIdAsync(Guid customerUserId, Guid customerId)
        {
            return _iunitofwork.CustomerUsers.GetByIdAsync(customerUserId, customerId);
        }
    }
}

