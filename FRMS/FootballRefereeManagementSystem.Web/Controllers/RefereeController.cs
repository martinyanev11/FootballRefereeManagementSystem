namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Identity;

    using Services.Contracts;
    using Data.Models;
    using ViewModels.RefereeSquad;
    using ViewModels.Referee;
    using ViewModels.Match;
    using Infrastructure.Extensions;

    public class RefereeController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRefereeService refereeService;
        private readonly IMatchService matchService;
        private readonly IMessageService messageService;

        public RefereeController(IRefereeService refereeService, 
            IMatchService matchService, 
            UserManager<ApplicationUser> userManager,
            IMessageService messageService)
        {
            this.refereeService = refereeService;
            this.matchService = matchService;
            this.userManager = userManager;
            this.messageService = messageService;
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

                string userId = await this.refereeService.GetUserIdByRefereeIdAsync(id);
                ApplicationUser user = await userManager.FindByIdAsync(userId);

                viewModel.Contact = await userManager.GetPhoneNumberAsync(user);

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

        [HttpGet]
        public async Task<IActionResult> MatchCenter(string id)
        {
            try
            {
                bool squadExists = await this.refereeService.CheckRefereeSquadExistanceByIdAsync(id);
                if (!squadExists)
                {
                    return View("Error404");
                }

                int matchId = await this.matchService.GetMatchIdByRefereeSquadIdAsync(id);

                MatchCenterViewModel model = new MatchCenterViewModel()
                {
                    RefereeSquad = await this.refereeService.GetRefereeSquadForMatchCenterAsync(id),
                    MatchInformation = await this.matchService.GetMatchDetailsByIdAsync(matchId),
                    Messages = await this.messageService.GetAllMessagesForRefereeSquadAsync(id),
                    MatchResult = new MatchFinishModel()
                    {
                        MatchId = matchId,
                        RefereeSquadId = id,
                    },
                };

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}