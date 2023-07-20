namespace FootballRefereeManagementSystem.Web.ViewModels.Season
{
    using Match;
    using Team;

    public class SeasonQueryModel
    {
        public SeasonQueryModel()
        {
            this.Matches = new HashSet<MatchTableViewModel>();
            this.Standings = new HashSet<TeamStandingsViewModel>();
            this.SeasonsOptions = new HashSet<string>();
            this.DivisionsOptions = new HashSet<string>();
        }

        public IEnumerable<MatchTableViewModel> Matches { get; set; } = null!;

        public IEnumerable<TeamStandingsViewModel> Standings { get; set; } = null!;

        public string SeasonFilter { get; set; } = null!;

        public string DivisionFilter { get; set; } = null!;

        public IEnumerable<string> SeasonsOptions { get; set; } = null!;

        public IEnumerable<string> DivisionsOptions { get; set; } = null!;
    }
}
