namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using Data;
    using Contracts;
    using Web.ViewModels.Referee;

    public class RefereeService : IRefereeService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public RefereeService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<RefereeViewModel>> GetAllRefereesAsync()
        {
            IEnumerable<RefereeViewModel> refereeViewModels = await this.dbContext.Referees
                .AsNoTracking()
                .Select(r => new RefereeViewModel()
                {
                    Id = r.Id,
                    FullName = $"{r.FirstName} {r.LastName}",
                    Role = r.Role.ToString(),
                    CareerStart = r.CareerStart,
                    TotalMatchesOfficiated = r.TotalMatchesOfficiated,
                })
                .ToArrayAsync();

            foreach (var refModel in refereeViewModels)
            {
                switch (refModel.Role)
                {
                    case "Referee":
                        refModel.Role = "Главен съдия";
                        break;
                    case "AssistantReferee":
                        refModel.Role = "Асистент съдия";
                        break;
                    case "Delegate":
                        refModel.Role = "Делегат";
                        break;
                    case "Administration":
                        refModel.Role = "Администрация";
                        break;
                }
            }

            return refereeViewModels;
        }
    }
}
