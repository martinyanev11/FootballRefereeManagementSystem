namespace FootballRefereeManagementSystem.Services.Tests.Tests
{
    using Contracts;
    using Web.ViewModels.Team;

    public class TeamServiceTests : TestDatabaseFixture
    {
        private ITeamService teamService;

        [SetUp]
        public async new Task InitializeDatabaseForTests()
        {
            await base.InitializeDatabaseForTests();

            this.teamService = new TeamService(dbContext);
        }

        [Test]
        public async Task GetAllTeamsAsync_NoFilters_ShouldReturnAllActiveTeams()
        {
            // Arrange
            int expectedTeamsCount = 17;
            TeamAdminQueryModel queryModel = new TeamAdminQueryModel()
            {
                SearchString = string.Empty,
                Zone = null,
            };

            // Act
            IEnumerable<TeamAdminViewModel> teams = 
                await this.teamService.GetAllTeamsAsync(queryModel);

            // Arrange
            Assert.That(teams.Count(), Is.EqualTo(expectedTeamsCount));
        }

        [Test]
        public async Task GetAllTeamsAsync_ZoneFilter_ShouldReturnTeamsInSelectedZone()
        {
            // Arrange
            int expectedTeamsCount = 9;
            string zoneFilter = "Плевен Изток";
            TeamAdminQueryModel queryModel = new TeamAdminQueryModel()
            {
                SearchString = string.Empty,
                Zone = zoneFilter,
            };

            // Act
            IEnumerable<TeamAdminViewModel> teams =
                await this.teamService.GetAllTeamsAsync(queryModel);

            // Arrange
            Assert.That(teams.Count(), Is.EqualTo(expectedTeamsCount));
        }

        [Test]
        public async Task CheckIfTeamIsAlreadyRegistered_RegisteredId_ShouldReturnTrue()
        {
            // Arrange
            int teamId = 1;
            int seasonId = 2;

            // Act
            bool result = await this.teamService.CheckIfTeamIsAlreadyRegistered(teamId, seasonId);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task CheckIfTeamIsAlreadyRegistered_NotRegisteredId_ShouldReturnFalse()
        {
            // Arrange
            int teamId = 10;
            int seasonId = 2;

            // Act
            bool result = await this.teamService.CheckIfTeamIsAlreadyRegistered(teamId, seasonId);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
