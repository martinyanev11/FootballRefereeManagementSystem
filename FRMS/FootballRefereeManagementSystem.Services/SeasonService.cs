namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using FootballRefereeManagementSystem.Web.ViewModels.Season;

    public class SeasonService : ISeasonService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public SeasonService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<string>> GetAllSeasonsAsync()
        {
            IEnumerable<string> seasons = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Select(s => s.Description)
                .ToArrayAsync();

            return seasons;
        }

        public async Task<string> GetCurrentSeasonDescriptionAsync()
        {
            string currentSeason = await this.dbContext.Seasons
                .AsNoTracking()
                .OrderByDescending(s => s.End.Year)
                .Select(s => s.Description)
                .FirstAsync();

            return currentSeason;
        }

        public async Task<int> GetSeasonIdByDescriptionAsync(string seasonFilter)
        {
            return await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Description == seasonFilter)
                .Select(s => s.Id)
                .FirstAsync();
        }
    }
}
