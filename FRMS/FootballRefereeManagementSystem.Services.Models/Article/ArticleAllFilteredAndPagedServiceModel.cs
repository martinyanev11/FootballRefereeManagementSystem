namespace FootballRefereeManagementSystem.Services.Models.Article
{
    using Web.ViewModels.News;

    public class ArticleAllFilteredAndPagedServiceModel
    {
        public ArticleAllFilteredAndPagedServiceModel()
        {
            this.Articles = new HashSet<ArticleViewModel>();
            this.Years = new HashSet<string>();
        }

        public int TotalArticlesCount { get; set; }

        public IEnumerable<ArticleViewModel> Articles { get; set; } = null!;

        public IEnumerable<string> Years { get; set; } = null!;
    }
}