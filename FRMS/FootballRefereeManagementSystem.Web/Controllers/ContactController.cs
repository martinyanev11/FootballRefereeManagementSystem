namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.Contact;
    using Services.Contracts;

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

            bool res = await emailService
                .SendEmailToContactSystemAsync(model.FirstName, model.LastName, model.Email, model.Title, model.Message);

            if (res)
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
