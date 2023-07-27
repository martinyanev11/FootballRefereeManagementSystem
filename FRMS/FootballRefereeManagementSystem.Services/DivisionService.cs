namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

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

        public async Task<IEnumerable<string>> GetAllDivisionNamesAsync()
        {
            IEnumerable<string> divisions = await this.dbContext
                .Divisions
                .AsNoTracking()
                .Select(d => d.Name)
                .ToArrayAsync();

            return divisions;
        }

        public async Task<string> GetNameOfMostOfficiatedDivisionForRefereeByIdAsync(int refereeId)
        {
            string mostOfficiatedDivision = await this.dbContext
                .RefereesDivisions
                .AsNoTracking()
                .Where(rd => rd.RefereeId == refereeId)
                .OrderByDescending(rd => rd.DivisionMatchesOfficiated)
                .Select(rd => rd.Division.Name)
                .FirstAsync();

            return mostOfficiatedDivision;
        }
    }
}
