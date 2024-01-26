using foodapi.Data.Response;
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
}