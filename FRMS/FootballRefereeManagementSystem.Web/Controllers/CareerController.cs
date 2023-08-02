namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Career;
    using ViewModels.Career.Enums;

    public class CareerController : BaseController
    {
        private readonly ICareerService careerService;
        private readonly IEmailService emailService;
        private readonly IRefereeService refereeService;
        private readonly IDivisionService divisionService;

        public CareerController(ICareerService careerService,
            IEmailService emailService,
            IRefereeService refereeService,
            IDivisionService divisionService)
        {
            this.careerService = careerService;
            this.emailService = emailService;
            this.refereeService = refereeService;
            this.divisionService = divisionService;
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
                model.DivisionId = await this.divisionService.DetermineBestSuitedDivisionForApplicationAsync(model);

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
            try
            {
                IEnumerable<ApplicationViewModel> allApplicationsFiltered =
                    await this.careerService.GetAllApplicationsFilteredAsync(queryModel);

                queryModel.Applications = allApplicationsFiltered;

                return View(queryModel);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeclineConfirmation(string id) // TODO: Admin access only
        {
            try
            {
                bool applicationExists =
                    await this.careerService.CheckApplicationExistanceByIdAsync(id);

                if (!applicationExists)
                {
                    return View("Error404");
                }

                ApplicationViewModel model = await this.careerService
                    .GetApplicationByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            } 
        }

        [HttpGet]
        public async Task<IActionResult> Decline(string id) // TODO: Admin access only
        {
            try
            {
                bool applicationExists = 
                    await this.careerService.CheckApplicationExistanceByIdAsync(id);

                if (!applicationExists)
                {
                    return View("Error404");
                }

                await this.careerService.ChangeApplicationStatusAsync(StatusSorting.Declined.ToString(), id);

                ApplicationEmailModel emailModel =
                    await this.careerService.GetApplicationForEmailByIdAsync(id);

                bool isSedingSuccessful = await this.emailService
                    .SendDeclineEmailToCareerCandidateAsync(emailModel);

                if (!isSedingSuccessful)
                {
                    return View("Error");
                }

                return RedirectToAction("All", "Career");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> ApproveConfirmation(string id) // TODO: Admin access only
        {
            try
            {
                bool applicationExists =
                    await this.careerService.CheckApplicationExistanceByIdAsync(id);

                if (!applicationExists)
                {
                    return View("Error404");
                }

                ApplicationViewModel model = await this.careerService
                    .GetApplicationByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Approve(string id) // TODO: Admin access only
        {
            try
            {
                bool applicationExists =
                    await this.careerService.CheckApplicationExistanceByIdAsync(id);

                if (!applicationExists)
                {
                    return View("Error404");
                }

                await this.careerService.ChangeApplicationStatusAsync(StatusSorting.Approved.ToString(), id);

                ApplicationEmailModel emailModel = 
                    await this.careerService.GetApplicationForEmailByIdAsync(id);

                bool isSedingSuccessful = await this.emailService
                    .SendApproveEmailToCareerCandidateAsync(emailModel);

                if (!isSedingSuccessful)
                {
                    return View("Error");
                }

                return RedirectToAction("All", "Career");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
