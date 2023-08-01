namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Data.Models;
    using Web.ViewModels.Career;

    public class DivisionService : IDivisionService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public DivisionService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddNewDivisionToRefereeByIdAsync(int refereeId, string division)
        {
            RefereeDivision refereeDivision = new RefereeDivision()
            {
                RefereeId = refereeId,
                DivisionId = await GetDivisionIdByNameAsync(division)
            };

            await this.dbContext.RefereesDivisions.AddAsync(refereeDivision);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<int> DetermineBestSuitedDivisionForApplicationAsync(ApplicationFormModel model)
        {
            if (model.Age <= 18)
            {
                // Gets the easiest division for underaged
                return await this.dbContext.Divisions
                    .OrderBy(d => d.Difficulty)
                    .Select(d => d.Id)
                    .FirstAsync();
            }
            else
            {
                if (model.ExperienceInYears <= 2)
                {
                    // Gets the easiest division for inexperienced candidate
                    return await this.dbContext.Divisions
                        .OrderBy(d => d.Difficulty)
                        .Select(d => d.Id)
                        .FirstAsync();
                }
                else if (model.ExperienceInYears <= 10)
                {
                    // Gets the middle division for candidate
                    return await this.dbContext.Divisions
                        .Where(d => d.Difficulty == 3)
                        .Select(d => d.Id)
                        .FirstAsync();
                }
                else
                {
                    // Gets the hardest division for experienced candidate
                    return await this.dbContext.Divisions
                        .OrderByDescending(d => d.Difficulty)
                        .Select(d => d.Id)
                        .FirstAsync();
                }
            }
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

        //------------------------------------------
        // Helper methods
        //------------------------------------------

        private async Task<int> GetDivisionIdByNameAsync(string divisionName)
        {
            return await this.dbContext.Divisions
                .Where(d => d.Name == divisionName)
                .Select(d => d.Id)
                .FirstAsync();
        }
    }
}
