using FootballRefereeManagementSystem.Services.Contracts;

namespace FootballRefereeManagementSystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Web.ViewModels.News;
    using Data;

    public class NewsService : INewsService
    {
        private readonly FootballRefereeManagementSystemDbContext dbContext;

        public NewsService(FootballRefereeManagementSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
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
                    CreatedOn = a.CreatedOn.ToString("dd-MM-yyyy"),
                    AuthorName = a.Author.Referee!.FirstName + " " + a.Author.Referee.LastName,
                    ImageUrl = a.ImageUrl,
                })
                .ToArrayAsync();

            return articles;
        }
    }
}
