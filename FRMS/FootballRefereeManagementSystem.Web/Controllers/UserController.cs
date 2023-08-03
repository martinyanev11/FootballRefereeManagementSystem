namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.User;
    using ViewModels.Referee;
    using ViewModels.Career;
    using Services.Contracts;
    using Infrastructure.Extensions;

    public class UserController : BaseController
    {
        private readonly IUserService userService;
        private readonly IRefereeService refereeService;
        private readonly ICareerService careerService;
        private readonly IDivisionService divisionService;

        public UserController(IUserService userService, 
            IRefereeService refereeService, 
            ICareerService careerService,
            IDivisionService divisionService)
        {
            this.userService = userService;
            this.refereeService = refereeService;
            this.careerService = careerService;
            this.divisionService = divisionService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                string userId = User.GetId();
                ApplicationUserViewModel model = 
                    await this.userService.GetUserInformationByIdAsync(userId);

                int userRefereeId = await this.refereeService.GetRefereeIdByUserIdAsync(userId);
                model.RefereeDetails = await this.refereeService.GetRefereeDetailsByIdAsync(userRefereeId);

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

        [HttpPost]
        public async Task<IActionResult> CompleteRegistration(RefereeFormModel model)
        {
            if (!model.Contact.StartsWith("0"))
            {
                ModelState.AddModelError("Contact", "Телефонния номер трябва да започва с 0");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
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
