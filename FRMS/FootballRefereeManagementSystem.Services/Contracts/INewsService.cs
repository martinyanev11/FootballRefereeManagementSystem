namespace FootballRefereeManagementSystem.Services.Contracts
{
    using Models.Article;
    using Web.ViewModels.News;

    public interface INewsService
    {
        /// <summary>
        /// Retrieves all articles from the database based on the provided query model, applying filtering, sorting, and pagination.
        /// </summary>
        /// <param name="queryModel">The query model containing filtering, sorting, and pagination parameters.</param>
        /// <returns>A task representing the asynchronous operation that returns an instance of <see cref="ArticleAllFilteredAndPagedServiceModel"/> containing the filtered and paginated <see cref="ArticleViewModel"/> models.</returns>
        Task<ArticleAllFilteredAndPagedServiceModel> GetAllArticlesAsync(ArticleQueryModel queryModel);

        /// <summary>
        /// Adds a new article to the database based on the provided <see cref="ArticleFormViewModel"/>.
        /// </summary>
        /// <param name="modelToAdd">The article model submitted from a form containing the article information to add.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task AddNewArticleAsync(ArticleFormViewModel modelToAdd);

        /// <summary>
        /// Retrieves a collection of distinct years in which active articles have been created from the database.
        /// </summary>
        /// <returns>A task representing the asynchronous operation that returns a collection of strings representing the distinct years.</returns>
        Task<IEnumerable<string>> GetArticlesDistinctYearsAsStringAsync();

        /// <summary>
        /// Retrieves the count of active articles from the database.
        /// </summary>
        /// <returns>A task representing the asynchronous operation that returns the count of active articles.</returns>
        Task<int> GetArticlesCountAsync();

        /// <summary>
        /// Retrieves an article for editing based on the provided ID from the database and returns it as an instance of <see cref="ArticleFormViewModel"/>.
        /// </summary>
        /// <param name="id">The ID of the article to retrieve for editing.</param>
        /// <returns>A task representing the asynchronous operation that returns an instance of <see cref="ArticleFormViewModel"/> containing the article data for editing.</returns>
        Task<ArticleFormViewModel> GetArticleForEditByIdAsync(int id);

        /// <summary>
        /// Edits an article based on the provided ID and <see cref="ArticleFormViewModel"/> in the database.
        /// </summary>
        /// <param name="id">The ID of the article to edit.</param>
        /// <param name="model">The article form view model containing the updated article information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task EditArticleAsync(int id, ArticleFormViewModel model);

        /// <summary>
        /// Deletes an article from the database based on the provided ID by setting the IsActive property to false.
        /// </summary>
        /// <param name="id">The ID of the article to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task DeleteArticleAsync(int id);

        /// <summary>
        /// Asynchronously checks the existence of an article based on the provided article ID.
        /// </summary>
        /// <param name="id">The ID of the article to check for existence.</param>
        /// <returns>A boolean value indicating whether the article with the specified ID exists or not.</returns>
        Task<bool> CheckArticleExistanceByIdAsync(int id);
    }
}
