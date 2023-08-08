namespace FootballRefereeManagementSystem.Web.ViewModels.Player
{
    public class PlayerDetailsViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public int Age { get; set; }

        public string? Position { get; set; }
    }
}
