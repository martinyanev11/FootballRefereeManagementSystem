using FootballRefereeManagementSystem.Services.Contracts;

namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Data;
    using Models.Article;
    using Web.ViewModels.News;
    using Web.ViewModels.News.Enums;
    using static FootballRefereeManagementSystem.Common.GeneralApplicationConstants;

    using Article = Data.Models.Article;

    public class NewsService : INewsService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public NewsService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddNewArticleAsync(ArticleFormViewModel modelToAdd)
        {
            Article article = new Article()
            {
                Title = modelToAdd.Title,
                Content = modelToAdd.Content,
                ImageUrl = modelToAdd.ImageUrl,
            };

            await dbContext.Articles.AddAsync(article);
            await dbContext.SaveChangesAsync();
        }

        public async Task<ArticleAllFilteredAndPagedServiceModel> GetAllArticlesAsync(ArticleQueryModel queryModel)
        {
            IQueryable<Article> articlesQuery = this.dbContext
                .Articles
                .Where(a => a.IsActive == true)
                .AsQueryable();

            // Filter by selected year
            if (!string.IsNullOrWhiteSpace(queryModel.Year))
            {
                int yearToFilter;
                bool parsedSuccessfully = int.TryParse(queryModel.Year, out yearToFilter);

                if (parsedSuccessfully)
                {
                    articlesQuery = articlesQuery
                        .Where(a => a.CreatedOn.Year == yearToFilter);
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

            // Pagination
            IEnumerable<ArticleViewModel> allArticles = await articlesQuery
                .Skip((queryModel.CurrentPage - 1) * ItemsPerPage)
                .Take(ItemsPerPage)
                .Select(a => new ArticleViewModel()
                {
                    Id = a.Id,
                    Title = a.Title,
                    Content = a.Content,
                    CreatedOn = a.CreatedOn,
                    ImageUrl = a.ImageUrl,
                })
                .ToArrayAsync();

            int totalArticles = articlesQuery.Count();

            return new ArticleAllFilteredAndPagedServiceModel()
            {
                TotalArticlesCount = totalArticles,
                Articles = allArticles,
            };
        }

        public async Task EditArticleAsync(int articleId, ArticleFormViewModel model)
        {
            Article articleToEdit = await this.GetArticleByIdAsync(articleId);

            articleToEdit.Title = model.Title;
            articleToEdit.Content = model.Content;
            articleToEdit.ImageUrl = model.ImageUrl;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<ArticleFormViewModel> GetArticleForEditByIdAsync(int id)
        {
            Article articleToEdit = await this.GetArticleByIdAsync(id);

            return new ArticleFormViewModel()
            {
                Title = articleToEdit.Title,
                Content = articleToEdit.Content,
                ImageUrl = articleToEdit.ImageUrl
            };
        }

        public async Task<int> GetArticlesCountAsync()
        {
            return await this.dbContext.Articles
                .Where(a => a.IsActive == true)
                .CountAsync();
        }

        public async Task<IEnumerable<string>> GetArticlesDistinctYearsAsStringAsync()
        {
            IEnumerable<string> years = await this.dbContext.Articles
                .Where(a => a.IsActive == true)
                .AsNoTracking()
                .Select(a => a.CreatedOn.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .Select(y => y.ToString())
                .ToArrayAsync();

            return years;
        }

        public async Task DeleteArticleAsync(int id)
        {
            Article articleToDelete = await this.GetArticleByIdAsync(id);

            articleToDelete.IsActive = false;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> CheckArticleExistanceByIdAsync(int id)
        {
            return await this.dbContext.Articles
                .AnyAsync(a => a.Id == id);
        }

        // ---------------------------------------
        // private methods
        // ---------------------------------------

        private async Task<Article> GetArticleByIdAsync(int id)
        {
            return await this.dbContext.Articles
                .FirstAsync(a => a.Id == id);
        }        
    }
}
