namespace FootballRefereeManagementSystem.Web.ViewModels.Match
{
    public class MatchTableViewModel
    {
        public int MatchId { get; set; }

        public string HomeTeam { get; set; } = null!;

        public string HomeTeamTownName { get; set; } = null!;

        public string AwayTeam { get; set; } = null!;

        public string AwayTeamTownName { get; set; } = null!;

        public DateTime FixtureTime { get; set; }

        public string? FinalResult { get; set; }
    }
}