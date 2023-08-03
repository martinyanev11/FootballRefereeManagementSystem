namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseAdminController
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
