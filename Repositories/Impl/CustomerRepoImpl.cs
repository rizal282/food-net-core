using foodapi.Data;
using foodapi.Data.Response;
using Microsoft.EntityFrameworkCore;

namespace foodapi.Repositories.Impl;

public class CustomerRepoImpl : ICustomerRepo
{

    private readonly ApplicationDbContext _appDbContext;

    public CustomerRepoImpl(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<CustomerResponse>> getAllCustomers()
    {
        return await _appDbContext.Customers.Select(customer => new CustomerResponse {
            Id = customer.Id,
            Name = customer.Name,
            PhoneNumber = customer.PhoneNumber,
            Email = customer.Email,
            Address = customer.Address
        }).ToListAsync();
    }
}