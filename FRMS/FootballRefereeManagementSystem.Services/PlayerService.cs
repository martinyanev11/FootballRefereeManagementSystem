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

        public async Task<IEnumerable<PlayerDetailsViewModel>> GetTeamPlayersForSeasonAsync(int id, int seasonId)
        {
            IEnumerable<PlayerDetailsViewModel> players = await this.dbContext
                .PlayersTeamsSeasons
                .AsNoTracking()
                .Where(pts => pts.SeasonId == seasonId && pts.TeamId == id)
                .Select(pts => new PlayerDetailsViewModel()
                {
                    FullName = $"{pts.Player.FirstName} {pts.Player.LastName}",
                    Age = pts.Player.Age,
                    Position = pts.Player.Position,
                })
                .ToArrayAsync();

            return players;
        }
    }
}
