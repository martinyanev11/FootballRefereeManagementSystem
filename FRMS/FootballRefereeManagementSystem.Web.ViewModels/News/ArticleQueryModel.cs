﻿namespace FootballRefereeManagementSystem.Web.ViewModels.News
{
    using Enums;
    using static Common.GeneralApplicationConstants;

    public class ArticleQueryModel
    {
        public ArticleQueryModel()
        {
            this.CurrentPage = DefaultPage;
            this.ArticlesPerPage = ItemsPerPage;
            this.Years = new HashSet<string>();
            this.Articles = new HashSet<ArticleViewModel>();
        }

        public string Year { get; set; } = null!;

        public ArticleSorting ArticleSorting { get; set; }

        public int CurrentPage { get; set; }

        public int TotalArticles { get; set; }

        public int ArticlesPerPage { get; set; }

        public IEnumerable<string> Years { get; set; } = null!;

        public IEnumerable<ArticleViewModel> Articles { get; set; } = null!;
    }
}
