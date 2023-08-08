namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Player;

    public interface IPlayerService
    {
        Task AddNewPlayerAsync(PlayerFormModel model);
        Task<bool> CheckPlayerExistanceByIdAsync(int id);
        Task DeletePlayerAsync(int id);
        Task EditPlayerAsync(int id, PlayerFormModel model);
        Task<IEnumerable<PlayerDetailsViewModel>> GetAllPlayersAsync(PlayerQueryModel queryModel);
        Task<IEnumerable<PlayerDetailsViewModel>> GetAllSeasonUnregisteredPlayers(int seasonId);
        Task<PlayerDetailsViewModel> GetPlayerByIdAsync(int id);
        Task<PlayerFormModel> GetPlayerForEditByIdAsync(int id);

        /// <summary>
        /// Asynchronously retrieves the details of players belonging to a specific team during a given season.
        /// </summary>
        /// <param name="teamId">The ID of the team to retrieve the players for.</param>
        /// <param name="seasonId">The ID of the season to filter the players.</param>
        /// <returns>A collection of models containing details of the players.</returns>
        Task<IEnumerable<PlayerDetailsViewModel>> GetTeamPlayersForSeasonAsync(int teamId, int seasonId);
        Task RegisterPlayerForSeason(PlayerTeamSeasonFormModel model);
    }
}
