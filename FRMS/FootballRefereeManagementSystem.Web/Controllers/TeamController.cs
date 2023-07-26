namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Team;

    public class TeamController : BaseController
    {
        public readonly ISeasonService seasonService;
        private readonly ITeamService teamService;
        private readonly IMatchService matchService;
        private readonly IPlayerService playerService;

        public TeamController(
            ISeasonService seasonService, 
            ITeamService teamService, 
            IMatchService matchService,
            IPlayerService playerService)
        {
            this.seasonService = seasonService;
            this.teamService = teamService;
            this.matchService = matchService;
            this.playerService = playerService;
        }

        public async Task<IActionResult> Details(int id, [FromQuery]TeamQueryModel queryModel)
        {
            if (string.IsNullOrEmpty(queryModel.SeasonFilter))
            {
                queryModel.SeasonFilter = await seasonService.GetCurrentSeasonDescriptionAsync();
            }

            queryModel.SeasonsOptions = await seasonService.GetAllSeasonsAsync();

            queryModel.GeneralInformation = await teamService.GetTeamDetailsInformationByIdAsync(id);
            queryModel.SeasonalInformation = await teamService.GetTeamSeasonsInformationByIdAsync(id);

            int seasonId = await this.seasonService.GetSeasonIdByDescriptionAsync(queryModel.SeasonFilter);
            queryModel.SeasonalInformation.MatchHistory = await this.matchService.GetMatchHistoryForSeasonByTeamId(id, seasonId);
            queryModel.SeasonalInformation.Players = await this.playerService.GetTeamPlayersForSeasonAsync(id, seasonId);

            return View();
        }
    }
}
