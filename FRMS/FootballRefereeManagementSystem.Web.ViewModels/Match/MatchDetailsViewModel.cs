namespace FootballRefereeManagementSystem.Web.ViewModels.Match
{
    public class MatchDetailsViewModel
    {
        public string Division { get; set; } = null!;

        public DateTime FixtureTime { get; set; }

        public int HomeTeamScore { get; set; }

        public int AwayTeamScore { get; set; }

        public int HomeTeamId { get; set; }

        public string HomeTeamName { get; set; } = null!;

        public string HomeTeamTownName { get; set; } = null!;

        public string HomeTeamShirtColor { get; set; } = null!;

        public int AwayTeamId { get; set; }

        public string AwayTeamName { get; set; } = null!;

        public string AwayTeamTownName { get; set; } = null!;

        public string AwayTeamShirtColor { get; set; } = null!;

        public bool HasFinished { get; set; }

        public int SeasonRound { get; set; }

        public int HomeTeamCurrentPosition { get; set; }

        public int AwayTeamCurrentPosition { get; set; }
    }
}
