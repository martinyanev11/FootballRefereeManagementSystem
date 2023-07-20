namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Web.ViewModels.Season;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface ISeasonService
    {
        Task<IEnumerable<string>> GetAllSeasonsAsync();
    }
}
