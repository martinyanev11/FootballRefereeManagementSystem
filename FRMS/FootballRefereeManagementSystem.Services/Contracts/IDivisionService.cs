namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Career;

    public interface IDivisionService
    {
        /// <summary>
        /// Asynchronously adds a specific division and divisions with less difficulty to a referee by their ID.
        /// </summary>
        /// <param name="refereeId">The ID of the referee.</param>
        /// <param name="divisionName">The name of the specific division to add.</param>
        /// <returns>Task representing the asynchronous operation.</returns>
        Task AddDivisionAndDivisionsWithLessDifficultyToRefereeByIdAsync(int refereeId, string divisionName);

        /// <summary>
        /// Asynchronously determines the best suited division for an application based on the applicant's age and experience.
        /// </summary>
        /// <param name="model">The <see cref="ApplicationFormModel"/> containing the applicant's information.</param>
        /// <returns>Task representing the asynchronous operation. The result is the ID of the best suited division.</returns>
        Task<int> DetermineBestSuitedDivisionForApplicationAsync(ApplicationFormModel model);

        /// <summary>
        /// Asynchronously retrieves all division names from the database.
        /// </summary>
        /// <returns>A collection sequence containing the names of all divisions.</returns>
        Task<IEnumerable<string>> GetAllDivisionNamesAsync();

        /// <summary>
        /// Asynchronously retrieves the name of the division that a referee has officiated the most matches in.
        /// </summary>
        /// <param name="refereeId">The ID of the referee.</param>
        /// <returns>The name of the most officiated division as a string.</returns>
        Task<string> GetNameOfMostOfficiatedDivisionForRefereeByIdAsync(int refereeId);
    }
}
