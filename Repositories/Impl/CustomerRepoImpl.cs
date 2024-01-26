using foodapi.Data;
using foodapi.Data.Request;
using foodapi.Data.Response;
using foodapi.Models;
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

    public async Task<CustomerResponse> GetCustomerById(int id)
    {
        return await _appDbContext.Customers
        .Select(customer => new CustomerResponse {
            Id = customer.Id,
            Name = customer.Name,
            Email = customer.Email,
            PhoneNumber = customer.PhoneNumber,
            Address = customer.Address
        })
        .Where(customer => customer.Id == id)
        .FirstAsync();
    }

    public async Task CreateNewCustomer(Customer customer)
    {
        _appDbContext.Customers.Add(customer);

        await _appDbContext.SaveChangesAsync();
    }
}