#nullable disable
namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account
{
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.WebUtilities;

    using Data.Models;
    using Enums;

    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;

        public ConfirmEmailModel(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [TempData]
        public string Message { get; set; }
        [TempData]
        public Alert AlertType { get; set; }
        public StatusMessage StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            if (userId is null || code is null)
            {
                return RedirectToPage("/Index");
            }

            ApplicationUser user = await this.userManager.FindByIdAsync(userId);
            if (user is null)
            {
                return RedirectToAction("Error", StatusCode(404));
            }

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            IdentityResult result = await this.userManager.ConfirmEmailAsync(user, code);

            if (!result.Succeeded)
            {
                this.Message = "Грешка при потвърждаването на имейл адреса.";
                this.AlertType = Alert.danger;
            }

            this.Message = "Успешно потвърдихте своя имейл адрес.";
            this.AlertType = Alert.success;
            return Page();
        }
    }
}
