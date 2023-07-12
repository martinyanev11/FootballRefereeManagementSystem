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
        private readonly IEmailService emailService;

        public ContactController(IEmailService emailService)
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

            // TODO: Add model properties into the message.
            bool result = await emailService.SendEmailAsync(model.Email, model.Title, model.Message);

            if (result)
            {
                return RedirectToAction("Success", "Contact");
            }
            
            return BadRequest(model);
        }

        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
    }
}
