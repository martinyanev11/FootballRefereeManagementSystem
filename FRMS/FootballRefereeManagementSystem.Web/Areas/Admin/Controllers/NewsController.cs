namespace FootballRefereeManagementSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services.Contracts;
    using ViewModels.News;

    public class NewsController : BaseAdminController
    {
        private readonly INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
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

            try
            {
                await this.newsService.AddNewArticleAsync(model);

                return RedirectToAction("All", "News", new { area = "" });
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
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
        public async Task<IActionResult> Edit(int id, ArticleFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.newsService.EditArticleAsync(id, model);

                return RedirectToAction("All", "News", new { area = "" });
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool entityExists =
                await this.newsService.CheckArticleExistanceByIdAsync(id);

                if (!entityExists)
                {
                    return View("Error404");
                }

                ArticleViewModel model = await this.newsService.GetArticleByIdAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                return View("Error");
            }
            
            
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmedDelete(int id)
        {
            try
            {
                bool entityExists =
                    await this.newsService.CheckArticleExistanceByIdAsync(id);

                if (!entityExists)
                {
                    return View("Error404");
                }

                await this.newsService.DeleteArticleAsync(id);

                return RedirectToAction("All", "News", new { area = "" });
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
