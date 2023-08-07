namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Home;

    public class HomeController : BaseAdminController
    {
        private readonly IRefereeService refereeService;
        private readonly ISeasonService seasonService;

        public HomeController(IRefereeService refereeService, ISeasonService seasonService)
        {
            this.refereeService = refereeService;
            this.seasonService = seasonService;
        }

        public async Task<IActionResult> Dashboard()
        {
            AdminStatisticsViewModel stats = new AdminStatisticsViewModel()
            {
                RefereesStatistics = await this.refereeService.GetRefereesStatisticsAsync(),
                SeasonStatistics = await this.seasonService.GetCurrentSeasonStatisticsAsync(),
            };

            return View(stats);
        }
    }
}
