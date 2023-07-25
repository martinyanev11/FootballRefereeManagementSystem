namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Match;

    public class MatchController : BaseController
    {
        private readonly IMatchService matchService;

        public MatchController(IMatchService matchService)
        {
            this.matchService = matchService;
        }

        public async Task<IActionResult> Details(int id)
        {
            MatchDetailsViewModel model = 
                await this.matchService.GetMatchDetailsByIdAsync(id);

            return View(model);
        }
    }
}
