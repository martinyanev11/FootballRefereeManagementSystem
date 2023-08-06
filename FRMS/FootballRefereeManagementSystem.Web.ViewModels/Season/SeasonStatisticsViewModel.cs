namespace FootballRefereeManagementSystem.Web.ViewModels.Season
{
    public class SeasonStatisticsViewModel
    {
        public string SeasonDescription { get; set; } = null!;

        public DateTime SeasonStart { get; set; }

        public DateTime SeasonEnd { get; set;}

        public int RegisteredTeamsCount { get; set; }

        public int RegisteredPlayersCount { get; set; }

        public int MatchesPlayed { get; set; }

        public int MatchesLeft { get; set; }
    }
}
