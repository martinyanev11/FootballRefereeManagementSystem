namespace FootballRefereeManagementSystem.Web.Areas.Identity.Pages.Account.Manage
{
    using Microsoft.AspNetCore.Mvc;

    using Manage.Enums;

    public class StatusMessage
    {
        public Alert Alert { get; set; }

        [TempData]
        public string? Text { get; set; }
    }
}
