namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    
    using Contracts;
    using Data;
    using FootballRefereeManagementSystem.Data.Models;

    public class TownService : ITownService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public TownService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddNewTownAsync(string townName, int zoneId)
        {
            Town newTown = new Town()
            {
                Name = townName,
                ZoneId = zoneId
            };

            await this.dbContext.Towns.AddAsync(newTown);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckTownExistanceByNameAsync(string townName)
        {
            return await this.dbContext.Towns
                .AnyAsync(t => t.Name == townName);
        }

        public async Task<int> GetTownIdByNameAsync(string townName)
        {
            return await this.dbContext.Towns
                .Where(t => t.Name == townName)
                .Select(t => t.Id)
                .FirstAsync();
        }
    }
}
