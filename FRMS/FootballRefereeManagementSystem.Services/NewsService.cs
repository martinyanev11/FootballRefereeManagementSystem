using FootballRefereeManagementSystem.Services.Contracts;

namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Web.ViewModels.News;
    using Data;
    using Models.Article;
    using Data.Models;
    using Web.ViewModels.News.Enums;
    using static FootballRefereeManagementSystem.Common.EntityValidationConstants;

    using Article = Data.Models.Article;

    public class NewsService : INewsService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public NewsService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddNewArticleAsync(ArticleAddViewModel modelToAdd)
        {
            Article article = new Article()
            {
                Title = modelToAdd.Title,
                Content = modelToAdd.Content,
                ImageUrl = modelToAdd.ImageUrl,
                AuthorId = Guid.Parse(modelToAdd.AuthorId)
            };

            await dbContext.Articles.AddAsync(article);
            await dbContext.SaveChangesAsync();
        }

        // TODO:
        public async Task<ArticleAllFilteredAndPagedServiceModel> AllAsync(ArticleQueryModel queryModel)
        {
            IQueryable<Article> articlesQuery = this.dbContext
                .Articles
                .AsQueryable();

            // Filter by selected year
            if (!string.IsNullOrWhiteSpace(queryModel.Year))
            {
                int yearToFilter;
                bool parsedSuccessfully = int.TryParse(queryModel.Year, out yearToFilter);

                if (parsedSuccessfully)
                {
                    articlesQuery = articlesQuery
                    .Where(a => a.CreatedOn.Year == int.Parse(queryModel.Year));
                }
            }

            // Order by selected option
            switch (queryModel.ArticleSorting)
            {
                case ArticleSorting.Newest:
                    articlesQuery = articlesQuery
                        .OrderByDescending(x => x.CreatedOn);
                    break;
                case ArticleSorting.Oldest:
                    articlesQuery = articlesQuery
                        .OrderBy(x => x.CreatedOn);
                    break;
                default:
                    articlesQuery = articlesQuery
                        .OrderByDescending(x => x.CreatedOn);
                    break;
            }

            IEnumerable<ArticleViewModel> allArticles = await articlesQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.ArticlesPerPage)
                .Take(queryModel.ArticlesPerPage)
                .Select(a => new ArticleViewModel()
                {
                    Id = a.Id,
                    Title = a.Title,
                    Content = a.Content,
                    CreatedOn = a.CreatedOn,
                    AuthorName = a.Author.Referee!.FirstName + " " + a.Author.Referee.LastName,
                    ImageUrl = a.ImageUrl,
                })
                .ToArrayAsync();

            int totalArticles = allArticles.Count();
            
            IEnumerable<string> years = queryModel.Articles
                .Select(a => a.CreatedOn.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .Select(x => x.ToString());

            return new ArticleAllFilteredAndPagedServiceModel()
            {
                TotalArticlesCount = totalArticles,
                Articles = allArticles,
                Years = years
            };
        }

        public async Task<IEnumerable<ArticleViewModel>> GetAllArticlesAsync()
        {
            IEnumerable<ArticleViewModel> articles = await dbContext
                .Articles
                .AsNoTracking()
                .OrderByDescending(a => a.CreatedOn)
                .Select(a => new ArticleViewModel()
                {
                    Id = a.Id,
                    Title = a.Title,
                    Content = a.Content,
                    CreatedOn = a.CreatedOn,
                    AuthorName = a.Author.Referee!.FirstName + " " + a.Author.Referee.LastName,
                    ImageUrl = a.ImageUrl,
                })
                .ToArrayAsync();

            return articles;
        }
    }
}
