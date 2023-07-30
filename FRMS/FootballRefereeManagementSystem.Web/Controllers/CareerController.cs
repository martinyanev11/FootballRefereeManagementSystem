namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Career;

    public class CareerController : BaseController
    {
        private readonly ICareerService careerService;

        public CareerController(ICareerService careerService)
        {
            this.careerService = careerService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [AllowAnonymous]
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

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.careerService.AddApplicationAsync(model);
            }
            catch (Exception)
            {
                return View("Error");
            }

            return RedirectToAction("Success", "Career");
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery]ApplicationQueryModel queryModel) // TODO: Admin access only
        {
            IEnumerable<ApplicationViewModel> allApplicationsFiltered =
                await this.careerService.GetAllApplicationsFilteredAsync(queryModel);

            queryModel.Applications = allApplicationsFiltered;

            return View(queryModel);
        }

        [HttpGet]
        public async Task<IActionResult> DeclineConfirmation(string id)
        {
            ApplicationViewModel model = await this.careerService
                .GetApplicationByIdAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ApproveConfirmation(string id)
        {
            ApplicationViewModel model = await this.careerService
                .GetApplicationByIdAsync(id);

            return View(model);
        }
    }
}
