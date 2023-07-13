namespace FootballRefereeManagementSystem.Web.ViewModels.News
{
    public class ArticleViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public string? ImageUrl { get; set; }

        public string AuthorName { get; set; } = null!;
    }
}
