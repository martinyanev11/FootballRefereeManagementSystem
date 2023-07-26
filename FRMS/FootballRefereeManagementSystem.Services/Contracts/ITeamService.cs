namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Web.ViewModels.Team;

    public interface ITeamService
    {
        Task<IEnumerable<TeamStandingsViewModel>> GetFilteredBySeasonAndDivisionTeamStandingsAsync(string seasonFilter, string divisionFilter);
        Task<TeamDetailsViewModel> GetTeamDetailsInformationByIdAsync(int id);
        Task<TeamSeasonDetailsViewModel> GetTeamSeasonsInformationByIdAsync(int id);
    }
}
