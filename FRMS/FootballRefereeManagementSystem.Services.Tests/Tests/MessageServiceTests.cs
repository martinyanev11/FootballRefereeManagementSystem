namespace FootballRefereeManagementSystem.Services.Tests.Tests
{
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Web.ViewModels.Message;

    public class MessageServiceTests : TestDatabaseFixture
    {
        private IMessageService messageService;

        [SetUp]
        public async new Task InitializeDatabaseForTests()
        {
            await base.InitializeDatabaseForTests();

            this.messageService = new MessageService(dbContext);
        }

        [Test]
        public async Task AddNewMessageAsync_ShouldAddSuccessfully()
        {
            // Arrange
            MessageFormModel model = new MessageFormModel()
            {
                RefereeSquadId = "5F7A5BAD-DA9C-4FD9-871A-483492E9BDAA",
                UserId = "EA01FE26-36C8-4DAA-B1C8-8B9209E82478",
                Content = "Test message",
            };

            // Act
            await this.messageService.AddNewMessageAsync(model);
            int count = await this.dbContext
                .Messages
                .CountAsync();

            // Assert
            Assert.That(count, Is.EqualTo(1));
        }
    }
}
