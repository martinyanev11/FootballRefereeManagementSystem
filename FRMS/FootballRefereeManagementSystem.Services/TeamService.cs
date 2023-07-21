namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Web.ViewModels.Team;
    using FootballRefereeManagementSystem.Data.Models;

    public class TeamService : ITeamService
    {
        private const int StandingsPlacementStart = 1;
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public TeamService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private async Task UpdateTeamPlacementsForSpecifiedDivisionAndSeason(string season, string division)
        {
            IEnumerable<TeamSeason> teams = await this.dbContext
                .TeamsSeasons
                .Where(ts => ts.Season.Description == season &&
                    ts.Division.Name == division)
                .OrderByDescending(ts => ts.Points)
                .ToArrayAsync();

            int currentPlacement = StandingsPlacementStart;
            foreach (TeamSeason team in teams)
            {
                team.Placement = currentPlacement;
                currentPlacement++;
            }

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TeamStandingsViewModel>> GetFilteredBySeasonAndDivisionTeamStandingsAsync
            (string seasonFilter, string divisionFilter)
        {
            await UpdateTeamPlacementsForSpecifiedDivisionAndSeason(seasonFilter, divisionFilter);

            IEnumerable<TeamStandingsViewModel> teams = await this.dbContext
                .TeamsSeasons
                .AsNoTracking()
                .Where(ts => ts.Season.Description == seasonFilter &&
                    ts.Division.Name == divisionFilter)
                .Select(ts => new TeamStandingsViewModel()
                {
                    TeamId = ts.TeamId,
                    TeamName = ts.Team.Name,
                    TeamTownName = ts.Team.Town.Name,
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
                .OrderByDescending(t => t.TeamPoints)
                .ToArrayAsync();

            return teams;
        }
    }
}
