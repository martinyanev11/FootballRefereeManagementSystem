namespace FootballRefereeManagementSystem.Web.Controllers
{
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

        //[HttpGet]
        //public async Task<IActionResult> All()
        //{
        //    IEnumerable<ArticleViewModel> articles = await this.newsService.GetAllArticlesAsync();

        //    return View(articles);
        //}

        [HttpGet]
        public async Task<IActionResult> All([FromQuery]ArticleQueryModel queryModel)
        {
            ArticleAllFilteredAndPagedServiceModel serviceModel =
                await this.newsService.AllAsync(queryModel);

            queryModel.Articles = serviceModel.Articles;
            queryModel.TotalArticles = serviceModel.TotalArticlesCount;
            queryModel.Years = serviceModel.Years;

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
