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

        /// <summary>
        /// Checks if a team is already registered for a specific season.
        /// </summary>
        /// <param name="teamId">The ID of the team to check.</param>
        /// <param name="seasonId">The ID of the season to check.</param>
        /// <returns><see langword="true"/> if the team is already registered for the season; otherwise, <see langword="false"/>.</returns>
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

        /// <summary>
        /// Edits the details of a team's registration for a specific season.
        /// </summary>
        /// <param name="model">The model containing the updated team season information.</param>
        /// <remarks>
        /// This method updates the division and shirt color of the team's registration for the specified season.
        /// </remarks>
        Task EditTeamSeasonAsync(TeamSeasonEditModel model);

        /// <summary>
        /// Retrieves a list of teams that are registered for a specific new season.
        /// </summary>
        /// <param name="seasonId">The ID of the new season.</param>
        /// <returns>A collection of registered teams with relevant information.</returns>
        /// <remarks>
        /// This method retrieves information about teams that are registered for the specified new season,
        /// including team name, location, division, registered players count, and total matches count.
        /// </remarks>
        Task<IEnumerable<TeamRegisteredListModel>> GetAllRegisteredForNewSeasonTeams(int seasonId);

        /// <summary>
        /// Retrieves a collection of all available shirt colors.
        /// </summary>
        /// <returns>A collection of shirt colors in Bulgarian.</returns>
        /// <remarks>
        /// This method retrieves all available shirt colors and translates them to Bulgarian.
        /// </remarks>
        IEnumerable<string> GetAllShirtColors();

        /// <summary>
        /// Retrieves a collection of team view models with additional administrative information based on the provided query model.
        /// </summary>
        /// <param name="queryModel">The query model containing filters and search criteria.</param>
        /// <returns>A task representing the asynchronous operation that returns the collection of team view models.</returns>
        Task<IEnumerable<TeamAdminViewModel>> GetAllTeamsAsync(TeamAdminQueryModel queryModel);

        /// <summary>
        /// Retrieves a collection of all teams available for registration in the specified season.
        /// </summary>
        /// <param name="seasonId">The ID of the season for which teams should be retrieved.</param>
        /// <returns>A collection of teams available for registration.</returns>
        /// <remarks>
        /// This method retrieves all teams that are currently not registered for the specified season.
        /// </remarks>
        Task<IEnumerable<TeamRegisteredListModel>> GetAllTeamsForRegistrationAsync(int seasonId);

        /// <summary>
        /// Asynchronously retrieves team standings for a specified season and division.
        /// </summary>
        /// <param name="seasonDescription">The season description to filter the team standings.</param>
        /// <param name="divisionName">The division name to filter the team standings.</param>
        /// <returns>An IEnumerable of TeamStandingsViewModel containing details of the filtered team standings.</returns>
        Task<IEnumerable<TeamStandingsViewModel>> GetFilteredBySeasonAndDivisionTeamsStandingsAsync
            (string seasonDescription, string divisionName);

        /// <summary>
        /// Retrieves the ID of the home town associated with a team.
        /// </summary>
        /// <param name="homeTeamId">The ID of the team.</param>
        /// <returns>The ID of the home town for the specified team.</returns>
        Task<int> GetHomeTownIdByTeamIdAsync(int homeTeamId);

        /// <summary>
        /// Retrieves a list of teams that are registered for a specific season.
        /// </summary>
        /// <param name="seasonId">The ID of the season.</param>
        /// <returns>An enumeration of <see cref="TeamListModel"/> representing the registered teams for the specified season.</returns>
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

        /// <summary>
        /// Retrieves the name of a team by its ID.
        /// </summary>
        /// <param name="teamId">The ID of the team.</param>
        /// <returns>The name of the team.</returns>
        Task<string> GetTeamNameByIdAsync(int teamId);

        /// <summary>
        /// Retrieves the division ID of a team playing in a specific season.
        /// </summary>
        /// <param name="homeTeamId">The ID of the home team.</param>
        /// <param name="seasonId">The ID of the season.</param>
        /// <returns>The division ID of the team for the specified season.</returns>
        Task<int> GetTeamSeasonDivision(int homeTeamId, int seasonId);

        /// <summary>
        /// Retrieves the team season information for editing by team and season IDs.
        /// </summary>
        /// <param name="teamId">The ID of the team.</param>
        /// <param name="seasonId">The ID of the season.</param>
        /// <returns>A <see cref="TeamSeasonEditModel"/> containing the team season information for editing.</returns>
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

        /// <summary>
        /// Registers a new team for a specific season.
        /// </summary>
        /// <param name="model">The <see cref="TeamSeasonRegisterModel"/> containing the information for registering the team.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task RegisterNewTeamSeasonAsync(TeamSeasonRegisterModel model);
    }
}