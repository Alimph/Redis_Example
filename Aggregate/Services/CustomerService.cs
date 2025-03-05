﻿namespace Aggregate.Services
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
            _context.Add(customer);
            _context.SaveChanges();
        }
    }
}
