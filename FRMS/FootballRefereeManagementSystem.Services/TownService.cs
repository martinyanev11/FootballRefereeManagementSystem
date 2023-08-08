namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    
    using Contracts;
    using Data;
    using Data.Models;
    using System.Collections.Generic;
    using Web.ViewModels.Town;

    public class TownService : ITownService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public TownService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddNewTownAsync(TownFormModel model)
        {
            Town newTown = new Town()
            {
                Name = model.Name,
                ZoneId = model.ZoneId
            };

            await this.dbContext.Towns.AddAsync(newTown);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckTownExistanceByIdAsync(int id)
        {
            return await this.dbContext.Towns
                .Where(t => t.IsActive)
                .AnyAsync(t => t.Id == id);
        }

        public async Task<bool> CheckTownExistanceByNameAsync(string townName)
        {
            return await this.dbContext.Towns
                .Where(t => t.IsActive)
                .AnyAsync(t => t.Name == townName);
        }

        public async Task DeleteTownAsync(int id)
        {
            Town townToDelete = await this.dbContext
                .Towns
                .Where(t => t.Id == id)
                .FirstAsync();

            townToDelete.IsActive = false;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditTownAsync(int id, TownFormModel model)
        {
            Town townToEdit = await this.dbContext
                .Towns
                .FirstAsync(t => t.Id == id);

            townToEdit.Name = model.Name;
            townToEdit.ZoneId = model.ZoneId;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<string>> GetAllTownNamesAsync()
        {
            return await this.dbContext
                .Towns
                .Where(t => t.IsActive)
                .Select(t => t.Name)
                .ToArrayAsync();
        }

        public async Task<IEnumerable<TownViewModel>> GetAllTownsAsync(TownQueryModel queryModel)
        {
            IQueryable<Town> townsQuery = this.dbContext
                .Towns
                .Where(t => t.IsActive)
                .AsNoTracking()
                .AsQueryable();

            // Filter by selected zone
            if (!string.IsNullOrWhiteSpace(queryModel.Zone))
            {
                townsQuery = townsQuery
                    .Where(t => t.Zone.Name == queryModel.Zone);
            }

            // Filter by search string
            if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString.ToLower()}%";

                townsQuery = townsQuery
                    .Where(t => EF.Functions.Like(t.Name, wildCard));
            }

            IEnumerable<TownViewModel> towns = await townsQuery
                .Select(t => new TownViewModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                    ZoneName = t.Zone.Name,
                    TeamsCount = t.Teams.Count(),
                    MatchesCount = t.Matches.Count(),
                })
                .ToArrayAsync();

            return towns;
        }

        public async Task<TownViewModel> GetTownByIdAsync(int id)
        {
            return await this.dbContext
                .Towns
                .Where(t => t.Id == id && t.IsActive)
                .Select(t => new TownViewModel()
                {
                    Id = id,
                    Name = t.Name,
                    ZoneName = t.Zone.Name,
                    TeamsCount = t.Teams.Count(),
                    MatchesCount = t.Matches.Count(),
                })
                .FirstAsync();
        }

        public async Task<TownFormModel> GetTownForEditByIdAsync(int id)
        {
            return await this.dbContext
                .Towns
                .Where(t => t.Id == id && t.IsActive)
                .Select(t => new TownFormModel()
                {
                    Name = t.Name,
                    Zone = t.Zone.Name,
                })
                .FirstAsync();
        }

        public async Task<int> GetTownIdByNameAsync(string townName)
        {
            return await this.dbContext.Towns
                .Where(t => t.Name == townName && t.IsActive)
                .Select(t => t.Id)
                .FirstAsync();
        }

        public async Task<IEnumerable<TownListModel>> GetTownsForListAsync()
        {
            return await this.dbContext
                .Towns
                .Where(t => t.IsActive)
                .Select(t => new TownListModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                })
                .ToArrayAsync();
        }
    }
}