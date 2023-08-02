namespace FootballRefereeManagementSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Common;
    using ViewModels.News;
    using Services.Contracts;
    using Services.Models.Article;
    using Microsoft.AspNetCore.Authorization;

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

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add(ArticleFormViewModel model) 
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.newsService.AddNewArticleAsync(model);

                return RedirectToAction("All", "News");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                bool entityExists = await this.newsService.CheckArticleExistanceByIdAsync(id);

                if (!entityExists)
                {
                    return View("Error404");
                }

                ArticleFormViewModel model = await this.newsService.GetArticleForEditByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
            
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, ArticleFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.newsService.EditArticleAsync(id, model);

                return RedirectToAction("All", "News");
            }
            catch (Exception)
            {
                return View("Error");
            }
            
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            bool entityExists = await this.newsService.CheckArticleExistanceByIdAsync(id);

            if (!entityExists)
            {
                return View("Error404");
            }

            try
            {
                await this.newsService.DeleteArticleAsync(id);

                return RedirectToAction("All", "News");
            }
            catch (Exception)
            {
                return View("Error");
            }
            
        }
    }
}
