namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Web.ViewModels.User;

    public interface IUserService
    {
        /// <summary>
        /// Changes the status of a user's referee availability based on the provided user ID.
        /// </summary>
        /// <param name="userId">The ID of the user to change the status for.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task ChangeStatusAsync(string userId);

        /// <summary>
        /// Retrieves information about an application user from the database based on the provided user ID.
        /// </summary>
        /// <param name="id">The ID of the application user to retrieve information for.</param>
        /// <returns>A task representing the asynchronous operation that returns an instance of <see cref="ApplicationUserViewModel"/> containing the user information.</returns>
        Task<ApplicationUserViewModel> GetUserInformationAsync(string id);
        Task LinkUserToRefereeAsync(string userId, int refereeId);
    }
}