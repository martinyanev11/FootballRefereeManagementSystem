namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Match;

    public interface IMatchService
    {
        Task AddNewMatchAsync(MatchFormModel model);
        Task<bool> CheckMatchExistanceById(int id);
        Task EditMatchAsync(int id, MatchEditViewModel model);
        Task<IEnumerable<MatchRefereeSquadSummaryViewModel>> GetAllMatchesForSeasonAsync(int seasonId);
        Task<int> GetDivisionIdByMatchIdAsync(int id);

        /// <summary>
        /// Asynchronously retrieves matches data based on the provided season and division.
        /// </summary>
        /// <param name="season">The season description to filter the matches.</param>
        /// <param name="division">The division name to filter the matches.</param>
        /// <returns>A collection of models containing details of the filtered matches.</returns>
        Task<IEnumerable<MatchTableViewModel>> GetFilteredBySeasonAndDivisionMatchesAsync(string season, string division);

        /// <summary>
        /// Asynchronously retrieves the detailed information of a match by its ID.
        /// </summary>
        /// <param name="id">The ID of the match to retrieve details for.</param>
        /// <returns>A model containing detailed information about the match.</returns>
        Task<MatchDetailsViewModel> GetMatchDetailsByIdAsync(int id);
        Task<MatchEditViewModel> GetMatchForEditByIdAsync(int id);

        /// <summary>
        /// Asynchronously retrieves a view model for a match associated with the provided referee squad ID.
        /// </summary>
        /// <param name="refereeSquadId">The ID of the referee squad.</param>
        /// <returns>A model containing details of the match.</returns>
        Task<MatchRefereeSquadSummaryViewModel> GetMatchForRefereeSquadByIdAsync(string refereeSquadId);

        /// <summary>
        /// Asynchronously retrieves the match history of a team during a specific season.
        /// </summary>
        /// <param name="id">The ID of the team to retrieve the match history for.</param>
        /// <param name="seasonId">The ID of the season to filter the matches.</param>
        /// <returns>A collection of models containing details of the matches.</returns>
        Task<IEnumerable<DetailsHistoryViewModel>> GetMatchHistoryForSeasonByTeamIdAsync(int id, int seasonId);
        Task<int> GetMatchIdByRefereeSquadIdAsync(string id);
        Task<IEnumerable<MatchRefereeSquadSummaryViewModel>> GetWeeklyMatchesAsync(MatchQueryModel model);
        Task LinkMatchToRefereeSquadAsync(int matchId, Guid newRefSquadId);
    }
}