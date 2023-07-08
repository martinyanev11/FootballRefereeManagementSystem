namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [AllowAnonymous]
    public class CareerController : BaseController
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
    }
}
