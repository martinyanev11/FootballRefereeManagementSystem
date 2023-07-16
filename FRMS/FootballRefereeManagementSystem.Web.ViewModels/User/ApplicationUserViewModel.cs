namespace FootballRefereeManagementSystem.Web.ViewModels.User
{
    public class ApplicationUserViewModel
    {
        public string FullName { get; set; } = null!;

        public string? ImageUrl { get; set; } = null!;

        public string Role { get; set; } = null!;

        public bool IsAvaliable { get; set; }

        public int CurrentlyAppointedMatchesCount { get; set; }
    }
}
