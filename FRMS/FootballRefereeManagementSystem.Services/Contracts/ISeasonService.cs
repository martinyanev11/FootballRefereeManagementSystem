namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISeasonService
    {
        /// <summary>
        /// Asynchronously retrieves all seasons from the database.
        /// </summary>
        /// <returns>A collection containing the descriptions of all seasons.</returns>
        Task<IEnumerable<string>> GetAllSeasonDescriptionsAsync();

        /// <summary>
        /// Asynchronously retrieves the description of the latest (current) season from the database.
        /// </summary>
        /// <returns>A string representing the description of the latest season.</returns>
        Task<string> GetLatestSeasonDescriptionAsync();

        /// <summary>
        /// Asynchronously retrieves the season ID based on the provided season description.
        /// </summary>
        /// <param name="seasonDescription">The season description to search for.</param>
        /// <returns>The season ID as an integer.</returns>
        Task<int> GetSeasonIdByDescriptionAsync(string seasonDescription);
    }
}
