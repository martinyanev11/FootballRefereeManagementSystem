namespace FootballRefereeManagementSystem.Services.Contracts
{
    using FootballRefereeManagementSystem.Web.ViewModels.Message;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMessageService
    {
        Task AddNewMessageAsync(MessageFormModel model);
        Task<bool> CheckMessageExistance(string id);
        Task<IEnumerable<MessageViewModel>> GetAllMessagesAsync(string id);
        Task<string> GetRefereeSquadIdAsync(string id);
        Task RemoveMessageAsync(string id);
    }
}
