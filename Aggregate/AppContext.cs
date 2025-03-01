using _Shared;
using Microsoft.EntityFrameworkCore;

namespace Aggregate
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}


