using FootballRefereeManagementSystem.Services.Contracts;

namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Data;
    using Data.Models;
    using Web.ViewModels.User;

    public class UserService : IUserService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public UserService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task ChangeStatusAsync(string userId)
        {
            ApplicationUser user = await this.dbContext.Users
                .Include(u => u.Referee)
                .Where(u => u.Id.ToString() == userId)
                .FirstAsync();

            // Check what is the current status and change it to the opposite
            if (user!.Referee!.IsAvaliable)
            {
                user!.Referee!.IsAvaliable = false;
            }
            else
            {
                user!.Referee!.IsAvaliable = true;
            }
            
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<ApplicationUserViewModel> GetUserInformationAsync(string id)
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
