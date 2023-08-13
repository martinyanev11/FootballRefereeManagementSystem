namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Match;

    public class MatchController : BaseController
    {
        private readonly IMatchService matchService;
        private readonly IRefereeService refereeService;

        public MatchController(IMatchService matchService, IRefereeService refereeService)
        {
            this.matchService = matchService;
            this.refereeService = refereeService;
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
                bool matchExists = await this.matchService.CheckMatchExistanceByIdAsync(model.MatchId);

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

                int matchDivisionId = await this.matchService.GetDivisionIdByMatchIdAsync(model.MatchId);
                int[] refereeIds = await this.refereeService.GetAllRefereeIdsFromRefereeSquadAsync(id);

                await this.refereeService.IncrementRefereeDivisionMatchCountStatsAsync(matchDivisionId, refereeIds);

                return RedirectToAction("Schedule", "Referee");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
