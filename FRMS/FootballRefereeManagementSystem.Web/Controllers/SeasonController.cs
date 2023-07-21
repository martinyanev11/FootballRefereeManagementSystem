namespace FootballRefereeManagementSystem.Web.Controllers
{
    using FootballRefereeManagementSystem.Web.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Season;

    public class SeasonController : BaseController
    {
        private readonly ISeasonService seasonService;
        private readonly IMatchService matchService;
        private readonly ITeamService teamService;
        private readonly IDivisionService divisionService;
        private readonly IRefereeService refereeService;

        public SeasonController(
            IMatchService matchService, 
            ITeamService teamService, 
            ISeasonService seasonService, 
            IDivisionService divisionService,
            IRefereeService refereeService)
        {
            this.matchService = matchService;
            this.teamService = teamService;
            this.seasonService = seasonService;
            this.divisionService = divisionService;
            this.refereeService = refereeService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery]SeasonQueryModel returneQueryModel)
        {
            SeasonQueryModel queryModel = new SeasonQueryModel();

            // Set default filter options
            if (string.IsNullOrEmpty(returneQueryModel.SeasonFilter))
            {
                queryModel.SeasonFilter = 
                    await this.seasonService.GetCurrentSeasonDescriptionAsync();
            }
            else
            {
                queryModel.SeasonFilter = returneQueryModel.SeasonFilter;
            }
            
            if (string.IsNullOrEmpty(returneQueryModel.DivisionFilter))
            {
                string userId = User.GetId();
                int refereeId = await this.refereeService.GetRefereeIdByUserId(userId);

                queryModel.DivisionFilter = 
                    await this.divisionService.GetMostOfficiatedDivisionForRefereeByIdAsync(refereeId);
            }
            else
            {
                queryModel.DivisionFilter = returneQueryModel.DivisionFilter;
            }

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
