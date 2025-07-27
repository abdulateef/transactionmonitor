using System;
using TransactionMonitoring.Application.DTO;
using TransactionMonitoring.Application.Interface.Repositories;
using TransactionMonitoring.Domain;

namespace TransactionMonitoring.Infrastructure.Repositories.EntityFramework
{
	public class EfCustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public EfCustomerRepository(AppDbContext context)
		{
            _context = context;
		}

        public Task<CustomerDto> GetByIdAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> SaveAsync(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> UpdateAsync(Guid customerId, CustomerDto customer)
        {
            throw new NotImplementedException();
        }
    }
}

