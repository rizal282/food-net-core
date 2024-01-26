using foodapi.Data.Request;
using foodapi.Data.Response;

namespace foodapi.Services;

public interface ICustomerService 
{
    Task<List<CustomerResponse>> GetAllCustomers();

    Task<CustomerResponse> GetCustomerById(int id);

    Task CreateNewCustomer(CustomerRequest customerRequest);
}