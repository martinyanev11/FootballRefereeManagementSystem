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

        public int Wins { get; set; }

        public int Draws { get; set; }

        public int Losses { get; set; }

        public int GoalsFor { get; set; }

        public int GoalsAgainst { get; set; }

        public int GoalDifference { get; set; }
    }
}
