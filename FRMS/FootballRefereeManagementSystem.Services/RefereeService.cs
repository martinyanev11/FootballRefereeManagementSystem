namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using Data;
    using Data.Models;
    using Data.Models.Enums;
    using Contracts;
    using Web.ViewModels.Referee;
    using Web.ViewModels.Referee.Enums;
    using Web.ViewModels.RefereeSquad;
    using Web.ViewModels.Career;
    using Services.Common;

    public class RefereeService : IRefereeService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        private const int HigherRoleAgeLimit = 18; // users younger than that this are assigned as AR.
        private const int RoleExperienceRequirement = 2;
        private const int HighRoleExperienceRequirement = 10;

        public RefereeService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> CheckRefereeExistanceByIdAsync(int id)
        {
            return await this.dbContext.Referees
                .AnyAsync(r => r.Id == id && r.IsActive);
        }

        public async Task<IEnumerable<RefereeViewModel>> GetAllRefereesFilteredAsync(RefereeQueryModel queryModel)
        {
            IQueryable<Referee> refereesAsQueryable = this.dbContext
                .Referees
                .Where(r => r.IsActive)
                .AsQueryable();

            // Filter by checkboxes
            // Check which boxes are checked
            List<Role> checkedRoles = new List<Role>();
            if (queryModel.IsCheckedReferee)
            {
                checkedRoles.Add(Role.Referee);
            }
            if (queryModel.IsCheckedAssistantReferee)
            {
                checkedRoles.Add(Role.AssistantReferee);
            }
            if (queryModel.IsCheckedDelegate)
            {
                checkedRoles.Add(Role.Delegate);
            }
            if (queryModel.IsCheckedAdministration)
            {
                checkedRoles.Add(Role.Administration);
            }

            if (checkedRoles.Any())
            {
                refereesAsQueryable = refereesAsQueryable.
                    Where(r => checkedRoles.Contains(r.Role));
            }
            
            // Order by selected option for name sorting
            switch (queryModel.NameSortingOrder)
            {
                case RefereeNameSortingOrder.AZ:
                    refereesAsQueryable = refereesAsQueryable
                        .OrderBy(r => r.FirstName)
                        .ThenBy(r => r.LastName);
                    break;
                case RefereeNameSortingOrder.ZA:
                    refereesAsQueryable = refereesAsQueryable
                        .OrderByDescending(r => r.FirstName)
                        .ThenByDescending(r => r.LastName);
                    break;
            }

            // Order by selected option for experience sorting
            switch (queryModel.ExperienceSortingOrder)
            {
                case RefereeExperienceSortingOrder.Newest:
                    refereesAsQueryable = refereesAsQueryable
                        .OrderByDescending(r => r.CareerStart);
                    break;
                case RefereeExperienceSortingOrder.Oldest:
                    refereesAsQueryable = refereesAsQueryable
                        .OrderBy(r => r.CareerStart);
                    break;
            }

            // Order by selected option for matches count sorting
            switch (queryModel.MatchCountSortingOrder)
            {
                case RefereeMatchCountSortingOrder.Least:
                    refereesAsQueryable = refereesAsQueryable
                        .OrderBy(r => r.TotalMatchesOfficiated);
                    break;
                case RefereeMatchCountSortingOrder.Most:
                    refereesAsQueryable = refereesAsQueryable
                        .OrderByDescending(r => r.TotalMatchesOfficiated);
                    break;
            }

            IEnumerable<RefereeViewModel> refereeViewModels = await refereesAsQueryable
                .Select(r => new RefereeViewModel()
                {
                    Id = r.Id,
                    FullName = $"{r.FirstName} {r.LastName}",
                    Role = r.Role.ToString(),
                    CareerStart = r.CareerStart,
                    TotalMatchesOfficiated = r.TotalMatchesOfficiated,
                })
                .ToArrayAsync();

            // This is to translate the enums
            foreach (var refModel in refereeViewModels)
            {
                refModel.Role = Translator.TranslateRoleToBulgarian(refModel.Role);
            }

            return refereeViewModels;
        }

        public async Task<IEnumerable<RefereeSquadViewModel>> GetAllActiveRefereeSquadsAsync()
        {
            IEnumerable<RefereeSquadViewModel> refereeSquads = await this.dbContext
                .RefereesSquads
                .AsNoTracking()
                .Where(rs => rs.Match.HasFinished == false)
                .Select(rs => new RefereeSquadViewModel()
                {
                    MainRefereeFullName = $"{rs.MainReferee.FirstName} {rs.MainReferee.LastName}",
                    AssistantRefereeOneFullName = $"{rs.FirstAssistantReferee.FirstName} {rs.FirstAssistantReferee.LastName}",
                    AssistantRefereeTwoFullName = $"{rs.SecondAssistantReferee.FirstName} {rs.SecondAssistantReferee.LastName}",
                    DelegateFullName = $"{rs.Delegate.FirstName} {rs.Delegate.LastName}",
                    RefereeSquadId = rs.Id.ToString(),
                    RefereeIds = new HashSet<int>()
                    {
                        rs.MainRefereeId,
                        rs.FirstAssistantRefereeId,
                        rs.SecondAssistantRefereeId,
                        rs.DelegateId
                    }
                })
                .ToArrayAsync();

            return refereeSquads;
        }

        public async Task<RefereeDetailsViewModel> GetRefereeDetailsByIdAsync(int id)
        {
            RefereeDetailsViewModel viewModel = await this.dbContext.Referees
                .Include(r => r.RefereeDivisions)
                .AsNoTracking()
                .Where(r => r.Id == id && r.IsActive)
                .Select(r => new RefereeDetailsViewModel()
                {
                    FullName = $"{r.FirstName} {r.LastName}",
                    Age = r.Age,
                    ImageUrl = r.ImageUrl!,
                    Role = r.Role.ToString(),
                    CareerStart = r.CareerStart,
                    TotalMatchesOfficiated = r.TotalMatchesOfficiated,
                    DivisionsAndMatchesCount = r.RefereeDivisions
                        .Select(rd => 
                            new Tuple<string, int>(rd.Division.Name, rd.DivisionMatchesOfficiated))
                        .ToHashSet()
                })
                .FirstAsync();

            viewModel.Role = Translator.TranslateRoleToBulgarian(viewModel.Role);

            return viewModel;
        }

        public async Task<int> GetRefereeIdByUserIdAsync(string userId)
        {
            return await this.dbContext.Referees
                .Where(r => r.UserId.ToString() == userId)
                .Select(r => r.Id)
                .FirstOrDefaultAsync();
        }

        public async Task CreateNewRefereeAsync(RefereeFormModel model)
        {
            model.StartingRole = Translator.TranslateRoleToEnglish(model.StartingRole);

            Referee newReferee = new Referee()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age,
                ImageUrl = model.ImageUrl,
                Role = (Role)Enum.Parse(typeof(Role), model.StartingRole),
                UserId = Guid.Parse(model.UserId)
            };

            await this.dbContext.Referees.AddAsync(newReferee);
            await this.dbContext.SaveChangesAsync();
        }

        public int DetermineBestSuitedRoleForApplication(ApplicationFormModel model)
        {
            if (model.Age <= HigherRoleAgeLimit)
            {
                return (int)Role.AssistantReferee;
            }
            else
            {
                if (model.ExperienceInYears <= RoleExperienceRequirement)
                {
                    return (int)Role.AssistantReferee;
                }
                else if (model.ExperienceInYears <= HighRoleExperienceRequirement)
                {
                    return (int)Role.Referee;
                }
                else
                {
                    return (int)Role.Delegate;
                }
            }
        }

        public async Task<string> GetUserIdByRefereeId(int id)
        {
            return await this.dbContext.Referees
                .Where(r => r.Id == id && r.IsActive)
                .Select(r => r.UserId.ToString())
                .FirstAsync();
        }
    }
}