namespace FootballRefereeManagementSystem.Services.Tests.Tests
{
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data.Models;
    using Web.ViewModels.Division;

    [TestFixture]
    public class DivisionServiceTests : TestDatabaseFixture
    {
        private IDivisionService divisionService;

        [SetUp]
        public async new Task InitializeDatabaseForTests()
        {
            await base.InitializeDatabaseForTests();

            this.divisionService = new DivisionService(dbContext);
        }

        [Test]
        public async Task AddNewDivisionAsync_ValidModel_ShouldAddDivisionToDatabase()
        {
            // Arrange
            DivisionFormModel newDivision = new DivisionFormModel
            {
                Name = "Нова дивизия",
                Difficulty = 6,
            };

            // Act
            await this.divisionService.AddNewDivisionAsync(newDivision);

            // Assert
            Division? addedDivision = await this.dbContext
                .Divisions
                .FirstOrDefaultAsync(d => d.Name == newDivision.Name);

            Assert.NotNull(addedDivision);
            Assert.That(newDivision.Name, Is.EqualTo(addedDivision.Name));
            Assert.That(newDivision.Difficulty, Is.EqualTo(addedDivision.Difficulty));
        }

        [Test]
        public async Task CheckDivisionExistanceByIdAsync_ValidId_ShouldReturnTrue()
        {
            // Arrange
            int divisionId = 1;

            // Act
            bool exists = await this.divisionService.CheckDivisionExistanceByIdAsync(divisionId);

            // Assert
            Assert.IsTrue(exists);
        }

        [Test]
        public async Task CheckDivisionExistanceByIdAsync_InvalidId_ShouldReturnFalse()
        {
            // Arrange
            int divisionId = 95555;

            // Act
            bool exists = await this.divisionService.CheckDivisionExistanceByIdAsync(divisionId);

            // Assert
            Assert.IsFalse(exists);
        }
    }
}
