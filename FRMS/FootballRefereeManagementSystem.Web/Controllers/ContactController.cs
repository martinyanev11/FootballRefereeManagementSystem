namespace FootballRefereeManagementSystem.Web.Controllers
{
    using FootballRefereeManagementSystem.Services.Contracts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Services;
    using ViewModels.Contact;

    [AllowAnonymous]
    public class ContactController : BaseController
    {
        private readonly EmailService emailService;

        public ContactController(EmailService emailService)
        {
            this.emailService = emailService;
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(ContactFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Contact", model);
            }

            // TODO: Implement email sending
            // 1. Install the SendGrid package via NuGet
            // 2. Configure SendGrid API credentials
            // 3. Set up SendGrid in appsettings.Development.json
            // 4. Create an EmailService
            // 5. Configure Dependency Injection (DI) for the EmailService

            await emailService.SendEmailAsync(model.Email, model.Title, model.Message);

            return RedirectToAction("Success", "Contact");
        }

        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
    }
}
