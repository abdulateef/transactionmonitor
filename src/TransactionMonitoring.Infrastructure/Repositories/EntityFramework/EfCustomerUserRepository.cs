using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;

namespace TransactionMonitoring.Infrastructure.Repositories.EntityFramework
{
	public class EfCustomerUserRepository : ICustomerUserRepository
    {
		public EfCustomerUserRepository()
		{
		}

        public Task<CustomerUserDto> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerUserDto> GetByIdAsync(Guid customerUserId, Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerUserDto> GetCustomerUserAsync(Guid customerUserId, Guid customerId, string name, string countryCode)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerUserDto> SaveAsync(CustomerUserDto customer)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerUserDto> UpdateAsync(Guid Id, CustomerUserDto customer)
        {
            throw new NotImplementedException();
        }
    }
}

