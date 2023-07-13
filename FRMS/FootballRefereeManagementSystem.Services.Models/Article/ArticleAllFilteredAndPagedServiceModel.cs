namespace FootballRefereeManagementSystem.Services.Models.Article
{
    using Web.ViewModels.News;

    public class ArticleAllFilteredAndPagedServiceModel
    {
        public ArticleAllFilteredAndPagedServiceModel()
        {
            this.Articles = new HashSet<ArticleViewModel>();
        }

        public int TotalArticlesCount { get; set; }

        public IEnumerable<ArticleViewModel> Articles { get; set; } = null!;
    }
}