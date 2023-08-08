namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using Data;
    using Contracts;
    using Web.ViewModels.Player;
    using FootballRefereeManagementSystem.Data.Models;

    public class PlayerService : IPlayerService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public PlayerService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<PlayerDetailsViewModel>> GetAllSeasonUnregisteredPlayers(int seasonId)
        {
            return await this.dbContext
                .PlayersTeamsSeasons
                .Where(pts => pts.SeasonId != seasonId)
                .Select(pts => new PlayerDetailsViewModel()
                {
                    Id = pts.Player.Id,
                    FullName = $"{pts.Player.FirstName} {pts.Player.LastName}",
                    Age = pts.Player.Age,
                    Position = pts.Player.Position,
                })
                .ToArrayAsync();
        }

        public async Task<IEnumerable<PlayerDetailsViewModel>> GetTeamPlayersForSeasonAsync(int teamId, int seasonId)
        {
            IEnumerable<PlayerDetailsViewModel> players = await this.dbContext
                .PlayersTeamsSeasons
                .AsNoTracking()
                .Where(pts => pts.SeasonId == seasonId && pts.TeamId == teamId)
                .Select(pts => new PlayerDetailsViewModel()
                {
                    FullName = $"{pts.Player.FirstName} {pts.Player.LastName}",
                    Age = pts.Player.Age,
                    Position = pts.Player.Position,
                })
                .ToArrayAsync();

            return players;
        }

        public async Task RegisterPlayerForSeason(PlayerTeamSeasonFormModel model)
        {
            PlayerTeamSeason playerToRegister = new PlayerTeamSeason()
            {
                PlayerId = model.PlayerId,
                SeasonId = model.SeasonId,
                TeamId = model.TeamId,
            };

            await this.dbContext.PlayersTeamsSeasons.AddAsync(playerToRegister);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
