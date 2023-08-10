namespace FootballRefereeManagementSystem.Services.Tests.Tests
{
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data.Models;
    using Data.Models.Enums;
    using Web.ViewModels.Career;

    [TestFixture]
    public class CareerServiceTests : TestDatabaseFixture
    {
        private ICareerService careerService;

        [SetUp]
        public async new Task InitializeDatabaseForTests()
        {
            await base.InitializeDatabaseForTests();

            this.careerService = new CareerService(dbContext);
        }

        [Test]
        public async Task AddApplicationAsync_ValidModel_ShouldAddApplicationToDatabase()
        {
            // Arrange
            ApplicationFormModel model = new ApplicationFormModel
            {
                FirstName = "Иван",
                LastName = "Петров",
                Email = "email@dummy.com",
                Age = 25,
                Contact = "0894566781",
                ExperienceInYears = 3,
                Role = (int)Role.Referee,
                DivisionId = 4
            };

            // Act
            await careerService.AddApplicationAsync(model);

            // Assert
            Application? addedApplication = await dbContext
                .Applications
                .FirstOrDefaultAsync(a => a.Email == model.Email);

            Assert.IsNotNull(addedApplication);
        }

        // [10.08.2023] TODO: In order to test the rest of the methods in the service...
        // ...I need to seed Application entity. Due to lack of time...
        // ...I will unfortunately have to postpone that for now and instead...
        // ...test other parts of the application.
    }
}
