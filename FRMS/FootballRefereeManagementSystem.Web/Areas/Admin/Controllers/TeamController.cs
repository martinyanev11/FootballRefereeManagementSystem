namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Team;

    public class TeamController : BaseAdminController
    {
        private readonly ITeamService teamService;
        private readonly IZoneService zoneService;
        private readonly ITownService townService;

        public TeamController(ITeamService teamService, IZoneService zoneService, ITownService townService)
        {
            this.teamService = teamService;
            this.zoneService = zoneService;
            this.townService = townService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] TeamAdminQueryModel queryModel)
        {
            try
            {
                queryModel ??= new TeamAdminQueryModel();

                queryModel.Teams = await this.teamService.GetAllTeamsAsync(queryModel);
                queryModel.Zones = await this.zoneService.GetAllZoneNamesAsync();

                return View(queryModel);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            TeamFormModel model = new TeamFormModel()
            {
                Towns = await this.townService.GetAllTownNamesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TeamFormModel model)
        {
            try
            {
                bool teamAlreadyExists = await this.teamService.IsTeamAlreadyAdded(model);
                if (teamAlreadyExists)
                {
                    ModelState.AddModelError("Name", "Вече има отбор от този град с това име.");
                }

                if (!ModelState.IsValid)
                {
                    model.Towns = await this.townService.GetAllTownNamesAsync();
                    return View(model);
                }

                model.TownId = await this.townService.GetTownIdByNameAsync(model.Town);
                await this.teamService.AddNewTeamAsync(model);

                return RedirectToAction("All", "Team");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                bool teamExists =
                    await this.teamService.CheckTeamExistanceByIdAsync(id);

                if (!teamExists)
                {
                    return View("Error404");
                }

                TeamFormModel model = await this.teamService.GetTeamForEditByIdAsync(id);
                model.Towns = await this.townService.GetAllTownNamesAsync();

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TeamFormModel model)
        {
            try
            {
                bool teamAlreadyExists = await this.teamService.IsTeamAlreadyAdded(id, model);
                if (teamAlreadyExists)
                {
                    ModelState.AddModelError("Name", "Вече има отбор от този град с това име.");
                }

                if (!ModelState.IsValid)
                {
                    model.Towns = await this.townService.GetAllTownNamesAsync();
                    return View(model);
                }

                model.TownId = await this.townService.GetTownIdByNameAsync(model.Town);
                await this.teamService.EditTeamAsync(id, model);

                return RedirectToAction("All", "Team");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool teamExists =
                    await this.teamService.CheckTeamExistanceByIdAsync(id);

                if (!teamExists)
                {
                    return View("Error404");
                }

                TeamAdminViewModel model =
                    await this.teamService.GetTeamInfoByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmedDelete(int id)
        {
            try
            {
                bool teamExists =
                    await this.teamService.CheckTeamExistanceByIdAsync(id);

                if (!teamExists)
                {
                    return View("Error404");
                }

                await this.teamService.DeleteTeamAsync(id);

                return RedirectToAction("All", "Team");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}