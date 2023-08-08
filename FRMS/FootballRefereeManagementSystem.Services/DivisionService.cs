namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data;
    using Data.Models;
    using Web.ViewModels.Career;
    using Web.ViewModels.Division;
    using System;

    public class DivisionService : IDivisionService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        private const int HigherDivisionsAgeLimit = 18; // users younger than that are placed in lowest division
        private const int LowDivisionsExperienceRequirement = 2;
        private const int MidDivisionsExperienceRequirement = 10;

        public DivisionService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddDivisionAndDivisionsWithLessDifficultyToRefereeByIdAsync(int refereeId, string divisionName)
        {
            Division division = await this.GetDivisionByNameAsync(divisionName);

            IEnumerable<Division> divisionsToAdd = await this.dbContext
                .Divisions
                .Where(d => d.Difficulty <= division.Difficulty && d.IsActive)
                .Select(d => d)
                .ToArrayAsync();

            foreach (Division div in divisionsToAdd)
            {
                RefereeDivision refereeDivision = new RefereeDivision()
                {
                    RefereeId = refereeId,
                    DivisionId = div.Id
                };

                await this.dbContext.RefereesDivisions.AddAsync(refereeDivision);
            }
            
            await this.dbContext.SaveChangesAsync();
        }

        public async Task AddNewDivisionAsync(DivisionFormModel model)
        {
            Division division = new Division()
            {
                Name = model.Name,
                Difficulty = model.Difficulty,
            };

            await this.dbContext.AddAsync(division);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckDivisionExistanceByIdAsync(int id)
        {
            return await this.dbContext.Divisions
                .Where(d => d.IsActive)
                .AnyAsync(d => d.Id == id);
        }

        public async Task DeleteDivisionAsync(int id)
        {
            Division divisionToDelete = await GetDivisionAsync(id);

            divisionToDelete.IsActive = false;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<int> DetermineBestSuitedDivisionForApplicationAsync(int candidateAge, int candidateExperienceInYears)
        {
            if (candidateAge <= HigherDivisionsAgeLimit)
            {
                // Gets the easiest division for underaged
                return await this.dbContext.Divisions
                    .OrderBy(d => d.Difficulty)
                    .Select(d => d.Id)
                    .FirstAsync();
            }
            else
            {
                if (candidateExperienceInYears <= LowDivisionsExperienceRequirement)
                {
                    // Gets the easiest division for inexperienced candidate
                    return await this.dbContext.Divisions
                        .OrderBy(d => d.Difficulty)
                        .Select(d => d.Id)
                        .FirstAsync();
                }
                else if (candidateExperienceInYears <= MidDivisionsExperienceRequirement)
                {
                    // Gets the middle division for candidate
                    int averageDivisionDifficulty = await GetMidDivisionDifficultyAsync();

                    return await this.dbContext.Divisions
                        .Where(d => d.Difficulty == averageDivisionDifficulty)
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

        public async Task EditDivisionAsync(int id, DivisionFormModel model)
        {
            Division divisionToEdit = await GetDivisionAsync(id);

            divisionToEdit.Name = model.Name;
            divisionToEdit.Difficulty = model.Difficulty;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<string>> GetAllDivisionNamesAsync()
        {
            IEnumerable<string> divisions = await this.dbContext
                .Divisions
                .AsNoTracking()
                .Where(d => d.IsActive)
                .Select(d => d.Name)
                .ToArrayAsync();

            return divisions;
        }

        public async Task<IEnumerable<DivisionAllViewModel>> GetAllDivisionsAsync()
        {
            IEnumerable<DivisionAllViewModel> divisions = await this.dbContext
                .Divisions
                .AsNoTracking()
                .Where(d => d.IsActive)
                .Select(d => new DivisionAllViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Difficulty = d.Difficulty,
                    RefereesCount = d.DivisionReferees.Count
                })
                .ToArrayAsync();

            return divisions;
        }

        public async Task<DivisionFormModel> GetDivisionForEditByIdAsync(int id)
        {
            return await this.dbContext.Divisions
                .Where(d => d.Id == id && d.IsActive)
                .Select(d => new DivisionFormModel()
                {
                    Name = d.Name,
                    Difficulty = d.Difficulty,
                })
                .FirstAsync();
        }

        public async Task<string> GetNameOfMostOfficiatedDivisionForRefereeByIdAsync(int refereeId)
        {
            string mostOfficiatedDivision = await this.dbContext
                .RefereesDivisions
                .AsNoTracking()
                .Where(rd => rd.RefereeId == refereeId && rd.Division.IsActive)
                .OrderByDescending(rd => rd.DivisionMatchesOfficiated)
                .Select(rd => rd.Division.Name)
                .FirstAsync();

            return mostOfficiatedDivision;
        }

        public async Task<DivisionViewModel> GetDivisionByIdAsync(int id)
        {
            return await this.dbContext.Divisions
                .Where(d => d.Id == id && d.IsActive)
                .Select(d => new DivisionViewModel()
                {
                    Id = id,
                    Name = d.Name,
                })
                .FirstAsync();
        }

        public async Task<IDictionary<int, string>> GetAllDivisionKeyValuePairs()
        {
            Dictionary<int, string> divisions = await this.dbContext
                .Divisions
                .Where(d => d.IsActive)
                .AsNoTracking()
                .Select(d => new { d.Id, d.Name })
                .ToDictionaryAsync(d => d.Id, d => d.Name);

            return divisions;
        }

        public async Task<IEnumerable<DivisionViewModel>> GetAllDivisionsForRegistrationAsync()
        {
            return await this.dbContext
                .Divisions
                .Where(d => d.IsActive)
                .Select(d => new DivisionViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                })
                .ToArrayAsync();
        }

        //------------------------------------------
        // private methods
        //------------------------------------------

        private async Task<Division> GetDivisionByNameAsync(string divisionName)
        {
            return await this.dbContext.Divisions
                .Where(d => d.Name == divisionName && d.IsActive)
                .Select(d => d)
                .FirstAsync();
        }

        private async Task<Division> GetDivisionAsync(int divisionId)
        {
            return await this.dbContext.Divisions
                .Where(d => d.Id == divisionId && d.IsActive)
                .FirstAsync();
        }

        /// <summary>
        /// Since only administrators add Divisions it is assumed divisions difficulty values are consecutive.
        /// </summary>
        /// <returns>Average division difficulty</returns>
        private async Task<int> GetMidDivisionDifficultyAsync()
        {
            int totalDivisionsCount = await this.dbContext
                .Divisions
                .Where(d => d.IsActive)
                .CountAsync();

            // If only 2 divisions exist, we take the lower value
            if (totalDivisionsCount <= 2)
            {
                return await this.dbContext.Divisions
                    .Where(d => d.IsActive)
                    .OrderBy(d => d.Difficulty)
                    .Select(d => d.Difficulty)
                    .FirstAsync();
            }

            int[] difficulties = await this.dbContext.Divisions
                    .Where(d => d.IsActive)
                    .Select(d => d.Difficulty)
                    .ToArrayAsync();

            int divisionsDifficultySum = difficulties.Sum();
            double averageDifficulty = (double)divisionsDifficultySum / (double)totalDivisionsCount;

            // If we have even number of divisions it is given the lower average real number value
            if (totalDivisionsCount % 2 == 0)
            {
                return (int)Math.Floor(averageDifficulty);
            }

            return (int)averageDifficulty;
        }
    }
}
