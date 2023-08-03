namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Division;

    public class DivisionController : BaseAdminController
    {
        private readonly IDivisionService divisionService;

        public DivisionController(IDivisionService divisionService)
        {
            this.divisionService = divisionService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<DivisionAllViewModel> models = 
                await this.divisionService.GetAllDivisionsAsync();

            return View(models);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(DivisionFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.divisionService.AddNewDivisionAsync(model);

                return RedirectToAction("All", "Division");
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
                bool divisionExists =
                    await this.divisionService.CheckDivisionExistanceByIdAsync(id);

                if (!divisionExists)
                {
                    return View("Error404");
                }

                DivisionFormModel model = 
                    await this.divisionService.GetDivisionForEditByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,  DivisionFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.divisionService.EditDivisionAsync(id, model);

                return RedirectToAction("All", "Division");
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
                bool divisionExists =
                    await this.divisionService.CheckDivisionExistanceByIdAsync(id);

                if (!divisionExists)
                {
                    return View("Error404");
                }

                DivisionViewModel model =
                    await this.divisionService.GetDivisionViewModelByIdAsync(id);

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
                bool divisionExists =
                    await this.divisionService.CheckDivisionExistanceByIdAsync(id);

                if (!divisionExists)
                {
                    return View("Error404");
                }

                await this.divisionService.DeleteDivisionAsync(id);

                return RedirectToAction("All", "Division");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
