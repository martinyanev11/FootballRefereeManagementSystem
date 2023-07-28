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

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                MatchDetailsViewModel model = 
                    await this.matchService.GetMatchDetailsByIdAsync(id);

                if (model is null)
                {
                    return View("Error404");
                }

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }

        }
    }
}
