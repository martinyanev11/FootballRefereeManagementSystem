namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Data.Models;
    using Web.ViewModels.User;

    public interface IUserService
    {
        Task AddUserToAdminRoleAsync(string userId);

        /// <summary>
        /// Changes the status of a user's referee availability based on the provided user ID.
        /// </summary>
        /// <param name="userId">The ID of the user to change the status for.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task ChangeStatusAsync(string userId);

        /// <summary>
        /// Deletes sensitive user information for the specified application user.
        /// </summary>
        /// <param name="user">The ApplicationUser for which to delete the information.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        Task DeleteUserInformationAsync(ApplicationUser user);

        /// <summary>
        /// Retrieves information about an application user from the database based on the provided user ID.
        /// </summary>
        /// <param name="userId">The ID of the application user to retrieve information for.</param>
        /// <returns>A task representing the asynchronous operation that returns an instance of <see cref="ApplicationUserViewModel"/> containing the user information.</returns>
        Task<ApplicationUserViewModel> GetUserInformationByIdAsync(string userId);

        /// <summary>
        /// Checks if a user is assigned the admin role.
        /// </summary>
        /// <param name="userId">The ID of the user to check.</param>
        /// <returns><see langword="true"/> if the user is an admin, otherwise <see langword="false"/>.</returns>
        Task<bool> IsUserAdminAsync(string userId);

        /// <summary>
        /// Links a user to a referee in the database.
        /// </summary>
        /// <param name="userId">The ID of the user to link to the referee.</param>
        /// <param name="refereeId">The ID of the referee to link the user to.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method queries the database to find the user with the specified ID,
        /// and if found, it sets the RefereeId property of the user to the given refereeId
        /// and saves the changes to the database.
        /// </remarks>
        Task LinkUserToRefereeAsync(string userId, int refereeId);

        /// <summary>
        /// Removes a user from the admin role.
        /// </summary>
        /// <param name="userId">The ID of the user to remove from the admin role.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task RemoveUserFromAdminRoleAsync(string userId);
    }
}