namespace FootballRefereeManagementSystem.Services.Tests.Tests
{
    using Contracts;
    using Web.ViewModels.Player;

    public class PlayerServiceTests : TestDatabaseFixture
    {
        private IPlayerService playerService;

        [SetUp]
        public async new Task InitializeDatabaseForTests()
        {
            await base.InitializeDatabaseForTests();

            this.playerService = new PlayerService(dbContext);
        }

        [Test]
        public async Task GetAllPlayersAsync_NoSearchFilter_ShouldReturnCorrectCount()
        {
            // Arrange
            int expectedCount = 88;
            PlayerQueryModel queryModel = new PlayerQueryModel();

            // Act
            IEnumerable<PlayerDetailsViewModel> players = 
                await this.playerService.GetAllPlayersAsync(queryModel);

            // Assert
            Assert.That(players.Count(), Is.EqualTo(expectedCount));
        }
    }
}
