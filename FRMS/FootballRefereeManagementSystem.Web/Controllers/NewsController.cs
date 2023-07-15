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
                await this.newsService.AllAsync(queryModel);

            queryModel.Articles = serviceModel.Articles;
            queryModel.TotalArticles = serviceModel.TotalArticlesCount;
            queryModel.Years = await this.newsService.GetArticlesDistinctYearsAsStringAsync();

            return View(queryModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleFormViewModel model) 
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.newsService.AddNewArticleAsync(model);

            return RedirectToAction("All", "News");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ArticleFormViewModel model = await this.newsService.GetArticleForEditByIdAsync(id);

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, ArticleFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.newsService.EditArticleAsync(id, model);

            return RedirectToAction("All", "News");
        }
    }
}
