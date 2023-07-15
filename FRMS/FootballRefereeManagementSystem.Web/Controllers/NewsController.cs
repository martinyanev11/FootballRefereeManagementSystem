namespace FootballRefereeManagementSystem.Web.Controllers
{
    using FootballRefereeManagementSystem.Common;
    using FootballRefereeManagementSystem.Services.Models.Article;
    using FootballRefereeManagementSystem.Web.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    using Services.Contracts;
    using ViewModels.News;

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
        public async Task<IActionResult> Add(ArticleAddViewModel model) 
        {
            string userId = this.User.GetId();
            model.AuthorId = userId;
            ModelState["AuthorId"]!.ValidationState = ModelValidationState.Valid;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.newsService.AddNewArticleAsync(model);

            return RedirectToAction("All", "News");
        }
    }
}
