namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Player;

    public interface IPlayerService
    {
        /// <summary>
        /// Adds a new player to the database.
        /// </summary>
        /// <param name="model">The player information to be added.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task AddNewPlayerAsync(PlayerFormModel model);

        /// <summary>
        /// Checks if a player with the specified ID exists in the database.
        /// </summary>
        /// <param name="id">The ID of the player to check for existence.</param>
        /// <returns><see langword="true"/> if a player with the specified ID exists in the database, <see langword="false"/> otherwise.</returns>
        Task<bool> CheckPlayerExistanceByIdAsync(int id);

        /// <summary>
        /// Deletes a player by setting their IsActive status to <see langword="false"/>.
        /// </summary>
        /// <param name="id">The ID of the player to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DeletePlayerAsync(int id);

        /// <summary>
        /// Edits an existing player's information based on the provided <paramref name="model"/>.
        /// </summary>
        /// <param name="id">The ID of the player to edit.</param>
        /// <param name="model">The <see cref="PlayerFormModel"/> containing the updated player information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task EditPlayerAsync(int id, PlayerFormModel model);

        /// <summary>
        /// Retrieves a collection of player details based on the specified <paramref name="queryModel"/>.
        /// </summary>
        /// <param name="queryModel">The <see cref="PlayerQueryModel"/> containing the search criteria.</param>
        /// <returns>A collection of <see cref="PlayerDetailsViewModel"/> representing player details.</returns>
        Task<IEnumerable<PlayerDetailsViewModel>> GetAllPlayersAsync(PlayerQueryModel queryModel);

        /// <summary>
        /// Retrieves a collection of player details who are not registered for the specified season.
        /// </summary>
        /// <param name="seasonId">The ID of the season to check for unregistered players.</param>
        /// <returns>A collection of <see cref="PlayerDetailsViewModel"/> representing unregistered players.</returns>
        Task<IEnumerable<PlayerDetailsViewModel>> GetAllSeasonUnregisteredPlayers(int seasonId);

        /// <summary>
        /// Retrieves player details by their unique identifier.
        /// </summary>
        /// <param name="id">The ID of the player to retrieve.</param>
        /// <returns>A <see cref="PlayerDetailsViewModel"/> containing the player's details.</returns>
        Task<PlayerDetailsViewModel> GetPlayerByIdAsync(int id);

        /// <summary>
        /// Retrieves player information for editing by their unique identifier.
        /// </summary>
        /// <param name="id">The ID of the player to retrieve.</param>
        /// <returns>A <see cref="PlayerFormModel"/> containing the player's editable information.</returns>
        Task<PlayerFormModel> GetPlayerForEditByIdAsync(int id);

        /// <summary>
        /// Asynchronously retrieves the details of players belonging to a specific team during a given season.
        /// </summary>
        /// <param name="teamId">The ID of the team to retrieve the players for.</param>
        /// <param name="seasonId">The ID of the season to filter the players.</param>
        /// <returns>A collection of models containing details of the players.</returns>
        Task<IEnumerable<PlayerDetailsViewModel>> GetTeamPlayersForSeasonAsync(int teamId, int seasonId);

        /// <summary>
        /// Registers a player for a specific season and team.
        /// </summary>
        /// <param name="model">The model containing the player, season, and team information.</param>
        Task RegisterPlayerForSeason(PlayerTeamSeasonFormModel model);
    }
}