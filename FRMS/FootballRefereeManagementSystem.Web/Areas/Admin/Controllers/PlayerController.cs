namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using FootballRefereeManagementSystem.Services.Contracts;
    using FootballRefereeManagementSystem.Web.ViewModels.Player;
    using FootballRefereeManagementSystem.Web.ViewModels.Team;
    using Microsoft.AspNetCore.Mvc;

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
    }
}
