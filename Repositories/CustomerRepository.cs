using foodapi.Core.GenericRepository;
using foodapi.Core.GenericRepository.Repositories;
using foodapi.Data;
using foodapi.Models;

namespace foodapi.Repositories;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
    {
    }

    
}