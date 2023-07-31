namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;

    public class ZoneService : IZoneService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public ZoneService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> CheckZoneExistanceByNameAsync(string zoneName)
        {
            return await this.dbContext.Zones
                .AnyAsync(x => x.Name == zoneName);
        }

        public async Task<IEnumerable<string>> GetAllZoneNamesAsync()
        {
            IEnumerable<string> zoneNames = await this.dbContext
                .Zones
                .AsNoTracking()
                .Select(z => z.Name)
                .ToArrayAsync();

            return zoneNames;
        }

        public async Task<int> GetZoneIdByNameAsync(string zoneName)
        {
            return await this.dbContext
                .Zones
                .AsNoTracking()
                .Where(z => z.Name == zoneName)
                .Select(z => z.Id)
                .FirstAsync();
        }
    }
}
