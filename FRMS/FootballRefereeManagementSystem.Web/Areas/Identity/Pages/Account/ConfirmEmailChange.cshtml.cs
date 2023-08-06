#nullable disable
namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account
{
    using System.Text;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.WebUtilities;

    using Data.Models;
    using Enums;

    public class ConfirmEmailChangeModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public ConfirmEmailChangeModel(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [TempData]
        public string Message { get; set; }
        [TempData]
        public Alert AlertType { get; set; }
        public StatusMessage StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string email, string code)
        {
            if (userId is null || email is null || code is null)
            {
                return RedirectToPage("/Index");
            }

            ApplicationUser user = await this.userManager.FindByIdAsync(userId);
            if (user is null)
            {
                return RedirectToAction("Error", StatusCode(404));
            }

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            IdentityResult result = await this.userManager.ChangeEmailAsync(user, email, code);
            if (!result.Succeeded)
            {
                this.Message = "Възникна грешка при промяна на имейл адреса.";
                this.AlertType = Alert.danger;
                return Page();
            }

            // In our UI email and user name are one and the same, so when we update the email
            // we need to update the user name.
            IdentityResult setUserNameResult = await this.userManager.SetUserNameAsync(user, email);
            if (!setUserNameResult.Succeeded)
            {
                this.Message = "Възникна грешка при промяна на потребителското име.";
                this.AlertType = Alert.danger;
                return Page();
            }

            await this.signInManager.RefreshSignInAsync(user);

            this.Message = "Успешно променихте своя имейл адрес.";
            this.AlertType = Alert.success;
            return Page();
        }
    }
}