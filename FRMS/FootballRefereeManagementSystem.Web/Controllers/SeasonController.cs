namespace FootballRefereeManagementSystem.Web.Controllers
{
    using FootballRefereeManagementSystem.Services.Models.Season;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Season;

    public class SeasonController : BaseController
    {
        private readonly ISeasonService seasonService;
        private readonly IMatchService matchService;
        private readonly ITeamService teamService;

        public SeasonController(IMatchService matchService, ITeamService teamService, ISeasonService seasonService)
        {
            this.matchService = matchService;
            this.teamService = teamService;
            this.seasonService = seasonService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery]SeasonQueryModel queryModel)
        {
            SeasonQueryModel sortedModel = 
                await this.seasonService.AllAsync(queryModel);

            

            return View();
        }
    }
}
