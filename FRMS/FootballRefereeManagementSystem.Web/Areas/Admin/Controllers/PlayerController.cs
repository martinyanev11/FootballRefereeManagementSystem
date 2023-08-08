namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using FootballRefereeManagementSystem.Web.ViewModels.Town;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Player;
    using ViewModels.Team;

    public class PlayerController : BaseAdminController
    {
        private readonly IPlayerService playerService;
        private readonly ISeasonService seasonService;
        private readonly ITeamService teamService;

        public PlayerController(
            IPlayerService playerService, 
            ISeasonService seasonService,
            ITeamService teamService)
        {
            this.playerService = playerService;
            this.seasonService = seasonService;
            this.teamService = teamService;
        }

        [HttpGet]
        public async Task<IActionResult> Register(int teamId)
        {
            try
            {
                int seasonId = await this.seasonService.GetPreparationSeasonIdAsync();
                TeamDetailsViewModel teamInfo = await this.teamService.GetTeamDetailsByIdAsync(teamId);

                PlayerTeamSeasonFormModel model = new PlayerTeamSeasonFormModel()
                {
                    TeamId = teamId,
                    TeamName = teamInfo.TeamName,
                    Teamlocation = teamInfo.TeamLocation,
                    SeasonId = seasonId,
                    Players = await this.playerService.GetAllSeasonUnregisteredPlayers(seasonId)
                };

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Register(PlayerTeamSeasonFormModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                await this.playerService.RegisterPlayerForSeason(model);

                return RedirectToAction("SeasonPreparation", "Season");
            }
            catch (Exception)
            {
                return View("Error");
            }

        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] PlayerQueryModel queryModel)
        {
            try
            {
                queryModel ??= new PlayerQueryModel();

                queryModel.Players = await this.playerService.GetAllPlayersAsync(queryModel);

                return View(queryModel);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PlayerFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.playerService.AddNewPlayerAsync(model);

                return RedirectToAction("All", "Player");
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
                bool playerExists =
                    await this.playerService.CheckPlayerExistanceByIdAsync(id);

                if (!playerExists)
                {
                    return View("Error404");
                }

                PlayerFormModel model = await this.playerService.GetPlayerForEditByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, PlayerFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.playerService.EditPlayerAsync(id, model);

                return RedirectToAction("All", "Player");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool playerExists =
                    await this.playerService.CheckPlayerExistanceByIdAsync(id);

                if (!playerExists)
                {
                    return View("Error404");
                }

                PlayerDetailsViewModel model =
                    await this.playerService.GetPlayerByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmedDelete(int id)
        {
            try
            {
                bool playerExists =
                    await this.playerService.CheckPlayerExistanceByIdAsync(id);

                if (!playerExists)
                {
                    return View("Error404");
                }

                await this.playerService.DeletePlayerAsync(id);

                return RedirectToAction("All", "Player");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
