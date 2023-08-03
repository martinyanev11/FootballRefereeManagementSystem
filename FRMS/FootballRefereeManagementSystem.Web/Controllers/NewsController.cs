namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Common;
    using ViewModels.News;
    using Services.Contracts;
    using Services.Models.Article;

    public class NewsController : BaseController
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery]ArticleQueryModel queryModel)
        {
            try
            {
                queryModel ??= new ArticleQueryModel();

                if (queryModel.CurrentPage <= 0)
                {
                    queryModel.CurrentPage = 1;
                }

                int allArticlesCount = await this.newsService.GetArticlesCountAsync();
                int maxPage = (int)Math.Ceiling((double)allArticlesCount / GeneralApplicationConstants.ItemsPerPage);

                if (queryModel.CurrentPage > maxPage)
                {
                    queryModel.CurrentPage = maxPage;
                }

                ArticleAllFilteredAndPagedServiceModel serviceModel =
                    await this.newsService.GetAllArticlesAsync(queryModel);

                queryModel.Articles = serviceModel.Articles;
                queryModel.TotalArticles = serviceModel.TotalArticlesCount;
                queryModel.Years = await this.newsService.GetArticlesDistinctYearsAsStringAsync();

                return View(queryModel);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
