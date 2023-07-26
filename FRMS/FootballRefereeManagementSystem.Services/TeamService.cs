﻿namespace FootballRefereeManagementSystem.Services
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
                .Include(ts => ts.HomeGames)
                .Include(ts => ts.AwayGames)
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

        public async Task<TeamDetailsViewModel> GetTeamDetailsInformationByIdAsync(int id)
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

        public async Task<TeamSeasonDetailsViewModel> GetTeamSeasonsInformationByIdAsync(int id)
        {
            TeamSeasonDetailsViewModel teamSeasonDetails = await this.dbContext
                .TeamsSeasons
                .AsNoTracking()
                .Where(ts => ts.TeamId == id)
                .Select(ts => new TeamSeasonDetailsViewModel()
                {
                    Division = ts.Division.Name,
                    ManagerName = $"{ts.Manager.LastName} {ts.Manager.LastName}",
                    ManagerAge = ts.Manager.Age
                })
                .FirstAsync();

            return teamSeasonDetails;
        }
    }
}
