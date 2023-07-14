namespace FootballRefereeManagementSystem.Services.Contracts
{
    using FootballRefereeManagementSystem.Web.ViewModels.Career;

    public interface ICareerService
    {
        /// <summary>
        /// Add new Application to the database.
        /// </summary>
        /// <param name="model">Application to add.</param>
        /// <returns></returns>
        Task AddApplicationAsync(ApplicationFormModel model);
    }
}
