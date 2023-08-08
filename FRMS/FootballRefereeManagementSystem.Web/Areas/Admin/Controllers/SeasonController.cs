namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Season;

    public class SeasonController : BaseAdminController
    {
        private readonly ISeasonService seasonService;
        private readonly ITeamService teamService;

        public SeasonController(ISeasonService seasonService, ITeamService teamService)
        {
            this.seasonService = seasonService;
            this.teamService = teamService;
            
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            bool alreadyHaveSeasonInPreparation = 
                await this.seasonService.CheckForSeasonInPreparation();

            if (alreadyHaveSeasonInPreparation)
            {
                return RedirectToAction("SeasonPreparation");
            }

            // !!! IMPORTANT !!!
            // Need to check for date manipulation...
            // Adding season with old season dates should be impossible!
            // For testing purposes this check will be skipped.
            // To be added before going in Production state!

            SeasonFormModel model = new SeasonFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SeasonFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await this.seasonService.AddNewSeasonAsync(model);

                return RedirectToAction("SeasonPreparation");
            }
            catch (Exception)
            {
                return View("Error");
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> SeasonPreparation()
        {
            bool preperationSeasonExists =
                await this.seasonService.CheckForSeasonInPreparation();

            if (!preperationSeasonExists)
            {
                return View("Error404");
            }

            SeasonPreparationModel model = 
                await this.seasonService.GetSeasonInPreparationAsync();

            int seasonId = await this.seasonService.GetPreparationSeasonIdAsync();
            model.RegisteredTeams = await this.teamService.GetAllRegisteredForNewSeasonTeams(seasonId);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string status)
        {
            try
            {
                bool isValidStatus = this.seasonService.StatusValidation(status);

                if (!isValidStatus)
                {
                    return View("Error");
                }

                SeasonFormModel model =
                    await this.seasonService.GetSeasonForEditAsync(status);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SeasonFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                bool isValidStatus = this.seasonService.StatusValidation(model.Status);

                if (!isValidStatus)
                {
                    return View("Error");
                }

                await this.seasonService.EditSeasonAsync(model);

                string returnController = model.Status == "Current" ? "Home" : "Season";
                string returnAction = model.Status == "Current" ? "Dashboard" : "SeasonPreparation";

                return RedirectToAction(returnAction, returnController);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
