namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using ViewModels.User;
    using Services.Contracts;
    using Infrastructure.Extensions;

    public class UserController : BaseController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
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
