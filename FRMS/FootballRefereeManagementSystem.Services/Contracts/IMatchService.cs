namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Match;

    public interface IMatchService
    {
        /// <summary>
        /// Adds a new match to the database.
        /// </summary>
        /// <param name="model">The model containing match details.</param>
        Task AddNewMatchAsync(MatchFormModel model);

        /// <summary>
        /// Checks if a match with the specified ID exists in the database.
        /// </summary>
        /// <param name="matchId">The ID of the match to check.</param>
        /// <returns><see langword="true"/> if a match with the specified ID exists, <see langword="false"/> otherwise.</returns>
        Task<bool> CheckMatchExistanceByIdAsync(int matchId);

        /// <summary>
        /// Edits a match with the specified ID using the provided view model.
        /// </summary>
        /// <param name="matchId">The ID of the match to edit.</param>
        /// <param name="model">The view model containing the updated match information.</param>
        Task EditMatchAsync(int matchId, MatchEditViewModel model);

        /// <summary>
        /// Finishes a match with the provided result and updates team statistics accordingly.
        /// </summary>
        /// <param name="model">The model containing match result information.</param>
        Task FinishMatchAsync(MatchFinishModel model);

        /// <summary>
        /// Retrieves summary information for all matches in a given season.
        /// </summary>
        /// <param name="seasonId">The ID of the season.</param>
        /// <returns>A collection of match summary view models.</returns>
        Task<IEnumerable<MatchRefereeSquadSummaryViewModel>> GetAllMatchesForSeasonAsync(int seasonId);

        /// <summary>
        /// Retrieves the ID of the division associated with a specific match.
        /// </summary>
        /// <param name="id">The ID of the match.</param>
        /// <returns>The ID of the division.</returns>
        Task<int> GetDivisionIdByMatchIdAsync(int matchId);

        /// <summary>
        /// Asynchronously retrieves matches data based on the provided season and division.
        /// </summary>
        /// <param name="seasonDescription">The season description to filter the matches.</param>
        /// <param name="divisionName">The division name to filter the matches.</param>
        /// <returns>A collection of models containing details of the filtered matches.</returns>
        Task<IEnumerable<MatchTableViewModel>> GetFilteredBySeasonAndDivisionMatchesAsync
            (string seasonDescription, string divisionName);

        /// <summary>
        /// Asynchronously retrieves the detailed information of a match by its ID.
        /// </summary>
        /// <param name="id">The ID of the match to retrieve details for.</param>
        /// <returns>A model containing detailed information about the match.</returns>
        Task<MatchDetailsViewModel> GetMatchDetailsByIdAsync(int matchId);

        /// <summary>
        /// Retrieves match details for editing by its ID.
        /// </summary>
        /// <param name="matchId">The ID of the match.</param>
        /// <returns>A view model containing match details for editing.</returns>
        Task<MatchEditViewModel> GetMatchForEditByIdAsync(int matchId);

        /// <summary>
        /// Asynchronously retrieves a view model for a match associated with the provided referee squad ID.
        /// </summary>
        /// <param name="refereeSquadId">The ID of the referee squad.</param>
        /// <returns>A model containing details of the match.</returns>
        Task<MatchRefereeSquadSummaryViewModel> GetMatchForRefereeSquadByIdAsync(string refereeSquadId);

        /// <summary>
        /// Asynchronously retrieves the match history of a team during a specific season.
        /// </summary>
        /// <param name="teamId">The ID of the team to retrieve the match history for.</param>
        /// <param name="seasonId">The ID of the season to filter the matches.</param>
        /// <returns>A collection of models containing details of the matches.</returns>
        Task<IEnumerable<DetailsHistoryViewModel>> GetMatchHistoryForSeasonByTeamIdAsync(int teamId, int seasonId);

        /// <summary>
        /// Retrieves the ID of a match based on the ID of the referee squad associated with it.
        /// </summary>
        /// <param name="refereeSquadId">The ID of the referee squad.</param>
        /// <returns>The ID of the match associated with the referee squad.</returns>
        Task<int> GetMatchIdByRefereeSquadIdAsync(string refereeSquadId);

        /// <summary>
        /// Retrieves a collection of match summaries for matches scheduled within a week from the current date.
        /// </summary>
        /// <param name="queryModel">The query parameters for filtering and searching matches.</param>
        /// <returns>A collection of match summaries.</returns>
        Task<IEnumerable<MatchRefereeSquadSummaryViewModel>> GetWeeklyMatchesAsync(MatchQueryModel model);

        /// <summary>
        /// Links a match to a referee squad by updating the referee squad ID of the specified match.
        /// </summary>
        /// <param name="matchId">The ID of the match to link.</param>
        /// <param name="newRefSquadId">The ID of the new referee squad to link the match to.</param>
        Task LinkMatchToRefereeSquadAsync(int matchId, Guid newRefSquadId);
    }
}