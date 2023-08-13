namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using Data;
    using Data.Models;
    using Contracts;
    using Web.ViewModels.Player;

    public class PlayerService : IPlayerService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public PlayerService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddNewPlayerAsync(PlayerFormModel model)
        {
            Player playerToAdd = new Player()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                Position = model.Position,
            };

            await this.dbContext.Players.AddAsync(playerToAdd);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckPlayerExistanceByIdAsync(int id)
        {
            return await this.dbContext
                .Players
                .Where(p => p.IsActive)
                .AnyAsync(p => p.Id == id);
        }

        public async Task DeletePlayerAsync(int id)
        {
            Player playerToDelete = await this.dbContext
                .Players
                .Where(p => p.Id == id)
                .FirstAsync();

            playerToDelete.IsActive = false;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditPlayerAsync(int id, PlayerFormModel model)
        {
            Player playerToEdit = await this.dbContext
                .Players
                .Where(p => p.Id == id)
                .FirstAsync();

            playerToEdit.FirstName = model.FirstName;
            playerToEdit.LastName = model.LastName;
            playerToEdit.Age = model.Age;
            playerToEdit.Position = model.Position;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<PlayerDetailsViewModel>> GetAllPlayersAsync
            (PlayerQueryModel queryModel)
        {
            IQueryable<Player> playersQuery = this.dbContext
                .Players
                .Where(p => p.IsActive)
                .AsNoTracking()
                .AsQueryable();

            // Filter by search string
            if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString.ToLower()}%";

                playersQuery = playersQuery
                    .Where(t => 
                        EF.Functions.Like(t.FirstName, wildCard) ||
                        EF.Functions.Like(t.LastName, wildCard));
            }

            IEnumerable<PlayerDetailsViewModel> players = await playersQuery
                .Select(p => new PlayerDetailsViewModel()
                {
                    Id = p.Id,
                    FullName = $"{p.FirstName} {p.LastName}",
                    Age = p.Age,
                    Position = p.Position,
                })
                .ToArrayAsync();

            return players;
        }

        public async Task<IEnumerable<PlayerDetailsViewModel>> GetAllSeasonUnregisteredPlayers
            (int seasonId)
        {
            return await this.dbContext
                .PlayersTeamsSeasons
                .Where(pts => pts.SeasonId != seasonId && pts.Player.IsActive)
                .Select(pts => new PlayerDetailsViewModel()
                {
                    Id = pts.Player.Id,
                    FullName = $"{pts.Player.FirstName} {pts.Player.LastName}",
                    Age = pts.Player.Age,
                    Position = pts.Player.Position,
                })
                .ToArrayAsync();
        }

        public async Task<PlayerDetailsViewModel> GetPlayerByIdAsync(int id)
        {
            return await this.dbContext
                .Players
                .Where(p => p.Id == id)
                .Select(p => new PlayerDetailsViewModel()
                {
                    Id = p.Id,
                    FullName = $"{p.FirstName} {p.LastName}",
                    Age = p.Age,
                    Position = p.Position,
                })
                .FirstAsync();
        }

        public async Task<PlayerFormModel> GetPlayerForEditByIdAsync(int id)
        {
            return await this.dbContext
                .Players
                .Where(p => p.Id == id)
                .Select (p => new PlayerFormModel()
                {
                    Age = p.Age,
                    Position = p.Position,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                })
                .FirstAsync();
        }

        public async Task<IEnumerable<PlayerDetailsViewModel>> GetTeamPlayersForSeasonAsync
            (int teamId, int seasonId)
        {
            IEnumerable<PlayerDetailsViewModel> players = await this.dbContext
                .PlayersTeamsSeasons
                .AsNoTracking()
                .Where(pts => pts.SeasonId == seasonId && pts.TeamId == teamId && pts.Player.IsActive)
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