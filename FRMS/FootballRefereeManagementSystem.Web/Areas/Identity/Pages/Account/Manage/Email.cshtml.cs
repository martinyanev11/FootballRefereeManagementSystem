#nullable disable
namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account.Manage
{
    using System.Text;
    using System.Text.Encodings.Web;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.AspNetCore.WebUtilities;

    using Data.Models;
    using Enums;
    using Services.Contracts;
    using static Common.EmailConstants;

    public class EmailModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IEmailService emailService;

        public EmailModel(
            UserManager<ApplicationUser> userManager,
            IEmailService emailService)
        {
            this.userManager = userManager;
            this.emailService = emailService;
            this.StatusMessage = new StatusMessage();
        }

        [Display(Name = "Имейл адрес")]
        public string Email { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string Message { get; set; }
        [TempData]
        public Alert AlertType { get; set; }
        public StatusMessage StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Нов имейл адрес")]
            public string NewEmail { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            string email = await this.userManager.GetEmailAsync(user);
            this.Email = email;

            this.Input = new InputModel
            {
                NewEmail = email,
            };

            this.IsEmailConfirmed = await this.userManager.IsEmailConfirmedAsync(user);
        }

        public async Task<IActionResult> OnGetAsync()
        {
            ApplicationUser user = await this.userManager.GetUserAsync(User);
            if (user is null)
            {
                return NotFound($"Потребител с ID '{this.userManager.GetUserId(User)}' не може да бъде намерен.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostChangeEmailAsync()
        {
            ApplicationUser user = await this.userManager.GetUserAsync(User);

            if (user is null)
            {
                return NotFound($"Потребител с ID '{this.userManager.GetUserId(User)}' не може да бъде намерен.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            string email = await userManager.GetEmailAsync(user);
            if (this.Input.NewEmail != email)
            {
                string userId = await this.userManager.GetUserIdAsync(user);
                string code = await this.userManager.GenerateChangeEmailTokenAsync(user, this.Input.NewEmail);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                string callbackUrl = Url.Page(
                    "/Account/ConfirmEmailChange",
                    pageHandler: null,
                    values: new { area = "Identity", userId = userId, email = Input.NewEmail, code = code },
                    protocol: Request.Scheme);

                string subject = EmailChangeConstants.Subject;
                string plainTextContent = EmailChangeConstants.PlainTextContent;
                string htmlContent = $"{string.Format(EmailChangeConstants.HtmlContent, HtmlEncoder.Default.Encode(callbackUrl))}";

                bool isMessageSend =
                    await this.emailService.SendEmailConfirmation(this.Input.NewEmail, subject, plainTextContent, htmlContent);

                if (!isMessageSend)
                {
                    this.Message = "Възникна грешка при изпращане на имейл за промяна!";
                    this.AlertType = Alert.danger;
                    return RedirectToPage();
                }

                this.Message = "Изпратен е линк за потвърждение на промяната. Моля проверете вашият имейл адрес.";
                this.AlertType = Alert.warning;
                return RedirectToPage();
            }

            this.Message = "Имейл адресът е същият.";
            this.AlertType = Alert.info;
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            ApplicationUser user = await this.userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Потребител с ID '{this.userManager.GetUserId(User)}' не може да бъде намерен.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            string userId = await this.userManager.GetUserIdAsync(user);
            string email = await this.userManager.GetEmailAsync(user);
            string code = await this.userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            string callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { area = "Identity", userId = userId, code = code },
                protocol: Request.Scheme);

            string subject = EmailConfirmationConstants.Subject;
            string plainTextContent = EmailConfirmationConstants.PlainTextContent;
            string htmlContent = $"{string.Format(EmailConfirmationConstants.HtmlContent, HtmlEncoder.Default.Encode(callbackUrl))}";

            bool isMessageSend =
                    await this.emailService.SendEmailConfirmation(email, subject, plainTextContent, htmlContent);

            if (!isMessageSend)
            {
                this.Message = "Възникна грешка при изпращане на имейл за промяна!";
                this.AlertType = Alert.danger;
                return RedirectToPage();
            }

            this.Message = "Линк на потвърждение е изпратен. Моля прожевете вашият имейл.";
            this.AlertType = Alert.success;
            return RedirectToPage();
        }
    }
}
