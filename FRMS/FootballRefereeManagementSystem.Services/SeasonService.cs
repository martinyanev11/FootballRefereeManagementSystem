﻿namespace FootballRefereeManagementSystem.Services
{
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Data.Models;
    using Data.Models.Enums;
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

        public async Task<SeasonViewModel> GetCurrentSeasonInformationAsync()
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
                await GetSeasonTotalFinishedMatchesCount();

            seasonStats.TotalMatchesCount =
                await GetTotalMatchesCountForSeason();

            return seasonStats;
        }

        public async Task<bool> CheckForSeasonInPreparationStatusAsync()
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
                Description = $"{model.StartDate.ToString("yyyy")}/{model.EndDate.ToString("yy")}",
                Status = SeasonStatus.InPreparation,
            };

            await this.dbContext.Seasons.AddAsync(seasonToAdd);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<SeasonFormModel> GetSeasonForEditAsync(string status)
        {
            SeasonFormModel season = await this.dbContext
                .Seasons
                .Where(s => s.Status == Enum.Parse<SeasonStatus>(status))
                .Select(s => new SeasonFormModel()
                {
                    StartDate = s.Start,
                    EndDate = s.End,
                    Status = s.Status.ToString()
                })
                .FirstAsync();

            return season;
        }

        public async Task EditSeasonAsync(SeasonFormModel model)
        {
            Season seasonToEdit = await this.dbContext
                .Seasons
                .Where(s => s.Status == Enum.Parse<SeasonStatus>(model.Status))
                .FirstAsync();

            seasonToEdit.Start = model.StartDate;
            seasonToEdit.End = model.EndDate;
            seasonToEdit.Description = $"{model.StartDate.ToString("yyyy")}/{model.EndDate.ToString("yy")}";

            await this.dbContext.SaveChangesAsync();
        }

        public bool StatusValidation(string status)
        {
            bool isParsed = Enum.TryParse<SeasonStatus>(status, out SeasonStatus parsedResult);

            return isParsed;
        }

        public async Task<SeasonPreparationModel> GetSeasonInPreparationAsync()
        {
            SeasonPreparationModel seasonInPreparation = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.InPreparation)
                .Select(s => new SeasonPreparationModel()
                {
                    StartDate = s.Start,
                    EndDate = s.End,
                    Description = s.Description,
                    Status = s.Status.ToString()
                })
                .FirstAsync();

            return seasonInPreparation;
        }

        public async Task<int> GetPreparationSeasonIdAsync()
        {
            return await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.InPreparation)
                .Select(s => s.Id)
                .FirstAsync();
        }

        public async Task BeginNewSeasonAsync()
        {
            Season currentSeason = await this.dbContext
                .Seasons
                .Where(s => s.Status == SeasonStatus.Current)
                .FirstAsync();

            Season inPreparationSeason = await this.dbContext
                .Seasons
                .Where(s => s.Status == SeasonStatus.InPreparation)
                .FirstAsync();

            currentSeason.Status = SeasonStatus.Ended;
            inPreparationSeason.Status = SeasonStatus.Current;

            await this.dbContext.SaveChangesAsync();
        }

        // ----------------------------------
        // private methods
        // ----------------------------------

        private async Task<int> GetTotalMatchesCountForSeason()
        {
            int[] totalMatchesCountArray = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.Current)
                .Select(s => s.SeasonTeams
                    .Select(ts => ts.HomeGames
                        .Count())
                    .ToArray())
                .FirstAsync();


            int gamesSum = totalMatchesCountArray.Sum();

            return gamesSum;
        }

        private async Task<int> GetSeasonTotalFinishedMatchesCount()
        {
            int[] matchesPlayedArray = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.Current)
                .Select(s => s.SeasonTeams
                    .Select(ts => ts.HomeGames
                        .Where(m => m.HasFinished == true)
                        .Count())
                    .ToArray())
                .FirstAsync();

            int matchesCount = matchesPlayedArray.Sum();

            return matchesCount;
        }

        private async Task<int> GetTotalRegisteredPlayersCountForCurrentSeason()
        {
            int[] playersCountFromEachTeamArray = await this.dbContext
                .Seasons
                .AsNoTracking()
                .Where(s => s.Status == SeasonStatus.Current)
                .Select(s => s.SeasonTeams
                    .Select(ts => ts.TeamSeasonPlayers.Count)
                    .ToArray())
                .FirstAsync();

            int totalPlayersCount = playersCountFromEachTeamArray.Sum();

            return totalPlayersCount;
        }
    }
}