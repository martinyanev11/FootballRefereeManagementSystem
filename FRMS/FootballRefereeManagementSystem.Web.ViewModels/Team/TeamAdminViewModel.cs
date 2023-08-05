namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    public class TeamAdminViewModel
    {
        public int Id { get; set; }

        public string TeamName { get; set; } = null!;

        public string TeamLocation { get; set; } = null!;

        public int SeasonsPlayed { get; set; }

        public int SeasonsWon { get; set; }
    }
}
