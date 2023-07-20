namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Web.ViewModels.Team;

    public class TeamService : ITeamService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public TeamService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<TeamStandingsViewModel>> GetFilteredBySeasonAndDivisionTeamStandingsAsync
            (string seasonFilter, string divisionFilter)
        {
            IEnumerable<TeamStandingsViewModel> teams = await this.dbContext
                .TeamsSeasons
                .AsNoTracking()
                .Where(ts => ts.Season.Description == seasonFilter &&
                    ts.Division.Name == divisionFilter)
                .Select(ts => new TeamStandingsViewModel()
                {
                    TeamId = ts.TeamId,
                    TeamName = ts.Team.Name,
                    TeamPoints = ts.Points,
                    TeamPlacement = ts.Placement,
                    MatchesPlayed = ts.HomeGames
                        .Where(hg => hg.FinalResult != null)
                        .Count()
                        +
                        ts.AwayGames
                        .Where(ag => ag.FinalResult != null)
                        .Count()
                })
                .ToArrayAsync();

            return teams;
        }
    }
}
