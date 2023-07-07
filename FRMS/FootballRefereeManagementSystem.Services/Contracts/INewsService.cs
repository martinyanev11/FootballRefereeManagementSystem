namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Web.ViewModels.News;

    public interface INewsService
    {
        Task<IEnumerable<ArticleViewModel>> GetAllArticlesAsync();
    }
}
