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

        [Test]
        public async Task DeleteDivisionAsync_ValidId_ShouldDeactivateDivision()
        {
            // Arrange
            int divisionId = 1;

            // Act
            await this.divisionService.DeleteDivisionAsync(divisionId);
            bool exists = await this.divisionService.CheckDivisionExistanceByIdAsync(divisionId);

            // Assert
            Assert.IsFalse(exists);
        }

        [Test]
        public async Task GetAllDivisionNamesAsync_ShouldReturnCorrectCollectionCount()
        {
            // Act
            IEnumerable<string> divisionNames = 
                await this.divisionService.GetAllDivisionNamesAsync();

            // Assert
            Assert.That(divisionNames.Count(), Is.EqualTo(5));
        }

        [Test]
        public async Task DetermineBestSuitedDivisionForApplicationAsync_UnderAgedCandidate_ShouldReturnIdOfDivisionWithLowestDifficulty()
        {
            // Arrange
            int candidateAge = 16; // Under 18 years are considered underaged candidates.
            int candidateExperienceInYears = 4;

            // Act
            int divisionId = await this.divisionService
                .DetermineBestSuitedDivisionForApplicationAsync(candidateAge, candidateExperienceInYears);

            // Assert
            Assert.That(divisionId, Is.EqualTo(5));
        }

        [Test]
        public async Task DetermineBestSuitedDivisionForApplicationAsync_InexperiencedCandidate_ShouldReturnIdOfDivisionWithLowestDifficulty()
        {
            // Arrange
            int candidateAge = 18; // 18 year olds are valid for higher divisions.
            int candidateExperienceInYears = 2; // but less than or 2 years experience also goes lowest difficulty division

            // Act
            int divisionId = await this.divisionService
                .DetermineBestSuitedDivisionForApplicationAsync(candidateAge, candidateExperienceInYears);

            // Assert
            Assert.That(divisionId, Is.EqualTo(5));
        }

        [Test]
        public async Task DetermineBestSuitedDivisionForApplicationAsync_MidXpCandidateWithOddDivsNumber_ShouldReturnIdOfDivisionWithAverageDifficulty()
        {
            // Arrange
            int candidateAge = 18;
            int candidateExperienceInYears = 10; //Less than or 10 years experience goes in middle difficulty division

            // Act
            int divisionId = await this.divisionService
                .DetermineBestSuitedDivisionForApplicationAsync(candidateAge, candidateExperienceInYears);

            // Assert
            // Since we have odd number of divisions (5) it should return the ID of the middle division
            Assert.That(divisionId, Is.EqualTo(3));
        }

        [Test]
        public async Task DetermineBestSuitedDivisionForApplicationAsync_MidXpCandidateWithEvenDivsNumber_ShouldReturnIdOfDivisionWithLowerAverageDifficulty()
        {
            // Arrange
            int candidateAge = 21;
            int candidateExperienceInYears = 5;

            // Leaves divisions with difficulties 1,2,3 and 4. (AVG = 2.5)...
            // ...thus it should pick division with difficuty 2 (divisionId = 4)
            await this.divisionService.DeleteDivisionAsync(1); 

            // Act
            int divisionId = await this.divisionService
                .DetermineBestSuitedDivisionForApplicationAsync(candidateAge, candidateExperienceInYears);

            // Assert
            // Since we have odd number of divisions (5) it should return the ID of the middle division
            Assert.That(divisionId, Is.EqualTo(4));
        }

        [Test]
        public async Task DetermineBestSuitedDivisionForApplicationAsync_ExperiencedCandidate_ShouldReturnIdOfDivisionWithHighestDifficulty()
        {
            // Arrange
            int candidateAge = 30;
            int candidateExperienceInYears = 11; // Over 10 years experience

            // Act
            int divisionId = await this.divisionService
                .DetermineBestSuitedDivisionForApplicationAsync(candidateAge, candidateExperienceInYears);

            // Assert
            Assert.That(divisionId, Is.EqualTo(1));
        }

        [Test]
        public async Task AddDivisionAndDivisionsWithLessDifficultyToRefereeByIdAsync_ShouldIncreaseRefereeDivisionsCountAccordingly()
        {
            // Arrange
            int refereeId = 1;
            string divisionName = "Първа професионална футболна лига";

            int currentRefereeDivisionsCount = await this.dbContext.RefereesDivisions.CountAsync();

            // Act
            await this.divisionService
                .AddDivisionAndDivisionsWithLessDifficultyToRefereeByIdAsync(refereeId, divisionName);

            int updatedRefereeDivisionsCount = await this.dbContext.RefereesDivisions.CountAsync();
            int difference = updatedRefereeDivisionsCount - currentRefereeDivisionsCount;

            // Assert
            Assert.That(difference, Is.EqualTo(3));
        }

        [Test]
        public async Task GetNameOfMostOfficiatedDivisionForRefereeByIdAsync_ShouldReturnCorrectName()
        {
            // Arrange
            int refereeId = 1;
            int divisionId = 5;

            RefereeDivision rd = await this.dbContext
                .RefereesDivisions
                .Where(rd => 
                    rd.RefereeId == refereeId && 
                    rd.DivisionId == divisionId)
                .FirstAsync();
            rd.DivisionMatchesOfficiated += 10; // The referee had officiated in 10 matches in this division.

            await this.dbContext.SaveChangesAsync();

            // Act
            string divisionName = await this.divisionService
                .GetNameOfMostOfficiatedDivisionForRefereeByIdAsync(refereeId);
            string expectedName = "„Б“ областнa футболнa групa";

            // Assert
            Assert.That(divisionName, Is.EqualTo(expectedName));
        }
    }
}
