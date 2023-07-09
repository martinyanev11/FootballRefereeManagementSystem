namespace FootballRefereeManagementSystem.Web.Controllers
{
    using FootballRefereeManagementSystem.Services.Contracts;
    using FootballRefereeManagementSystem.Web.ViewModels.Career;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [AllowAnonymous]
    public class CareerController : BaseController
    {
        private readonly ICareerService careerService;

        public CareerController(ICareerService careerService)
        {
            this.careerService = careerService;
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Apply(ApplicationFormModel model)
        {
            if (!model.KnowsFootballRules)
            {
                ModelState.AddModelError("KnowsFootballRules", "Задължителна проверка");
            }

            if (model.Contact.StartsWith("0") == false)
            {
                ModelState.AddModelError("Contact", "Телефонния номер трябва да започва с 0");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.careerService.AddApplicationAsync(model);

            return RedirectToAction("Success", "Career");
        }

        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
    }
}
