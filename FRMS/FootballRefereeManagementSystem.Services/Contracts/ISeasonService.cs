namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Season;
    using Data.Models.Enums;

    public interface ISeasonService
    {
        /// <summary>
        /// Asynchronously retrieves all seasons from the database.
        /// </summary>
        /// <returns>A collection containing the descriptions of all seasons.</returns>
        Task<IEnumerable<string>> GetAllSeasonDescriptionsAsync();

        /// <summary>
        /// Retrieves information about the current season.
        /// </summary>
        /// <returns>A <see cref="SeasonViewModel"/> containing the current season information.</returns>
        Task<SeasonViewModel> GetCurrentSeasonInformationAsync();

        /// <summary>
        /// Asynchronously retrieves the description of the latest (current) season from the database.
        /// </summary>
        /// <returns>A string representing the description of the latest season.</returns>
        Task<string> GetCurrentSeasonDescriptionAsync();

        /// <summary>
        /// Asynchronously retrieves the season ID based on the provided season description.
        /// </summary>
        /// <param name="seasonDescription">The season description to search for.</param>
        /// <returns>The season ID as an integer.</returns>
        Task<int> GetSeasonIdByDescriptionAsync(string seasonDescription);

        /// <summary>
        /// Retrieves statistics for the current season.
        /// </summary>
        /// <returns>A <see cref="SeasonStatisticsViewModel"/> containing the statistics for the current season.</returns>
        Task<SeasonStatisticsViewModel> GetCurrentSeasonStatisticsAsync();

        /// <summary>
        /// Checks if there is a season in the "In Preparation" status.
        /// </summary>
        /// <returns><see langword="true"/> if a season is in "In Preparation" status, otherwise <see langword="false"/>.</returns>
        Task<bool> CheckForSeasonInPreparationStatusAsync();

        /// <summary>
        /// Adds a new season in "In Preparation" status with the provided start and end dates.
        /// </summary>
        /// <param name="model">The <see cref="SeasonFormModel"/> containing the start and end dates of the new season.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task AddNewSeasonAsync(SeasonFormModel model);

        /// <summary>
        /// Retrieves the details of a season with the specified status for editing purposes.
        /// </summary>
        /// <param name="status">The status of the season to retrieve.</param>
        /// <returns>A <see cref="SeasonFormModel"/> containing the details of the selected season.</returns>
        Task<SeasonFormModel> GetSeasonForEditAsync(string status);

        /// <summary>
        /// Edits the details of a season with the specified status.
        /// </summary>
        /// <param name="model">A <see cref="SeasonFormModel"/> containing the updated details of the season.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task EditSeasonAsync(SeasonFormModel model);

        /// <summary>
        /// Validates if the provided string can be successfully parsed into a <see cref="SeasonStatus"/> enumeration value.
        /// </summary>
        /// <param name="status">The string representation of the season status to be validated.</param>
        /// <returns><see langword="true"/> if the string can be parsed into a valid <see cref="SeasonStatus"/> value; otherwise, <see langword="false"/>.</returns>
        bool StatusValidation(string status);

        /// <summary>
        /// Retrieves information about the season that is currently in preparation status.
        /// </summary>
        /// <returns>A <see cref="SeasonPreparationModel"/> representing the season in preparation.</returns>
        Task<SeasonPreparationModel> GetSeasonInPreparationAsync();

        /// <summary>
        /// Retrieves the ID of the season that is currently in preparation status.
        /// </summary>
        /// <returns>The ID of the season in preparation.</returns>
        Task<int> GetPreparationSeasonIdAsync();

        /// <summary>
        /// Ends the current season and begins a new season by updating their statuses.
        /// </summary>
        /// <remarks>
        /// This method transitions the status of the current season to "Ended" and the status of
        /// the season in preparation to "Current", effectively starting a new season.
        /// </remarks>
        Task BeginNewSeasonAsync();
    }
}