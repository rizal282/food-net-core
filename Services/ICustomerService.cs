using foodapi.Data.Response;

namespace foodapi.Services;

public interface ICustomerService 
{
    Task<List<CustomerResponse>> GetAllCustomers();
}