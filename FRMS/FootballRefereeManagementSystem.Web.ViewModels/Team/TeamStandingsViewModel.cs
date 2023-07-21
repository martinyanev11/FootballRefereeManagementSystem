namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    public class TeamStandingsViewModel
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; } = null!;

        public string TeamTownName = null!;

        public int TeamPoints { get; set; }

        public int TeamPlacement { get; set; }

        public int MatchesPlayed { get; set; }
    }
}
