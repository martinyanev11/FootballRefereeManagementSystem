namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.Contact;

    [AllowAnonymous]
    public class ContactController : BaseController
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(ContactFormModel model)
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

            return RedirectToAction("Success", "Contact");
        }

        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
    }
}
