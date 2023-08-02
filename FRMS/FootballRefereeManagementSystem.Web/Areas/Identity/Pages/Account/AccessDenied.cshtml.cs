namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class AccessDeniedModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToAction("Error", StatusCode(401));
        }
    }
}
