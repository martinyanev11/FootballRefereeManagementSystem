namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IZoneService
    {
        Task<bool> CheckZoneExistanceByNameAsync(string zoneName);
        Task<IEnumerable<string>> GetAllZoneNamesAsync();
        Task<int> GetZoneIdByNameAsync(string zoneName);
    }
}
