namespace FootballRefereeManagementSystem.Services.Contracts
{
    using FootballRefereeManagementSystem.Data.Models;
    using Web.ViewModels.User;

    public interface IUserService
    {
        /// <summary>
        /// Changes the status of a user's referee availability based on the provided user ID.
        /// </summary>
        /// <param name="userId">The ID of the user to change the status for.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task ChangeStatusAsync(string userId);
        Task DeleteUserInformationAsync(ApplicationUser user);

        /// <summary>
        /// Retrieves information about an application user from the database based on the provided user ID.
        /// </summary>
        /// <param name="userId">The ID of the application user to retrieve information for.</param>
        /// <returns>A task representing the asynchronous operation that returns an instance of <see cref="ApplicationUserViewModel"/> containing the user information.</returns>
        Task<ApplicationUserViewModel> GetUserInformationByIdAsync(string userId);

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
    }
}