namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Career;

    public interface ICareerService
    {
        /// <summary>
        /// Adds a new application to the database based on the provided <see cref="ApplicationFormModel"/>.
        /// </summary>
        /// <param name="model">The application form model containing the application information to add.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task AddApplicationAsync(ApplicationFormModel model);

        /// <summary>
        /// Asynchronously changes the status of an application based on the provided application ID.
        /// </summary>
        /// <param name="newStatus">The new status to set for the application (e.g., "Approved" or "Declined").</param>
        /// <param name="applicationId">The ID of the application to change its status.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        Task ChangeApplicationStatusAsync(string newStatus, string applicationId);

        /// <summary>
        /// Asynchronously checks the existence of an application based on the provided application ID.
        /// </summary>
        /// <param name="id">The ID of the application to check for existence.</param>
        /// <returns>A boolean value indicating whether the application with the specified ID exists in the database or not.</returns>
        Task<bool> CheckApplicationExistanceByIdAsync(string id);

        /// <summary>
        /// Asynchronously checks if the given email address is already used by a registered applicant.
        /// </summary>
        /// <param name="email">The email address to check.</param>
        /// <returns><see langword="true"/> if the email address is already used by a registered applicant, otherwise <see langword="false"/>.</returns>
        Task<bool> CheckIfEmailIsAlreadyUsedAsync(string email);

        /// <summary>
        /// Asynchronously confirms the registration link for an application based on the provided ID.
        /// A registration link is considered valid if it has not been used yet and the ID exists in the database.
        /// </summary>
        /// <param name="id">The ID of the application to confirm the registration link.</param>
        /// <returns>A boolean value indicating whether the registration link is valid or not.</returns>
        Task<bool> ConfirmRegistrationLinkAsync(string id);

        /// <summary>
        /// Asynchronously retrieves all filtered <see cref="ApplicationViewModel"/> models based on the provided query model.
        /// </summary>
        /// <param name="queryModel">The query model containing filtering and sorting options for applications.</param>
        /// <returns>A collection of models containing details of the filtered applications.</returns>
        Task<IEnumerable<ApplicationViewModel>> GetAllApplicationsFilteredAsync(ApplicationQueryModel queryModel);

        /// <summary>
        /// Asynchronously retrieves an <see cref="ApplicationViewModel"/> based on the provided application ID.
        /// </summary>
        /// <param name="id">The ID of the application to retrieve.</param>
        /// <returns>A model containing details of the specified application for career.</returns>
        Task<ApplicationViewModel> GetApplicationByIdAsync(string id);

        /// <summary>
        /// Asynchronously retrieves an application's information for email purposes by its ID.
        /// </summary>
        /// <param name="id">The ID of the application to retrieve.</param>
        /// <returns>An <see cref="ApplicationEmailModel"/> containing the relevant information for sending emails.</returns>
        Task<ApplicationEmailModel> GetApplicationForEmailByIdAsync(string id);

        /// <summary>
        /// Asynchronously sets the IsRegistered value of an application to <see langword="true"/> by its ID.
        /// </summary>
        /// <param name="id">The ID of the application to update.</param>
        /// <returns>Task representing the asynchronous operation.</returns>
        Task SetIsRegisterValueToTrueAsync(string id);
    }
}
