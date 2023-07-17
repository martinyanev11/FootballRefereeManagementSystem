﻿namespace FootballRefereeManagementSystem.Web.Controllers
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
            string userId = User.GetId();
            ApplicationUserViewModel model = await this.userService.GetApplicationUserInformationAsync(userId);

            return View(model);
        }

        public async Task<IActionResult> Status()
        {
            string userId = User.GetId();
            await this.userService.ChangeStatusAsync(userId);

            return RedirectToAction("Index", "User");
        }
    }
}