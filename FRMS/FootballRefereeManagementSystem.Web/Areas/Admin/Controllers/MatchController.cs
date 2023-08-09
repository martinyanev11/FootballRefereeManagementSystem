namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using FootballRefereeManagementSystem.Services.Contracts;
    using FootballRefereeManagementSystem.Web.ViewModels.Match;
    using Microsoft.AspNetCore.Mvc;

    public class MatchController : BaseAdminController
    {
        private readonly IMatchService matchService;
        private readonly ISeasonService seasonService;
        private readonly ITeamService teamService;
        private readonly ITownService townService;

        public MatchController(
            IMatchService matchService, 
            ISeasonService seasonService, 
            ITeamService teamService,
            ITownService townService)
        {
            this.matchService = matchService;
            this.seasonService = seasonService;
            this.teamService = teamService;
            this.townService = townService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            try
            {
                int seasonId = await this.seasonService.GetPreparationSeasonIdAsync();

                MatchFormModel model = new MatchFormModel()
                {
                    SeasonId = seasonId,
                    Teams = await this.teamService.GetRegisteredForSeasonTeams(seasonId),
                };

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(MatchFormModel model)
        {
            try
            {
                if (model.HomeTeamId == model.AwayTeamId)
                {
                    ModelState.AddModelError("HomeTeamId", "Не може отбор да играе срещу себе си!");
                }

                if (!ModelState.IsValid)
                {
                    int seasonId = await this.seasonService.GetPreparationSeasonIdAsync();
                    model.Teams = await this.teamService.GetRegisteredForSeasonTeams(seasonId);
                    return View(model);
                }

                int divisionId = await this.teamService.GetTeamSeasonDivision(model.HomeTeamId, model.SeasonId);
                model.DivisionId = divisionId;

                int townId = await this.teamService.GetHomeTownIdByTeamIdAsync(model.HomeTeamId);
                model.TownId = townId;

                await this.matchService.AddNewMatchAsync(model);

                return RedirectToAction("SeasonPreparation", "Season");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                bool matchExists = await this.matchService.CheckMatchExistanceById(id);

                if (!matchExists)
                {
                    return View("Error404");
                }

                MatchEditViewModel model = 
                    await this.matchService.GetMatchForEditByIdAsync(id);
                model.Towns = await this.townService.GetTownsForListAsync();

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, MatchEditViewModel model)
        {
            try
            {
                bool matchExists = await this.matchService.CheckMatchExistanceById(id);

                if (!matchExists)
                {
                    return View("Error404");
                }

                if (!ModelState.IsValid)
                {
                    model.Towns = await this.townService.GetTownsForListAsync();
                    return View(model);
                }

                await this.matchService.EditMatchAsync(id, model);

                bool preperationSeasonExists =
                    await this.seasonService.CheckForSeasonInPreparation();

                string returnController = preperationSeasonExists ? "Season" : "Referee";
                string returnAction = preperationSeasonExists ? "SeasonPreparation" : "Schedule";

                return RedirectToAction(returnAction, returnController);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }        
    }
}
