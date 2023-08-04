namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Team;

    public interface ITeamService
    {
        /// <summary>
        /// Asynchronously checks the existence of a team based on the provided team ID.
        /// </summary>
        /// <param name="id">The ID of the team to check for existence.</param>
        /// <returns>A boolean value indicating whether the team with the specified ID exists or not.</returns>
        Task<bool> CheckTeamExistanceByIdAsync(int id);
        Task<TeamAdminQueryModel> GetAllTeamsAsync(TeamAdminQueryModel queryModel);

        /// <summary>
        /// Asynchronously retrieves team standings for a specified season and division.
        /// </summary>
        /// <param name="seasonDescription">The season description to filter the team standings.</param>
        /// <param name="divisionName">The division name to filter the team standings.</param>
        /// <returns>An IEnumerable of TeamStandingsViewModel containing details of the filtered team standings.</returns>
        Task<IEnumerable<TeamStandingsViewModel>> GetFilteredBySeasonAndDivisionTeamsStandingsAsync(string seasonDescription, string divisionName);

        /// <summary>
        /// Asynchronously retrieves detailed information about a team based on the provided team ID.
        /// </summary>
        /// <param name="id">The ID of the team to retrieve details for.</param>
        /// <returns>A model containing detailed information about the team.</returns>
        Task<TeamDetailsViewModel> GetTeamDetailsByIdAsync(int id);

        /// <summary>
        /// Asynchronously retrieves detailed information about a team's season based on the provided team ID.
        /// </summary>
        /// <param name="id">The ID of the team to retrieve season details for.</param>
        /// <returns>A model containing detailed information about the team's season.</returns>
        Task<TeamSeasonDetailsViewModel> GetTeamSeasonInformationByIdAsync(int id);
    }
}
