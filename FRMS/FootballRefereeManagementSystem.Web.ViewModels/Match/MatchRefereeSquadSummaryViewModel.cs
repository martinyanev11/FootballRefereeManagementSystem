namespace FootballRefereeManagementSystem.Web.ViewModels.Match
{
    public class MatchRefereeSquadSummaryViewModel
    {
        public int MatchId { get; set; }

        public string HomeTeamName { get; set; } = null!;

        public string HomeTeamTown { get; set; } = null!;

        public string AwayTeamName { get; set; } = null!;

        public string AwayTeamTown { get; set; } = null!;

        public DateTime FixtureTime { get; set; }
    }
}
