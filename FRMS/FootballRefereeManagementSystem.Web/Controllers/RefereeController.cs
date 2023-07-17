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

        public async Task<IActionResult> All()
        {
            IEnumerable<RefereeViewModel> model = await this.refereeService.GetAllRefereesAsync();

            return View(model);
        }
    }
}
