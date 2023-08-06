namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Web.ViewModels.Season;

    public class SeasonService : ISeasonService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public SeasonService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<string>> GetAllSeasonDescriptionsAsync()
        {
            IEnumerable<string> seasons = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Select(s => s.Description)
                .ToArrayAsync();

            return seasons;
        }

        public async Task<SeasonViewModel> GetCurrentSeasonInformation()
        {
            return await this.dbContext
                .Seasons
                .AsNoTracking()
                .OrderByDescending(s => s.End.Year)
                .Select(s => new SeasonViewModel
                {
                    Description = s.Description,
                    StartDate = s.Start,
                    EndDate = s.End
                })
                .FirstAsync();
        }

        public async Task<string> GetLatestSeasonDescriptionAsync()
        {
            string currentSeason = await this.dbContext.Seasons
                .AsNoTracking()
                .OrderByDescending(s => s.End.Year)
                .Select(s => s.Description)
                .FirstAsync();

            return currentSeason;
        }

        public async Task<int> GetSeasonIdByDescriptionAsync(string seasonDescription)
        {
            return await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Description == seasonDescription)
                .Select(s => s.Id)
                .FirstAsync();
        }

        public async Task<SeasonStatisticsViewModel> GetSeasonStatisticsAsync()
        {
            return await this.dbContext
                .Seasons
                .AsNoTracking()
                .OrderByDescending(s => s.End.Year)
                .Select(s => new SeasonStatisticsViewModel()
                {
                    SeasonDescription = s.Description,
                    SeasonStart = s.Start,
                    SeasonEnd = s.End,
                    RegisteredTeamsCount = s.SeasonTeams.Count(),
                    // TODO: Finish this query...
                    //RegisteredPlayersCount = ,
                    //MatchesPlayed = ,
                    //MatchesLeft = 
                })
                .FirstAsync();
        }
    }
}
