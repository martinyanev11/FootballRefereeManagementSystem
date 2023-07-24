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

        private async Task UpdateTeamPointsForSpecifiedDivisionAndSeasonAsync(string season, string division)
        {
            IEnumerable<TeamSeason> teams = await this.dbContext
                .TeamsSeasons
                .Where(ts => ts.Season.Description == season &&
                    ts.Division.Name == division)
                .ToArrayAsync();

            foreach (TeamSeason team in teams)
            {
                team.Points = team.Wins * 3 + team.Draws;
            }

            await this.dbContext.SaveChangesAsync();
        }

        private async Task UpdateTeamPlacementsForSpecifiedDivisionAndSeasonAsync(string season, string division)
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
            await UpdateTeamPointsForSpecifiedDivisionAndSeasonAsync(seasonFilter, divisionFilter);
            await UpdateTeamPlacementsForSpecifiedDivisionAndSeasonAsync(seasonFilter, divisionFilter);

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
                    TeamPoints = ts.Points, // Might change logic to make this auto-calculated property later!
                    TeamPlacement = ts.Placement,
                    MatchesPlayed = ts.HomeGames
                        .Where(m => m.HasFinished == true)
                        .Count()
                        +
                        ts.AwayGames
                        .Where(m => m.HasFinished == true)
                        .Count(),
                    Wins = ts.Wins,
                    Draws = ts.Draws,
                    Losses = ts.Losses,
                    GoalsFor = ts.GoalsFor,
                    GoalsAgainst = ts.GoalsAgainst,
                    GoalDifference = ts.GoalsFor - ts.GoalsAgainst
                })
                .OrderByDescending(t => t.TeamPoints)
                .ToArrayAsync();

            return teams;
        }
    }
}
