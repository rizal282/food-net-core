namespace foodapi.Core.GenericRepository;

public interface IUnitOfWork
{
    ICustomerRepository Customers { get; set; }
    Task CompleteAsync();
}