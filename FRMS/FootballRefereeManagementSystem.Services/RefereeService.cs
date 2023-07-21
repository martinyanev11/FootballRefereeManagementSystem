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

    public class RefereeService : IRefereeService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public RefereeService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private string TranslateRole(string role)
        {
            switch (role)
            {
                case "Referee":
                    role = "Главен съдия";
                    break;
                case "AssistantReferee":
                    role = "Асистент съдия";
                    break;
                case "Delegate":
                    role = "Делегат";
                    break;
                case "Administration":
                    role = "Администрация";
                    break;
            }

            return role;
        }

        public async Task<IEnumerable<RefereeViewModel>> GetAllRefereesFilteredAsync(RefereeQueryModel queryModel)
        {
            IQueryable<Referee> refereesAsQueryable = this.dbContext
                .Referees
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
                refModel.Role = TranslateRole(refModel.Role);
                //switch (refModel.Role)
                //{
                //    case "Referee":
                //        refModel.Role = "Главен съдия";
                //        break;
                //    case "AssistantReferee":
                //        refModel.Role = "Асистент съдия";
                //        break;
                //    case "Delegate":
                //        refModel.Role = "Делегат";
                //        break;
                //    case "Administration":
                //        refModel.Role = "Администрация";
                //        break;
                //}
            }

            return refereeViewModels;
        }

        public async Task<RefereeDetailsViewModel> GetRefereeDetailsByIdAsync(int id)
        {
            RefereeDetailsViewModel viewModel = await this.dbContext.Referees
                .Include(r => r.Town)
                .Include(r => r.RefereeDivisions)
                .AsNoTracking()
                .Where(r => r.Id == id)
                .Select(r => new RefereeDetailsViewModel()
                {
                    FullName = $"{r.FirstName} {r.LastName}",
                    Age = r.Age,
                    ImageUrl = r.ImageUrl!,
                    Contact = r.Contact,
                    Role = r.Role.ToString(),
                    CareerStart = r.CareerStart,
                    TotalMatchesOfficiated = r.TotalMatchesOfficiated,
                    Town = r.Town.Name,
                    DivisionsAndMatchesCount = r.RefereeDivisions
                        .Select(rd => 
                            new Tuple<string, int>(rd.Division.Name, rd.DivisionMatchesOfficiated))
                        .ToHashSet()
                })
                .FirstAsync();

            viewModel.Role = TranslateRole(viewModel.Role);

            return viewModel;
        }

        public async Task<int> GetRefereeIdByUserId(string userId)
        {
            return await this.dbContext.Referees
                .Where(r => r.UserId.ToString() == userId)
                .Select(r => r.Id)
                .FirstOrDefaultAsync();
        }
    }
}