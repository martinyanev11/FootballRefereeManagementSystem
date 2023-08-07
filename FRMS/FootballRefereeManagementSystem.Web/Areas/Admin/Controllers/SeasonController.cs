namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Season;

    public class SeasonController : BaseAdminController
    {
        private readonly ISeasonService seasonService;

        public SeasonController(ISeasonService seasonService)
        {
            this.seasonService = seasonService;
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
        public IActionResult SeasonPreparation()
        {
            return View();
        }
    }
}
