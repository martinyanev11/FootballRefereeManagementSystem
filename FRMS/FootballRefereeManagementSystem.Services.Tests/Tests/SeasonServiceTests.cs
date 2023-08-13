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
            SeasonViewModel model = await this.seasonService.GetCurrentSeasonInformationAsync();

            // Assert
            Assert.That(model.Description, Is.EqualTo(expectedDescription)); 
        }

        [Test]
        public async Task GetCurrentSeasonDescriptionAsync_ShouldReturnCorrectDescription()
        {
            // Arrange
            string expectedDescription = "2023/24";

            // Act
            string result = await this.seasonService.GetCurrentSeasonDescriptionAsync();

            // Assert
            Assert.That(result, Is.EqualTo(expectedDescription));
        }

        [Test]
        public async Task GetSeasonIdByDescriptionAsync_ShouldReturnCorrectId()
        {
            // Arrange
            int expected = 1;
            string inputDescription = "2022/23";

            // Act
            int result = await this.seasonService.GetSeasonIdByDescriptionAsync(inputDescription);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public async Task GetCurrentSeasonStatisticsAsync_ShouldReturnCorrectData()
        {
            // Arrange
            string expectedSeasonDescription = "2023/24";
            int expectedRegisteredTeamsCount = 8; // Seeded 8 TeamSeason entities with seasonId = 2.
            int expectedRegisteredPlayersCount = 88; // Seeded 88 players in total. Each team has 11 PlayerTeamSeason entities
            int expectedMatchesPlayed = 0; // No games should be played as the new season hasn't started yet.
            int expectedTotalMatchesCount = 56; // 8 teams play each other -> 8 * 7 (because teams can't play themself)

            // Act
            SeasonStatisticsViewModel seasonStats = await this.seasonService.GetCurrentSeasonStatisticsAsync();

            // Assert
            Assert.That(seasonStats.SeasonDescription, Is.EqualTo(expectedSeasonDescription));
            Assert.That(seasonStats.RegisteredTeamsCount, Is.EqualTo(expectedRegisteredTeamsCount));
            Assert.That(seasonStats.RegisteredTeamsCount, Is.EqualTo(expectedRegisteredTeamsCount));
            Assert.That(seasonStats.RegisteredPlayersCount, Is.EqualTo(expectedRegisteredPlayersCount));
            Assert.That(seasonStats.MatchesPlayed, Is.EqualTo(expectedMatchesPlayed));
            Assert.That(seasonStats.TotalMatchesCount, Is.EqualTo(expectedTotalMatchesCount));
        }
    }
}
