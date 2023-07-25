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
                    Round = m.SeasonRound
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
                    HomeTeamTownName = m.HomeTeam.Team.Town.Name,
                    FixtureTime = m.FixtureTime,
                    HomeTeamId = m.HomeTeamId,
                    HomeTeamName = m.HomeTeam.Team.Name,
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
                    SeasonRound = m.SeasonRound,
                })
                .FirstAsync();

            return match;
        }
    }
}
