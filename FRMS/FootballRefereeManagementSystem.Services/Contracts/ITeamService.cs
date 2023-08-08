namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Team;

    public interface ITeamService
    {
        /// <summary>
        /// Adds a new team to the database based on the provided model.
        /// </summary>
        /// <param name="model">The <see cref="TeamFormModel"/> containing the data for the new team.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task AddNewTeamAsync(TeamFormModel model);
        Task<bool> CheckIfTeamIsAlreadyRegistered(int teamId, int seasonId);

        /// <summary>
        /// Asynchronously checks the existence of a team based on the provided team ID.
        /// </summary>
        /// <param name="id">The ID of the team to check for existence.</param>
        /// <returns>A boolean value indicating whether the team with the specified ID exists or not.</returns>
        Task<bool> CheckTeamExistanceByIdAsync(int id);

        /// <summary>
        /// Soft deletes the team with the specified ID by setting its IsActive property to <see langword="false"/>.
        /// </summary>
        /// <param name="id">The ID of the team to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DeleteTeamAsync(int id);

        /// <summary>
        /// Edits the team with the specified ID using the provided model data.
        /// </summary>
        /// <param name="id">The ID of the team to edit.</param>
        /// <param name="model">The model containing the updated team data.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task EditTeamAsync(int id, TeamFormModel model);
        Task EditTeamSeasonAsync(TeamSeasonEditModel model);
        Task<IEnumerable<TeamRegisteredListModel>> GetAllRegisteredForNewSeasonTeams(int seasonId);
        IEnumerable<string> GetAllShirtColors();

        /// <summary>
        /// Retrieves a collection of team view models with additional administrative information based on the provided query model.
        /// </summary>
        /// <param name="queryModel">The query model containing filters and search criteria.</param>
        /// <returns>A task representing the asynchronous operation that returns the collection of team view models.</returns>
        Task<IEnumerable<TeamAdminViewModel>> GetAllTeamsAsync(TeamAdminQueryModel queryModel);
        Task<IEnumerable<TeamRegisteredListModel>> GetAllTeamsForRegistrationAsync(int seasonId);

        /// <summary>
        /// Asynchronously retrieves team standings for a specified season and division.
        /// </summary>
        /// <param name="seasonDescription">The season description to filter the team standings.</param>
        /// <param name="divisionName">The division name to filter the team standings.</param>
        /// <returns>An IEnumerable of TeamStandingsViewModel containing details of the filtered team standings.</returns>
        Task<IEnumerable<TeamStandingsViewModel>> GetFilteredBySeasonAndDivisionTeamsStandingsAsync(string seasonDescription, string divisionName);
        Task<int> GetHomeTownIdByTeamIdAsync(int homeTeamId);
        Task<IEnumerable<TeamListModel>> GetRegisteredForSeasonTeams(int seasonId);

        /// <summary>
        /// Asynchronously retrieves detailed information about a team based on the provided team ID.
        /// </summary>
        /// <param name="id">The ID of the team to retrieve details for.</param>
        /// <returns>A model containing detailed information about the team.</returns>
        Task<TeamDetailsViewModel> GetTeamDetailsByIdAsync(int id);

        /// <summary>
        /// Retrieves a team form model for editing based on the provided team ID.
        /// </summary>
        /// <param name="id">The ID of the team to retrieve.</param>
        /// <returns>A task representing the asynchronous operation that returns the team form model for editing.</returns>
        Task<TeamFormModel> GetTeamForEditByIdAsync(int id);

        /// <summary>
        /// Retrieves team information for administrative purposes based on the provided team ID.
        /// </summary>
        /// <param name="id">The ID of the team to retrieve information for.</param>
        /// <returns>A task representing the asynchronous operation that returns the team information.</returns>
        Task<TeamAdminViewModel> GetTeamInfoByIdAsync(int id);
        Task<string> GetTeamNameByIdAsync(int teamId);
        Task<int> GetTeamSeasonDivision(int homeTeamId, int seasonId);
        Task<TeamSeasonEditModel> GetTeamSeasonForEdintById(int teamId, int seasonId);

        /// <summary>
        /// Asynchronously retrieves detailed information about a team's season based on the provided team ID.
        /// </summary>
        /// <param name="id">The ID of the team to retrieve season details for.</param>
        /// <returns>A model containing detailed information about the team's season.</returns>
        Task<TeamSeasonDetailsViewModel> GetTeamSeasonInformationByIdAsync(int id);

        /// <summary>
        /// Checks if a team with the provided team name and town already exists in the database.
        /// </summary>
        /// <param name="model">The team form model containing the team name and town to check for existence.</param>
        /// <returns>
        /// <see langword="true"/> if a team with the provided name and town exists in the database, <see langword="false"/> otherwise.
        /// </returns>
        Task<bool> IsTeamAlreadyAdded(TeamFormModel model);

        /// <summary>
        /// Checks if a team with the provided team name and town already exists in the database, excluding the team with the specified ID.
        /// </summary>
        /// <param name="teamId">The ID of the team to exclude from the check.</param>
        /// <param name="model">The team form model containing the team name and town to check for existence.</param>
        /// <returns>
        /// <see langword="true"/> if a team with the provided name and town exists in the database (excluding the team with ID), <see langword="false"/> otherwise.
        /// </returns>
        Task<bool> IsTeamAlreadyAdded(int teamId, TeamFormModel model);
        Task RegisterNewTeamSeasonAsync(TeamSeasonRegisterModel model);
    }
}
