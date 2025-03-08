namespace Aggregate.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public void CreateCustomer(_Shared.Customer customer)
        {
            customer.CreationDate = DateTime.Now;
            _context.Add(customer);
            _context.SaveChanges();
        }

        public IEnumerable<_Shared.Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
