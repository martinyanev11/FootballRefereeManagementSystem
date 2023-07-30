namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Data.Models;
    using Web.ViewModels.Team;

    public class TeamService : ITeamService
    {
        private const int StandingsPlacementStart = 1;
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public TeamService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<TeamStandingsViewModel>> GetFilteredBySeasonAndDivisionTeamsStandingsAsync
            (string season, string division)
        {
            await UpdateAllTeamsPointsForSpecifiedDivisionAndSeasonAsync(season, division);
            await UpdateAllTeamsPlacementForSpecifiedDivisionAndSeasonAsync(season, division);

            IEnumerable<TeamStandingsViewModel> teams = await this.dbContext
                .TeamsSeasons
                .Include(ts => ts.HomeGames)
                .Include(ts => ts.AwayGames)
                .AsNoTracking()
                .Where(ts => ts.Season.Description == season &&
                    ts.Division.Name == division)
                .Select(ts => new TeamStandingsViewModel()
                {
                    TeamId = ts.TeamId,
                    TeamName = ts.Team.Name,
                    TeamTownName = ts.Team.Town.Name,
                    TeamPoints = ts.Points,
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
                .ThenByDescending(t => t.GoalDifference)
                .ToArrayAsync();

            return teams;
        }

        public async Task<TeamDetailsViewModel> GetTeamDetailsByIdAsync(int id)
        {
            TeamDetailsViewModel teamDetails = await this.dbContext
                .Teams
                .AsNoTracking()
                .Where(t => t.Id == id)
                .Select(t => new TeamDetailsViewModel()
                {
                    Id = t.Id,
                    TeamName = t.Name,
                    TeamLocation = t.Town.Name,
                    HighestPlacement = t.TeamSeasons.Max(ts => ts.Placement),
                    YearOfHighestPlacement = t.TeamSeasons
                        .Where(ts => ts.Placement == t.TeamSeasons.Max(maxTs => maxTs.Placement))
                        .Select(ts => ts.Season.Description)
                        .First()
                })
                .FirstAsync();

            return teamDetails;
        }

        public async Task<TeamSeasonDetailsViewModel> GetTeamSeasonInformationByIdAsync(int id)
        {
            TeamSeasonDetailsViewModel teamSeasonDetails = await this.dbContext
                .TeamsSeasons
                .AsNoTracking()
                .Where(ts => ts.TeamId == id)
                .Select(ts => new TeamSeasonDetailsViewModel()
                {
                    Division = ts.Division.Name,
                    ManagerName = $"{ts.Manager.FirstName} {ts.Manager.LastName}",
                    ManagerAge = ts.Manager.Age
                })
                .FirstAsync();

            return teamSeasonDetails;
        }

        public async Task<bool> CheckTeamExistanceByIdAsync(int id)
        {
            return await this.dbContext.Teams
                .AnyAsync(t => t.Id == id);
        }

        // ----------------------------------
        // Helper classes
        // ----------------------------------

        /// <summary>
        /// Asynchronously updates the points for all teams in the standings table in the specified division and during specified season.
        /// </summary>
        /// <param name="season">The description of the season to update teams' points for.</param>
        /// <param name="division">The name of the division to update teams' points for.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        private async Task UpdateAllTeamsPointsForSpecifiedDivisionAndSeasonAsync(string season, string division)
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

        /// <summary>
        /// Asynchronously updates the placement for all teams in the standings table in the specified division and season based on their points.
        /// </summary>
        /// <param name="season">The description of the season to update teams' placement for.</param>
        /// <param name="division">The name of the division to update teams' placement for.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        private async Task UpdateAllTeamsPlacementForSpecifiedDivisionAndSeasonAsync(string season, string division)
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
    }
}
