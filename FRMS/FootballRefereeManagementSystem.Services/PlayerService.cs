namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using Data;
    using Contracts;
    using Web.ViewModels.Player;

    public class PlayerService : IPlayerService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public PlayerService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<IEnumerable<PlayerDetailsViewModel>> GetTeamPlayersForSeasonAsync(int id, int seasonId)
        {
            throw new NotImplementedException();
        }
    }
}
