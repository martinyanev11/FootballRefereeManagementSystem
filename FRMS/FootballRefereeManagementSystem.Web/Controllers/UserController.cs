namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Identity;

    using Services.Contracts;
    using Data.Models;
    using ViewModels.User;
    using ViewModels.Referee;
    using ViewModels.Career;
    using Infrastructure.Extensions;

    public class UserController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserService userService;
        private readonly IRefereeService refereeService;
        private readonly ICareerService careerService;
        private readonly IDivisionService divisionService;
        private readonly ISeasonService seasonService;

        public UserController(IUserService userService, 
            IRefereeService refereeService, 
            ICareerService careerService,
            IDivisionService divisionService,
            UserManager<ApplicationUser> userManager,
            ISeasonService seasonService)
        {
            this.userService = userService;
            this.refereeService = refereeService;
            this.careerService = careerService;
            this.divisionService = divisionService;
            this.userManager = userManager;
            this.seasonService = seasonService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                string userId = User.GetId();
                int userRefereeId = await this.refereeService.GetRefereeIdByUserIdAsync(userId);
                await this.refereeService.UpdateCurrentlyAppointedMatchesCountAsync(userRefereeId);

                ApplicationUserViewModel model = 
                    await this.userService.GetUserInformationByIdAsync(userId);

                model.RefereeDetails = await this.refereeService.GetRefereeDetailsByIdAsync(userRefereeId);
                model.CurrrentSeasonInformation = await this.seasonService.GetCurrentSeasonInformationAsync();

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> Status()
        {
            try
            {
                string userId = User.GetId();
                await this.userService.ChangeStatusAsync(userId);

                return RedirectToAction("Index", "User");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> CompleteRegistration(string id)
        {
            ApplicationViewModel userCareerApplication = 
                await this.careerService.GetApplicationByIdAsync(id);

            RefereeFormModel model = new RefereeFormModel()
            {
                FirstName = userCareerApplication.FirstName,
                LastName = userCareerApplication.LastName,
                Age = userCareerApplication.Age,
                Contact = userCareerApplication.ContactNumber,
                UserId = this.User.GetId(),
                StartingRole = userCareerApplication.Role.ToString(),
                StartingDivision = userCareerApplication.Division
            };

            return View(model);
        }

        // When this action is hit there is already registered user in the system
        // We add the phone number and confirm his email before adding referee table relation
        [HttpPost]
        public async Task<IActionResult> CompleteRegistration(RefereeFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                ApplicationUser user = await userManager.GetUserAsync(User);

                if (user is null)
                {
                    return View("Error404");
                }

                IdentityResult setPhoneResult = await userManager.SetPhoneNumberAsync(user, model.Contact);
                if (!setPhoneResult.Succeeded)
                {
                    return View("Error");
                }

                string code = await this.userManager.GenerateEmailConfirmationTokenAsync(user);
                IdentityResult result = await userManager.ConfirmEmailAsync(user, code);
                if (!result.Succeeded)
                {
                    return View("Erorr");
                }

                await this.refereeService.CreateNewRefereeAsync(model);

                int refereeId = await this.refereeService.GetRefereeIdByUserIdAsync(model.UserId);
                await this.divisionService.AddDivisionAndDivisionsWithLessDifficultyToRefereeByIdAsync(refereeId, model.StartingDivision);

                await this.userService.LinkUserToRefereeAsync(model.UserId, refereeId);

                return RedirectToAction("Index", "User");
            }
            catch (Exception)
            {
                return View("Error");
            }            
        }
    }
}
