namespace FootballRefereeManagementSystem.Services.Tests.Tests
{
    using Microsoft.EntityFrameworkCore;

    using Contracts;
    using Models.Article;
    using Web.ViewModels.News;

    public class NewsServiceTests : TestDatabaseFixture
    {
        private INewsService newsService;

        [SetUp]
        public async new Task InitializeDatabaseForTests()
        {
            await base.InitializeDatabaseForTests();

            this.newsService = new NewsService(dbContext);
        }

        [Test]
        public async Task AddNewArticleAsync_ShouldAddSuccessfully()
        {
            // Arrange
            string title = "Title";
            string content = "Content of the article";

            ArticleFormViewModel modelToAdd = new ArticleFormViewModel()
            {
                Title = title,
                Content = content,
                ImageUrl = null,
            };

            // Act
            int countBefore = await this.dbContext
                .Articles
                .CountAsync();

            await this.newsService.AddNewArticleAsync(modelToAdd);

            int countAfter = await this.dbContext
                .Articles
                .CountAsync();

            int countDiff = countAfter - countBefore;

            // Assert
            Assert.That(countDiff, Is.EqualTo(1));
        }

        [Test]
        public async Task GetAllArticlesAsync_NoFilter_ShouldReturnAllArticlesCount()
        {
            // Arrange
            int expectedCount = 10;
            int expectedCountPerPage = 4;
            ArticleQueryModel queryModel = new ArticleQueryModel();

            // Act
            ArticleAllFilteredAndPagedServiceModel result = 
                await this.newsService.GetAllArticlesAsync(queryModel);

            // Assert
            Assert.That(result.TotalArticlesCount, Is.EqualTo(expectedCount));
            Assert.That(result.Articles.Count(), Is.EqualTo(expectedCountPerPage));
        }

        [Test]
        public async Task GetAllArticlesAsync_Year2022Filter_ShouldReturnCorrectCount()
        {
            // Arrange
            int expectedCount = 3;
            int expectedCountPerPage = 3;
            ArticleQueryModel queryModel = new ArticleQueryModel()
            {
                Year = "2022",
            };

            // Act
            ArticleAllFilteredAndPagedServiceModel result =
                await this.newsService.GetAllArticlesAsync(queryModel);

            // Assert
            Assert.That(result.TotalArticlesCount, Is.EqualTo(expectedCount));
            Assert.That(result.Articles.Count(), Is.EqualTo(expectedCountPerPage));
        }        
    }
}
