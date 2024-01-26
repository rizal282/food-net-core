using foodapi.Data.Response;

namespace foodapi.Repositories;

public interface ICustomerRepo
{
    Task<List<CustomerResponse>> getAllCustomers();
}