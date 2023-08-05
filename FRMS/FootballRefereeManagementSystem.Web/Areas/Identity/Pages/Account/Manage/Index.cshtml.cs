#nullable disable
namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account.Manage
{
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    using Enums;
    using Data.Models;
    using static Common.EntityValidationConstants.Referee;
    using Common.CustomValidationAttributes;

    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.StatusMessage = new StatusMessage();
        }

        [Display(Name = "Имейл")]
        public string Username { get; set; }

        [TempData]
        public string Message { get; set; }
        [TempData]
        public Alert AlertType { get; set; }
        public StatusMessage StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Телефонен номер")]
            [StringLength(ContactLength, MinimumLength = ContactLength,
                ErrorMessage = "Телефонния номер трябва да е с дължина 10 цифри.")]
            [PhoneNumber(ErrorMessage = "Телефонният номер трябва да започва с 0.")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            string userName = await userManager.GetUserNameAsync(user);
            string phoneNumber = await userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ApplicationUser user = await userManager.GetUserAsync(User);
            if (user is null)
            {
                return RedirectToAction("Error", StatusCode(404));
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ApplicationUser user = await userManager.GetUserAsync(User);
            if (user is null)
            {
                return RedirectToAction("Error", StatusCode(404));
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            string phoneNumber = await userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                IdentityResult setPhoneResult = await userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    Message = "Грешка при запазването на телефонен номер.";
                    AlertType = Alert.danger;
                    return RedirectToPage();
                }
                else
                {
                    Message = "Профилът е актуализиран.";
                    AlertType = Alert.success;
                    return RedirectToPage();
                }
            }

            await signInManager.RefreshSignInAsync(user);
            Message = "Няма промени.";
            AlertType = Alert.info;

            return RedirectToPage();
        }
    }
}
