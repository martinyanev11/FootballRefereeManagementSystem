#nullable disable
namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account.Manage
{
    using FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account.Manage.Enums;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class ShowRecoveryCodesModel : PageModel
    {
        public ShowRecoveryCodesModel()
        {
            this.StatusMessage = new StatusMessage();
        }

        [TempData]
        public string[] RecoveryCodes { get; set; }

        [TempData]
        public string Message { get; set; }
        [TempData]
        public Alert AlertType { get; set; }
        public StatusMessage StatusMessage { get; set; }

        public IActionResult OnGet()
        {
            if (RecoveryCodes == null || RecoveryCodes.Length == 0)
            {
                return RedirectToPage("./TwoFactorAuthentication");
            }

            return Page();
        }
    }
}
