namespace FootballRefereeManagementSystem.Web.Controllers
{
    using FootballRefereeManagementSystem.Services.Contracts;
    using Microsoft.AspNetCore.Mvc;

    public class MatchController : BaseController
    {
        private readonly IMatchService matchService;

        public MatchController(IMatchService matchService)
        {
            this.matchService = matchService;
        }

        public IActionResult All()
        {
            return View();
        }
    }
}
