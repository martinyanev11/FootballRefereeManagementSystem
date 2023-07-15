namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Models.Article;
    using Web.ViewModels.News;

    public interface INewsService
    {
        Task<ArticleAllFilteredAndPagedServiceModel> AllAsync(ArticleQueryModel articleQueryModel);

        Task AddNewArticleAsync(ArticleFormViewModel modelToAdd);

        Task<IEnumerable<string>> GetArticlesDistinctYearsAsStringAsync();

        Task<int> GetArticlesCountAsync();

        Task<ArticleFormViewModel> GetArticleForEditByIdAsync(int id);

        Task EditArticleAsync(int id, ArticleFormViewModel model);
    }
}
