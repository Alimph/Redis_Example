using Aggregate;
using Aggregate.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Customer.Pages
{
    public class CreateCustomerModel(ICustomerService customerService) : PageModel
    {
        [BindProperty]
        public _Shared.Customer Customer { get; set; }

        public void OnGet()
        {
            // Initialization code if needed
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            customerService.CreateCustomer(Customer);
            // Add logic to save the customer
            return RedirectToPage("/Index");
        }
    }
}
