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

        public CareerController(ICareerService careerService, IEmailService emailService)
        {
            this.careerService = careerService;
            this.emailService = emailService;
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

                ApplicationViewModel applicationModel = await this.careerService
                    .GetApplicationByIdAsync(id);

                bool isSedingSuccessful = await this.emailService
                    .SendDeclineEmailToCareerCandidateAsync(applicationModel.FullName, applicationModel.EmailAddress);

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

                ApplicationViewModel applicationModel = await this.careerService
                    .GetApplicationByIdAsync(id);

                bool isSedingSuccessful = await this.emailService
                    .SendApproveEmailToCareerCandidateAsync(applicationModel.FullName, applicationModel.EmailAddress, applicationModel.Id);

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
