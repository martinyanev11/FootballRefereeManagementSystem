namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Web.ViewModels.Match;

    public interface IMatchService
    {
        Task<IEnumerable<MatchTableViewModel>> GetFilteredBySeasonAndDivisionMatchesAsync(string seasonFilter, string divisionFilter);
        Task<MatchDetailsViewModel> GetMatchDetailsByIdAsync(int id);
    }
}