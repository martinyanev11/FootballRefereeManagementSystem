namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using FootballRefereeManagementSystem.Data.Models;
    using FootballRefereeManagementSystem.Web.ViewModels.Match;
    using FootballRefereeManagementSystem.Web.ViewModels.Referee;
    using FootballRefereeManagementSystem.Web.ViewModels.RefereeSquad;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using static FootballRefereeManagementSystem.Common.EntityValidationConstants;

    public class RefereeController : BaseAdminController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserService userService;
        private readonly IRefereeService refereeService;
        private readonly IDivisionService divisionService;
        private readonly IMatchService matchService;

        public RefereeController(
            UserManager<ApplicationUser> userManager,
            IRefereeService refereeService,
            IDivisionService divisionService,
            IUserService userService,
            IMatchService matchService)
        {
            this.userManager = userManager;
            this.refereeService = refereeService;
            this.divisionService = divisionService;
            this.userService = userService;
            this.matchService = matchService;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                bool refereeExists =
                    await this.refereeService.CheckRefereeExistanceByIdAsync(id);

                if (!refereeExists)
                {
                    return View("Error404");
                }

                RefereeEditFormModel model = 
                    await this.refereeService.GetRefereeForEditByIdAsync(id);

                model.Divisions = await this.divisionService.GetAllDivisionKeyValuePairs();

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, RefereeEditFormModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    model.Divisions = await this.divisionService.GetAllDivisionKeyValuePairs();
                    return View(model);
                }

                bool refereeExists =
                    await this.refereeService.CheckRefereeExistanceByIdAsync(id);

                if (!refereeExists)
                {
                    return View("Error404");
                }

                await this.refereeService.EditRefereeByIdAsync(id, model);

                return RedirectToAction("All", "Referee", new { area = "" });
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
                bool refereeExists =
                    await this.refereeService.CheckRefereeExistanceByIdAsync(id);

                if (!refereeExists)
                {
                    return View("Error404");
                }

                RefereeDetailsViewModel viewModel =
                    await this.refereeService.GetRefereeDetailsByIdAsync(id);

                string userId = await this.refereeService.GetUserIdByRefereeId(id);
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
        public async Task<IActionResult> ConfirmedDelete(int id)
        {
            try
            {
                bool refereeExists =
                    await this.refereeService.CheckRefereeExistanceByIdAsync(id);

                if (!refereeExists)
                {
                    return View("Error404");
                }

                string userId = await this.refereeService.GetUserIdByRefereeId(id);
                ApplicationUser? user = await this.userManager.FindByIdAsync(userId);
                if (user is null)
                {
                    return RedirectToAction("Error", StatusCode(404));
                }

                await this.userService.DeleteUserInformationAsync(user);
                IdentityResult result = await this.userManager.UpdateAsync(user);

                if (!result.Succeeded)
                {
                    return RedirectToAction("Error");
                }

                await this.refereeService.DeleteRefereeAsync(user.RefereeId);

                return RedirectToAction("All", "Referee", new { area = "" });
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Schedule([FromQuery] MatchQueryModel model)
        {
            model.DivisionOptions = await this.divisionService.GetAllDivisionNamesAsync();
            model.WeeklyMatches = await this.matchService.GetWeeklyMatchesAsync(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateSquad(int id)
        {
            try
            {
                int divisionId = await this.matchService.GetDivisionIdByMatchIdAsync(id);

                RefereeSquadFormModel model = new RefereeSquadFormModel()
                {
                    DivisionId = divisionId,
                    MainRefereesList = await this.refereeService.GetAllAvaliableInDivisionRefereesOfRoleType(divisionId, "Referee"),
                    AssistantRefereesList = await this.refereeService.GetAllAvaliableInDivisionRefereesOfRoleType(divisionId, "AssistantReferee"),
                    DelegatesList = await this.refereeService.GetAllAvaliableInDivisionRefereesOfRoleType(divisionId, "Delegate"),
                };

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> CreateSquad(int id, RefereeSquadFormModel model)
        {
            try
            {
                if (model.AssistantRefereeOneId == model.AssistantRefereeTwoId)
                {
                    ModelState.AddModelError("AssistantRefereeOneId", "Асистент съдийте трябва да са различни.");
                }

                if (!ModelState.IsValid)
                {
                    model.MainRefereesList = await this.refereeService.GetAllAvaliableInDivisionRefereesOfRoleType(model.DivisionId, "Referee");
                    model.AssistantRefereesList = await this.refereeService.GetAllAvaliableInDivisionRefereesOfRoleType(model.DivisionId, "AssistantReferee");
                    model.DelegatesList = await this.refereeService.GetAllAvaliableInDivisionRefereesOfRoleType(model.DivisionId, "Delegate");
                    return View(model);
                }

                Guid newRefSquadId = await this.refereeService.CreateRefereeSquad(id, model);

                await this.matchService.LinkMatchToRefereeSquadAsync(id, newRefSquadId);

                return RedirectToAction("Schedule", "Referee");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}