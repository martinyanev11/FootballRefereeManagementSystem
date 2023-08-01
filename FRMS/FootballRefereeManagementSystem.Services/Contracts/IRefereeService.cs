namespace FootballRefereeManagementSystem.Services.Contracts
{
    using FootballRefereeManagementSystem.Web.ViewModels.Career;
    using FootballRefereeManagementSystem.Web.ViewModels.RefereeSquad;
    using System.Collections.Generic;

    using Web.ViewModels.Referee;

    public interface IRefereeService
    {
        /// <summary>
        /// Asynchronously checks the existence of a referee based on the provided referee ID.
        /// </summary>
        /// <param name="id">The ID of the referee to check for existence.</param>
        /// <returns>A boolean value indicating whether the referee with the specified ID exists or not.</returns>
        Task<bool> CheckRefereeExistanceByIdAsync(int id);

        /// <summary>
        /// Asynchronously retrieves a filtered list of referees based on the provided query model.
        /// </summary>
        /// <param name="queryModel">The query model containing filter and sorting options for the referees.</param>
        /// <returns>A collection of models containing details of the filtered referees.</returns>
        Task<IEnumerable<RefereeViewModel>> GetAllRefereesFilteredAsync(RefereeQueryModel queryModel);

        /// <summary>
        /// Asynchronously retrieves all active referee squads along with their details.
        /// An active referee squad is considered one where the match that they officiate is yet to be played.
        /// </summary>
        /// <returns>A collection of models containing details of active referee squads.</returns>
        Task<IEnumerable<RefereeSquadViewModel>> GetAllActiveRefereeSquadsAsync();

        /// <summary>
        /// Asynchronously retrieves detailed information about a referee based on the provided ID.
        /// </summary>
        /// <param name="id">The ID of the referee to retrieve details for.</param>
        /// <returns>A model containing detailed information about the referee.</returns>
        Task<RefereeDetailsViewModel> GetRefereeDetailsByIdAsync(int id);

        /// <summary>
        /// Asynchronously retrieves the referee ID associated with the provided user ID.
        /// </summary>
        /// <param name="userId">The ID of the user to retrieve the referee ID for.</param>
        /// <returns>The referee ID as an integer.</returns>
        Task<int> GetRefereeIdByUserIdAsync(string userId);

        string GetRefereeStartingRole();
        Task CreateNewRefereeAsync(RefereeFormModel model);
        int DetermineBestSuitedRoleForApplication(ApplicationFormModel model);
    }
}
