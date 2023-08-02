namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Threading.Tasks;

    public interface ITownService
    {
        /// <summary>
        /// Adds a new town to the database with the specified town name and zone ID.
        /// </summary>
        /// <param name="townName">The name of the town to be added.</param>
        /// <param name="zoneId">The ID of the zone to which the town belongs.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task AddNewTownAsync(string townName, int zoneId);

        /// <summary>
        /// Checks if a town with the specified name exists in the database.
        /// </summary>
        /// <param name="townName">The name of the town to check for existence.</param>
        /// <returns>
        /// <see langword="true"/> if a town with the specified name exists in the database; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method asynchronously queries the database to check for the existence of a town
        /// with the given name and returns the result as a boolean value.
        /// </remarks>
        Task<bool> CheckTownExistanceByNameAsync(string townName);

        /// <summary>
        /// Retrieves the ID of a town with the specified name from the database.
        /// </summary>
        /// <param name="townName">The name of the town for which to get the ID.</param>
        /// <returns>
        /// The ID of the town if found in the database; otherwise, the default value for the ID type.
        /// </returns>
        /// <remarks>
        /// This method asynchronously queries the database to find the town with the given name,
        /// and if found, it returns the ID of the town. If no town is found with the given name,
        /// it returns the default value for the ID type (0 for int).
        /// </remarks>
        Task<int> GetTownIdByNameAsync(string townName);
    }
}
