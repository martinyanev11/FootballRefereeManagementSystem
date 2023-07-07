namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.News;

    public class NewsController : BaseController
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<ArticleViewModel> articles = await this.newsService.GetAllArticlesAsync();

            return View(articles);
        }
    }
}
