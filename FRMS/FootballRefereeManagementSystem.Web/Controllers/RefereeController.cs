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
            IEnumerable<RefereeViewModel> filteredRefereesCollection =
                await this.refereeService.GetAllRefereesFilteredAsync(queryModel);

            queryModel.Referees = filteredRefereesCollection;

            return View(queryModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            RefereeDetailsViewModel viewModel = 
                await this.refereeService.GetRefereeDetailsByIdAsync(id);

            return PartialView("_Details", viewModel);
        }
    }
}
