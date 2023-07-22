﻿namespace FootballRefereeManagementSystem.Services
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
                    FinalResult = m.FinalResult,
                })
                .OrderBy(m => m.FixtureTime)
                .ToArrayAsync();

            return matches;
        }
    }
}