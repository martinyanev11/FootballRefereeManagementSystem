namespace FootballRefereeManagementSystem.Web.ViewModels.News
{
    using Enums;
    using static Common.GeneralApplicationConstants;

    public class ArticleQueryModel
    {
        public ArticleQueryModel()
        {
            this.CurrentPage = DefaultPage;

            this.Years = new HashSet<int>();
            this.Articles = new HashSet<ArticleViewModel>();
        }

        public int Year { get; set; }

        public ArticleSorting ArticleSorting { get; set; }

        public int CurrentPage { get; set; }

        public int TotalArticles { get; set; }

        public IEnumerable<int> Years { get; set; } = null!;

        public IEnumerable<ArticleViewModel> Articles { get; set; } = null!;
    }
}
