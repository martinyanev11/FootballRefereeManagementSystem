namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using Common;
    using Data.Models;
    using ViewModels.Match;
    using ViewModels.Referee;
    using ViewModels.RefereeSquad;
    using Services.Contracts;
    using static Common.EntityValidationConstants;
    using FootballRefereeManagementSystem.Web.Infrastructure.Extensions;

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
                bool refereeExists =
                    await this.refereeService.CheckRefereeExistanceByIdAsync(id);

                if (!refereeExists)
                {
                    return View("Error404");
                }

                if (!ModelState.IsValid)
                {
                    model.Divisions = await this.divisionService.GetAllDivisionKeyValuePairs();
                    return View(model);
                }

                await this.refereeService.EditRefereeByIdAsync(id, model);

                string userToChangeId = await this.refereeService.GetUserIdByRefereeIdAsync(id);
                bool isAdmin = await this.userService.IsUserAdminAsync(userToChangeId);

                if (model.Role == GeneralApplicationConstants.AdminRoleTranslated)
                {
                    // If admin role is selected and user is not admin -> add role
                    if (!isAdmin)
                    {
                        await this.userService.AddUserToAdminRoleAsync(userToChangeId);
                    }
                }
                else
                {
                    // If selected role is something other than admin
                    // Check if user is admin and his rights need to be removed                    
                    if (isAdmin)
                    {
                        await this.userService.RemoveUserFromAdminRoleAsync(userToChangeId);
                    }
                }

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

                string userId = await this.refereeService.GetUserIdByRefereeIdAsync(id);
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

        [HttpGet]
        public async Task<IActionResult> EditSquad(string id)
        {
            try
            {
                bool squadExists = await this.refereeService.CheckRefereeSquadExistanceByIdAsync(id);
                if (!squadExists)
                {
                    return View("Error404");
                }

                RefereeSquadEditModel model = await this.refereeService.GetRefereeSquadForEditByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditSquad(string id, RefereeSquadEditModel model)
        {
            try
            {
                if (model.AssistantRefereeOneId == model.AssistantRefereeTwoId)
                {
                    ModelState.AddModelError("AssistantRefereeOneId", "Асистент съдийте трябва да са различни.");
                }

                if (!ModelState.IsValid)
                {
                    model = await this.refereeService.GetRefereeSquadForEditByIdAsync(id);
                    return View(model);
                }

                await this.refereeService.EditRefereeSquadAsync(id, model);

                return RedirectToAction("Schedule", "Referee", new { area = "" });
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}