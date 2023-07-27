namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDivisionService
    {
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
