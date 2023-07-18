#nullable disable
namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account.Manage
{
    using System.Text.Json;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    using Data.Models;
    using System.Reflection;

    public class DownloadPersonalDataModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;

        public DownloadPersonalDataModel(
            UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ApplicationUser user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Потребител с ID '{userManager.GetUserId(User)}' не може да бъде намерен.");
            }

            // Only include personal data for download
            Dictionary<string, string> personalData = new Dictionary<string, string>();
            IEnumerable<PropertyInfo> personalDataProps = typeof(ApplicationUser).GetProperties()
                .Where(prop => Attribute
                    .IsDefined(prop, typeof(PersonalDataAttribute)));
            foreach (PropertyInfo pi in personalDataProps)
            {
                personalData.Add(pi.Name, pi.GetValue(user)?.ToString() ?? "null");
            }

            IList<UserLoginInfo> logins = await userManager.GetLoginsAsync(user);
            foreach (var l in logins)
            {
                personalData.Add($"{l.LoginProvider} external login provider key", l.ProviderKey);
            }

            personalData.Add($"Authenticator Key", await userManager.GetAuthenticatorKeyAsync(user));

            Response.Headers.Add("Content-Disposition", "attachment; filename=PersonalData.json");
            return new FileContentResult(JsonSerializer.SerializeToUtf8Bytes(personalData), "application/json");
        }
    }
}
