namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Threading.Tasks;

    public interface ITownService
    {
        Task AddNewTownAsync(string townName, int zoneId);
        Task<bool> CheckTownExistanceByNameAsync(string townName);
        Task<int> GetTownIdByNameAsync(string town);
    }
}
