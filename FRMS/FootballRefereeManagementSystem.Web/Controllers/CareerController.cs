namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Career;

    [AllowAnonymous]
    public class CareerController : BaseController
    {
        private readonly ICareerService careerService;
        private readonly IRefereeService refereeService;
        private readonly IDivisionService divisionService;

        public CareerController(ICareerService careerService,
            IRefereeService refereeService,
            IDivisionService divisionService)
        {
            this.careerService = careerService;
            this.refereeService = refereeService;
            this.divisionService = divisionService;
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

            if (!model.Contact.StartsWith("0"))
            {
                ModelState.AddModelError("Contact", "Телефонния номер трябва да започва с 0");
            }

            try
            {
                bool isEmailTaken = await this.careerService.CheckIfEmailIsAlreadyUsedAsync(model.Email);

                if (isEmailTaken)
                {
                    ModelState.AddModelError("Email", "Вече съществува потребител с този имейл в системата.");
                }
            }
            catch (Exception)
            {
                return View("Error");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                model.Role = this.refereeService.DetermineBestSuitedRoleForApplication(model);
                model.DivisionId = await this.divisionService.DetermineBestSuitedDivisionForApplicationAsync(model.Age, model.ExperienceInYears);

                await this.careerService.AddApplicationAsync(model);
            }
            catch (Exception)
            {
                return View("Error");
            }

            return RedirectToAction("Success", "Career");
        }

        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
    }
}
