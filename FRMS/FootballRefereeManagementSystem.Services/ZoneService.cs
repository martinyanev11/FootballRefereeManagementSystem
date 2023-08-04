namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Data.Models;
    using Web.ViewModels.Zone;

    public class ZoneService : IZoneService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public ZoneService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddNewZoneAsync(ZoneFormModel model)
        {
            Zone zoneToAdd = new Zone()
            {
                Name = model.Name,
            };

            await this.dbContext.Zones.AddAsync(zoneToAdd);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckZoneExistanceByIdAsync(int id)
        {
            return await this.dbContext.Zones
                .AnyAsync(z => z.Id == id && z.IsActive);
        }

        public async Task<bool> CheckZoneExistanceByNameAsync(string zoneName)
        {
            return await this.dbContext.Zones
                .AnyAsync(x => x.Name == zoneName);
        }

        public async Task DeleteZoneAsync(int id)
        {
            Zone zoneToDelete = await this.dbContext.Zones
                .Where(z => z.Id == id)
                .FirstAsync();

            zoneToDelete.IsActive = false;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditZoneAsync(int id, ZoneFormModel model)
        {
            Zone zoneToEdit = await this.dbContext
                .Zones
                .Where(z => id == z.Id && z.IsActive)
                .FirstAsync();

            zoneToEdit.Name = model.Name;
            await this.dbContext.SaveChangesAsync();
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

        public async Task<IEnumerable<ZoneViewModel>> GetAllZonesAsync()
        {
            IEnumerable<ZoneViewModel> zones = await this.dbContext
                .Zones
                .Where(z => z.IsActive)
                .AsNoTracking()
                .Select(z => new ZoneViewModel
                { 
                    Id = z.Id, 
                    Name = z.Name,
                    TownsCount = z.Towns.Count
                })
                .ToArrayAsync();

            return zones;
        }

        public async Task<ZoneViewModel> GetZoneByIdAsync(int id)
        {
            return await this.dbContext
                .Zones
                .Where(z => z.Id == id && z.IsActive)
                .Select(z => new ZoneViewModel 
                { 
                    Id = z.Id,
                    Name = z.Name,
                    TownsCount = z.Towns.Count
                })
                .FirstAsync();
        }

        public async Task<ZoneFormModel> GetZoneForEditByIdAsync(int id)
        {
            return await this.dbContext
                .Zones
                .Where(z => z.IsActive && z.Id == id)
                .Select(z => new ZoneFormModel()
                {
                    Name = z.Name,
                })
                .FirstAsync();
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
