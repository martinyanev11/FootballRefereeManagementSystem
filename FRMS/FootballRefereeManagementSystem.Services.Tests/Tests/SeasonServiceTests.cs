namespace FootballRefereeManagementSystem.Services.Tests.Tests
{
    using Contracts;
    using FootballRefereeManagementSystem.Web.ViewModels.Season;

    public class SeasonServiceTests : TestDatabaseFixture
    {
        private ISeasonService seasonService;

        [SetUp]
        public async new Task InitializeDatabaseForTests()
        {
            await base.InitializeDatabaseForTests();

            this.seasonService = new SeasonService(dbContext);
        }

        [Test]
        public async Task GetAllSeasonDescriptionsAsync_ShouldReturnCorrectCount()
        {
            // Arrange
            int expectedResult = 2;

            // Act
            IEnumerable<string> descriptions = await seasonService.GetAllSeasonDescriptionsAsync();

            // Assert
            Assert.That(descriptions.Count(), Is.EqualTo(expectedResult));
        }

        [Test]  
        public async Task GetCurrentSeasonInformation_ShouldReturnCorrectSeasonInformation()
        {
            // Arrange
            string expectedDescription = "2023/24";

            // Act
            SeasonViewModel model = await this.seasonService.GetCurrentSeasonInformation();

            // Assert
            Assert.That(model.Description, Is.EqualTo(expectedDescription)); 
        }
    }
}
