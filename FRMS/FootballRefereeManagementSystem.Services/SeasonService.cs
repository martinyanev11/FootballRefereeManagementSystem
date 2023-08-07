namespace FootballRefereeManagementSystem.Services
{
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Data.Models.Enums;
    using Web.ViewModels.Season;
    using FootballRefereeManagementSystem.Data.Models;

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
                .Where(s => s.Status == SeasonStatus.Current)
                .Select(s => new SeasonViewModel
                {
                    Description = s.Description,
                    StartDate = s.Start,
                    EndDate = s.End
                })
                .FirstAsync();
        }

        public async Task<string> GetCurrentSeasonDescriptionAsync()
        {
            string currentSeason = await this.dbContext.Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.Current)
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

        public async Task<SeasonStatisticsViewModel> GetCurrentSeasonStatisticsAsync()
        {
            SeasonStatisticsViewModel seasonStats = await this.dbContext
                .Seasons
                .Include(s => s.SeasonTeams)
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.Current)
                .Select(s => new SeasonStatisticsViewModel()
                {
                    SeasonDescription = s.Description,
                    SeasonStart = s.Start,
                    SeasonEnd = s.End,
                    RegisteredTeamsCount = s.SeasonTeams
                        .Count()
                })
                .FirstAsync();

            seasonStats.RegisteredPlayersCount =
                await GetTotalRegisteredPlayersCountForCurrentSeason();

            seasonStats.MatchesPlayed =
                await GetSeasonTotalMatchesPlayedCount();

            seasonStats.TotalMatchesCount =
                await GetTotalMatchesCountForSeason();

            return seasonStats;
        }

        public async Task<bool> CheckForSeasonInPreparation()
        {
            return await this.dbContext
                .Seasons
                .AnyAsync(s => s.Status == SeasonStatus.InPreparation);
        }

        public async Task AddNewSeasonAsync(SeasonFormModel model)
        {
            Season seasonToAdd = new Season()
            {
                Start = model.StartDate,
                End = model.EndDate,
                Description = $"{model.StartDate.ToString("yyyy")}/{model.EndDate.ToString("yy")}"
            };

            await this.dbContext.Seasons.AddAsync(seasonToAdd);
            await this.dbContext.SaveChangesAsync();
        }

        // ----------------------------------
        // private methods
        private async Task<int> GetTotalMatchesCountForSeason()
        {
            int[][] homeMatchesCount = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.Current)
                .Select(s => s.SeasonTeams
                    .Select(ts => ts.HomeGames
                        .Count())
                    .ToArray())
                .ToArrayAsync();

            int[][] awayMatchesCount = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.Current)
                .Select(s => s.SeasonTeams
                    .Select(ts => ts.AwayGames
                        .Count())
                    .ToArray())
                .ToArrayAsync();

            int homeGamesSum = CaculateJaggedArraySum(homeMatchesCount);
            int awayGamesSum = CaculateJaggedArraySum(awayMatchesCount);

            return homeGamesSum + awayGamesSum;
        }

        private async Task<int> GetSeasonTotalMatchesPlayedCount()
        {
            int[][] homeMatchesPlayedArray = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.Current)
                .Select(s => s.SeasonTeams
                    .Select(ts => ts.HomeGames
                        .Where(m => m.HasFinished == true)
                        .Count())
                    .ToArray())
                .ToArrayAsync();

            int[][] awayMatchesPlayedArray = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.Current)
                .Select(s => s.SeasonTeams
                    .Select(ts => ts.AwayGames
                        .Where(m => m.HasFinished == true)
                        .Count())
                    .ToArray())
                .ToArrayAsync();

            int homeGamesSum = CaculateJaggedArraySum(homeMatchesPlayedArray);
            int awayGamesSum = CaculateJaggedArraySum(awayMatchesPlayedArray);

            return homeGamesSum + awayGamesSum;
        }

        private async Task<int> GetTotalRegisteredPlayersCountForCurrentSeason()
        {
            // Getting the number of players per registered team for the season
            // Result is jagged array where we have different TeamSeasons (team playing in a season) for rows
            // and their respective players count for colums
            int[][] teamsPlayersCountArray = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.Current)
                .Select(s => s.SeasonTeams
                    .Select(ts => ts.TeamSeasonPlayers.Count)
                    .ToArray())
                .ToArrayAsync();

            int totalPlayersCount = CaculateJaggedArraySum(teamsPlayersCountArray);

            return totalPlayersCount;
        }

        private static int CaculateJaggedArraySum(int[][] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
            }

            return sum;
        }
    }
}
