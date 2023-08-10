namespace FootballRefereeManagementSystem.Web.Controllers
{
    using System.IO;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;

    [AllowAnonymous]
    public class HomeController : BaseController
    {
        private readonly ISeasonService seasonService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HomeController(ISeasonService seasonService, IWebHostEnvironment webHostEnvironment)
        {
            this.seasonService = seasonService;
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            // Carousel rotation images load
            string imagesPath = Path.Combine(webHostEnvironment.WebRootPath, "Images", "Home");

            IEnumerable<string> imagePaths = Directory.EnumerateFiles(imagesPath)
                .Where(file => file.EndsWith(".jpeg") || file.EndsWith(".jpg"));

            ViewData["CurrentSeason"] = 
                await this.seasonService.GetCurrentSeasonDescriptionAsync();

            return View(imagePaths);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("Error404");
            }
            if (statusCode == 401)
            {
                return View("Error401");
            }
            if (statusCode == 403)
            {
                return View("Error403");
            }

            return View();
        }
    }
}