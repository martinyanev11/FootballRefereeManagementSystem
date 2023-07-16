using FootballRefereeManagementSystem.Services.Contracts;

namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Data;
    using Web.ViewModels.User;

    public class UserService : IUserService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public UserService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ApplicationUserViewModel> GetApplicationUserInformationAsync(string id)
        {
            ApplicationUserViewModel model = await dbContext.Users
                .Where(u => u.Id.ToString() == id)
                .Select(u => new ApplicationUserViewModel()
                {
                    FullName = $"{u.Referee!.FirstName} {u.Referee.LastName}",
                    ImageUrl = u.Referee.ImageUrl,
                    Role = u.Referee.Role.ToString(),
                    IsAvaliable = u.Referee.IsAvaliable,
                    CurrentlyAppointedMatchesCount = u.Referee.CurrentlyAppointedMatchesCount
                })
                .FirstAsync();

            switch (model.Role)
            {
                case "Referee":
                    model.Role = "Главен съдия";
                    break;
                case "AssistantReferee":
                    model.Role = "Асистент съдия";
                    break;
                case "Delegate":
                    model.Role = "Делегат";
                    break;
                case "Administration":
                    model.Role = "Администрация";
                    break;
                default:
                    break;
            }

            return model;
        }
    }
}
