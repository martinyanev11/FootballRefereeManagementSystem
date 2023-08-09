namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using Services.Contracts;
    using ViewModels.Message;

    public class MessageController : BaseController
    {
        private readonly IMessageService messageService;

        public MessageController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        [HttpPost]
        public async Task<IActionResult> Send(string id, MessageFormModel model)
        {
            try
            {
                string userId = User.GetId();

                model.UserId = userId;
                model.RefereeSquadId = id;

                await this.messageService.AddNewMessageAsync(model);

                return RedirectToAction("MatchCenter", "Referee", new { id = id });
            }
            catch (Exception)
            {
                return View("Error");
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> Remove(string id)
        {
            try
            {
                bool messageExists = await this.messageService.CheckMessageExistance(id);

                if (!messageExists)
                {
                    return View("Error404");
                }

                string refereeSquadId = await this.messageService.GetRefereeSquadIdAsync(id);
                await this.messageService.RemoveMessageAsync(id);

                return RedirectToAction("MatchCenter", "Referee", new { id = refereeSquadId });
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
