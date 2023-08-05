namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Town;

    public interface ITownService
    {
        /// <summary>
        /// Adds a new town to the database.
        /// </summary>
        /// <param name="model">The town form model containing the town information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task AddNewTownAsync(TownFormModel model);

        /// <summary>
        /// Checks if a town with the specified ID exists in the database.
        /// </summary>
        /// <param name="id">The ID of the town to check for existence.</param>
        /// <returns>
        /// <see langword="true"/> if a town with the specified ID exists in the database, <see langword="false"/> otherwise.
        /// </returns>
        Task<bool> CheckTownExistanceByIdAsync(int id);

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
        /// Deletes the town with the specified ID from the database.
        /// </summary>
        /// <param name="id">The ID of the town to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DeleteTownAsync(int id);

        /// <summary>
        /// Edits the town with the specified ID in the database.
        /// </summary>
        /// <param name="id">The ID of the town to edit.</param>
        /// <param name="model">The updated data for the town.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task EditTownAsync(int id, TownFormModel model);

        /// <summary>
        /// Retrieves the names of all active towns from the database.
        /// </summary>
        /// <returns>A collection of strings containing the names of all active towns.</returns>
        Task<IEnumerable<string>> GetAllTownNamesAsync();

        /// <summary>
        /// Retrieves a collection of town view models based on the specified query parameters.
        /// </summary>
        /// <param name="queryModel">The query parameters for filtering and searching.</param>
        /// <returns>A task representing the asynchronous operation. The result is a collection of town view models.</returns>
        Task<IEnumerable<TownViewModel>> GetAllTownsAsync(TownQueryModel queryModel);

        /// <summary>
        /// Retrieves a town view model by its ID.
        /// </summary>
        /// <param name="id">The ID of the town to retrieve.</param>
        /// <returns>A task representing the asynchronous operation. The result is the town view model.</returns>
        Task<TownViewModel> GetTownByIdAsync(int id);

        /// <summary>
        /// Retrieves a town form model for editing by its ID.
        /// </summary>
        /// <param name="id">The ID of the town to retrieve.</param>
        /// <returns>A task representing the asynchronous operation. The result is the town form model.</returns>
        Task<TownFormModel> GetTownForEditByIdAsync(int id);

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