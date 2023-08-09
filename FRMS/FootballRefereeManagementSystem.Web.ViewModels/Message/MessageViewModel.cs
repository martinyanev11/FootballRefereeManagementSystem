namespace FootballRefereeManagementSystem.Web.ViewModels.Message
{
    public class MessageViewModel
    {
        public string Id { get; set; } = null!;

        public string UserId { get; set; } = null!;

        public string AuthorName { get; set; } = null!;

        public string Content { get; set; } = null!;

        public DateTime CreatedOn { get; set; }
    }
}
