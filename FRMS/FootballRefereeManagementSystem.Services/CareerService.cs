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
                Weight = model.Weight,
                Contact = model.Contact,
                HasDriverLicense = model.HasDriverLicense,
                HasCar = model.HasCar,
            };

            await dbContext.Applications.AddAsync(application);
            await dbContext.SaveChangesAsync();
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
                    FullName = $"{a.FirstName} {a.LastName}",
                    Age = a.Age,
                    Weight = a.Weight,
                    ContactNumber = a.Contact,
                    HasDriverLicense = a.HasDriverLicense,
                    HasCar = a.HasCar,
                    EmailAddress = a.Email,
                    Id = a.Id.ToString(),
                    CreatedOn = a.CreatedOn,
                    IsRegistered = a.IsRegistered,
                    Status = a.Status.ToString(),
                })
                .ToArrayAsync();

            foreach (var appModel in applicationViewModels)
            {
                appModel.Status = TranslateStatusToBulgarian(appModel.Status);
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
                    FullName = $"{a.FirstName} {a.LastName}",
                    Age = a.Age,
                    Weight = a.Weight,
                    ContactNumber = a.Contact,
                    HasDriverLicense = a.HasDriverLicense,
                    HasCar = a.HasCar,
                    EmailAddress = a.Email,
                    Id = a.Id.ToString(),
                    CreatedOn = a.CreatedOn,
                    IsRegistered = a.IsRegistered,
                    Status = a.Status.ToString(),
                })
                .FirstAsync();

            return application;
        }

        // ---------------------------------------------
        // Helper methods
        // ---------------------------------------------

        private string TranslateStatusToBulgarian(string status)
        {
            switch (status)
            {
                case "Waiting":
                    status = "В процес";
                    break;
                case "Approved":
                    status = "Одобрен";
                    break;
                case "Declined":
                    status = "Отхвърлен";
                    break;
            }

            return status;
        }
    }
}
