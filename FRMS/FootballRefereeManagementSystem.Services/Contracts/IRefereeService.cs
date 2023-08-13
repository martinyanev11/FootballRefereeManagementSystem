namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;

    using Web.ViewModels.Referee;
    using Web.ViewModels.RefereeSquad;
    using Web.ViewModels.Career;
    using Models.Referee;

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

        /// <summary>
        /// Asynchronously creates a new referee and adds it to the database.
        /// </summary>
        /// <param name="model">The <see cref="RefereeFormModel"/> containing the referee's information.</param>
        /// <returns>Task representing the asynchronous operation.</returns>
        Task CreateNewRefereeAsync(RefereeFormModel model);

        /// <summary>
        /// Determines the best suited role for an application based on the applicant's age and experience.
        /// </summary>
        /// <param name="model">The ApplicationFormModel containing the applicant's information.</param>
        /// <returns>An integer representing the best suited role (Role enum value).</returns>
        int DetermineBestSuitedRoleForApplication(ApplicationFormModel model);

        /// <summary>
        /// Gets the user ID associated with the referee ID.
        /// </summary>
        /// <param name="refereeId">The ID of the referee.</param>
        /// <returns>The user ID as a string.</returns>
        Task<string> GetUserIdByRefereeIdAsync(int refereeId);

        /// <summary>
        /// Deletes a referee by setting its sensitive data properties to <see langword="null"/> and marking it as inactive.
        /// </summary>
        /// <param name="refereeId">The ID of the referee to delete.</param>
        Task DeleteRefereeAsync(int? refereeId);

        /// <summary>
        /// Retrieves referee profile data by the associated user ID.
        /// </summary>
        /// <param name="userId">The user ID of the referee.</param>
        /// <returns>A <see cref="RefereeServiceModel"/> containing the referee's profile data.</returns>
        Task<RefereeServiceModel> GetRefereeProfileDataByUserIdAsync(string userId);

        /// <summary>
        /// Updates referee data for the specified user.
        /// </summary>
        /// <param name="newRefereeData">The new referee data to update.</param>
        /// <param name="userId">The user ID of the referee.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task UpdateRefereeDataAsync(RefereeServiceModel newRefereeData, string userId);

        /// <summary>
        /// Retrieves referee data for editing by ID.
        /// </summary>
        /// <param name="id">The ID of the referee.</param>
        /// <returns>A task representing the asynchronous operation. The <see cref="RefereeEditFormModel"/> containing referee data for editing.</returns>
        Task<RefereeEditFormModel> GetRefereeForEditByIdAsync(int id);

        /// <summary>
        /// Edits referee data based on the provided ID and model.
        /// </summary>
        /// <param name="id">The ID of the referee to be edited.</param>
        /// <param name="model">The <see cref="RefereeEditFormModel"/> containing the updated referee data.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task EditRefereeByIdAsync(int id, RefereeEditFormModel model);

        /// <summary>
        /// Retrieves statistics about referees.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation. The task result contains the <see cref="RefereesStatisticsViewModel"/>.</returns>
        Task<RefereesStatisticsViewModel> GetRefereesStatisticsAsync();

        /// <summary>
        /// Retrieves a list of referees available in a specific division and of a certain role type.
        /// </summary>
        /// <param name="divisionId">The ID of the division.</param>
        /// <param name="roleType">The role type of the referees to filter by.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation. The task result contains an enumerable collection of <see cref="RefereeListModel"/>.</returns>
        Task<IEnumerable<RefereeListModel>> GetAllAvaliableInDivisionRefereesOfRoleTypeAsync
            (int divisionId, string roleType);

        /// <summary>
        /// Creates a new referee squad for a match.
        /// </summary>
        /// <param name="id">The ID of the match.</param>
        /// <param name="model">The model containing referee squad information.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation. The task result contains the ID of the created referee squad.</returns>
        Task<Guid> CreateRefereeSquadAsync(int id, RefereeSquadFormModel model);

        /// <summary>
        /// Checks the existence of a referee squad by its ID.
        /// </summary>
        /// <param name="id">The ID of the referee squad.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation. The task result contains a boolean indicating whether the referee squad exists.</returns>
        Task<bool> CheckRefereeSquadExistanceByIdAsync(string id);

        /// <summary>
        /// Retrieves referee squad data for editing based on its ID.
        /// </summary>
        /// <param name="refereeSquadId">The ID of the referee squad.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the asynchronous operation. The task result contains a <see cref="RefereeSquadEditModel"/> with the referee squad data.</returns>
        Task<RefereeSquadEditModel> GetRefereeSquadForEditByIdAsync(string refereeSquadId);

        /// <summary>
        /// Edits an existing referee squad based on its ID.
        /// </summary>
        /// <param name="refereeSquadId">The ID of the referee squad.</param>
        /// <param name="model">The updated referee squad data.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task EditRefereeSquadAsync(string refereeSquadId, RefereeSquadEditModel model);

        /// <summary>
        /// Updates the count of currently appointed matches for a referee.
        /// </summary>
        /// <param name="refereeId">The ID of the referee.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task UpdateCurrentlyAppointedMatchesCountAsync(int refereeId);

        /// <summary>
        /// Retrieves referee squad information for the match center.
        /// </summary>
        /// <param name="id">The ID of the referee squad.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task<RefereeSquadMatchCenterModel> GetRefereeSquadForMatchCenterAsync(string id);

        /// <summary>
        /// Retrieves the IDs of all referees in a specific referee squad.
        /// </summary>
        /// <param name="id">The ID of the referee squad.</param>
        /// <returns>An array of referee IDs.</returns>
        Task<int[]> GetAllRefereeIdsFromRefereeSquadAsync(string refereeSquadId);

        /// <summary>
        /// Increments the match count statistics for referees officiating in a specific division.
        /// </summary>
        /// <param name="matchDivisionId">The ID of the division for the match.</param>
        /// <param name="refereeIds">An array of referee IDs.</param>
        /// <returns>Task representing the asynchronous operation.</returns>
        Task IncrementRefereeDivisionMatchCountStatsAsync(int matchDivisionId, int[] refereeIds);
    }
}