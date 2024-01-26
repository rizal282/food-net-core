using foodapi.Data.Response;
using foodapi.Models;

namespace foodapi.Repositories;

public interface ICustomerRepo
{
    Task<List<CustomerResponse>> getAllCustomers();

    Task<CustomerResponse> GetCustomerById(int id);

    Task CreateNewCustomer(Customer customer);
}