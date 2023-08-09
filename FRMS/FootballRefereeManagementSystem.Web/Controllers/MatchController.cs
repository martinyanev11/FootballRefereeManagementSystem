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

        [HttpPost]
        public async Task<IActionResult> FinishMatch(string id, MatchFinishModel model)
        {
            try
            {
                bool matchExists = await this.matchService.CheckMatchExistanceById(model.MatchId);

                if (!matchExists)
                {
                    return View("Error404");
                }

                if (model.HomeTeamScore < 0 || model.AwayTeamScore < 0)
                {
                    ModelState.AddModelError(string.Empty, "Резултатът не може да бъде отрицателно число");
                }

                if (!ModelState.IsValid)
                {
                    return RedirectToAction("MatchCenter", "Referee", new { id = id });
                }

                await this.matchService.FinishMatchAsync(model);

                return RedirectToAction("Schedule", "Referee");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
