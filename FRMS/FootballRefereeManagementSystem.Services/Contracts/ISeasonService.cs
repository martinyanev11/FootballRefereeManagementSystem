namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;

    public interface ISeasonService
    {
        Task<IEnumerable<string>> GetAllSeasonsAsync();
        Task<string> GetCurrentSeasonDescriptionAsync();
    }
}
