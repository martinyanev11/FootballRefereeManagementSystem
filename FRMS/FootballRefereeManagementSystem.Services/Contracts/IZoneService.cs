namespace FootballRefereeManagementSystem.Services.Contracts
{
    using FootballRefereeManagementSystem.Web.ViewModels.Zone;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IZoneService
    {
        /// <summary>
        /// Adds a new zone to the database.
        /// </summary>
        /// <param name="model">The zone form model containing the zone information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task AddNewZoneAsync(ZoneFormModel model);

        /// <summary>
        /// Checks if a zone with the specified ID exists in the database.
        /// </summary>
        /// <param name="id">The ID of the zone to check for existence.</param>
        /// <returns>
        /// <see langword="true"/> if a zone with the specified ID exists in the database, <see langword="false"/> otherwise.
        /// </returns>
        Task<bool> CheckZoneExistanceByIdAsync(int id);

        /// <summary>
        /// Checks if a zone with the specified name exists in the database.
        /// </summary>
        /// <param name="zoneName">The name of the zone to check for existence.</param>
        /// <returns>
        /// <see langword="true"/> if a zone with the specified name exists in the database, <see langword="false"/> otherwise.
        /// </returns>
        Task<bool> CheckZoneExistanceByNameAsync(string zoneName);

        /// <summary>
        /// Deletes the zone with the specified ID by setting its IsActive property to false.
        /// </summary>
        /// <param name="id">The ID of the zone to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DeleteZoneAsync(int id);

        /// <summary>
        /// Edits the zone with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the zone to edit.</param>
        /// <param name="model">The <see cref="ZoneFormModel"/> containing the updated zone information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task EditZoneAsync(int id, ZoneFormModel model);

        /// <summary>
        /// Gets all zone names from the database.
        /// </summary>
        /// <returns>A collection of zone names.</returns>
        Task<IEnumerable<string>> GetAllZoneNamesAsync();

        /// <summary>
        /// Retrieves all active zones along with the count of towns associated with each zone.
        /// </summary>
        /// <returns>A collection of <see cref="ZoneViewModel"/> representing the zones in the database.</returns>
        Task<IEnumerable<ZoneViewModel>> GetAllZonesAsync();
        Task<ZoneViewModel> GetZoneByIdAsync(int id);

        /// <summary>
        /// Retrieves the details of a specific zone for editing purposes.
        /// </summary>
        /// <param name="id">The unique identifier of the zone to retrieve.</param>
        /// <returns>A <see cref="ZoneFormModel"/> containing the details of the zone.</returns>
        Task<ZoneFormModel> GetZoneForEditByIdAsync(int id);

        /// <summary>
        /// Retrieves the zone ID by its name from the database.
        /// </summary>
        /// <param name="zoneName">The name of the zone.</param>
        /// <returns>The ID of the zone, or 0 if not found.</returns>
        Task<int> GetZoneIdByNameAsync(string zoneName);
    }
}
