namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Town;

    public class TownController : BaseAdminController
    {
        private readonly ITownService townService;
        private readonly IZoneService zoneService;

        public TownController(IZoneService zoneService, ITownService townService)
        {
            this.zoneService = zoneService;
            this.townService = townService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery]TownQueryModel queryModel)
        {
            try
            {
                queryModel ??= new TownQueryModel();

                queryModel.Towns = await this.townService.GetAllTownsAsync(queryModel);
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
            TownFormModel model = new TownFormModel()
            {
                Zones = await this.zoneService.GetAllZoneNamesAsync(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TownFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Zones = await this.zoneService.GetAllZoneNamesAsync();
                return View(model);
            }

            try
            {
                bool zoneExists = await this.zoneService.CheckZoneExistanceByNameAsync(model.Zone);
                if (!zoneExists)
                {
                    ModelState.AddModelError("Zone", "Зоната не съществува");
                    model.Zones = await this.zoneService.GetAllZoneNamesAsync();
                    return View(model);
                }

                model.ZoneId = await this.zoneService.GetZoneIdByNameAsync(model.Zone);
                await this.townService.AddNewTownAsync(model);

                return RedirectToAction("All", "Town");
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
                bool townExists = 
                    await this.townService.CheckTownExistanceByIdAsync(id);

                if (!townExists)
                {
                    return View("Error404");
                }

                TownFormModel model = await this.townService.GetTownForEditByIdAsync(id);
                model.Zones = await this.zoneService.GetAllZoneNamesAsync();

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }            
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TownFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                bool zoneExists = await this.zoneService.CheckZoneExistanceByNameAsync(model.Zone);
                if (!zoneExists)
                {
                    ModelState.AddModelError("Zone", "Зоната не съществува");
                    model.Zones = await this.zoneService.GetAllZoneNamesAsync();
                    return View(model);
                }

                model.ZoneId = await this.zoneService.GetZoneIdByNameAsync(model.Zone);
                await this.townService.EditTownAsync(id, model);

                return RedirectToAction("All", "Town");
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
                bool townExists =
                    await this.townService.CheckTownExistanceByIdAsync(id);

                if (!townExists)
                {
                    return View("Error404");
                }

                TownViewModel model =
                    await this.townService.GetTownByIdAsync(id);

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
                bool townExists =
                    await this.townService.CheckTownExistanceByIdAsync(id);

                if (!townExists)
                {
                    return View("Error404");
                }

                await this.townService.DeleteTownAsync(id);

                return RedirectToAction("All", "Town");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
