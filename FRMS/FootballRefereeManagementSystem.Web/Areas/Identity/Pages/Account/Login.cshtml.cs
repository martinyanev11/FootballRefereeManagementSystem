#nullable disable
namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    using Data.Models;
    using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

    public class LoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> signInManager;

        public LoginModel(SignInManager<ApplicationUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Полето е задължително.")]
            [EmailAddress(ErrorMessage = "Моля въвъдете валиден имейл адрес.")]
            [Display(Name = "Имейл")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Полето е задължително.")]
            [DataType(DataType.Password)]
            [Display(Name = "Парола")]
            public string Password { get; set; }
        }

        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                SignInResult result = await signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "User", new { area = "" });
                }
                if (result.IsLockedOut)
                {
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Грешен имейл или парола.");
                    return Page();
                }
            }

            return Page();
        }
    }
}
