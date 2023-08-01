namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.User;
    using Services.Contracts;
    using Infrastructure.Extensions;
    using Web.ViewModels.Career;
    using Web.ViewModels.Referee;
    using FootballRefereeManagementSystem.Data.Models.Enums;

    public class UserController : BaseController
    {
        private readonly IUserService userService;
        private readonly IRefereeService refereeService;
        private readonly ICareerService careerService;
        private readonly IDivisionService divisionService;
        private readonly ITownService townService;
        private readonly IZoneService zoneService;

        public UserController(IUserService userService, 
            IRefereeService refereeService, 
            ICareerService careerService,
            IDivisionService divisionService,
            ITownService townService,
            IZoneService zoneService)
        {
            this.userService = userService;
            this.refereeService = refereeService;
            this.careerService = careerService;
            this.divisionService = divisionService;
            this.townService = townService;
            this.zoneService = zoneService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                if (User.IsInRole("Admin"))
                {
                    return View("Dashboard");
                }

                string userId = User.GetId();
                ApplicationUserViewModel model = 
                    await this.userService.GetUserInformationAsync(userId);

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
                FirstName = userCareerApplication.FirstName.Split()[0].TrimEnd(),
                LastName = userCareerApplication.FirstName.Split()[1].TrimStart(),
                Age = userCareerApplication.Age,
                Contact = userCareerApplication.ContactNumber,
                UserId = this.User.GetId(),
                Role = this.refereeService.GetRefereeStartingRole(),
                Division = await this.divisionService.GetLowestDivisionNameAsync(),
                Zones = await this.zoneService.GetAllZoneNamesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CompleteRegistration(RefereeFormModel model)
        {
            bool zoneExists = await this.zoneService.CheckZoneExistanceByNameAsync(model.Zone);

            if (!zoneExists)
            {
                ModelState.AddModelError("Zone", "Зоната не е валидна");
            }

            if (!model.Contact.StartsWith("0"))
            {
                ModelState.AddModelError("Contact", "Телефонния номер трябва да започва с 0");
            }

            if (!ModelState.IsValid)
            {
                model.UserId = this.User.GetId();
                model.Role = this.refereeService.GetRefereeStartingRole();
                model.Division = await this.divisionService.GetLowestDivisionNameAsync();
                model.Zones = await this.zoneService.GetAllZoneNamesAsync();

                return View(model);
            }

            bool townExists = await this.townService.CheckTownExistanceByNameAsync(model.Town);

            if (!townExists)
            {
                int zoneId = await this.zoneService.GetZoneIdByNameAsync(model.Zone);
                await this.townService.AddNewTownAsync(model.Town, zoneId);
            }

            int townId = await this.townService.GetTownIdByNameAsync(model.Town); 
            model.TownId = townId;

            await this.refereeService.CreateNewRefereeAsync(model);

            int refereeId = await this.refereeService.GetRefereeIdByUserIdAsync(model.UserId);
            await this.divisionService.AddNewDivisionToRefereeByIdAsync(refereeId, model.Division);

            return RedirectToAction("Index", "User");
        }

        public IActionResult Dashboard()
        {
            if (!User.IsInRole("Admin"))
            {
                return View("Error401");
            }

            return View();
        }
    }
}
