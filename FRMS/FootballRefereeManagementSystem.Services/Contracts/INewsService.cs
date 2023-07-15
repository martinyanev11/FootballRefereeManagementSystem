namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Models.Article;
    using Web.ViewModels.News;

    public interface INewsService
    {
        Task<ArticleAllFilteredAndPagedServiceModel> AllAsync(ArticleQueryModel articleQueryModel);

        Task AddNewArticleAsync(ArticleAddViewModel modelToAdd);

        Task<IEnumerable<string>> GetArticlesDistinctYearsAsStringAsync();

        Task<int> GetArticlesCountAsync();
    }
}
