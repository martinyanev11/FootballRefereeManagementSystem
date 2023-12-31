﻿#nullable disable
namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account.Manage
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    using Data.Models;
    using Enums;

    public class ChangePasswordModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public ChangePasswordModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.StatusMessage = new StatusMessage();
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string Message { get; set; }
        [TempData]
        public Alert AlertType { get; set; }
        public StatusMessage StatusMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Полето е задължително")]
            [DataType(DataType.Password)]
            [Display(Name = "Сегашна парола")]
            public string OldPassword { get; set; }

            [Required(ErrorMessage = "Полето е задължително")]
            [DataType(DataType.Password)]
            [Display(Name = "Нова парола")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Потвърди нова парола")]
            [Compare("NewPassword", ErrorMessage = "Паролите не съвпадат.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ApplicationUser user = await this.userManager.GetUserAsync(User);
            if (user is null)
            {
                return RedirectToAction("Error", StatusCode(404));
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ApplicationUser user = await this.userManager.GetUserAsync(User);
            if (user is null)
            {
                return RedirectToAction("Error", StatusCode(404));
            }

            IdentityResult changePasswordResult = 
                await userManager.ChangePasswordAsync(user, this.Input.OldPassword, this.Input.NewPassword);

            if (!changePasswordResult.Succeeded)
            {
                foreach (IdentityError error in changePasswordResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }

            await this.signInManager.RefreshSignInAsync(user);
            this.Message = "Паролата е сменена успешно.";
            this.AlertType = Alert.success;

            return RedirectToPage();
        }
    }
}
