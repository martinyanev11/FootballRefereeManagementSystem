namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Data.Models;
    using Web.ViewModels.Team;
    using Data.Models.Enums;
    using Common;

    public class TeamService : ITeamService
    {
        private const int StandingsPlacementStart = 1;
        private const int PointsForWin = 3;
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
                })
                .FirstAsync();

            return teamSeasonDetails;
        }

        public async Task<bool> CheckTeamExistanceByIdAsync(int id)
        {
            return await this.dbContext.Teams
                .AnyAsync(t => t.Id == id && t.IsActive);
        }

        public async Task<IEnumerable<TeamAdminViewModel>> GetAllTeamsAsync(TeamAdminQueryModel queryModel)
        {
            IQueryable<Team> teamsQuery = this.dbContext
                .Teams
                .Where(t => t.IsActive)
                .AsNoTracking()
                .AsQueryable();

            // Filter by selected zone
            if (!string.IsNullOrWhiteSpace(queryModel.Zone))
            {
                teamsQuery = teamsQuery
                    .Where(t => t.Town.Zone.Name == queryModel.Zone);
            }

            // Filter by search string
            if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString.ToLower()}%";

                teamsQuery = teamsQuery
                    .Where(t => EF.Functions.Like(t.Name, wildCard));
            }

            IEnumerable<TeamAdminViewModel> teams = await teamsQuery
                .Select(t => new TeamAdminViewModel()
                {
                    Id = t.Id,
                    TeamName = t.Name,
                    TeamLocation = t.Town.Name,
                    SeasonsPlayed = t.TeamSeasons.Count,
                    SeasonsWon = t.TeamSeasons
                        .Where(ts => ts.Placement == 1)
                        .Count()
                })
                .ToArrayAsync();

            return teams;
        }

        public async Task AddNewTeamAsync(TeamFormModel model)
        {
            Team teamToAdd = new Team()
            {
                Name = model.Name,
                TownId = model.TownId,
            };

            await this.dbContext.Teams.AddAsync(teamToAdd);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteTeamAsync(int id)
        {
            Team teamToDelete = await GetTeamAsync(id);
            teamToDelete.IsActive = false;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditTeamAsync(int id, TeamFormModel model)
        {
            Team teamToEdit = await GetTeamAsync(id);

            teamToEdit.Name = model.Name;
            teamToEdit.TownId = model.TownId;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<TeamFormModel> GetTeamForEditByIdAsync(int id)
        {
            return await this.dbContext
                .Teams
                .Where(t => t.Id == id && t.IsActive)
                .Select(t => new TeamFormModel()
                {
                    Name = t.Name,
                    TownId = t.TownId,
                    Town = t.Town.Name
                })
                .FirstAsync();
        }

        public async Task<bool> IsTeamAlreadyAdded(int teamId, TeamFormModel model)
        {
            return await this.dbContext
                .Teams
                .Where(t => t.IsActive)
                .AnyAsync(t => 
                    t.Name == model.Name && 
                    t.Town.Name == model.Town &&
                    t.Id != teamId);
        }

        public async Task<bool> IsTeamAlreadyAdded(TeamFormModel model)
        {
            return await this.dbContext
                .Teams
                .Where(t => t.IsActive)
                .AnyAsync(t =>
                    t.Name == model.Name &&
                    t.Town.Name == model.Town);
        }

        public async Task<TeamAdminViewModel> GetTeamInfoByIdAsync(int id)
        {
            return await this.dbContext
                .Teams
                .AsNoTracking()
                .Where(t => t.Id == id && t.IsActive)
                .Select(t => new TeamAdminViewModel()
                {
                    Id = t.Id,
                    TeamName = t.Name,
                    TeamLocation = t.Town.Name,
                    SeasonsPlayed = t.TeamSeasons.Count,
                    SeasonsWon = t.TeamSeasons
                        .Where(ts => ts.Placement == 1)
                        .Count()
                })
                .FirstAsync();
        }

        public async Task<IEnumerable<TeamRegisteredListModel>> GetAllTeamsForRegistrationAsync(int seasonId)
        {
            return await this.dbContext
                .Teams
                .AsNoTracking()
                .Where(t => 
                    t.IsActive && 
                    t.TeamSeasons
                        .Any(ts => 
                            ts.TeamId == t.Id &&
                            ts.SeasonId == seasonId) == false)
                .Select(t => new TeamRegisteredListModel()
                {
                    TeamId = t.Id,
                    TeamName = t.Name,
                    TeamLocation = t.Town.Name,
                })
                .ToArrayAsync();
        }

        public IEnumerable<string> GetAllShirtColors()
        {
            IEnumerable<string> allShirtColors = Enum.GetNames<Color>();
            allShirtColors = Translator.TranslateAllColorsToBulgarian(allShirtColors);
            return allShirtColors;
        }

        public async Task RegisterNewTeamSeasonAsync(TeamSeasonRegisterModel model)
        {
            TeamSeason teamSeasonToAdd = new TeamSeason()
            {
                TeamId = model.TeamId,
                SeasonId = model.SeasonId,
                DivisionId = model.DivisionId,
                ShirtColor = Enum.Parse<Color>(Translator.TranslateColorToEnglish(model.ShirtColor)),
            };

            await this.dbContext.TeamsSeasons.AddAsync(teamSeasonToAdd);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckIfTeamIsAlreadyRegistered(int teamId, int seasonId)
        {
            return await this.dbContext
                .TeamsSeasons
                .AnyAsync(ts => ts.TeamId == teamId && ts.SeasonId == seasonId);
        }

        public async Task<IEnumerable<TeamRegisteredListModel>> GetAllRegisteredForNewSeasonTeams(int seasonId)
        {
            return await this.dbContext
                .Teams
                .Where(t => t.IsActive && t.TeamSeasons
                        .Any(ts =>
                            ts.TeamId == t.Id &&
                            ts.SeasonId == seasonId))
                .Select(t => new TeamRegisteredListModel()
                {
                    TeamId = t.Id,
                    TeamName = t.Name,
                    TeamLocation = t.Town.Name,
                    DivisionName = t.TeamSeasons
                        .Where(ts => ts.TeamId == t.Id &&
                            ts.SeasonId == seasonId)
                        .Select(ts => ts.Division.Name)
                        .First(),
                    RegisteredPlayersCount = t.TeamSeasons
                        .Where(ts => ts.TeamId == t.Id &&
                            ts.SeasonId == seasonId)
                        .Select(ts => ts.TeamSeasonPlayers.Count)
                        .First(),
                    MatchesCount = t.TeamSeasons
                        .Where(ts => ts.TeamId == t.Id &&
                                ts.SeasonId == seasonId)
                            .Select(ts => ts.HomeGames.Count + ts.AwayGames.Count)
                            .First(),
                })
                .ToArrayAsync();
        }

        public async Task<TeamSeasonEditModel> GetTeamSeasonForEdintById(int teamId, int seasonId)
        {
            return await this.dbContext
                .TeamsSeasons
                .Where(ts => ts.TeamId == teamId && ts.SeasonId == seasonId)
                .Select(ts => new TeamSeasonEditModel()
                {
                    TeamId = ts.TeamId,
                    TeamName = ts.Team.Name,
                    SeasonId = ts.SeasonId,
                    DivisionId = ts.DivisionId,
                    ShirtColor = Translator.TranslateColorToBulgarian(ts.ShirtColor.ToString()),
                })
                .FirstAsync();
        }

        public async Task EditTeamSeasonAsync(TeamSeasonEditModel model)
        {
            TeamSeason teamSeasonToEdit = await this.dbContext
                .TeamsSeasons
                .Where(ts => ts.TeamId == model.TeamId && ts.SeasonId == model.SeasonId)
                .FirstAsync();

            teamSeasonToEdit.DivisionId = model.DivisionId;
            teamSeasonToEdit.ShirtColor = Enum.Parse<Color>(Translator.TranslateColorToEnglish(model.ShirtColor));

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TeamListModel>> GetRegisteredForSeasonTeams(int seasonId)
        {
            return await this.dbContext
                .TeamsSeasons
                .Where(ts => ts.SeasonId == seasonId)
                .Select(ts => new TeamListModel()
                {
                    Id = ts.Team.Id,
                    TeamName = ts.Team.Name,
                    TeamLocation = ts.Team.Town.Name,
                })
                .ToArrayAsync();
        }

        public async Task<int> GetTeamSeasonDivision(int homeTeamId, int seasonId)
        {
            return await this.dbContext
                .TeamsSeasons
                .Where(ts => ts.TeamId == homeTeamId && ts.SeasonId == seasonId)
                .Select(ts => ts.DivisionId)
                .FirstAsync();
        }

        public async Task<int> GetHomeTownIdByTeamIdAsync(int homeTeamId)
        {
            return await this.dbContext
                .Teams
                .Where(t => t.Id == homeTeamId)
                .Select(t => t.TownId)
                .FirstAsync();
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
                team.Points = team.Wins * PointsForWin + team.Draws;
            }

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<string> GetTeamNameByIdAsync(int teamId)
        {
            return await this.dbContext
                .Teams
                .Where(t => t.Id == teamId)
                .Select(t => t.Name)
                .FirstAsync();
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

        private async Task<Team> GetTeamAsync(int id)
        {
            return await this.dbContext
                .Teams
                .Where(t => t.Id == id)
                .FirstAsync();
        }
    }
}
