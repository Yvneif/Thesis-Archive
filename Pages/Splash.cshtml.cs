using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThesisArchive.Pages
{
    public class SplashModel : PageModel
    {
        public void OnGet()
        {
            // Add a 3-second delay before redirecting to the login page
            Response.Headers.Add("Refresh", "3;url=/Login");
        }
    }
}