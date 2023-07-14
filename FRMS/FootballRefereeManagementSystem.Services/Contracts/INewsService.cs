namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Models.Article;
    using Web.ViewModels.News;

    public interface INewsService
    {
        Task<IEnumerable<ArticleViewModel>> GetAllArticlesAsync();

        Task<ArticleAllFilteredAndPagedServiceModel> AllAsync(ArticleQueryModel articleQueryModel);

        Task AddNewArticleAsync(ArticleAddViewModel modelToAdd);
    }
}
