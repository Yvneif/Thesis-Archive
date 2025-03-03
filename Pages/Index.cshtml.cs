using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThesisArchive.Pages;
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
{
    return RedirectToPage("/Login");
}
    }
