namespace FootballRefereeManagementSystem.Web.ViewModels.News
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Article;

    public class ArticleFormViewModel
    {
        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLegnth,
            ErrorMessage = "Заглавието трябва да е между 3 и 100 символа")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength,
            ErrorMessage = "Съдържанието трябва да е между 10 и 1500 симлова")]
        public string Content { get; set; } = null!;

        public string? ImageUrl { get; set; }
    }
}
