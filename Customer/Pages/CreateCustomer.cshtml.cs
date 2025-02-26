using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Customer.Pages
{
    public class CreateCustomerModel : PageModel
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

            // Add logic to save the customer
            return RedirectToPage("/Index");
        }
    }
}
