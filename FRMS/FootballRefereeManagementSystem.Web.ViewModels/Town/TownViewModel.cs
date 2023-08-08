namespace FootballRefereeManagementSystem.Web.ViewModels.Town
{
    public class TownViewModel : TownListModel
    {
        public string ZoneName { get; set; } = null!;

        public int TeamsCount { get; set; }

        public int MatchesCount { get; set; }
    }
}
