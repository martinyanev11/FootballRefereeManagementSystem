namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    public class TeamStandingsViewModel
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; } = null!;

        public int TeamPoints { get; set; }

        public int TeamPlacement { get; set; }
    }
}
