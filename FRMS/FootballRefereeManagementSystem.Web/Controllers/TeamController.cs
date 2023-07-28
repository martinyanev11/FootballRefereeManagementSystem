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
            try
            {
                bool teamExists = await this.teamService.CheckTeamExistanceByIdAsync(id);

                if (!teamExists)
                {
                    return View("Error404");
                }

                if (string.IsNullOrEmpty(queryModel.SeasonFilter))
                {
                    queryModel.SeasonFilter = await seasonService.GetLatestSeasonDescriptionAsync();
                }

                queryModel.SeasonsOptions = await seasonService.GetAllSeasonDescriptionsAsync();

                // General team information
                TeamDetailsViewModel teamVM = await teamService.GetTeamDetailsByIdAsync(id);
                queryModel.GeneralInformation = teamVM;

                // Team information for specific season
                TeamSeasonDetailsViewModel teamSeasonVM = await teamService.GetTeamSeasonInformationByIdAsync(id);
                int seasonId = await this.seasonService.GetSeasonIdByDescriptionAsync(queryModel.SeasonFilter);
                teamSeasonVM.MatchHistory = await this.matchService.GetMatchHistoryForSeasonByTeamIdAsync(id, seasonId);
                teamSeasonVM.Players = await this.playerService.GetTeamPlayersForSeasonAsync(id, seasonId);

                queryModel.SeasonalInformation = teamSeasonVM;

                return View(queryModel);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
