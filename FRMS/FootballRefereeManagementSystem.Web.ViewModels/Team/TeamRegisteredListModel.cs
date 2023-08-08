namespace FootballRefereeManagementSystem.Web.ViewModels.Team
{
    using Player;

    public class TeamRegisteredListModel
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; } = null!;

        public string TeamLocation { get; set; } = null!;

        public string DivisionName { get; set; } = null!;

        public int RegisteredPlayersCount { get; set; }

        public int MatchesCount { get; set; }
    }
}