namespace FootballRefereeManagementSystem.Services.Tests.Tests
{
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data.Models;
    using Web.ViewModels.Match;

    [TestFixture]
    public class MatchServiceTests : TestDatabaseFixture
    {
        private IMatchService matchService;

        [SetUp]
        public async new Task InitializeDatabaseForTests()
        {
            await base.InitializeDatabaseForTests();

            this.matchService = new MatchService(dbContext);
        }

        [Test]
        public async Task AddNewMatchAsync_ShouldAddMatchInDatabase()
        {
            // Arrange
            MatchFormModel modelToAdd = new MatchFormModel()
            {
                DivisionId = 4,
                TownId = 2,
                FixtureTime = DateTime.UtcNow,
                HomeTeamId = 1,
                AwayTeamId = 2,
                SeasonId = 2
            };

            // Act
            await this.matchService.AddNewMatchAsync(modelToAdd);

            // Assert
            bool matchIsAdded = await this.dbContext
                .Matches
                .Where(m => m.HomeTeamId == 1 &&
                    m.AwayTeamId == 2 &&
                    m.SeasonId == 2)
                .AnyAsync();

            Assert.IsTrue(matchIsAdded);
        }

        [Test]
        public async Task CheckMatchExistanceByIdAsync_ValidId_ShouldReturnTrue()
        {
            // Arrange
            int matchId = 1;

            // Act
            bool exists = await this.matchService.CheckMatchExistanceByIdAsync(matchId);

            // Assert
            Assert.IsTrue(exists);
        }

        [Test]
        public async Task CheckMatchExistanceByIdAsync_InalidId_ShouldReturnFalse()
        {
            // Arrange
            int matchId = 100000;

            // Act
            bool exists = await this.matchService.CheckMatchExistanceByIdAsync(matchId);

            // Assert
            Assert.IsFalse(exists);
        }

        [Test]
        public async Task EditMatchAsync_ShouldUpdateEntityCorrectly()
        {
            // Arrange
            int newTownId = 5;
            DateTime newDate = DateTime.UtcNow;
            int newHomeTeamScore = 4;
            int newAwayTeamScore = 5;

            int matchId = 1;
            MatchEditViewModel model = new MatchEditViewModel()
            {
                TownId = newTownId,
                FixtureTime = newDate,
                HomeTeamScore = newHomeTeamScore,
                AwayTeamScore = newAwayTeamScore,
            };

            // Act
            await this.matchService.EditMatchAsync(matchId, model);

            Match updatedModel = await this.dbContext
                .Matches
                .Where(m => m.Id == matchId)
                .FirstAsync();

            // Assert
            Assert.That(newTownId, Is.EqualTo(updatedModel.TownId));
            Assert.That(newDate, Is.EqualTo(updatedModel.FixtureTime));
            Assert.That(newHomeTeamScore, Is.EqualTo(updatedModel.HomeTeamScore));
            Assert.That(newAwayTeamScore, Is.EqualTo(updatedModel.AwayTeamScore));
        }

        [Test]
        public async Task FinishMatchAsync_HomeTeamWinner_ShouldUpdateStatsAccordingly()
        {
            // Arrange
            int seasonId = 2;
            int matchId = 1;
            int homeTeamScore = 4;
            int awayTeamScore = 1;

            MatchFinishModel model = new MatchFinishModel()
            {
                MatchId = matchId,
                HomeTeamScore = homeTeamScore,
                AwayTeamScore = awayTeamScore,
            };

            // Act
            await this.matchService.FinishMatchAsync(model);

            Match match = await this.dbContext
                .Matches
                .Where(m => m.Id == matchId)
                .FirstAsync();

            TeamSeason homeTeam = await this.dbContext
                .TeamsSeasons
                .Where(ts => 
                    ts.TeamId == match.HomeTeamId &&
                    ts.SeasonId == seasonId)
                .FirstAsync();

            TeamSeason awayTeam = await this.dbContext
                .TeamsSeasons
                .Where(ts =>
                    ts.TeamId == match.AwayTeamId &&
                    ts.SeasonId == seasonId)
                .FirstAsync();

            // Assert
            Assert.IsTrue(match.HasFinished);
            Assert.That(match.HomeTeamScore, Is.EqualTo(homeTeamScore));
            Assert.That(match.AwayTeamScore, Is.EqualTo(awayTeamScore));

            Assert.That(homeTeam.GoalsFor, Is.EqualTo(homeTeamScore));
            Assert.That(awayTeam.GoalsFor, Is.EqualTo(awayTeamScore));

            Assert.That(homeTeam.GoalsAgainst, Is.EqualTo(awayTeamScore));
            Assert.That(awayTeam.GoalsAgainst, Is.EqualTo(homeTeamScore));

            Assert.That(homeTeam.Wins, Is.EqualTo(1));
            Assert.That(awayTeam.Losses, Is.EqualTo(1));
        }

        [Test]
        public async Task FinishMatchAsync_AwayTeamWinner_ShouldUpdateStatsAccordingly()
        {
            // Arrange
            int seasonId = 2;
            int matchId = 1;
            int homeTeamScore = 1;
            int awayTeamScore = 3;

            MatchFinishModel model = new MatchFinishModel()
            {
                MatchId = matchId,
                HomeTeamScore = homeTeamScore,
                AwayTeamScore = awayTeamScore,
            };

            // Act
            await this.matchService.FinishMatchAsync(model);

            Match match = await this.dbContext
                .Matches
                .Where(m => m.Id == matchId)
                .FirstAsync();

            TeamSeason homeTeam = await this.dbContext
                .TeamsSeasons
                .Where(ts =>
                    ts.TeamId == match.HomeTeamId &&
                    ts.SeasonId == seasonId)
                .FirstAsync();

            TeamSeason awayTeam = await this.dbContext
                .TeamsSeasons
                .Where(ts =>
                    ts.TeamId == match.AwayTeamId &&
                    ts.SeasonId == seasonId)
                .FirstAsync();

            // Assert
            Assert.IsTrue(match.HasFinished);
            Assert.That(match.HomeTeamScore, Is.EqualTo(homeTeamScore));
            Assert.That(match.AwayTeamScore, Is.EqualTo(awayTeamScore));

            Assert.That(homeTeam.GoalsFor, Is.EqualTo(homeTeamScore));
            Assert.That(awayTeam.GoalsFor, Is.EqualTo(awayTeamScore));

            Assert.That(homeTeam.GoalsAgainst, Is.EqualTo(awayTeamScore));
            Assert.That(awayTeam.GoalsAgainst, Is.EqualTo(homeTeamScore));

            Assert.That(homeTeam.Losses, Is.EqualTo(1));
            Assert.That(awayTeam.Wins, Is.EqualTo(1));
        }

        [Test]
        public async Task FinishMatchAsync_MatchWasDraw_ShouldUpdateStatsAccordingly()
        {
            // Arrange
            int seasonId = 2;
            int matchId = 1;
            int homeTeamScore = 1;
            int awayTeamScore = 1;

            MatchFinishModel model = new MatchFinishModel()
            {
                MatchId = matchId,
                HomeTeamScore = homeTeamScore,
                AwayTeamScore = awayTeamScore,
            };

            // Act
            await this.matchService.FinishMatchAsync(model);

            Match match = await this.dbContext
                .Matches
                .Where(m => m.Id == matchId)
                .FirstAsync();

            TeamSeason homeTeam = await this.dbContext
                .TeamsSeasons
                .Where(ts =>
                    ts.TeamId == match.HomeTeamId &&
                    ts.SeasonId == seasonId)
                .FirstAsync();

            TeamSeason awayTeam = await this.dbContext
                .TeamsSeasons
                .Where(ts =>
                    ts.TeamId == match.AwayTeamId &&
                    ts.SeasonId == seasonId)
                .FirstAsync();

            // Assert
            Assert.IsTrue(match.HasFinished);
            Assert.That(match.HomeTeamScore, Is.EqualTo(homeTeamScore));
            Assert.That(match.AwayTeamScore, Is.EqualTo(awayTeamScore));

            Assert.That(homeTeam.GoalsFor, Is.EqualTo(homeTeamScore));
            Assert.That(awayTeam.GoalsFor, Is.EqualTo(awayTeamScore));

            Assert.That(homeTeam.GoalsAgainst, Is.EqualTo(awayTeamScore));
            Assert.That(awayTeam.GoalsAgainst, Is.EqualTo(homeTeamScore));

            Assert.That(homeTeam.Draws, Is.EqualTo(1));
            Assert.That(awayTeam.Draws, Is.EqualTo(1));
        }

        [Test]
        public async Task GetAllMatchesForSeasonAsync_ShouldReturnCorrectCount()
        {
            // Arrange
            int seasonId = 2;
            int expectedCount = 56;

            //Act
            IEnumerable<MatchRefereeSquadSummaryViewModel> result = 
                await this.matchService.GetAllMatchesForSeasonAsync(seasonId);

            //Assert
            Assert.That(result.Count(), Is.EqualTo(expectedCount));
        }

        [Test]
        public async Task GetDivisionIdByMatchIdAsync_ShouldReturnCorrectIdValue()
        {
            // Arrange
            int matchId = 1;
            int expectedDivisionId = 4;

            // Act
            int resultId = await this.matchService.GetDivisionIdByMatchIdAsync(matchId);

            // Assert
            Assert.That(resultId, Is.EqualTo(expectedDivisionId));
        }

        [Test]
        public async Task GetFilteredBySeasonAndDivisionMatchesAsync_ShouldReturnCorrectCount()
        {
            // Arrange
            string seasonDescription = "2023/24";
            string divisionName = "„А“ областнa футболнa групa";
            int expectedCount = 56;

            //Act
            IEnumerable<MatchTableViewModel> result =
                await this.matchService.GetFilteredBySeasonAndDivisionMatchesAsync(seasonDescription, divisionName);

            //Assert
            Assert.That(result.Count(), Is.EqualTo(expectedCount));
        }

        [Test]
        public async Task GetWeeklyMatchesAsync__WithNoFilters_ShouldReturnCorrectCount()
        {
            // Arrange
            int expectedCount = 3;
            MatchQueryModel queryModel = new MatchQueryModel(); // query model with filters == null

            // Act
            IEnumerable<MatchRefereeSquadSummaryViewModel> result = 
                await this.matchService.GetWeeklyMatchesAsync(queryModel);

            // Assert
            Assert.That(result.Count(), Is.EqualTo(expectedCount));
        }

        [Test]
        public async Task GetWeeklyMatchesAsync__WithDivisionNameFilter_ShouldReturnCorrectCount()
        {
            // Arrange
            int expectedCount = 0;
            MatchQueryModel queryModel = new MatchQueryModel()
            {
                DivisionFilter = "Първа професионална футболна лига",
            };

            // Act
            IEnumerable<MatchRefereeSquadSummaryViewModel> result =
                await this.matchService.GetWeeklyMatchesAsync(queryModel);

            // Assert
            Assert.That(result.Count(), Is.EqualTo(expectedCount));
        }
    }
}
