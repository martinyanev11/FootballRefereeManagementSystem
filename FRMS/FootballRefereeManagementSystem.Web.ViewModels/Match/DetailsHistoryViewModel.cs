namespace FootballRefereeManagementSystem.Web.ViewModels.Match
{
    public class DetailsHistoryViewModel
    {
        public string HomeTeamName { get; set; } = null!;

        public string AwayTeamName { get; set; } = null!;

        public DateTime FixtureTime { get; set; }

        public int HomeTeamGoals { get; set; }

        public int AwayTeamGoals { get; set; }
    }
}
