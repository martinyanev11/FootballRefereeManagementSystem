namespace FootballRefereeManagementSystem.Services.Contracts
{
    using FootballRefereeManagementSystem.Web.ViewModels.Season;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISeasonService
    {
        /// <summary>
        /// Asynchronously retrieves all seasons from the database.
        /// </summary>
        /// <returns>A collection containing the descriptions of all seasons.</returns>
        Task<IEnumerable<string>> GetAllSeasonDescriptionsAsync();
        Task<SeasonViewModel> GetCurrentSeasonInformation();

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
        Task<SeasonStatisticsViewModel> GetCurrentSeasonStatisticsAsync();
        Task<bool> CheckForSeasonInPreparation();
        Task AddNewSeasonAsync(SeasonFormModel model);
        Task<SeasonFormModel> GetSeasonForEditAsync(string status);
        Task EditSeasonAsync(SeasonFormModel model);
        bool StatusValidation(string status);
        Task<SeasonPreparationModel> GetSeasonInPreparationAsync();
        Task<int> GetPreparationSeasonIdAsync();
        Task BeginNewSeasonAsync();
    }
}
