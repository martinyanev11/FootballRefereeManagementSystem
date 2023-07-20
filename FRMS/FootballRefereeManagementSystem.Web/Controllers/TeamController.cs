namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class TeamController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
