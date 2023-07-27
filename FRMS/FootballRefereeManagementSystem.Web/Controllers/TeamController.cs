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
                queryModel.SeasonFilter = await seasonService.GetLatestSeasonDescriptionAsync();
            }

            queryModel.SeasonsOptions = await seasonService.GetAllSeasonDescriptionsAsync();

            TeamDetailsViewModel teamVM = await teamService.GetTeamDetailsByIdAsync(id);
            queryModel.GeneralInformation = teamVM;

            TeamSeasonDetailsViewModel teamSeasonVM = await teamService.GetTeamSeasonInformationByIdAsync(id);
            int seasonId = await this.seasonService.GetSeasonIdByDescriptionAsync(queryModel.SeasonFilter);
            teamSeasonVM.MatchHistory = await this.matchService.GetMatchHistoryForSeasonByTeamIdAsync(id, seasonId);
            teamSeasonVM.Players = await this.playerService.GetTeamPlayersForSeasonAsync(id, seasonId);

            queryModel.SeasonalInformation = teamSeasonVM;

            return View(queryModel);
        }
    }
}
