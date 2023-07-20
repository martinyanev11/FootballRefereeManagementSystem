namespace FootballRefereeManagementSystem.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDivisionService
    {
        Task<IEnumerable<string>> GetAllDivisionsAsync();
    }
}
