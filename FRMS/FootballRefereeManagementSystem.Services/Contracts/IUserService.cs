namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Web.ViewModels.User;

    public interface IUserService
    {
        Task<ApplicationUserViewModel> GetApplicationUserInformationAsync(string id);
    }
}