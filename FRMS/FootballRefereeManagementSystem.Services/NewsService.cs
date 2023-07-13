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

    public class NewsService : INewsService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public NewsService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // TODO:
        public Task<ArticleAllFilteredAndPagedServiceModel> AllAsync(ArticleQueryModel articleQueryModel)
        {
            throw new NotImplementedException();

            //IQueryable<Article> articlesQuery = this.dbContext
            //    .Articles
            //    .AsQueryable();
        }

        public async Task<IEnumerable<ArticleViewModel>> GetAllArticlesAsync()
        {
            IEnumerable<ArticleViewModel> articles = await dbContext
                .Articles
                .AsNoTracking()
                .OrderBy(a => a.CreatedOn)
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
