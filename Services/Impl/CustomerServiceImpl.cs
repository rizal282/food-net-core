using foodapi.Data.Request;
using foodapi.Data.Response;
using foodapi.Models;
using foodapi.Repositories;

namespace foodapi.Services.Impl;

public class CustomerServiceImpl : ICustomerService
{

    private readonly ICustomerRepo _customerRepo;

    public CustomerServiceImpl(ICustomerRepo customerRepo)
    {
        _customerRepo = customerRepo;
    }

    public async Task<List<CustomerResponse>> GetAllCustomers()
    {
        var listCustomers = await _customerRepo.getAllCustomers();

        return listCustomers.Count == 0 ? [] : listCustomers;
    }

    public async Task<CustomerResponse> GetCustomerById(int id)
    {
        var customer = await _customerRepo.GetCustomerById(id);

        if (customer == null)
        {
            return null;
        }

        return customer;
    }

    public async Task CreateNewCustomer(CustomerRequest customerRequest)
    {

        var newCustomer = new Customer {
            Name = customerRequest.Name,
            Address = customerRequest.Address,
            Email = customerRequest.Email,
            PhoneNumber = customerRequest.PhoneNumber
        };

        await _customerRepo.CreateNewCustomer(newCustomer);
    }
}