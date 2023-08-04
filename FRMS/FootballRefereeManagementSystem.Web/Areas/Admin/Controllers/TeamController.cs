namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using FootballRefereeManagementSystem.Services.Contracts;
    using FootballRefereeManagementSystem.Web.ViewModels.Team;
    using FootballRefereeManagementSystem.Web.ViewModels.Town;
    using Microsoft.AspNetCore.Mvc;

    public class TeamController : BaseAdminController
    {
        private readonly ITeamService teamService;
        private readonly IZoneService zoneService;

        public TeamController(ITeamService teamService, IZoneService zoneService)
        {
            this.teamService = teamService;
            this.zoneService = zoneService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] TeamAdminQueryModel queryModel)
        {
            try
            {
                queryModel ??= new TeamAdminQueryModel();

                queryModel = await this.teamService.GetAllTeamsAsync(queryModel);
                queryModel.Zones = await this.zoneService.GetAllZoneNamesAsync();

                return View(queryModel);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
