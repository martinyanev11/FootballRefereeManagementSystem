namespace FootballRefereeManagementSystem.Services.Contracts
{
    using FootballRefereeManagementSystem.Web.ViewModels.Career;

    public interface ICareerService
    {
        /// <summary>
        /// Add new Application to the database asynchronous.
        /// </summary>
        /// <param name="model">Object to add.</param>
        /// <returns></returns>
        Task AddApplicationAsync(ApplicationFormModel model);
    }
}
