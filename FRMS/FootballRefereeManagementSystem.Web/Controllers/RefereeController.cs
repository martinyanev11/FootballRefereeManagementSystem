namespace FootballRefereeManagementSystem.Web.Controllers
{
    using FootballRefereeManagementSystem.Web.Infrastructure.Extensions;
    using FootballRefereeManagementSystem.Web.ViewModels.RefereeSquad;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.Referee;

    public class RefereeController : BaseController
    {
        private readonly IRefereeService refereeService;
        private readonly IMatchService matchService;

        public RefereeController(IRefereeService refereeService, IMatchService matchService)
        {
            this.refereeService = refereeService;
            this.matchService = matchService;
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

        [HttpGet]
        public async Task<IActionResult> Schedule()
        {
            IEnumerable<RefereeSquadViewModel> squadViewModels =
                await this.refereeService.GetAllActiveRefereeSquadsAsync();

            string userId = this.User.GetId();
            int userRefereeId = await this.refereeService.GetRefereeIdByUserIdAsync(userId);
            ViewData["UserRefereeId"] = userRefereeId;

            foreach (RefereeSquadViewModel refSquad in squadViewModels)
            {
                refSquad.Match = 
                    await this.matchService.GetMatchForRefereeSquadByIdAsync(refSquad.RefereeSquadId);
            }

            return View(squadViewModels);
        }
    }
}