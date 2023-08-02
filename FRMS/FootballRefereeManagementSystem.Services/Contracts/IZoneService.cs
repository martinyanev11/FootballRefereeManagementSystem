namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IZoneService
    {
        /// <summary>
        /// Checks if a zone with the specified name exists in the database.
        /// </summary>
        /// <param name="zoneName">The name of the zone to check for existence.</param>
        /// <returns>
        /// <see langword="true"/> if a zone with the specified name exists in the database, <see langword="false"/> otherwise.
        /// </returns>
        Task<bool> CheckZoneExistanceByNameAsync(string zoneName);

        /// <summary>
        /// Gets all zone names from the database.
        /// </summary>
        /// <returns>A collection of zone names.</returns>
        Task<IEnumerable<string>> GetAllZoneNamesAsync();

        /// <summary>
        /// Retrieves the zone ID by its name from the database.
        /// </summary>
        /// <param name="zoneName">The name of the zone.</param>
        /// <returns>The ID of the zone, or 0 if not found.</returns>
        Task<int> GetZoneIdByNameAsync(string zoneName);
    }
}
