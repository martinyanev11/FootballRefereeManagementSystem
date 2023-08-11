namespace FootballRefereeManagementSystem.Services
{
    using System.Data;
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
    using Services.Models.Referee;

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

            // Filter by search string
            if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString.ToLower()}%";

                refereesAsQueryable = refereesAsQueryable
                    .Where(r => 
                        EF.Functions.Like(r.FirstName!, wildCard) ||
                        EF.Functions.Like(r.LastName!, wildCard));
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
                    RefereeId = r.Id,
                    FullName = $"{r.FirstName} {r.LastName}",
                    Age = (int)r.Age!,
                    ImageUrl = r.ImageUrl!,
                    Role = r.Role.ToString(),
                    CareerStart = r.CareerStart,
                    Contact = r.User.PhoneNumber,
                    TotalMatchesOfficiated = r.TotalMatchesOfficiated,
                    DivisionsAndMatchesCount = r.RefereeDivisions
                        .Where(rd => rd.IsActive)
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
            if (model.Age < HigherRoleAgeLimit)
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

        public async Task<string> GetUserIdByRefereeIdAsync(int id)
        {
            return await this.dbContext.Referees
                .Where(r => r.Id == id && r.IsActive)
                .Select(r => r.UserId.ToString())
                .FirstAsync();
        }

        public async Task DeleteRefereeAsync(int? refereeId)
        {
            Referee refereeToDelete = await this.dbContext
                .Referees
                .Where(r => r.Id == refereeId)
                .FirstAsync();

            refereeToDelete.FirstName = null;
            refereeToDelete.LastName = null;
            refereeToDelete.Age = null;
            refereeToDelete.ImageUrl = null;
            refereeToDelete.IsAvaliable = false;
            refereeToDelete.IsActive = false;

            foreach (RefereeDivision refereeDivision in refereeToDelete.RefereeDivisions)
            {
                refereeDivision.IsActive = false;
            }

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<RefereeServiceModel> GetRefereeProfileDataByUserIdAsync(string userId)
        {
            return await this.dbContext
                .Referees
                .Where(r => r.UserId.ToString() == userId)
                .Select(r => new RefereeServiceModel()
                {
                    FirstName = r.FirstName!,
                    LastName = r.LastName!,
                    ImageUrl = r.ImageUrl!
                })
                .FirstAsync();
        }

        public async Task UpdateRefereeData(RefereeServiceModel newRefereeData, string userId)
        {
            Referee refereeToUpdate = await this.dbContext
                .Referees
                .Where(r => r.UserId.ToString() == userId)
                .FirstAsync();

            refereeToUpdate.FirstName = newRefereeData.FirstName;
            refereeToUpdate.LastName = newRefereeData.LastName;
            refereeToUpdate.ImageUrl = newRefereeData.ImageUrl;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<RefereeEditFormModel> GetRefereeForEditByIdAsync(int id)
        {
            RefereeEditFormModel model = await this.dbContext
                .Referees
                .Where(r => r.IsActive && r.Id == id)
                .Select(r => new RefereeEditFormModel()
                {
                    UserId = r.UserId.ToString(),
                    FirstName = r.FirstName!,
                    LastName = r.LastName!,
                    ImageUrl = r.ImageUrl!,
                    Role = r.Role.ToString(),
                    CurrentDivisionIds = r.RefereeDivisions
                        .Where(rd => rd.IsActive)
                        .Select(rd => rd.DivisionId)
                        .ToArray()
                })
                .FirstAsync();

            model.Roles = Translator.GetAllRolesTranslated();
            model.Role = Translator.TranslateRoleToBulgarian(model.Role);
            return model;
        }

        public async Task EditRefereeByIdAsync(int id, RefereeEditFormModel model)
        {
            Referee refereeToEdit = await this.dbContext
                .Referees
                .Where(r => id == r.Id)
                .Include(r => r.RefereeDivisions
                    .Where(rd => rd.IsActive))
                .FirstAsync();

            refereeToEdit.FirstName = model.FirstName;
            refereeToEdit.LastName = model.LastName;
            refereeToEdit .ImageUrl = model.ImageUrl;
            refereeToEdit.Role = Enum.Parse<Role>(Translator.TranslateRoleToEnglish(model.Role));

            foreach (int divId in model.SelectedDivisionIds)
            {
                // If the referee doesn't have this division we need add it
                if (!refereeToEdit.RefereeDivisions
                    .Any(rd => rd.IsActive && rd.DivisionId == divId))
                {

                    // Check if this referee was officiating in this division before but is no longer active
                    RefereeDivision? refereeDivision = await this.dbContext
                        .RefereesDivisions
                        .Where(rd => rd.RefereeId == id && rd.DivisionId == divId)
                        .FirstOrDefaultAsync();

                    // If RefereeDivision exists but is not active
                    if (refereeDivision is not null)
                    {
                        refereeDivision.IsActive = true;
                    }
                    // Else we create brand new entity
                    else
                    {
                        refereeDivision = new RefereeDivision()
                        {
                            DivisionId = divId,
                            RefereeId = id
                        };

                        await this.dbContext.RefereesDivisions.AddAsync(refereeDivision);
                    }
                }
            }

            // If the count is different some divisions were removed from this referee.
            if (refereeToEdit.RefereeDivisions.Count != model.SelectedDivisionIds.Count())
            {
                List<int> removedDivisionIds = refereeToEdit.RefereeDivisions
                    .Where(rd => !model.SelectedDivisionIds.Contains(rd.DivisionId))
                    .Select(rd => rd.DivisionId)
                    .ToList();

                // Remove the corresponding RefereeDivisions from the database.
                foreach (int divId in removedDivisionIds)
                {
                    RefereeDivision? removedRefereeDivision = refereeToEdit.RefereeDivisions
                        .FirstOrDefault(rd => rd.DivisionId == divId);

                    if (removedRefereeDivision is not null)
                    {
                        removedRefereeDivision.IsActive = false;
                    }
                }
            }

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<RefereesStatisticsViewModel> GetRefereesStatisticsAsync()
        {
            IQueryable<Referee> refereeQueriable = this.dbContext
                .Referees
                .AsNoTracking()
                .Where(r => r.IsActive)
                .AsQueryable();

            RefereesStatisticsViewModel refStats = new RefereesStatisticsViewModel()
            {
                RefereesTotalCount = await refereeQueriable.CountAsync(),
                CurrentlyAvaliableReferees = await refereeQueriable
                    .Where(r => r.IsAvaliable)
                    .CountAsync(),
                MainRefereesCount = await refereeQueriable
                    .Where(r => r.Role == Role.Referee)
                    .CountAsync(),
                AssistantRefereesCount = await refereeQueriable
                    .Where(r => r.Role == Role.AssistantReferee)
                    .CountAsync(),
                DelegatesCount = await refereeQueriable
                    .Where(r => r.Role == Role.Delegate)
                    .CountAsync(),
                AdministrationCount = await refereeQueriable
                    .Where(r => r.Role == Role.Administration)
                    .CountAsync(),
                AverageRefereesAge = (int)await refereeQueriable
                    .AverageAsync(r => r.Age)
            };

            refStats.Roles = Translator.GetAllRolesTranslated();
            return refStats;
        }

        public async Task<IEnumerable<RefereeListModel>> GetAllAvaliableInDivisionRefereesOfRoleType
            (int divisionId, string roleType)
        {
            return await this.dbContext
                .Referees
                .Where(r =>
                    r.IsAvaliable && 
                    r.IsActive &&
                    r.RefereeDivisions
                        .Any(rd => rd.DivisionId == divisionId) &&
                    r.Role == Enum.Parse<Role>(roleType))
                .Select(r => new RefereeListModel()
                {
                    Id = r.Id,
                    FullName = $"{r.FirstName} {r.LastName}",
                })
                .ToArrayAsync();
        }

        public async Task<Guid> CreateRefereeSquad(int id, RefereeSquadFormModel model)
        {
            RefereeSquad newSquad = new RefereeSquad()
            {
                MainRefereeId = model.MainRefereeId,
                FirstAssistantRefereeId = model.AssistantRefereeOneId,
                SecondAssistantRefereeId = model.AssistantRefereeTwoId,
                DelegateId = model.DelegateId,
                MatchId = id
            };

            await this.dbContext.RefereesSquads.AddAsync(newSquad);
            await this.dbContext.SaveChangesAsync();

            return newSquad.Id;
        }

        public async Task<bool> CheckRefereeSquadExistanceByIdAsync(string id)
        {
            return await this.dbContext.RefereesSquads
                .AnyAsync(rs => rs.Id.ToString() == id);
        }

        public async Task<RefereeSquadEditModel> GetRefereeSquadForEditByIdAsync(string id)
        {
            RefereeSquadEditModel refereeSquad = await this.dbContext
                .RefereesSquads
                .Where(rs => rs.Id.ToString() == id)
                .Select(rs => new RefereeSquadEditModel()
                {
                    MainRefereeId = rs.MainRefereeId,
                    MainRefereeName = $"{rs.MainReferee.FirstName} {rs.MainReferee.LastName}",
                    AssistantRefereeOneId = rs.FirstAssistantRefereeId,
                    AssistantRefereeOneName = $"{rs.FirstAssistantReferee.FirstName} {rs.FirstAssistantReferee.LastName}",
                    AssistantRefereeTwoId = rs.SecondAssistantRefereeId,
                    AssistantRefereeTwoName = $"{rs.SecondAssistantReferee.FirstName} {rs.SecondAssistantReferee.LastName}",
                    DelegateId = rs.DelegateId,
                    DelegateName = $"{rs.Delegate.FirstName} {rs.Delegate.LastName}",
                    DivisionId = rs.Match.DivisionId
                })
            .FirstAsync();

            refereeSquad.MainRefereesList = await GetAllAvaliableInDivisionRefereesOfRoleType(refereeSquad.DivisionId, Role.Referee.ToString());
            refereeSquad.AssistantRefereesList = await GetAllAvaliableInDivisionRefereesOfRoleType(refereeSquad.DivisionId, Role.AssistantReferee.ToString());
            refereeSquad.DelegatesList = await GetAllAvaliableInDivisionRefereesOfRoleType(refereeSquad.DivisionId, Role.Delegate.ToString());

            return refereeSquad;
        }

        public async Task EditRefereeSquadAsync(string id, RefereeSquadEditModel model)
        {
            RefereeSquad refereeSquadToEdit = await this.dbContext
                .RefereesSquads
                .Where(rs => rs.Id.ToString() == id)
                .FirstAsync();

            refereeSquadToEdit.MainRefereeId = model.MainRefereeId;
            refereeSquadToEdit.FirstAssistantRefereeId = model.AssistantRefereeOneId;
            refereeSquadToEdit.SecondAssistantRefereeId = model.AssistantRefereeTwoId;
            refereeSquadToEdit.DelegateId = model.DelegateId;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task UpdateCurrentlyAppointedMatchesCount(int refereeId)
        {
            Referee refereeToUpdate = await this.dbContext
                .Referees
                .Where(r => r.Id ==  refereeId)
                .FirstAsync();

            int currentlyAppointedMatchesCount = await this.dbContext
                .RefereesSquads
                .Where(rs => rs.Match.HasFinished == false &&
                    rs.MainRefereeId == refereeId ||
                    rs.FirstAssistantRefereeId == refereeId ||
                    rs.SecondAssistantRefereeId == refereeId ||
                    rs.DelegateId == refereeId)
                .CountAsync();

            refereeToUpdate.CurrentlyAppointedMatchesCount = currentlyAppointedMatchesCount;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<RefereeSquadMatchCenterModel> GetRefereeSquadForMatchCenterAsync(string id)
        {
            return await this.dbContext
                .RefereesSquads
                .Where(rs => rs.Id.ToString() == id)
                .Select(rs => new RefereeSquadMatchCenterModel()
                {
                    Id = rs.Id.ToString(),
                    MainRefereeName = $"{rs.MainReferee.FirstName} {rs.MainReferee.LastName}",
                    MainRefereeContact = rs.MainReferee.User.PhoneNumber,
                    FirstARName = $"{rs.FirstAssistantReferee.FirstName} {rs.FirstAssistantReferee.LastName}",
                    FirstARContact = rs.FirstAssistantReferee.User.PhoneNumber,
                    SecondARName = $"{rs.SecondAssistantReferee.FirstName} {rs.SecondAssistantReferee.LastName}",
                    SecondARContact = rs.SecondAssistantReferee.User.PhoneNumber,
                    DelegateName = $"{rs.Delegate.FirstName} {rs.Delegate.LastName}",
                    DelegateContact = rs.Delegate.User.PhoneNumber,
                })
                .FirstAsync();
        }

        public async Task<int[]> GetAllRefereeIdsFromRefereeSquad(string id)
        {
            return await this.dbContext
                .RefereesSquads
                .Where(rs => rs.Id.ToString().ToLower() == id.ToLower())
                .Select(rs => new int[]
                {
                    rs.MainRefereeId,
                    rs.FirstAssistantRefereeId,
                    rs.SecondAssistantRefereeId,
                    rs.DelegateId
                })
                .FirstAsync();
        }

        public async Task IncrementRefereeDivisionMatchCountStats(int matchDivisionId, int[] refereeIds)
        {
            foreach (int refId in refereeIds)
            {
                RefereeDivision refereeToUpdate = await this.dbContext
                    .RefereesDivisions
                    .Where(rd => rd.IsActive &&
                        rd.RefereeId == refId && 
                        rd.DivisionId == matchDivisionId)
                    .FirstAsync();

                refereeToUpdate.DivisionMatchesOfficiated++;
            }

            await this.dbContext.SaveChangesAsync();
        }
    }
}