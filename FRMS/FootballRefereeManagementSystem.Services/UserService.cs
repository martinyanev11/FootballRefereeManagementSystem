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
            await UpdateCurrentlyAppointedMatchesCountForUserAsync(id);

            ApplicationUserViewModel model = await dbContext.Users
                .Where(u => u.Id.ToString() == id)
                .Select(u => new ApplicationUserViewModel()
                {
                    FullName = $"{u.Referee!.FirstName} {u.Referee.LastName}",
                    IsAvaliable = u.Referee.IsAvaliable,
                    CurrentlyAppointedMatchesCount = u.Referee.CurrentlyAppointedMatchesCount
                })
                .FirstAsync();

            return model;
        }

        public async Task LinkUserToRefereeAsync(string userId, int refereeId)
        {
            ApplicationUser user = await this.dbContext.Users
                .Where(u => u.Id.ToString() == userId)
                .FirstAsync();

            user.RefereeId = refereeId;
            await this.dbContext.SaveChangesAsync();
        }

        // --------------------------------------
        // Helper methods
        // --------------------------------------

        private async Task UpdateCurrentlyAppointedMatchesCountForUserAsync(string userId)
        {
            ApplicationUser appUser = await this.dbContext
                .Users
                .Include(u => u.Referee)
                .Where(u => u.Id.ToString() == userId)
                .FirstAsync();

            // Update count for matches which are active
            int currentMatches = 0;
            currentMatches += appUser!.Referee!.MainRefereeSquads
                .Where(rs => rs.Match.HasFinished == false)
                .Count();

            currentMatches += appUser!.Referee!.FirstAssistantRefereeSquads
                .Where(rs => rs.Match.HasFinished == false)
                .Count();

            currentMatches += appUser!.Referee!.SecondAssistantRefereeSquads
                .Where(rs => rs.Match.HasFinished == false)
                .Count();

            currentMatches += appUser!.Referee!.DelegateRefereeSquads
                .Where(rs => rs.Match.HasFinished == false)
                .Count();

            appUser.Referee.CurrentlyAppointedMatchesCount = currentMatches;
            await this.dbContext.SaveChangesAsync();
        }
    }
}
