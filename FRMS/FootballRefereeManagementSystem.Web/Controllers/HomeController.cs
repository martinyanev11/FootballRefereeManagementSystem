namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [AllowAnonymous]
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GameRulesDownload()
        {
            string fileName = "Footbal-Rules-2021-22.pdf";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Downloads", fileName);

            if (!System.IO.File.Exists(filePath))
            {
                return View("Error");
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(fileBytes, "application/pdf", fileName);
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