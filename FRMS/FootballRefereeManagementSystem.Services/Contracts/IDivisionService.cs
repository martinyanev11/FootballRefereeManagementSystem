namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Web.ViewModels.Division;

    public interface IDivisionService
    {
        /// <summary>
        /// Asynchronously adds a specific division and divisions with less difficulty to a referee by their ID.
        /// </summary>
        /// <param name="refereeId">The ID of the referee.</param>
        /// <param name="divisionName">The name of the specific division to add.</param>
        /// <returns>Task representing the asynchronous operation.</returns>
        Task AddDivisionAndDivisionsWithLessDifficultyToRefereeByIdAsync(int refereeId, string divisionName);

        /// <summary>
        /// Adds a new division to the database based on the provided model.
        /// </summary>
        /// <param name="model">The model containing division information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task AddNewDivisionAsync(DivisionFormModel model);

        /// <summary>
        /// Checks if a division with the specified ID exists in the database and is active.
        /// </summary>
        /// <param name="id">The ID of the division to check for existence.</param>
        /// <returns><see langword="true"/> if a division with the specified ID exists and is not deleted, <see langword="false"/> otherwise.</returns>
        Task<bool> CheckDivisionExistanceByIdAsync(int id);

        /// <summary>
        /// Deletes a division with the specified ID by setting its IsActive flag to <see langword="false"/>.
        /// </summary>
        /// <param name="id">The ID of the division to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DeleteDivisionAsync(int id);

        /// <summary>
        /// Determines the best suited division ID for an application based on the candidate's age and experience in years.
        /// </summary>
        /// <param name="candidateAge">The age of the candidate.</param>
        /// <param name="candidateExperienceInYears">The experience in years of the candidate.</param>
        /// <returns>The ID of the best suited division for the application.</returns>
        Task<int> DetermineBestSuitedDivisionForApplicationAsync(int candidateAge, int candidateExperienceInYears);

        /// <summary>
        /// Edits the properties of a division with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the division to edit.</param>
        /// <param name="model">The model containing the new properties of the division.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task EditDivisionAsync(int id, DivisionFormModel model);
        Task<IDictionary<int, string>> GetAllDivisionKeyValuePairs();

        /// <summary>
        /// Asynchronously retrieves all division names from the database.
        /// </summary>
        /// <returns>A collection sequence containing the names of all divisions.</returns>
        Task<IEnumerable<string>> GetAllDivisionNamesAsync();

        /// <summary>
        /// Retrieves all active divisions along with their details.
        /// </summary>
        /// <returns>A collection of <see cref="DivisionAllViewModel"/> representing the active divisions.</returns>
        Task<IEnumerable<DivisionAllViewModel>> GetAllDivisionsAsync();
        Task<IEnumerable<DivisionViewModel>> GetAllDivisionsForRegistrationAsync();

        /// <summary>
        /// Retrieves a specific division's details by its ID.
        /// </summary>
        /// <param name="id">The ID of the division to retrieve.</param>
        /// <returns>A <see cref="DivisionViewModel"/> representing the details of the division.</returns>
        Task<DivisionViewModel> GetDivisionByIdAsync(int id);

        /// <summary>
        /// Retrieves a specific division's details for editing by its ID.
        /// </summary>
        /// <param name="id">The ID of the division to retrieve.</param>
        /// <returns>A <see cref="DivisionFormModel"/> representing the details of the division for editing.</returns>
        Task<DivisionFormModel> GetDivisionForEditByIdAsync(int id);

        /// <summary>
        /// Asynchronously retrieves the name of the division that a referee has officiated the most matches in.
        /// </summary>
        /// <param name="refereeId">The ID of the referee.</param>
        /// <returns>The name of the most officiated division as a string.</returns>
        Task<string> GetNameOfMostOfficiatedDivisionForRefereeByIdAsync(int refereeId);
    }
}
