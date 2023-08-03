namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.Career.Enums;
    using ViewModels.Career;
    using Services.Contracts;

    public class CareerController : BaseAdminController
    {
        private readonly ICareerService careerService;
        private readonly IEmailService emailService;

        public CareerController(ICareerService careerService, IEmailService emailService)
        {
            this.careerService = careerService;
            this.emailService = emailService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] ApplicationQueryModel queryModel)
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
        public async Task<IActionResult> DeclineConfirmation(string id)
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
        public async Task<IActionResult> Decline(string id)
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
        public async Task<IActionResult> ApproveConfirmation(string id)
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
        public async Task<IActionResult> Approve(string id)
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