namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Season;
    using Infrastructure.Extensions;

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

            try
            {
                // Set default filter options
                if (string.IsNullOrEmpty(returneQueryModel.SeasonFilter))
                {
                    queryModel.SeasonFilter =
                        await this.seasonService.GetLatestSeasonDescriptionAsync();
                }
                else
                {
                    queryModel.SeasonFilter = returneQueryModel.SeasonFilter;
                }

                if (string.IsNullOrEmpty(returneQueryModel.DivisionFilter))
                {
                    string userId = User.GetId();
                    int refereeId = await this.refereeService.GetRefereeIdByUserIdAsync(userId);

                    queryModel.DivisionFilter =
                        await this.divisionService.GetNameOfMostOfficiatedDivisionForRefereeByIdAsync(refereeId);
                }
                else
                {
                    queryModel.DivisionFilter = returneQueryModel.DivisionFilter;
                }

                // Fetch data
                queryModel.Matches = await this.matchService
                    .GetFilteredBySeasonAndDivisionMatchesAsync(queryModel.SeasonFilter, queryModel.DivisionFilter);

                queryModel.Standings = await this.teamService
                    .GetFilteredBySeasonAndDivisionTeamsStandingsAsync(queryModel.SeasonFilter, queryModel.DivisionFilter);

                queryModel.SeasonsOptions = await this.seasonService.GetAllSeasonDescriptionsAsync();
                queryModel.DivisionsOptions = await this.divisionService.GetAllDivisionNamesAsync();

                // Return to last selected tab for better UX
                if (string.IsNullOrEmpty(returneQueryModel.LastSelectedTab))
                {
                    // Set default value
                    queryModel.LastSelectedTab = "Matches";
                }
                else
                {
                    queryModel.LastSelectedTab = returneQueryModel.LastSelectedTab;
                }

                return View(queryModel);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
