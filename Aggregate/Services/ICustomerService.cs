using _Shared;

namespace Aggregate.Services
{
    public interface ICustomerService
    {
        void CreateCustomer(Customer customer);
        IEnumerable<_Shared.Customer> GetAllCustomers();
    }
}
