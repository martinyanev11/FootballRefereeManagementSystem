using FootballRefereeManagementSystem.Services.Contracts;

namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;

    using Data;
    using Data.Models;
    using Web.ViewModels.User;
    using static FootballRefereeManagementSystem.Common.GeneralApplicationConstants;

    public class UserService : IUserService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public UserService(FootballRefereeManagementSystemDbContext dbContext,
            UserManager<ApplicationUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }

        public async Task AddUserToAdminRoleAsync(string userId)
        {
            ApplicationUser user = await userManager.FindByIdAsync(userId);

            await this.userManager.AddToRoleAsync(user, AdminRoleName);
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

        public async Task DeleteUserInformationAsync(ApplicationUser user)
        {
            await this.userManager.SetEmailAsync(user, null);
            await this.userManager.SetUserNameAsync(user, Guid.NewGuid().ToString());
            await this.userManager.UpdateNormalizedUserNameAsync(user);
            await this.userManager.RemovePasswordAsync(user);
            await this.userManager.SetPhoneNumberAsync(user, null);
        }

        public async Task<ApplicationUserViewModel> GetUserInformationByIdAsync(string id)
        {
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

        public async Task<bool> IsUserAdminAsync(string userId)
        {
            ApplicationUser user = await userManager.FindByIdAsync(userId);

            return await this.userManager.IsInRoleAsync(user, AdminRoleName);
        }

        public async Task LinkUserToRefereeAsync(string userId, int refereeId)
        {
            ApplicationUser user = await this.dbContext.Users
                .Where(u => u.Id.ToString() == userId)
                .FirstAsync();

            user.RefereeId = refereeId;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task RemoveUserFromAdminRoleAsync(string userId)
        {
            ApplicationUser user = await userManager.FindByIdAsync(userId);

            await this.userManager.RemoveFromRoleAsync(user, AdminRoleName);
        }
    }
}