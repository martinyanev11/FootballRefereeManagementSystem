namespace FootballRefereeManagementSystem.Web.ViewModels.Town
{
    public class TownViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string ZoneName { get; set; } = null!;

        public int TeamsCount { get; set; }

        public int MatchesCount { get; set; }
    }
}
