namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Web.ViewModels.Match;

    public class MatchService : IMatchService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public MatchService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<MatchTableViewModel>> GetFilteredBySeasonAndDivisionMatchesAsync
            (string seasonFilter, string divisionFilter)
        {
            IEnumerable<MatchTableViewModel> matches =  await this.dbContext
                .Matches
                .AsNoTracking()
                .Where(m => m.HomeTeam.Season.Description == seasonFilter
                    && m.Division.Name == divisionFilter)
                .Select(m => new MatchTableViewModel()
                {
                    MatchId = m.Id,
                    HomeTeam = m.HomeTeam.Team.Name,
                    HomeTeamTownName = m.HomeTeam.Team.Town.Name,
                    AwayTeam = m.AwayTeam.Team.Name,
                    AwayTeamTownName = m.AwayTeam.Team.Town.Name,
                    FixtureTime = m.FixtureTime,
                    FinalResult = m.HasFinished ? $"{m.HomeTeamScore} : {m.AwayTeamScore}" : "-",
                })
                .OrderBy(m => m.FixtureTime)
                .ToArrayAsync();

            return matches;
        }

        public async Task<MatchDetailsViewModel> GetMatchDetailsByIdAsync(int id)
        {
            MatchDetailsViewModel match = await this.dbContext
                .Matches
                .AsNoTracking()
                .Where(m => m.Id == id)
                .Select(m => new MatchDetailsViewModel()
                {
                    Division = m.Division.Name,
                    FixtureTime = m.FixtureTime,
                    MatchLocation = m.Town.Name,
                    HomeTeamId = m.HomeTeamId,
                    HomeTeamName = m.HomeTeam.Team.Name,
                    HomeTeamTownName = m.HomeTeam.Team.Town.Name,
                    HomeTeamScore = m.HomeTeamScore,
                    HomeTeamShirtColor = m.HomeTeam.ShirtColor.ToString(),
                    HomeTeamCurrentPosition = m.HomeTeam.Placement,
                    AwayTeamId = m.AwayTeamId,
                    AwayTeamName = m.AwayTeam.Team.Name,
                    AwayTeamTownName = m.AwayTeam.Team.Town.Name,
                    AwayTeamScore = m.AwayTeamScore,
                    AwayTeamShirtColor = m.AwayTeam.ShirtColor.ToString(),
                    AwayTeamCurrentPosition = m.AwayTeam.Placement,
                    HasFinished = m.HasFinished,
                })
                .FirstAsync();

            match.MatchHistoryBetweenThem = 
                await this.GetOtherMatchesBetweenTwoTeams(id, match.HomeTeamId, match.AwayTeamId);

            return match;
        }

        public async Task<MatchRefereeSquadSummaryViewModel> GetMatchForRefereeSquadByIdAsync(string refereeSquadId)
        {
            MatchRefereeSquadSummaryViewModel matchSummary = await this.dbContext
                .Matches
                .AsNoTracking()
                .Where(m => m.RefereeSquadId == new Guid(refereeSquadId))
                .Select(m => new MatchRefereeSquadSummaryViewModel()
                {
                    MatchId = m.Id,
                    HomeTeamName = m.HomeTeam.Team.Name,
                    HomeTeamTown = m.HomeTeam.Team.Town.Name,
                    AwayTeamName = m.AwayTeam.Team.Name,
                    AwayTeamTown = m.AwayTeam.Team.Town.Name,
                    FixtureTime = m.FixtureTime,
                })
                .FirstAsync();

            return matchSummary;
        }

        public async Task<IEnumerable<DetailsHistoryViewModel>> GetMatchHistoryForSeasonByTeamIdAsync(int id, int seasonId)
        {
            IEnumerable<DetailsHistoryViewModel> matches = await this.dbContext
                .Matches
                .AsNoTracking()
                .Where(m => (m.HomeTeamId == id || m.AwayTeamId == id) &&
                    m.HasFinished == true && m.SeasonId == seasonId)
                .Select(m => new DetailsHistoryViewModel()
                {
                    HomeTeamName = m.HomeTeam.Team.Name,
                    HomeTeamGoals = m.HomeTeamScore,
                    AwayTeamName = m.AwayTeam.Team.Name,
                    AwayTeamGoals = m.AwayTeamScore,
                    FixtureTime = m.FixtureTime
                })
                .ToArrayAsync();

            return matches;
        }

        // --------------------------------------------
        // private methods
        // ---------------------------------------------

        /// <summary>
        /// Asynchronously retrieves details of other finished matches between two teams.
        /// </summary>
        /// <param name="matchId">The ID of the current match to exclude from the results.</param>
        /// <param name="homeTeamId">The ID of the home team.</param>
        /// <param name="awayTeamId">The ID of the away team.</param>
        /// <returns>A collection of models containing details of the other matches.</returns>
        private async Task<IEnumerable<DetailsHistoryViewModel>> GetOtherMatchesBetweenTwoTeams(int matchId, int homeTeamId, int awayTeamId)
        {
            return await this.dbContext
                .Matches
                .AsNoTracking()
                .Where(m =>
                    m.Id != matchId &&
                    m.HasFinished == true &&
                    ((m.HomeTeamId == homeTeamId && m.AwayTeamId == awayTeamId) ||
                    (m.HomeTeamId == awayTeamId && m.AwayTeamId == homeTeamId)))
                .Select(m => new DetailsHistoryViewModel()
                {
                    HomeTeamName = m.HomeTeam.Team.Name,
                    HomeTeamGoals = m.HomeTeamScore,
                    AwayTeamName = m.AwayTeam.Team.Name,
                    AwayTeamGoals = m.AwayTeamScore,
                    FixtureTime = m.FixtureTime,
                })
                .OrderBy(model => model.FixtureTime)
                .ToArrayAsync();
        }
    }
}
