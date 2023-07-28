namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Referee;

    public class RefereeController : BaseController
    {
        private readonly IRefereeService refereeService;

        public RefereeController(IRefereeService refereeService)
        {
            this.refereeService = refereeService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery]RefereeQueryModel queryModel)
        {
            try
            {
                IEnumerable<RefereeViewModel> filteredRefereesCollection =
                await this.refereeService.GetAllRefereesFilteredAsync(queryModel);

                queryModel.Referees = filteredRefereesCollection;

                return View(queryModel);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                bool refereeExists = await this.refereeService.CheckRefereeExistanceByIdAsync(id);

                if (!refereeExists)
                {
                    return View("Error404");
                }
            
                RefereeDetailsViewModel viewModel =
                await this.refereeService.GetRefereeDetailsByIdAsync(id);

                return View(viewModel);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
