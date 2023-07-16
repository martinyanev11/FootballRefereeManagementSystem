﻿namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Web.ViewModels.Career;

    public interface ICareerService
    {
        /// <summary>
        /// Adds a new application to the database based on the provided <see cref="ApplicationFormModel"/>.
        /// </summary>
        /// <param name="model">The application form model containing the application information to add.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task AddApplicationAsync(ApplicationFormModel model);
    }
}
