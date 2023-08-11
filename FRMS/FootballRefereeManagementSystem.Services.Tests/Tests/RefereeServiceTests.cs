namespace FootballRefereeManagementSystem.Services.Tests.Tests
{
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Data.Models.Enums;
    using Common;
    using Web.ViewModels.Career;
    using Web.ViewModels.Referee;
    using Data.Models;

    public class RefereeServiceTests : TestDatabaseFixture
    {
        private IRefereeService refereeService;

        [SetUp]
        public async new Task InitializeDatabaseForTests()
        {
            await base.InitializeDatabaseForTests();

            this.refereeService = new RefereeService(dbContext);
        }

        [Test]
        public async Task CheckRefereeExistanceByIdAsync_ValidId_ShouldReturnTrue()
        {
            // Arrange
            int validId = 1;

            // Act
            bool result = await this.refereeService.CheckRefereeExistanceByIdAsync(validId);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task CheckRefereeExistanceByIdAsync_InvalidId_ShouldReturnFalse()
        {
            // Arrange
            int invalidId = 4244;

            // Act
            bool result = await this.refereeService.CheckRefereeExistanceByIdAsync(invalidId);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetAllRefereesFilteredAsync_NoFilters_ShouldReturnAllReferees()
        {
            // Arrange
            int expectedCount = 5;
            RefereeQueryModel queryModel = new RefereeQueryModel();

            // Act
            IEnumerable<RefereeViewModel> refs = 
                await this.refereeService.GetAllRefereesFilteredAsync(queryModel);

            // Assert
            Assert.That(refs.Count(), Is.EqualTo(expectedCount));
        }

        [Test]
        public async Task GetAllRefereesFilteredAsync_RoleFilters_ShouldReturnCorrectReferees()
        {
            // Arrange
            int expectedCount = 2;
            string expectedRole = Translator.TranslateRoleToBulgarian(Role.AssistantReferee.ToString());
            RefereeQueryModel queryModel = new RefereeQueryModel()
            {
                IsCheckedAssistantReferee = true,
            };

            // Act
            IEnumerable<RefereeViewModel> refs =
                await this.refereeService.GetAllRefereesFilteredAsync(queryModel);
            

            // Assert
            Assert.That(refs.Count(), Is.EqualTo(expectedCount));
            foreach (var referee in refs)
            {
                Assert.That(referee.Role, Is.EqualTo(expectedRole));
            }
        }

        [Test]
        public void DetermineBestSuitedRoleForApplication_UnderagedCandidate_ShouldReturnAssistantRefereeRoleId()
        {
            // Arrange
            int expectedRoleEnumId = 1;
            ApplicationFormModel model = new ApplicationFormModel()
            {
                FirstName = "First",
                LastName = "Last",
                Age = 16,
                Contact = "0898777666",
                Email = "example@email.com",
                ExperienceInYears = 4,
                KnowsFootballRules = true
            };

            // Act
            int result = this.refereeService.DetermineBestSuitedRoleForApplication(model);

            // Assert
            Assert.That(result, Is.EqualTo(expectedRoleEnumId));
        }

        [Test]
        public void DetermineBestSuitedRoleForApplication_InexperiencedCandidate_ShouldReturnAssistantRefereeRoleId()
        {
            // Arrange
            int expectedRoleEnumId = 1;
            ApplicationFormModel model = new ApplicationFormModel()
            {
                FirstName = "First",
                LastName = "Last",
                Age = 18,
                Contact = "0898777666",
                Email = "example@email.com",
                ExperienceInYears = 2, // 2 or less is inexperienced
                KnowsFootballRules = true
            };

            // Act
            int result = this.refereeService.DetermineBestSuitedRoleForApplication(model);

            // Assert
            Assert.That(result, Is.EqualTo(expectedRoleEnumId));
        }

        [Test]
        public void DetermineBestSuitedRoleForApplication_RegularCandidate_ShouldReturnRefereeRoleId()
        {
            // Arrange
            int expectedRoleEnumId = 0;
            ApplicationFormModel model = new ApplicationFormModel()
            {
                FirstName = "First",
                LastName = "Last",
                Age = 18,
                Contact = "0898777666",
                Email = "example@email.com",
                ExperienceInYears = 3,
                KnowsFootballRules = true
            };

            // Act
            int result = this.refereeService.DetermineBestSuitedRoleForApplication(model);

            // Assert
            Assert.That(result, Is.EqualTo(expectedRoleEnumId));
        }

        [Test]
        public void DetermineBestSuitedRoleForApplication_ExperiencedCandidate_ShouldReturnDelegateRoleId()
        {
            // Arrange
            int expectedRoleEnumId = 2;
            ApplicationFormModel model = new ApplicationFormModel()
            {
                FirstName = "First",
                LastName = "Last",
                Age = 18,
                Contact = "0898777666",
                Email = "example@email.com",
                ExperienceInYears = 11,
                KnowsFootballRules = true
            };

            // Act
            int result = this.refereeService.DetermineBestSuitedRoleForApplication(model);

            // Assert
            Assert.That(result, Is.EqualTo(expectedRoleEnumId));
        }

        [Test]
        public async Task UpdateCurrentlyAppointedMatchesCount_ShouldReturnNumberOfRefereeSquadsUserIsInvolved()
        {
            // Arrange
            int expectedResult = 1;
            int refereeId = 1;

            // Act
            await this.refereeService.UpdateCurrentlyAppointedMatchesCount(refereeId);
            Referee referee = await this.dbContext
                .Referees
                .Where(r => r.Id == refereeId)
                .FirstAsync();

            // Assert
            Assert.That(referee.CurrentlyAppointedMatchesCount, Is.EqualTo(expectedResult));
        }
    }
}
