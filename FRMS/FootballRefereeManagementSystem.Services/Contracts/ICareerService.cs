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

        Task<IEnumerable<ApplicationViewModel>> GetAllApplicationsFilteredAsync(ApplicationQueryModel queryModel);
        Task<ApplicationViewModel> GetApplicationByIdAsync(string id);
    }
}
