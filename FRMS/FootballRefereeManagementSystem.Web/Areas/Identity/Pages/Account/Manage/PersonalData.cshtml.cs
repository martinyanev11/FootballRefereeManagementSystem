namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account.Manage
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    using Data.Models;

    public class PersonalDataModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;

        public PersonalDataModel(
            UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> OnGet()
        {
            ApplicationUser? user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Потребител с ID '{userManager.GetUserId(User)}' не може да бъде намерен.");
            }

            return Page();
        }
    }
}
