namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;

    public class DivisionService : IDivisionService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public DivisionService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<string>> GetAllDivisionsAsync()
        {
            IEnumerable<string> divisions = await this.dbContext
                .Divisions
                .AsNoTracking()
                .Select(d => d.Name)
                .ToArrayAsync();

            return divisions;
        }
    }
}
