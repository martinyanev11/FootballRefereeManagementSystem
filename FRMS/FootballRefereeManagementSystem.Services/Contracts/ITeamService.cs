namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Web.ViewModels.Team;

    public interface ITeamService
    {
        Task<IEnumerable<TeamStandingsViewModel>> GetFilteredBySeasonAndDivisionTeamStandingsAsync(string seasonFilter, string divisionFilter);
    }
}
