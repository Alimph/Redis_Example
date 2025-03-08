using Aggregate.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Customer.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<_Shared.Customer> Customers;

        public IndexModel(ICustomerService customerService)
        {
            Customers = customerService.GetAllCustomers();
        }

        public void OnGet()
        {
        }
    }
}
