namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class RefereeController : BaseController
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
