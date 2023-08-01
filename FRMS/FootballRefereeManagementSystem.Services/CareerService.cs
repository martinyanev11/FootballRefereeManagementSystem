namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Data;
    using Data.Models;
    using Data.Models.Enums;
    using Contracts;
    using Web.ViewModels.Career;
    using Web.ViewModels.Career.Enums;
    using Services.Common;

    public class CareerService : ICareerService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public CareerService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddApplicationAsync(ApplicationFormModel model)
        {
            Application application = new Application()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Age = model.Age,
                Contact = model.Contact,
                ExperienceInYears = model.ExperienceInYears,
                StartingRole = (Role)model.Role,
                StartingDivisionId = model.DivisionId
            };

            await dbContext.Applications.AddAsync(application);
            await dbContext.SaveChangesAsync();
        }

        public async Task ChangeApplicationStatusAsync(string newStatus, string applicationId)
        {
            Application application = await this.dbContext.Applications
                .Where(a => a.Id.ToString() == applicationId)
                .FirstAsync();

            if (StatusSorting.Approved.ToString() == newStatus)
            {
                application.Status = Status.Approved;
            }
            else
            {
                application.Status = Status.Declined;
            }

            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckApplicationExistanceByIdAsync(string id)
        {
            return await this.dbContext.Applications
                .AnyAsync(a => a.Id.ToString() == id);
        }

        public async Task<bool> ConfirmRegistrationLinkAsync(string id)
        {
            bool result = await this.dbContext.Applications
                .AnyAsync(a => a.IsRegistered == false && a.Id.ToString() == id);

            return result;
        }

        public async Task<IEnumerable<ApplicationViewModel>> GetAllApplicationsFilteredAsync(ApplicationQueryModel queryModel)
        {
            IQueryable<Application> applicationsAsQueryable = this.dbContext
                .Applications
                .AsNoTracking()
                .AsQueryable();

            if (queryModel.IsRegisteredIsChecked)
            {
                applicationsAsQueryable = applicationsAsQueryable
                    .Where(a => a.IsRegistered == true);
            }

            // Order by selected option for date sorting
            switch (queryModel.DateSorting)
            {
                case DateSorting.Newest:
                    applicationsAsQueryable = applicationsAsQueryable
                        .OrderByDescending(r => r.CreatedOn);
                    break;
                case DateSorting.Oldest:
                    applicationsAsQueryable = applicationsAsQueryable
                        .OrderBy(r => r.CreatedOn);
                    break;
            }

            // Order by selected option for status sorting
            switch (queryModel.StatusSorting)
            {
                case StatusSorting.Waiting:
                    applicationsAsQueryable = applicationsAsQueryable
                        .Where(a => a.Status == Status.Waiting);
                    break;
                case StatusSorting.Approved:
                    applicationsAsQueryable = applicationsAsQueryable
                        .Where(a => a.Status == Status.Approved);
                    break;
                case StatusSorting.Declined:
                    applicationsAsQueryable = applicationsAsQueryable
                        .Where(a => a.Status == Status.Declined);
                    break;
            }

            IEnumerable<ApplicationViewModel> applicationViewModels = await applicationsAsQueryable
                .Select(a => new ApplicationViewModel()
                {
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Age = a.Age,
                    ContactNumber = a.Contact,
                    EmailAddress = a.Email,
                    Id = a.Id.ToString(),
                    CreatedOn = a.CreatedOn,
                    IsRegistered = a.IsRegistered,
                    Status = a.Status.ToString(),
                    Experience = a.ExperienceInYears,
                    Role = a.StartingRole.ToString(),
                    Division = a.StartingDivision.Name
                })
                .ToArrayAsync();

            foreach (var appModel in applicationViewModels)
            {
                appModel.Status = Translator.TranslateStatus(appModel.Status);
                appModel.Role = Translator.TranslateRoleToBulgarian(appModel.Role);
            }

            return applicationViewModels;
        }

        public async Task<ApplicationViewModel> GetApplicationByIdAsync(string id)
        {
            ApplicationViewModel application = await this.dbContext
                .Applications
                .Where(a => a.Id.ToString() == id)
                .Select(a => new ApplicationViewModel()
                {
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Age = a.Age,
                    ContactNumber = a.Contact,
                    EmailAddress = a.Email,
                    Id = a.Id.ToString(),
                    CreatedOn = a.CreatedOn,
                    IsRegistered = a.IsRegistered,
                    Status = a.Status.ToString(),
                    Experience = a.ExperienceInYears,
                    Role = a.StartingRole.ToString(),
                    Division = a.StartingDivision.Name
                })
                .FirstAsync();

            application.Role = Translator.TranslateRoleToBulgarian(application.Role);

            return application;
        }

        public async Task<ApplicationEmailModel> GetApplicationForEmailByIdAsync(string id)
        {
            ApplicationEmailModel application = await this.dbContext
                .Applications
                .Where(a => a.Id.ToString() == id)
                .Select(a => new ApplicationEmailModel()
                {
                    Id = a.Id.ToString(),
                    FullName = $"{a.FirstName} {a.LastName}",
                    EmailAddress = a.Email,
                })
                .FirstAsync();

            return application;
        }

        public async Task SetIsRegisterValueToTrueAsync(string id)
        {
            Application app = await this.dbContext.Applications
                .Where(a => a.Id.ToString() == id)
                .FirstAsync();

            app.IsRegistered = true;
            await this.dbContext.SaveChangesAsync();
        }
    }
}
