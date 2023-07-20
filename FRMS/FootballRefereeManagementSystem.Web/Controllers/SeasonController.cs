namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Season;

    public class SeasonController : BaseController
    {
        private readonly ISeasonService seasonService;
        private readonly IMatchService matchService;
        private readonly ITeamService teamService;
        private readonly IDivisionService divisionService;

        public SeasonController(
            IMatchService matchService, 
            ITeamService teamService, 
            ISeasonService seasonService, 
            IDivisionService divisionService)
        {
            this.matchService = matchService;
            this.teamService = teamService;
            this.seasonService = seasonService;
            this.divisionService = divisionService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery]SeasonQueryModel queryModel)
        {
            queryModel.Matches = await this.matchService
                .GetFilteredBySeasonAndDivisionMatchesAsync(queryModel.SeasonFilter, queryModel.DivisionFilter);

            queryModel.Standings = await this.teamService
                .GetFilteredBySeasonAndDivisionTeamStandingsAsync(queryModel.SeasonFilter, queryModel.DivisionFilter);

            queryModel.SeasonsOptions = await this.seasonService.GetAllSeasonsAsync();
            queryModel.DivisionsOptions = await this.divisionService.GetAllDivisionsAsync();

            return View(queryModel);
        }
    }
}
