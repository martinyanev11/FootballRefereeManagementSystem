namespace FootballRefereeManagementSystem.Services
{
    using System.Threading.Tasks;

    using Data;
    using Data.Models;
    using Contracts;
    using Web.ViewModels.Career;

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
    }
}
