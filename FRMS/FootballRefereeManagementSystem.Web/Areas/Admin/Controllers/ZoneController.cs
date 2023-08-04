namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Zone;

    public class ZoneController : BaseAdminController
    {
        private readonly IZoneService zoneService;

        public ZoneController(IZoneService zoneService)
        {
            this.zoneService = zoneService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            try
            {
                IEnumerable<ZoneViewModel> model =
                    await this.zoneService.GetAllZonesAsync();

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ZoneFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.zoneService.AddNewZoneAsync(model);

                return RedirectToAction("All", "Zone");
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
                bool zoneExists =
                    await this.zoneService.CheckZoneExistanceByIdAsync(id);

                if (!zoneExists)
                {
                    return View("Error404");
                }

                ZoneFormModel model = await this.zoneService.GetZoneForEditByIdAsync(id);
                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ZoneFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.zoneService.EditZoneAsync(id, model);

                return RedirectToAction("All", "Zone");
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
                bool zoneExists =
                    await this.zoneService.CheckZoneExistanceByIdAsync(id);

                if (!zoneExists)
                {
                    return View("Error404");
                }

                ZoneViewModel model =
                    await this.zoneService.GetZoneByIdAsync(id);

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
                bool zoneExists =
                    await this.zoneService.CheckZoneExistanceByIdAsync(id);

                if (!zoneExists)
                {
                    return View("Error404");
                }

                await this.zoneService.DeleteZoneAsync(id);

                return RedirectToAction("All", "Zone");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
