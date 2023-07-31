namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.User;
    using Services.Contracts;
    using Infrastructure.Extensions;

    public class UserController : BaseController
    {
        private readonly IUserService userService;
        private readonly IRefereeService refereeService;

        public UserController(IUserService userService, IRefereeService refereeService)
        {
            this.userService = userService;
            this.refereeService = refereeService;
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
        public IActionResult CompleteRegistration(string id)
        {
            return View();
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
